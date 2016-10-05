module Mil82.PartyWorks

open System

open Thread2
open Mil82.Alchemy

open ViewModel.Operations

[<AutoOpen>]
module private Helpers = 
    type P = Product
    let party = AppContent.party
    let appCfg = AppConfig.config
    let viewCfg = appCfg.View


    let writeInitKefs write = state{ 
        for kef in Coef.coefs do
            if notKeepRunning() then () else
            let! p = getState
            match initKefValue party.GetPgs (party.getProductType()) kef p with
            | None -> ()
            | Some value -> 
                do! P.setKef kef (Some value) 
                write kef value }

let checkedProducts() = 
    party.Products
    |> Seq.filter( fun p -> p.IsChecked )
let hasNotCheckedProduct() = checkedProducts() |> Seq.isEmpty 
let hasCheckedProduct() = not <| hasNotCheckedProduct()


let doWithProducts f = 
    checkedProducts() |> Seq.iter ( fun p ->       
        if isKeepRunning() && p.IsChecked then 
            f p ) 

type Mil82.ViewModel.Product1 with
    
    member x.WriteKef (kef,value) = 
        let r = x.WriteModbus( WriteKef kef, value )
        match r with
        | Ok () -> 
            Logging.info "%s.коэф.%d <- %M" x.What kef.Order value
            x.setKef kef (Some value)
        | Err err -> Logging.error "%s.коэф.%d <- %M : %s" x.What kef.Order value err
        r

    member x.WriteKef1 kef  = 
        match P.getKef kef x.Product with
        | None ->  Logging.warn "%s, нет значения записываемого к-та %d, %s" x.What kef.Order kef.Description ; Ok()
        | Some value -> x.WriteKef(kef,value) 
       
    
    member x.WriteKefs kefsValues = 
        kefsValues |> List.iter ( x.WriteKef >> ignore )
        

    member x.WriteKefs1 kefs = 
        kefs |> List.iter ( x.WriteKef1 >> ignore )

    

    member x.WriteKefsInitValues() = 
        let t = party.getProductType()        
        Coef.coefs 
        |> List.choose( fun kef -> 
            if notKeepRunning() then None else 
            Alchemy.initKefValue party.GetPgs t kef x.Product 
            |> Option.map(fun v -> kef,v) )
        |> x.WriteKefs

    member x.ReadKefs kefs = maybeErr {
        for kef in kefs do
            match x.ReadModbus( ReadKef kef ) with
            | Ok value -> 
                Logging.info "%s.коэф.%d = %M" x.What kef.Order value
                x.setKef kef (Some value) 
            | Err err ->
                Logging.error "%s.коэф.%d : %s" x.What kef.Order err }

    
    member x.Interrogate() = maybeErr {
        for var in PhysVar.values do 
            let! _ = x.ReadModbus( ReadVar var)
            () }

    member p.TestConc gas = maybeErr{
        let whatPt = ScalePt.what gas
        let! conc = p.ReadModbus( ReadVar Conc )
        p.setVar (Test,Conc,gas,TermoNorm) (Some conc)
        let concErrorlimit = Alchemy.concErrorlimit (party.getProductType()) conc
        let pgs = party.GetPgs gas
        let d = abs(conc - pgs)
        Logging.write 
            (if d < concErrorlimit then Logging.Info else Logging.Error)
            "%s, проверка погрешности %s=%M - конц.=%M, погр.=%M, макс.погр.=%M" 
                p.What (ScalePt.what gas) pgs conc d concErrorlimit }

type Mil82.ViewModel.Party with
    member x.DoForEachProduct f = 
        let xs = x.Products |> Seq.filter(fun p -> p.IsChecked)
        if Seq.isEmpty xs then
            Err "приборы не отмечены"
        else
            for p in xs do 
                if isKeepRunning() && p.IsChecked then 
                    f p
            Ok ()

    member x.Interrogate() = Option.toResult <| maybeErr {
        let xs = x.Products |> Seq.filter(fun p -> p.IsChecked)
        if Seq.isEmpty xs then
            return "приборы не отмечены"
        else
            do! Comport.testPort AppConfig.config.ComportProducts
            for p in xs do 
                if isKeepRunning() && p.IsChecked then                         
                    p.Interrogate() |> ignore }

    member x.WriteModbus(cmd,value) = maybeErr{
        do! Comport.testPort appCfg.ComportProducts
        do! x.DoForEachProduct (fun p -> p.WriteModbus(SendCommand cmd,value) |> ignore  ) }

    member x.WriteKefs(kefs) = maybeErr{
        do! Comport.testPort appCfg.ComportProducts
        do! x.DoForEachProduct (fun p -> 
            p.WriteKefs1 kefs |> ignore ) }

    member x.ReadKefs(kefs) = maybeErr{
        do! Comport.testPort appCfg.ComportProducts
        do! x.DoForEachProduct (fun p -> 
            p.ReadKefs kefs |> ignore ) }

    member x.ComputeAndWriteKefGroup (kefGroup) = 
        x.DoForEachProduct(fun p -> 
            p.ComputeKefGroup kefGroup
            p.WriteKefs1 (KefGroup.kefs kefGroup) |> ignore )
   
