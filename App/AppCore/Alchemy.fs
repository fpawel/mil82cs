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

let initKefsValues pgs (t : ProductType) = 
    let now = DateTime.Now
    [   CoefYear, decimal now.Year
        CoefPgsChNull, pgs ScaleBeg
        CoefPgsChSens, pgs ScaleEnd 
        CoefShkala1  , decimal t.Scale.Code
        CoefPredelLo1, t.Scale.Begin
        CoefPredelHi1, t.Scale.End
        CoefEdIzmer1 , decimal ( t.Gas.UnitsCode)
        CoefGasType1 , decimal ( t.Gas.Code)
        CoefMaxCountReg, t.K4
        CoefKyskch, t.K14
        CoefCb, t.K45
        CoefMadSafe, t.K35
        Coef50, t.K50

        CoefCchlin0, 0m
        CoefCchlin1, 1m
        CoefCchlin2, 0m
        CoefCchlin3, 0m

        CoefChtNull0,  0m
        CoefChtNull1,  0m
        CoefChtNull2,  0m
        CoefKChtSens0, 1m
        CoefKChtSens1, 0m
        CoefKChtSens2, 0m ]

    
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

    let termoPoints = 
        [TermoLow; TermoNorm; TermoHigh]

    let getTermoValues  var gas p =
        termoPoints
        |> List.map( fun t ->  Termo, var, gas, t) 
        |> getVarsValues p

    let getTermoValues2 var gas p =
        termoPoints
        |> List.map( fun t -> 
            let group = match t with 
                        | TermoNorm -> RetNku
                        | _ -> Test  
            in group, var, gas, t ) 
        |> getVarsValues p

    

    
    let getGaussXY p pgs  = function
        | KefLin -> 
            ScalePt.values 
            |> List.map( fun gas -> Lin, Conc, gas, TermoNorm )
            |> getVarsValues p
            |> Result.map ( fun xs -> 
                List.zip xs ( ScalePt.values |> List.map pgs  ) )
            |> Result.mapErr( 
                fmtErr (function  
                            | V(_,_,gas,_) -> sprintf "%A" gas 
                            | x -> failwithf "%A" x )
                >> sprintf "нет значения LIN в %s" )
        | KefT0 -> 
            result {
                let! t = getTermoValues Temp ScaleBeg p
                let! var = getTermoValues Var1 ScaleBeg p
                return List.zip t ( List.map (fun var -> - var) var) }
            |> Result.mapErr( 
                fmtErr (function  
                            | V(_,var,_,t) -> sprintf "%s.%s" (PhysVar.what var) (TermoPt.what t) 
                            | x -> failwithf "%A" x )
                >> sprintf "нет значения T0 в %s" )

        | KefTK -> 
            result {
                let! t = getTermoValues Temp ScaleEnd p
                let! var = getTermoValues Var1 ScaleEnd p
                let! var0 = getTermoValues Var1 ScaleBeg p
                return List.zip3 t var0 var}
            |> Result.mapErr( 
                fmtErr (function 
                            | V(_,var,_,t) -> sprintf "%s.%s" (PhysVar.what var) (TermoPt.what t) 
                            | x -> failwithf "%A" x )
                >> sprintf "нет значения TK в %s" )
            |> Result.bind(fun xs ->
                let errs =
                    xs |> List.zip termoPoints
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
        | KefTM ->
            
            result{

                let getValues f =
                    [ScaleBeg; ScaleMid; ScaleEnd]
                    |> List.map f
                    |> getVarsValues p
                    
                let! [k16; k17; k18; k19] = getKefsValues p [CoefCchlin0; CoefCchlin1; CoefCchlin2; CoefCchlin3]
                let! [v_0_nku; v_s_nku; v_k_nku] = getValues ( fun gas ->  Termo, Var1, gas, TermoNorm) 
                let! [v_0_min; v_s_min; v_k_min] = getValues ( fun gas ->  Termo, Var1, gas, TermoLow) 
                let! [v_0_max; v_s_max; v_k_max] = getValues ( fun gas ->  Termo, Var1, gas, TermoHigh)                 
                let! [t1; t2; t3] = termoPoints 
                                    |> List.map( fun t -> Termo, Temp, ScaleMid, t  ) 
                                    |> getVarsValues p

                let r = 
                    if v_0_nku = v_k_nku then Err (sprintf " v_0_nku:%M = v_k_nku:%M" v_0_nku v_k_nku) 
                    elif v_0_min = v_k_min then Err (sprintf "v_0_min:%M = v_k_nku:%M" v_0_min v_k_min) 
                    elif v_0_max = v_k_max then Err (sprintf "v_0_min:%M = v_k_nku:%M" v_0_max v_k_max)
                    else 
                        let conc = pgs ScaleEnd
                        let x1 = conc * (v_0_nku-v_s_nku) / (v_0_nku-v_k_nku)
                        let x2 = conc * (v_0_min-v_s_min)/(v_0_min-v_k_min)
                        let d = k16 + k17*x2 + k18*x2*x2 + k19*x2*x2*x2 - x2
                        if d = 0M then Err (sprintf "k16 + k17*x2 + k18*x2*x2 + k19*x2*x2*x2 - x2 = 0") 
                        else 
                            let yLo = (k16 + k17*x1 + k18*x1*x1 + k19*x1*x1*x1 - x2) / d
                            let x1 = conc * (v_0_nku-v_s_nku)/(v_0_nku-v_k_nku)
                            let x2 = conc * (v_0_max-v_s_max)/(v_0_max-v_k_max)
                            let d = k16 + k17*x2 + k18*x2*x2 + k19*x2*x2*x2 - x2
                            if d = 0M then Err (sprintf "k16 + k17*x2 + k18*x2*x2 + k19*x2*x2*x2 - x2 = 0") 
                            else 
                                let yHi = (k16 + k17*x1 + k18*x1*x1 + k19*x1*x1*x1 - x2) / d
                                Ok [ t1, yLo; t2, 1m; t3, yHi ] 
                match r with
                | Ok r -> return r
                | Err err -> 
                    Logging.error "%s" err
                    return []
                }
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

    let initKefsValues = 
        initKefsValues pgs productType 
        |> Map.ofList


    do! kefs 
        |> List.choose(fun kef ->         
            initKefsValues.TryFind kef
            |> Option.map(fun v -> kef,v) )
        |> Product.setKefs 
    let result = getGaussXY product pgs group
    match result with
    | Err e -> Logging.error "%s : %s" (Product.what product) e
    | Ok xy ->
        let x,y = List.toArray xy |> Array.unzip
        let result =  NumericMethod.GaussInterpolation.calculate(x,y) 
        let val6 = Seq.toStr ", " Decimal.toStr6
        Logging.info "метод Гаусса X=%s Y=%s ==> %s=%s" (val6 x) (val6 y) skefs (val6 result)
        do! result |> Array.toList |> List.zip kefs |> Product.setKefs   }

