namespace Mil82

open System

type TermoPt =
    | TermoNorm
    | TermoLow    
    | TermoHigh
    | Termo90
    static member what = function
        | TermoLow -> "T-"
        | TermoNorm -> "НКУ"
        | TermoHigh -> "T+"
        | Termo90 -> "+90"
    static member dscr = function
        | TermoLow -> "Пониженная температура"
        | TermoNorm -> "Нормальная температура"
        | TermoHigh -> "Повышенная температура"
        | Termo90 -> "Температура +90\"C"

    static member values = [ TermoNorm; TermoLow;  TermoHigh; Termo90 ] 
    static member name (x:TermoPt) = FSharpValue.unionCaseName x
    static member defaultTermoTemperature = function
        | TermoLow -> -60m
        | TermoNorm -> 20m
        | TermoHigh -> 80m
        | Termo90 -> 90m

    member x.Dscr = TermoPt.dscr x
    member x.What = TermoPt.what x

type ScalePt = 
    | ScaleBeg
    | ScaleMid
    | ScaleEnd
    member x.What = ScalePt.what x
    member x.Code = ScalePt.code x |> byte
    static member values = FSharpType.unionCasesList<ScalePt>
    static member what = function
        | ScaleBeg -> "ПГС1"
        | ScaleMid -> "ПГС3"
        | ScaleEnd -> "ПГС4"
    static member whatScale = function
        | ScaleBeg -> "начало шкалы"
        | ScaleMid -> "середина шкалы"
        | ScaleEnd -> "конец шкалы"
    static member code = function
        | ScaleBeg -> 1
        | ScaleMid -> 3
        | ScaleEnd -> 4
    static member defaultBallonConc = function
        | ScaleBeg -> 0m
        | ScaleMid -> 50m
        | ScaleEnd -> 100m
    static member name (x:ScalePt) = FSharpValue.unionCaseName x

type Feature = 
    | Lin
    | Termo
    | Test
    | RetNku
    | Tex1
    | Tex2
    static member what = function
        | Lin -> "Линейность", "лин"            
        | Termo ->  "Термокомпенсация","t"            
        | Test -> "Проверка","main"            
        | RetNku -> "Возврат-НКУ", "nku2"            
        | Tex1 -> "Техпрогон1", "tex1"            
        | Tex2 -> "Техпрогон2", "tex2"
    static member what1 = Feature.what >> fst 
    static member what2 = Feature.what >> snd
    static member name (x:Feature) = FSharpValue.unionCaseName x
    static member values = FSharpType.unionCasesList<Feature>

    member x.What1 = Feature.what1 x

type PhysVar =
    | Conc
    | Curr
    | Var1
    | Temp
    | Workk 
    | Refk
    static member context = function
        | Conc  -> 0,  ("Конц.", "Концентрация")
        | Temp  -> 2,  ("Т\"С",  "Температура")
        | Curr  -> 4,  ("Iизл",  "Ток излучателя")
        | Var1  -> 16, ("Var1",  "Var1")
        | Workk -> 12, ("Uраб",  "Рабочий канал")
        | Refk  -> 14, ("Uоп",   "Опорный канал")
    static member code = PhysVar.context >> fst
    static member what = PhysVar.context >> snd >> fst
    static member dscr = PhysVar.context >> snd >> snd
    static member values = FSharpType.unionCasesList<PhysVar>
    static member name (x:PhysVar) = FSharpValue.unionCaseName x
    member x.Dscr = PhysVar.dscr x
    
type Id = string


type KefGroup = 
    | KefLin
    | KefTermo of ScalePt 

    static member ctx = function
        | KefLin -> 
            "LIN", "Линеаризация", [CoefCchlin0; CoefCchlin1; CoefCchlin2]            
        | KefTermo ScaleBeg -> 
            "T0", "Комп. вл. темп. на нулев. показ.",
                [CoefChtNull0; CoefChtNull1; CoefChtNull2]
        | KefTermo ScaleMid -> 
            "TM", "Комп. вл. темп. на середину шк.",
                [CoefKChtMid0; CoefKChtMid1; CoefKChtMid2]
        | KefTermo ScaleEnd -> 
            "TK","Комп. влиян. темп-ры на чувст.",
                [CoefKChtSens0; CoefKChtSens1; CoefKChtSens2]

    member x.What = KefGroup.what x
    member x.Dscr = KefGroup.dscr x

    static member what = KefGroup.ctx >> (fun (x,_,_) -> x)
    static member dscr = KefGroup.ctx >> (fun (_,x,_) -> x)
    static member kefs = KefGroup.ctx >> (fun (_,_,x) -> x)