module Delay = 
    let onStart = Ref.Initializable<_>(sprintf "Delay.start %s:%s" __LINE__ __SOURCE_FILE__ )
    let onStop = Ref.Initializable<_>(sprintf "Delay.stop %s:%s" __LINE__ __SOURCE_FILE__ )
    let onUpdate = Ref.Initializable<_>(sprintf "Delay.stop %s:%s" __LINE__ __SOURCE_FILE__ )

    let mutable private keepRunning = false

    let cancel() = keepRunning <- false

    let perform what gettime interrogate = maybeErr{
        onStart.Value what gettime
        keepRunning <- true
        let start'time = DateTime.Now
        while keepRunning && Thread2.isKeepRunning() && (DateTime.Now - start'time < gettime()) do
            onUpdate.Value start'time gettime
            if interrogate then
                do! party.Interrogate()
            else
                Threading.Thread.Sleep 10
        keepRunning <- false
        onStop.Value() }

module ModalMessage = 
    let onShow = Ref.Initializable<_>(sprintf "ModalMessage.onShow %s:%s" __LINE__ __SOURCE_FILE__ )
    let getIsVivisble = Ref.Initializable<_>(sprintf "ModalMessage.getIsVivisble %s:%s" __LINE__ __SOURCE_FILE__ )
    let onClose = Ref.Initializable<_>(sprintf "ModalMessage.onClose %s:%s" __LINE__ __SOURCE_FILE__ )
    
    let show (level:Logging.Level) (title:string) (text:string) = 
        onShow.Value title level text
        while Thread2.isKeepRunning() && getIsVivisble.Value() do
            Threading.Thread.Sleep 50
        onClose.Value()    

[<AutoOpen>]
module private Helpers1 = 
    
    let none _ = None
    let (<|>) what f = 
        Operation.CreateSingle (what, none) f 
    let (<-|->) (what,time,whatDelay) f = 
        Operation.CreateTimed (what, none) (Delay.create time whatDelay) f
    let (<||>) what xs =  Operation.CreateScenary ( what, none)  xs

    let computeGroup kefGroup = 
        sprintf "Расчёт %A" (KefGroup.what kefGroup) <|> fun () -> 
            party.ComputeAndWriteKefGroup kefGroup
            |> Result.someErr

    let writeGroup kefGroup = 
        sprintf "Запись к-тов группы %A" (KefGroup.what kefGroup) <|> fun () -> 
            party.WriteKefs ( KefGroup.kefs kefGroup)

    let computeAndWriteGroup kefGroup = 
        [   "Расчёт" <|> fun () -> 
                party.ComputeAndWriteKefGroup kefGroup
                |> Result.someErr
            "Запись" <|> fun () -> party.WriteKefs ( KefGroup.kefs kefGroup) ]

    type OpConfig = Config
    type Op = Operation

    let switchPneumo gas = maybeErr{
        let code, title, text = 
            match gas with
            | Some gas -> 
                let s = ScalePt.what gas
                ScalePt.code gas |> byte, "Продувка " + s, "Подайте " + s
            | _ -> 0uy, "Выключить пневмоблок", "Отключите газ"

        if appCfg.UsePneumoblock then
            do! Hardware.Pneumo.switch code
        else            
            ModalMessage.show Logging.Info  title text 
            if isKeepRunning() then
                match gas with
                | Some gas -> Logging.info "газ %s подан вручную" gas.What
                | _ -> Logging.info "пневмоблок закрыт вручную" }

    let blow minutes gas what = 
        let s = ScalePt.what gas
        let title, text = "Продувка " + s, "Подайте " + s

        (what, TimeSpan.FromMinutes (float minutes), BlowDelay gas ) <-|-> fun gettime -> maybeErr{        
            do! switchPneumo <| Some gas
            do! Delay.perform title gettime true }

    let warm t = maybeErr{    
        if appCfg.UsePneumoblock && Hardware.Pneumo.isOpened()  then
            do! switchPneumo None
        let value = party.GetTermoTemperature t
        Logging.info "Установка температуры %A %M\"C" (TermoPt.what t) value
        if not appCfg.UseTermochamber then             
            ModalMessage.show Logging.Info
                "Уставка термокамеры" (sprintf "Установите в термокамере температуру %M\"C" value) 
            if isKeepRunning() then
                Logging.info "температура %s установлена вручную" t.What
        else 
            do! Hardware.Warm.warm value Thread2.isKeepRunning party.Interrogate  }

    let adjust isScaleEnd = 
        let cmd, gas, wht = 
            if not isScaleEnd then 
                AdjustBeg, ScaleBeg, "начало" 
            else 
                AdjustEnd, ScaleEnd, "конец"
        let whatOperation = sprintf "Калибровка %s шкалы" wht
        let defaultDelayTime = TimeSpan.FromMinutes 3.
        (whatOperation, defaultDelayTime, AdjustDelay isScaleEnd)  <-|-> fun gettime -> maybeErr{
            let pgs = party.GetPgs gas
            Logging.info  "Калибровка %s шкалы, %M" wht  pgs
            do! switchPneumo <| Some gas
            do! Delay.perform (sprintf  "Продувка перед калибровкой %A" gas.What) gettime true
            do! party.WriteModbus( cmd, pgs ) 
            do! Delay.perform (sprintf  "Выдержка после калибровки %A" gas.What) (fun () -> TimeSpan.FromSeconds 10.) true
            }

    let goNku = "Установка НКУ" <|> fun () -> warm TermoNorm

    let readVarsValues feat gas t wht = maybeErr{
        do! Comport.testPort appCfg.ComportProducts
        do! party.DoForEachProduct(fun p -> 
            maybeErr{
                for var in PhysVar.values do
                    let! readedValue = p.ReadModbus( ReadVar var)
                    p.setVar (feat,var,gas,t) (Some readedValue)
                    Logging.info "%s : %s = %s" p.What (PhysVar.what var) (Decimal.toStr6 readedValue) } |> function 
            | Some error -> Logging.error "%s" error
            | _ -> () ) }

let blowAir = 
    "Продувка воздухом" <||> [   
        blow 1 ScaleBeg "Продуть воздух"
        "Закрыть пневмоблок" <|> fun () -> switchPneumo None
    ]
let blowAndRead feat t =
    [   for gas in ScalePt.values ->
            gas.What <||> [
                yield blow 3 gas "Продувка"
                yield "Считывание" <|> readVarsValues feat gas t  ] 
        yield blowAir ]

let warmAndRead feat t =
    sprintf "Cнятие %A %A" (Feature.what1 feat) (TermoPt.what t) <||> 
        [   yield sprintf "Температура %A" (TermoPt.what t) <||> [
                yield "Установка"  <|> fun () -> warm t
                yield ("Выдержка", TimeSpan.FromHours 1., WarmDelay t) <-|-> fun gettime -> maybeErr{    
                    do! switchPneumo None    
                    do! Delay.perform ( sprintf "Выдержка термокамеры %A" (TermoPt.what t) ) gettime true } ]
        
            yield! blowAndRead feat t  ]

let test = 
    
    [   adjust false
        adjust true 
        blowAir
        "Cнятие НКУ" <||> ( blowAndRead Test TermoNorm  )
        warmAndRead Test TermoLow 
        warmAndRead Test TermoHigh 
        warmAndRead Test Termo90 
        warmAndRead RetNku TermoNorm  ]
    |> (<||>) "Проверка"

let texprogon = 
    "Техпрогон" <||> [   
        adjust false
        adjust true 
        blowAir
        "Снятие перед техпрогоном" <||> blowAndRead Tex1 TermoNorm 
        ("Выдержка на техпрогоне", TimeSpan.FromHours 16., TexprogonDelay) <-|-> fun gettime ->
            Delay.perform "Техпрогон" gettime true
        "Снятие после техпрогона" <||> blowAndRead Tex2 TermoNorm ]

let reworkTermo = 
        
    [   goNku
        adjust false
        adjust true
        blowAir
        "Снятие НКУ для перевода климатики" <||> blowAndRead Termo TermoNorm 
        "Переcчёт" <|> fun () ->
            party.DoForEachProduct(fun p -> 
                p.Product <- snd <| runState Alchemy.translateTermo p.Product )
            |> Result.someErr
            
        "Термокомпенсация" <||> [
            "Начало шкалы" <||> computeAndWriteGroup (KefTermo ScaleBeg)
            "Конец шкалы" <||> computeAndWriteGroup (KefTermo ScaleEnd) ]
        test ]
    |> (<||>) "Перевод климатики" 

    

let productionWork = 
    [   "Установка к-тов исп." <|> fun () -> maybeErr{
            do! party.DoForEachProduct (fun p -> 
                p.WriteKefsInitValues() ) }
        goNku
        blowAir
        "Ноормировка" <|> fun () -> party.WriteModbus(Nommalize, 1000m)        
        adjust false
        adjust true 
        "Линеаризация" <||> [
            yield "Снятие" <||> blowAndRead Lin TermoNorm 
            yield!  computeAndWriteGroup KefLin ]
        warmAndRead Termo TermoLow 
        warmAndRead Termo TermoHigh 
        warmAndRead Termo Termo90 
        warmAndRead Termo TermoNorm 
        "Термокомпенсация"  <||> [
            for gas in ScalePt.values ->
                 gas.What <||> computeAndWriteGroup  (KefTermo gas) ]
        test
        texprogon ]
    |> (<||>) "Осн."

let testo = 
    let m = System.Collections.Generic.Dictionary<string,decimal>()
    [   "draw sin" <|> fun () -> 
            while isKeepRunning() do
                for p in party.Products do
                    if notKeepRunning() then () else
                    let b,v = m.TryGetValue(p.Product.Id)
                    let v = if b then v else 0m
                    let y = System.Math.Sin( float v ) |> decimal 
                    p.setPhysVarValue Conc y
                    m.[p.Product.Id] <- v + 0.1m
                    sleep 100 |> ignore                
            None ]
    |> (<||>) "testo"

let mil82 =
    let mil82 =  "МИЛ-82" <||> [productionWork; reworkTermo]
    let dummy msg = 
        Logging.debug "%s" msg
        Mil82.ViewModel.Operations.Config.CreateNew()
    let fileName = IO.Path.Combine(IO.Path.ofExe, "scenary.json")
    let config = 
        if IO.File.Exists fileName |> not then                
            dummy <| sprintf "не найден файл сценария %A" fileName 
        else                
            try
                match Json.Serialization.parse<OpConfig> (IO.File.ReadAllText(fileName)) with
                | Ok x -> x
                | Err error ->
                    dummy <| sprintf "ошибла файла сценария %s\n%s" fileName error                    
            with e ->             
                dummy <| sprintf "ошибла файла сценария %s\n%A" fileName e 
    Op.SetConfig (mil82,config)

    MainWindow.form.Closing.Add <| fun _ ->
        let config = Op.GetConfig mil82
        try
            IO.File.WriteAllText(fileName, Json.Serialization.stringify config ) 
        with e ->             
            Logging.error "ошибла сохранения файла сценария %s\n%A" fileName e 
    Thread2.scenary.Set mil82    

    mil82

module Works =
    let all = Op.MapReduce Some mil82 

    let blow = 
        all |> List.choose ( function 
            | (Op.Timed (_, ({DelayContext = BlowDelay gas} as delay),_) as op) -> 
                Some (op,delay,gas)
            | _ -> None)

    let warm = 
        all |> List.choose ( function 
            | (Op.Timed (_, ({DelayContext = WarmDelay t} as delay),_) as op) -> 
                Some (op,delay,t)
            | _ -> None)



[<AutoOpen>]
module private Helpers3 =
    let ( -->> ) s f =
        s <|> f
        |> Thread2.run (false)

    
let runInterrogate() = "Опрос" -->> fun () -> maybeErr{ 
    do! Comport.testPort appCfg.ComportProducts
    while Thread2.isKeepRunning() do
        do! party.Interrogate() }


let setAddr addr = sprintf "Установка адреса %A" addr -->> fun () -> maybeErr{ 
    
    do! Mdbs.write appCfg.ComportProducts 0uy ResetAddy.Code "установка адреса" addr
    let! _ =  Mdbs.read3decimal appCfg.ComportProducts (byte addr) 0 "проверка установки адреса"
    () }

let sendCommand (cmd,value as x) = 
    sprintf "%s <- %M" (Command.what cmd) value -->> fun () -> 
        party.WriteModbus x


module Pneumoblock =
    let switch gas = 
        ScalePt.what gas -->> fun () -> 
            Hardware.Pneumo.switch gas.Code |> Result.someErr
    let close() = 
        "Выкл." -->> fun () ->
            Hardware.Pneumo.switch 0uy |> Result.someErr

module Kefs = 
    
    let private run s f = 
        s -->> fun () ->
            let x = appCfg.View
            let kefs = 
                Set.intersect 
                    (IntRanges.parseSet x.SelectedCoefs)
                    (IntRanges.parseSet x.VisibleCoefs)
                |> Set.map Coef.tryGetByOrder  
                |> Set.toList
                |> List.choose id
            if kefs.IsEmpty then Some "не выбрано ни одного коэффициента" else f kefs

    let write() = run "Запись к-тов" party.WriteKefs 
    let read() = run "Считывание к-тов"  party.ReadKefs

module TermoChamber =
    let private (-->>) s f = 
        s -->> fun () ->
            f () |> Result.someErr

    let start() = "Старт" -->> Hardware.Termo.start
    let stop() = "Стоп" -->> Hardware.Termo.stop
    let setSetpoint value = "Уставка" -->> fun () -> 
        Hardware.Termo.setSetpoint value
    let read () = "Замер" -->> fun () -> 
        let r = Hardware.Termo.read ()
        Logging.write (Result.level r) "%A" r
        Result.map (fun _ -> () ) r