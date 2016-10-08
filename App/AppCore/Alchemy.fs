module Mil82.Alchemy  

open System

type private P = Product
type private T = ProductType


[<AutoOpen>]
module ReportHelper = 
    type Content = 
        | Info of string
        | Error of string
        | Bitmap of System.IO.MemoryStream

let encodeDate (date : DateTime) = 
    let year = decimal date.Year - 2000m
    let month = decimal date.Month 
    let day = decimal date.Day
    year * 10000m + month * 100m + day

let initKefValue pgs productType kef p = 
    let _,_, gas, scale, kef4, kef14, kef45 = ProductType.ctx productType
    let now = DateTime.Now
    match kef with
    | CoefYear          -> Some <| decimal now.Year
    | CoefPgsChNull     -> Some <| pgs ScaleBeg
    | CoefPgsChSens     -> Some <| pgs ScaleEnd 
    | CoefShkala1       -> Some <| decimal ( Scale.code scale)
    | CoefPredelLo1     -> Some <| 0m
    | CoefPredelHi1     -> Some <| Scale.value scale
    | CoefEdIzmer1      -> Some <| decimal ( Gas.unitsCode gas)
    | CoefGasType1      -> Some <| decimal ( Gas.code gas)
    | CoefMaxCountReg   -> Some <| kef4
    | CoefKyskch        -> Some <| kef14
    | CoefCb            -> Some <| kef45  

    | CoefCchlin0 ->    Some <| 0m
    | CoefCchlin1 ->    Some <| 1m
    | CoefCchlin2 ->    Some <| 0m
    | CoefCchlin3 ->    Some <| 0m

    | CoefChtNull0 ->     Some <| 0m
    | CoefChtNull1 ->     Some <| 0m
    | CoefChtNull2 ->     Some <| 0m
    | CoefKChtSens0 ->     Some <| 1m
    | CoefKChtSens1 ->     Some <| 0m
    | CoefKChtSens2 ->     Some <| 0m

    | CoefSelfaddr      -> Some <| decimal p.Addr

    | _ -> None

let initializeKefsValues kefs pgs productType = state{ 
    //let _,_, gas, scale, kef4, kef14, kef45 = ProductType.ctx productType    
    for kef in kefs do
        let! p = getState
        match initKefValue pgs productType kef p with
        | None -> ()
        | Some value -> 
            do! P.setKef kef (Some value) }
    
