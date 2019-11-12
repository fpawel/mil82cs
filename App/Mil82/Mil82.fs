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
    | ScaleMid2
    | ScaleMid
    | ScaleEnd
    member x.What = ScalePt.what x
    member x.Code = ScalePt.code x |> byte
    static member values = FSharpType.unionCasesList<ScalePt>
    static member what = function
        | ScaleBeg -> "ПГС1"
        | ScaleMid2 -> "ПГС2"
        | ScaleMid -> "ПГС3"
        | ScaleEnd -> "ПГС4"
    static member whatScale = function
        | ScaleBeg -> "начало шкалы"
        | ScaleMid2 -> "середина шкалы 2"
        | ScaleMid -> "середина шкалы"
        | ScaleEnd -> "конец шкалы"
    static member code = function
        | ScaleBeg -> 1
        | ScaleMid2 -> 2
        | ScaleMid -> 3
        | ScaleEnd -> 4
    static member defaultBallonConc = function
        | ScaleBeg -> 0m
        | ScaleMid2 -> 25m
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
        | Termo ->  "Компенсация","t"            
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
    | Var8
    | Var10
    static member context = function
        | Conc  -> 0,  ("C", "Концентрация")
        | Temp  -> 2,  ("Т",  "Температура")
        | Curr  -> 4,  ("I",  "Ток излучателя")
        | Var1  -> 16, ("Var1",  "Var1")
        | Var8  -> 8, ("Var8",  "Var8")
        | Var10  -> 10, ("Var10",  "Var10")
        | Workk -> 12, ("Work",  "Рабочий канал")
        | Refk  -> 14, ("Ref",   "Опорный канал")
    static member code = PhysVar.context >> fst
    static member what = PhysVar.context >> snd >> fst
    static member dscr = PhysVar.context >> snd >> snd
    static member values = FSharpType.unionCasesList<PhysVar>
    static member name (x:PhysVar) = FSharpValue.unionCaseName x
    member x.Dscr = PhysVar.dscr x
    member x.What = PhysVar.what x
    member x.Code = PhysVar.code x
    
type Id = string


type KefGroup = 
    | KefLin
    | KefT0 
    | KefTM
    | KefTK

    static member ctx v = 
        match v with
        | KefLin -> 
            "LIN", "Линеаризация", [CoefCchlin0; CoefCchlin1; CoefCchlin2; CoefCchlin3]            
        
        | KefT0 -> 
            "T0", "Комп. вл. темп. на нулев. показ.",
                [CoefChtNull0; CoefChtNull1; CoefChtNull2]
        | KefTM -> 
            "TM", "Комп. вл. темп. на середину шк.",
                [CoefKChtMid0; CoefKChtMid1; CoefKChtMid2]
        | KefTK -> 
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

type DelayContext = 
    | BlowDelay  
    | BlowAirDelay 
    | WarmDelay 
    | TexprogonDelay
    static member what = function
        | BlowDelay -> "Продувка газом"
        | BlowAirDelay -> "Продувка воздухом"
        | WarmDelay -> "Прогрев"
        | TexprogonDelay -> "Выдержка, техпрогон"
        
    member x.What = DelayContext.what x
    static member values = 
        [ BlowDelay, BlowAirDelay, WarmDelay, TexprogonDelay ]
    

    