type Command =
    | AdjustBeg
    | AdjustEnd
    | Nommalize
    | ResetAddy
    static member context = function
        | AdjustBeg -> 1, "Корректировка нуля"
        | AdjustEnd -> 2, "Корректировка чувствительности"
        | Nommalize -> 8, "Нормировка"
        | ResetAddy -> 7, "Установка адреса"
    static member what = Command.context >> snd
    static member code = Command.context >> fst

    member x.What = Command.what x
    member x.Code = Command.code x
    
    static member values = FSharpType.unionCasesList<Command>

type WriteContext =
    | WriteKef of Coef
    | SendCommand of Command
    static member what = function
        | WriteKef kef -> sprintf "запись коеф.%d" kef.Order
        | SendCommand cmd -> sprintf "отправка команды %A"  <| Command.what cmd
    static member code = function
        | WriteKef kef -> Coef.writeCmd kef
        | SendCommand cmd -> Command.code cmd

type ReadContext =
    | ReadKef of Coef
    | ReadVar of PhysVar
    static member what = function
        | ReadKef kef -> sprintf "коеф.%d" kef.Order
        | ReadVar var -> PhysVar.what var

    static member code = function
        | ReadKef kef -> Coef.readReg kef
        | ReadVar var -> PhysVar.code var

type Var = Feature * PhysVar * ScalePt * TermoPt

type ProdDataCtx = 
    | ProdVarCtx of Var
    | ProdKefCtx of Coef


type DelayContext = 
    | BlowDelay of ScalePt 
    | WarmDelay of TermoPt
    | TexprogonDelay
    | AdjustDelay of bool
    static member values = 
        [   yield! List.map BlowDelay ScalePt.values
            yield! List.map WarmDelay TermoPt.values
            yield TexprogonDelay
            yield AdjustDelay false
            yield AdjustDelay true ]

    static member what = function
        | BlowDelay gas -> sprintf "Продувка %s" gas.What
        | WarmDelay t -> sprintf "Прогрев %s" t.What
        | TexprogonDelay -> "Выдержка, техпрогон"
        | AdjustDelay false -> "Продувка ПГС1, калибровка"
        | AdjustDelay true -> "Продувка ПГС4, калибровка"
    member x.What = DelayContext.what x
    member x.Prop = DelayContext.prop x

    static member prop = function
        | BlowDelay gas -> FSharpValue.unionCaseName gas 
        | WarmDelay t -> FSharpValue.unionCaseName t 
        | TexprogonDelay -> FSharpValue.unionCaseName TexprogonDelay 
        | AdjustDelay false -> "AdjustDelay_0" 
        | AdjustDelay true -> "AdjustDelay_1" 


module Vars = 
    let what ( (f,v,s,t) as x : Var ) = 
        sprintf "%A.%A.%A.%A" (Feature.what1 f) (PhysVar.what v) (ScalePt.what s) (TermoPt.what t)  

    let name ( (f,v,s,t) as x : Var ) = 
        sprintf "%s_%s_%s_%s" (Feature.name f) (PhysVar.name v) (ScalePt.name s) (TermoPt.name t)

    let gas_t_vars = 
        [   for gas in ScalePt.values do
                for t in TermoPt.values @ [TermoPt.Termo90] do
                    yield gas,t ]

    let vars = 
        let trm feat temps = 
            [   for t in temps do
                    for var in PhysVar.values  do  
                        for gas in ScalePt.values do                    
                            yield feat, var, gas, t ]

        [   yield! trm Lin [TermoNorm]
            yield! trm Termo [TermoLow; TermoNorm; TermoHigh ]
            yield! trm Test [TermoLow; TermoNorm; TermoHigh; Termo90 ]
            yield! trm RetNku [TermoNorm]
            yield! trm Tex1 [TermoNorm]
            yield! trm Tex2 [TermoNorm] ]
        |> List.sortBy( fun (feat,var,gas,t) -> var, feat, t, gas)

    let vars_kefs = 
        (List.map ProdVarCtx vars)  @ (List.map ProdKefCtx Coef.coefs) 