[<AutoOpen>]
module private PivateComputeProduct = 

    let round6 (x:decimal) = System.Math.Round(x,6)

    let tup2 = function [x;y] -> Some(x,y) | _ -> None
    let tup3 = function [x;y;z] -> Some(x,y,z) | _ -> None

    type C = 
        | V of Var
        | K of Coef

    let getVarsValues p vars =         
        let oks, errs =
            vars |> List.map( fun k ->
                match Product.getVar k p with 
                | None ->  Err k
                | Some value -> Ok (k,value) )
            |> List.partition Result.isOk
        if List.isEmpty errs then 
            Ok ( oks |> List.map ( Result.Unwrap.ok >> snd) ) 
        else 
            errs 
            |> List.map ( Result.Unwrap.err  >> V)
            |> Err

    let getKefsValues p kefs = 
        let oks, errs =
            kefs |> List.map( fun k ->
                match Product.getKef k p with 
                | None ->  Err k
                | Some value -> Ok (k,value) )
            |> List.partition Result.isOk
        if List.isEmpty errs then 
            Ok ( oks |> List.map ( Result.Unwrap.ok >> snd) ) 
        else 
            errs 
            |> List.map ( Result.Unwrap.err >> K )
            |> Err  


    let fmtErr<'a> (fmt : 'a -> string) = function
        | [x] -> sprintf "точке %A" (fmt x)
        | xs -> 
            xs |> List.rev |> Seq.toStr ", " fmt     
            |> sprintf "точках %s"

    let getTermoValues var gas p =
        TermoPt.values
        |> List.map( fun t ->  Termo, var, gas, t) |> getVarsValues p

    let getScaleValues p f =
        ScalePt.values
        |> List.map f
        |> getVarsValues p

    
    let getGaussXY p pgs  = function
        | KefLin -> 
            ScalePt.values 
            |> List.map( fun gas -> Lin, Conc, gas, TermoNorm )
            |> getVarsValues p
            |> Result.map ( fun xs -> 
                List.zip xs ( ScalePt.values |> List.map pgs  ) )
            |> Result.mapErr( 
                fmtErr (function  V(_,_,gas,_) -> sprintf "%A" gas)
                >> sprintf "нет значения LIN в %s" )
        | KefTermo ScaleBeg -> 
            result {
                let! t = getTermoValues Temp ScaleBeg p
                let! var = getTermoValues Var1 ScaleBeg p
                return List.zip t ( List.map (fun var -> - var) var) }
            |> Result.mapErr( 
                fmtErr (function V(_,var,_,t) -> 
                        sprintf "%s.%s" (PhysVar.what var) (TermoPt.what t) )                
                >> sprintf "нет значения T0 в %s" )

        | KefTermo ScaleEnd -> 
            result {
                let! t = getTermoValues Temp ScaleEnd p
                let! var = getTermoValues Var1 ScaleEnd p
                let! var0 = getTermoValues Var1 ScaleBeg p
                return List.zip3 t var0 var}
            |> Result.mapErr( 
                fmtErr (function V(_,var,_,t) -> 
                    sprintf "%s.%s" (PhysVar.what var) (TermoPt.what t) )
                >> sprintf "нет значения TK в %s" )
            |> Result.bind(fun xs ->
                let errs =
                    xs |> List.zip TermoPt.values 
                    |> List.map(fun (ptT,(_,var0,var)) ->  if var0 = var then Some ptT else None )
                    |> List.filter Option.isSome
                if List.isEmpty errs then 
                    let vk = xs |> List.map( fun (t,var0,var) -> t, var - var0)
                    vk |> List.map(fun (t,x) -> t, snd vk.[1] / x)
                    |> Ok
                else
                    errs 
                    |> List.map Option.get
                    |> fmtErr TermoPt.what 
                    |> sprintf "при расчёте TK деление на ноль в %s"
                    |> Err )
        | KefTermo ScaleMid ->
            
            result{
                    
                let! [k16; k17; k18] = getKefsValues p [CoefCchlin0; CoefCchlin1; CoefCchlin2]
                let! [v_0_nku; v_s_nku; v_k_nku] = getScaleValues p  ( fun gas ->  Termo, Var1, gas, TermoNorm) 
                let! [v_0_min; v_s_min; v_k_min] = getScaleValues p  ( fun gas ->  Termo, Var1, gas, TermoLow) 
                let! [v_0_max; v_s_max; v_k_max] = getScaleValues p  ( fun gas ->  Termo, Var1, gas, TermoHigh) 
                let! [t1; t2; t3] = TermoPt.values |> List.map( fun t ->  Termo, Temp, ScaleMid, t) |> getVarsValues p

                let conc = pgs ScaleEnd

                let yLo =
                    let x1 = conc * (v_0_nku-v_s_nku) / (v_0_nku-v_k_nku)
                    let x2 = conc * (v_0_min-v_s_min)/(v_0_min-v_k_min)
                    (k16 + k17*x1 + k18*x1*x1 - x2) / 
                    (k16 + k17*x2 + k18*x2*x2 - x2) 
                let yHi = 
                    let x1 = conc * (v_0_nku-v_s_nku)/(v_0_nku-v_k_nku)
                    let x2 = conc * (v_0_max-v_s_max)/(v_0_max-v_k_max)
                    (k16 + k17*x1 + k18*x1*x1 - x2) / 
                    (k16 + k17*x2 + k18*x2*x2 - x2) 
                        
                return [ t1, yLo; t2, 1m; t3, yHi ] }
            |> Result.mapErr( 
                fmtErr ( function
                    | K kef -> sprintf "коэф.%d" kef.Order
                    | V (_,var, gas,t) -> sprintf "%A.%A.%A" (PhysVar.what var) (ScalePt.what gas) (TermoPt.what t) )
                >> sprintf "нет значения TM в %s" )

        

let compute group pgs productType = state {
    let! product = getState
    let kefs = KefGroup.kefs group
    let skefs = Seq.toStr ", " (Coef.order >> string) kefs    
    Logging.info "%s : расчёт коэффициентов %A, %s" (Product.what product) (KefGroup.what group) skefs

    do! kefs |> List.choose(fun kef -> 
            initKefValue pgs productType kef product
            |> Option.map(fun v -> kef,v) )
        |> Product.setKefs 
    let result = getGaussXY product pgs group
    match result with
    | Err e -> Logging.error "%s : %s" (Product.what product) e
    | Ok xy ->
        let x,y = List.toArray xy |> Array.unzip
        let result =  NumericMethod.GaussInterpolation.calculate(x,y) 
        let ff = Seq.toStr ", " string
        Logging.info "метод Гаусса X=%s Y=%s ==> %s=%s" (ff x) (ff y) skefs (ff result)
        do! result |> Array.toList |> List.zip kefs |> Product.setKefs   }