module Vars = 
    let what ( (f,v,s,t) as x : Var ) = 
        sprintf "%A.%A.%A.%A" (Feature.what1 f) (PhysVar.what v) (ScalePt.what s) (TermoPt.what t)  

    let name ( (f,v,s,t) as x : Var ) = 
        sprintf "%s_%s_%s_%s" (Feature.name f) (PhysVar.name v) (ScalePt.name s) (TermoPt.name t)

    let gas_t_vars = 
        [   for gas in ScalePt.values do
                for t in TermoPt.values  do
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

module Property = 
    let concError scalePt = sprintf "ConcError_%s" (ScalePt.name scalePt)
    let tex1Error scalePt = sprintf "Tex1Error_%s" (ScalePt.name scalePt)
    let tex2Error scalePt = sprintf "Tex2Error_%s" (ScalePt.name scalePt)
    let retNkuError scalePt = sprintf "RetNkuError_%s" (ScalePt.name scalePt)
    let termoError (scalePt,termoPt) = sprintf "TermoError_%s_%s" (ScalePt.name scalePt) (TermoPt.name termoPt)
    let var var = sprintf "Var_%s" (Vars.name var)
    

[<AutoOpen>]
module ProductHelpers = 
    let decode2 encodedValue = 
        encodedValue / 10000, encodedValue % 10000

    let encode2 value1 value2 = 
        value1 * 10000 + value2
        |> decimal
        |> Some

type ProductInfo =
    {   serial : int
        year : int
        month : int
        kind : int
    } 

type Product = 
    {   Id : Id
        IsChecked : bool        
        Addr : byte
        VarValue : Map<Var, decimal> 
        CoefValue : Map<Coef, decimal> }

    member x.What = Product.what x

    member x.ProductInfo = Product.getProductInfo x
    
    static member id x = x.Id

    static member getProductInfo x = 
        let year,serial = 
            x.CoefValue.TryFind CoefSerialYearMil82
            |> Option.map( int >> decode2 )
            |> Option.withDefault (0,0)
        let month, kind = 
            x.CoefValue.TryFind CoefPriborTypeMonthMil82
            |> Option.map(int >> decode2 )
            |> Option.withDefault (0,0)
        {   serial = serial
            year  = year
            month = month
            kind = kind } 

    static member setProductInfo i = state{
        do! Product.setKef CoefSerialYearMil82 <|  encode2 i.year i.serial
        do! Product.setKef CoefPriborTypeMonthMil82 <|  encode2 i.month i.kind        
    }

    static member createNewId() = String.getUniqueKey 12
    static member what x = sprintf "№%d.#%d" (Product.getProductInfo x).serial x.Addr 

    static member getVar k p =p.VarValue.TryFind k 

    static member setVar k v =  state{                
        let! p = getState 
        let m = 
            match v with
            | None -> Map.remove k
            | Some v -> Map.add k v
               
        do! setState { p with VarValue = m p.VarValue   } }


    static member getKef k p =p.CoefValue.TryFind k 

    static member getKefs kefs p =
        kefs 
        |> List.map p.CoefValue.TryFind 
        |> List.choose id

    static member setKef k (v:decimal option) =  state{                
        let! p = getState 
        let m = 
            match v with
            | None -> Map.remove k
            | Some v -> Map.add k v
               
        do! setState { p with CoefValue = m p.CoefValue   } }

    static member setVars varsValues =  state{ 
        for var,value in varsValues do
            do! Product.setVar var (Some value)    }

    static member setKefs kefsVals = state{ 
        for kef,value in kefsVals do
            do! Product.setKef kef (Some value)  }

    static member createNew addy kefs = 
        let now = DateTime.Now
        {   Id = Product.createNewId()
            Addr = addy
            IsChecked = true
            VarValue = Map.empty 
            CoefValue = kefs }

    static member tryParseSerailMonthYear s =
        let m = Text.RegularExpressions.Regex.Match(s, @"(\d\d)\s*[\./\s]\s*(\d+)")
        if not m.Success then None else
        let y = Int32.Parse m.Groups.[2].Value - 2000
        let mn = Byte.Parse m.Groups.[1].Value
        if y >= 16 && mn > 0uy && mn < 13uy then 
            Some ( mn, byte y )
        else None

    static member formatSerailMonthYear (m:byte, y:byte) =
        let sm = if m<10uy then sprintf "0%d" m else m.ToString()
        sprintf "%s.%d" sm (2000 + int y)

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
            ProductInfo : ProductInfo list   }
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
            ProductInfo = List.map Product.getProductInfo []
            Date=DateTime.Now 
            Name = ""
            ProductType = A00 }, 
            {   Products = []
                BallonConc = Map.empty
                TermoTemperature = Map.empty
                PerformingJournal = Map.empty}

    let ballonConc gas m =
        match Map.tryFind gas m with
        | Some x -> x
        | _ -> ScalePt.defaultBallonConc gas


    let getTermoTemperature partyData t = 
        partyData.TermoTemperature
        |> Map.tryFind t
        |> Option.withDefault (TermoPt.defaultTermoTemperature t)