module Property = 
    let concError scalePt = sprintf "ConcError_%s" (ScalePt.name scalePt)
    let tex1Error scalePt = sprintf "Tex1Error_%s" (ScalePt.name scalePt)
    let tex2Error scalePt = sprintf "Tex2Error_%s" (ScalePt.name scalePt)
    let retNkuError scalePt = sprintf "RetNkuError_%s" (ScalePt.name scalePt)
    let termoError (scalePt,termoPt) = sprintf "TermoError_%s_%s" (ScalePt.name scalePt) (TermoPt.name termoPt)
    let var var = sprintf "Var_%s" (Vars.name var)
    let kef (kef:Coef) = sprintf "%A" kef
    let ctx = function
        | ProdVarCtx v -> var v
        | ProdKefCtx k -> kef k
    
type Product = 
    {   Id : Id
        IsChecked : bool
        Serial : int
        Addr : byte
        ProdValue : Map<ProdDataCtx, decimal> }

    member x.What = Product.what x
    static member id x = x.Id
    static member serial x = x.Serial
    static member createNewId() = String.getUniqueKey 12
    static member what x = sprintf "№%d.#%d" x.Serial x.Addr 

    static member getProdValue k p =p.ProdValue.TryFind k 

    static member setProdValue k v =  state{                
        let! p = getState 
        let m = 
            match v with
            | None -> Map.remove k
            | Some v -> Map.add k v
               
        do! setState { p with ProdValue = m p.ProdValue   } }

    static member setVar var = Product.setProdValue (ProdVarCtx var)
    static member setKef kef = Product.setProdValue (ProdKefCtx kef)

    static member getVar var p = p.ProdValue.TryFind ( ProdVarCtx var)
    static member getKef kef p = p.ProdValue.TryFind ( ProdKefCtx kef)

    static member setVars varsValues =  state{ 
        for var,value in varsValues do
            do! Product.setVar var (Some value)    }

    static member setKefs kefsVals = state{            
        for kef,value in kefsVals do
            do! Product.setKef kef (Some value)  }

    static member createNew addy serial = 
        {   Id = Product.createNewId()
            Addr = addy
            Serial = serial
            IsChecked = true
            ProdValue = Map.empty }

type LoggingRecord = DateTime * Logging.Level * string

type PerformingOperation =
    {   RunStart : DateTime option 
        RunEnd : DateTime option
        LoggingRecords : LoggingRecord list }
    static member createNew() = 
        {   RunStart = None
            RunEnd = None
            LoggingRecords = [] }
        

type PerformingJournal = Map<int, PerformingOperation >

module Party =
    type Head = 
        {   Id : Id
            Date : DateTime
            ProductType : ProductType
            Name : string
            Serials : int list   }
        static member id x = x.Id 
    type Data = {
        Products : Product list
        BallonConc : Map<ScalePt,decimal>
        TermoTemperature : Map<TermoPt,decimal>
        PerformingJournal : PerformingJournal }

    type Content = Head * Data

    let getNewValidAddy addrs = 
        let rec loop n = 
            if addrs |> Seq.exists( (=) n ) then
                if n=127uy then 1uy else loop (n+1uy)
            else n
        loop 1uy

    let createNewEmpty() : Content =         
        //let products = [ Product.createNew 1uy 1 A00 ]
        let t = A00
        {   Id = Product.createNewId()
            Serials = List.map Product.serial []
            Date=DateTime.Now 
            Name = "Партия1"
            ProductType = A00 }, 
            {   Products = []
                BallonConc = Map.empty
                TermoTemperature = Map.empty
                PerformingJournal = Map.empty}

    

    let ballonConc gas m =
        match Map.tryFind gas m with
        | Some x -> x
        | _ -> ScalePt.defaultBallonConc gas