let translateTermo = 
    let (~%%) var = state{
        let! p = getState
        do! 
            [ for t in [TermoLow; TermoHigh] do
                for gas in ScalePt.values do 
                    yield 
                        Product.getVar (Test,var,gas,t) p 
                        |> Option.map(fun value -> (Termo, var, gas, t), value ) ]
            |> List.choose id
            |> Product.setVars  }
    state{ 
        do! %% Var1
        do! %% Temp }

    

let concErrorlimit productType concValue =        
    let scale = ProductType.scale productType        
    if ProductType.isCH productType then 2.5m+0.05m * concValue
    elif scale=Sc4 then 0.2m + 0.05m * concValue
    elif scale=Sc10 then 0.5m
    elif scale=Sc20 then 1.0m else 0.m


let termoErrorlimit productType pgs (gas,t) product =
    if ProductType.isCH productType |> not then 
        (Product.getVar (Test,Conc, gas,t) product, Product.getVar (Test, Temp, gas, t) product) 
        |> Option.map2(fun(c,t) -> 
            let dt = t - 20m     
            let maxc = concErrorlimit productType pgs
            0.5m * abs( maxc*dt ) / 10.0m )
    else
        match gas with
        | ScaleBeg -> Some 5m
        | _ ->
            Product.getVar (Test,Conc,gas,TermoNorm) product
            |> Option.map(fun conc20 -> conc20 * 0.15m |> abs  |> decimal )

type ValueError = 
    {   Value : decimal
        Nominal : decimal
        Limit : decimal }
    member x.IsError = abs x.Error >= abs x.Limit 
    member x.Error = x.Value - x.Nominal
    static member error = function 
        | Some (x : ValueError ) -> Decimal.toStr ".###" x.Error
        | _ -> ""

type Product with

    static member concError productType pgs gas product = 
        Product.getVar (Test,Conc, gas, TermoNorm) product 
        |> Option.map(fun conc ->                 
            { Value = conc; Nominal = pgs; Limit = concErrorlimit productType pgs } ) 

    static member tex1Error productType pgs gas product = 
        Product.getVar (Tex1, Conc, gas, TermoNorm) product 
        |> Option.map(fun conc ->                 
            { Value = conc; Nominal = pgs; Limit = concErrorlimit productType pgs } ) 

    static member tex2Error productType pgs gas product = 
        Product.getVar (Tex2, Conc, gas, TermoNorm) product 
        |> Option.map(fun conc ->                 
            { Value = conc; Nominal = pgs; Limit = concErrorlimit productType pgs } ) 

    static member retNkuError productType pgs gas product = 
        Product.getVar (RetNku, Conc, gas, TermoNorm) product 
        |> Option.map(fun conc ->                 
            { Value = conc; Nominal = pgs; Limit = concErrorlimit productType pgs } ) 

    static member termoError productType pgs (gas,t) p = 
        (   Product.getVar (Test,Conc,gas,t) p,
            Product.getVar (Test,Conc,gas,TermoNorm) p,
            termoErrorlimit productType pgs (gas,t) p )
        |> Option.map3( fun (c,c20,limit) -> 
            { Value = c; Nominal = c20; Limit = limit } )

let createNewProduct addr getPgs productType =
    runState 
        ( initializeKefsValues Coef.coefs getPgs productType )
        ( Product.createNew addr )
    |> snd


let createNewParty() = 
    let h,d = Party.createNewEmpty()
    let getPgs = d.BallonConc.TryFind >> Option.getWith 0m
    let productType = h.ProductType
    let product = createNewProduct 1uy getPgs productType
    let products = [ product ]
    {h with ProductsSerials = [product.ProductSerial] }, { d with Products = products }

let createNewParty1( name, productType, pgs1, pgs2, pgs3, count) : Party.Content = 
        let pgs = Map.ofList <| List.zip ScalePt.values [pgs1; pgs2; pgs3]
        let getPgs = pgs.TryFind >> Option.getWith 0m
        let products = 
            [1uy..count] 
            |> List.map( fun addr ->  createNewProduct addr getPgs productType )
        
        {   Id = Product.createNewId()
            ProductsSerials = List.map Product.productSerial products
            Date=DateTime.Now 
            Name = name
            ProductType = productType }, 
                {   Products = products
                    BallonConc = pgs
                    TermoTemperature = Map.empty
                    PerformingJournal = Map.empty}