let concErrorlimit (t:ProductType) concValue =        
    let scale = t.Scale
    if t.IsCH then 2.5m+0.05m * concValue
    elif scale=Sc4 then 0.2m + 0.05m * concValue
    elif scale=Sc10 then 0.5m
    elif scale=Sc20 then 1.0m else 0.m


let termoErrorlimit (prodType:ProductType) pgs (gas,termoPt) product =
    if not prodType.IsCH  then 
        let t0 = 
            match termoPt with
            | Termo90 -> 80m
            | _ -> 20m
        (Product.getVar (Test,Conc, gas, termoPt) product, 
            Product.getVar (Test, Temp, gas, termoPt) product) 
        |> Option.map2(fun(c,t) ->             
            let dt = t - t0     
            let maxc = concErrorlimit prodType pgs
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
        let termo0pt = 
            match t with
            | Termo90 -> TermoHigh
            | _ -> TermoNorm 


        (   Product.getVar (Test,Conc,gas,t) p,
            Product.getVar (Test,Conc,gas,termo0pt) p,
            termoErrorlimit productType pgs (gas,t) p )
        |> Option.map3( fun (c,c0,limit) -> 
            {   Value = c
                Nominal = c0
                Limit = limit } )

let createNewProduct addr getPgs productType =
    Product.createNew addr ( Map.ofList (initKefsValues getPgs productType) )


let createNewParty() = 
    let h,d = Party.createNewEmpty()
    let getPgs = d.BallonConc.TryFind >> Option.withDefault 0m
    let productType = h.ProductType
    let product = createNewProduct 1uy getPgs productType
    let products = [ product ]
    {h with ProductInfo = [product.ProductInfo] }, { d with Products = products }

let createNewParty1( name, productType, pgs1, pgs2, pgs3, pgs4, count) : Party.Content = 
        let pgs = Map.ofList <| List.zip ScalePt.values [pgs1; pgs2; pgs3; pgs4]
        let getPgs = pgs.TryFind >> Option.withDefault 0m
        let products = 
            [1uy..count] 
            |> List.map( fun addr ->  createNewProduct addr getPgs productType )
        
        {   Id = Product.createNewId()
            ProductInfo = List.map Product.getProductInfo products
            Date=DateTime.Now 
            Name = name
            ProductType = productType }, 
                {   Products = products
                    BallonConc = pgs
                    TermoTemperature = Map.empty
                    PerformingJournal = Map.empty}