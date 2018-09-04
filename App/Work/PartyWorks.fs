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
        let value =
            match value, P.getKef kef x.Product with
            | Some value, _ -> Some value
            | _, Some value -> Some  value            
            | _ ->  None
        match value with
        | None -> 
            Logging.warn "%s, нет значения записываемого к-та %d, %s" x.What kef.Order kef.Description 
            Ok()
        | Some value -> x.WriteModbus( WriteKef kef, value )
    
    member x.WriteKefs kefsValues  = maybeErr {
        for kef,value in kefsValues do
            let _ = x.WriteKef(kef,value)
            () }

    member x.SetKefsSerial() =
         let value = (decimal DateTime.Now.Year - 2000m) * 10000m //+ x.Product.ProductSerial
         ()
            
    member x.WriteKefsInitValues() = 
        let t = party.getProductType()        

        [   //yield CoefSerialYearMil82, x.getKef CoefSerialYearMil82
            //yield CoefPriborTypeMonthMil82, x.getKef CoefPriborTypeMonthMil82
            yield! 
                Alchemy.initKefsValues party.GetPgs t  
                |> List.map( fun (coef,value) -> coef, Some value )
        ]
        |> List.sortBy fst
        |> x.WriteKefs

    member x.ReadKefs kefs = maybeErr {
        for kef in kefs do
            let r = x.ReadModbus( ReadKef kef )
            match r with
            | Ok value -> 
                Logging.info "%s.коэф.%d = %M" x.What kef.Order value
                x.setKef kef (Some value) 
            | Err err ->
                Logging.error "%s.коэф.%d : %s" x.What kef.Order err 
            let! _ = r
            () }
    
    member x.Interrogate() = maybeErr {
        let xs = 
            let xs = AppConfig.config.View.VisiblePhysVars
            if Set.isEmpty xs then [Conc] else
            Set.toList xs
        for var in xs do
            let _ = x.ReadModbus( ReadVar var)
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

    member x.Interrogate(f) = Option.toResult <| maybeErr {
        let xs = x.Products |> Seq.filter(fun p -> p.IsChecked)
        if Seq.isEmpty xs then
            return "приборы не отмечены"
        else
            do! Comport.testPort appCfg.Hardware.ComportProducts
            for p in xs do 
                if isKeepRunning() && p.IsChecked then                         
                    do! p.Interrogate() 
                    f()}

    member x.WriteModbus(cmd,value) = maybeErr{
        do! Comport.testPort appCfg.Hardware.ComportProducts
        do! x.DoForEachProduct (fun p -> p.WriteModbus(SendCommand cmd,value) |> ignore  ) }

    member x.WriteKefs(kefs) = maybeErr{
        do! Comport.testPort appCfg.Hardware.ComportProducts
        do! x.DoForEachProduct (fun p -> 
            p.WriteKefs kefs |> ignore ) }

    member x.ReadKefs(kefs) = maybeErr{
        do! Comport.testPort appCfg.Hardware.ComportProducts
        do! x.DoForEachProduct (fun p -> 
            p.ReadKefs kefs |> ignore ) }

    member x.ComputeAndWriteKefGroup (kefGroup) = 
        x.DoForEachProduct(fun p -> 
            p.ComputeKefGroup kefGroup
            KefGroup.kefs kefGroup
            |> List.map (fun x -> x, None)
            |> p.WriteKefs  
            |> ignore )
   
module Delay = 
    let onStart = Ref.Initializable<_>(sprintf "Delay.start %s:%s" __LINE__ __SOURCE_FILE__ )
    let onStop = Ref.Initializable<_>(sprintf "Delay.stop %s:%s" __LINE__ __SOURCE_FILE__ )
    let onUpdate = Ref.Initializable<_>(sprintf "Delay.stop %s:%s" __LINE__ __SOURCE_FILE__ )
    

    let mutable private keepRunning = false

    let cancel() = keepRunning <- false

    let perform what gettime interrogate = 
        onStart.Value what gettime
        keepRunning <- true
        let start'time = DateTime.Now
        let result = 
            maybeErr{
                let upd () = 
                    onUpdate.Value start'time gettime
                while keepRunning && Thread2.isKeepRunning() && (DateTime.Now - start'time < gettime()) do
                    upd()
                    if interrogate then
                        do! party.Interrogate(upd)
                    else
                        Threading.Thread.Sleep 10 }
        keepRunning <- false
        onStop.Value() 
        result

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
        Operation.CreateTimed (what, none) (Delay.Create time whatDelay) f
    let (<||>) what xs =  Operation.CreateScenary ( what, none)  xs

    let computeGroup kefGroup = 
        sprintf "Расчёт %A" (KefGroup.what kefGroup) <|> fun () -> 
            party.ComputeKefGroup kefGroup
            None

    let writeGroup kefGroup = 
        sprintf "Запись к-тов группы %A" (KefGroup.what kefGroup) <|> fun () -> 
            KefGroup.kefs kefGroup
            |> List.map(fun x -> x, None)
            |> party.WriteKefs 

    let computeAndWriteGroup kefGroup = 
        [   "Расчёт" <|> fun () -> 
                party.ComputeKefGroup kefGroup
                None
            "Запись" <|> fun () ->  
                KefGroup.kefs kefGroup
                |> List.map(fun x -> x, None)
                |> party.WriteKefs ]

    type Op = Operation

    let switchPneumo gas = maybeErr{
        let code, title, text = 
            match gas with
            | Some gas -> 
                let s = ScalePt.what gas
                ScalePt.code gas |> byte, "Продувка " + s, "Подайте " + s
            | _ -> 0uy, "Выключить пневмоблок", "Отключите газ"

        if appCfg.Hardware.Pneumoblock.Enabled then
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

        (what, TimeSpan.FromMinutes (float minutes), BlowDelay  ) <-|-> fun gettime -> maybeErr{        
            do! switchPneumo <| Some gas
            do! Delay.perform title gettime true }


    let setupTermo tempValue = maybeErr{    
        if appCfg.Hardware.Pneumoblock.Enabled && Hardware.Pneumo.isOpened()  then
            do! switchPneumo None
        Logging.info "Установка температуры %M\"C" tempValue
        if not appCfg.Hardware.Termochamber.Enabled then             
            ModalMessage.show Logging.Info
                "Уставка термокамеры" (sprintf "Установите в термокамере температуру %M\"C" tempValue) 
            if isKeepRunning() then
                Logging.info "температура %M\"C установлена вручную" tempValue
        else 
            do! 
                Hardware.setupTermo 
                    tempValue 
                    Thread2.isKeepRunning 
                    ( fun () -> party.Interrogate ignore)
    }

    type TermoPt with
        member x.Setup() = 
            TermoPt.setup x
        static member setup t =
            setupTermo (party.GetTermoTemperature t)

    let adjust isScaleEnd = 
        let cmd, gas, wht = 
            if not isScaleEnd then 
                AdjustBeg, ScaleBeg, "начало" 
            else 
                AdjustEnd, ScaleEnd, "конец"
        let whatOperation = sprintf "Калибровка %s шкалы" wht
        let defaultDelayTime = TimeSpan.FromMinutes 3.
        (whatOperation, defaultDelayTime, BlowDelay)  <-|-> fun gettime -> maybeErr{
            let pgs = party.GetPgs gas
            Logging.info  "Калибровка %s шкалы, %M" wht  pgs
            do! switchPneumo <| Some gas
            do! Delay.perform (sprintf  "Продувка перед калибровкой %A" gas.What) gettime true
            do! party.WriteModbus( cmd, pgs ) 
            }

    let goNku = 
        ("Установка НКУ", TimeSpan.FromHours 1., WarmDelay) 
            <-|-> fun gettime -> 
                maybeErr{    
                    do! switchPneumo None    
                    do! TermoNorm.Setup()
                    do! Delay.perform "Выдержка НКУ" gettime true }

    let readVarsValues feat gas t wht = maybeErr{
        do! Comport.testPort appCfg.Hardware.ComportProducts
        do! party.DoForEachProduct(fun p -> 
            maybeErr{
                for var in PhysVar.values do
                    let! readedValue = p.ReadModbus( ReadVar var)
                    p.setVar (feat,var,gas,t) (Some readedValue)
                    Logging.info "%s : %s = %s" p.What (PhysVar.what var) (Decimal.toStr6 readedValue) } |> function 
            | Some error -> Logging.error "%s" error
            | _ -> () ) }

let blowAir() = 
    ("Продувка воздухом", TimeSpan.FromMinutes 1., BlowAirDelay)  <-|-> fun gettime -> maybeErr{
        do! switchPneumo <| Some ScaleBeg
        do! Delay.perform "Продувка воздухом" gettime false
        do! switchPneumo None
    }
let blowAndRead feat t =
    [   for gas in ScalePt.values ->
            ScalePt.what gas <||> [
                yield blow 3 gas "Продувка"
                yield "Считывание" <|> readVarsValues feat gas t  ] 
        yield blowAir() ]

let processTermoPoint feat t =
    let what = sprintf "Выдержка термокамеры %A" (TermoPt.what t)
    let opHoldOn = "Выдержка", TimeSpan.FromHours 1., WarmDelay
    sprintf "%s %s" (Feature.what1 feat) (TermoPt.what t) <||> 
        [   yield sprintf "Перевод термокамеры %s" t.What <||> [
                yield "Установка"  <|> t.Setup
                yield opHoldOn <-|-> fun gettime -> 
                    maybeErr{    
                        do! switchPneumo None    
                        do! Delay.perform what gettime true } ]
        
            yield! blowAndRead feat t  ]

let test = 
    
    [   adjust false
        adjust true 
        blowAir()
        "Cнятие НКУ" <||> ( blowAndRead Test TermoNorm  )
        processTermoPoint Test TermoLow 
        processTermoPoint Test TermoHigh 
        processTermoPoint Test Termo90 
        processTermoPoint RetNku TermoNorm  ]
    |> (<||>) "Проверка"


let texprogon = 
    "Техпрогон" <||> [   
        adjust false
        adjust true 
        blowAir()
        "Снятие перед техпрогоном" <||> blowAndRead Tex1 TermoNorm 
        ("Выдержка на техпрогоне", TimeSpan.FromHours 16., TexprogonDelay) <-|-> fun gettime ->
            Delay.perform "Техпрогон" gettime true
        "Снятие после техпрогона" <||> blowAndRead Tex2 TermoNorm ]



    

let mil82 = 
    "Настройка МИЛ-82" <||>
        [   "Установка к-тов исп." <|> fun () -> maybeErr{
                do! party.DoForEachProduct (fun p -> 
                    p.WriteKefsInitValues()
                    |> ignore ) }
            goNku
            blowAir()
            "Ноормировка" <|> fun () -> party.WriteModbus(Nommalize, 1000m)        
            adjust false
            adjust true 
            "Линеаризация" <||> [
                yield "Снятие" <||> blowAndRead Lin TermoNorm 
                yield!  computeAndWriteGroup KefLin ]
            processTermoPoint Termo TermoLow 
            processTermoPoint Termo TermoHigh 
            processTermoPoint Termo TermoNorm 
            "Термокомпенсация"  <||> [
                "Начало шкалы" <||> computeAndWriteGroup  KefT0
                "Середина шкалы" <||> computeAndWriteGroup  KefTM
                "Конец шкалы" <||> computeAndWriteGroup  KefTK
            ]
            test
            "Сигналы каналов"  <|> fun () -> 
                party.DoForEachProduct (fun p -> 
                    p.ReadKefs [Coef21; Coef22; CoefKw; CoefKr]
                    |> ignore )
                |> Result.someErr
            texprogon ]
    |> Operation.ApplyRootConfig    

let allWorks = Op.MapReduce Some mil82 

[<AutoOpen>]
module private Helpers3 =
    let ( -->> ) s f =
        s <|> f
        |> Thread2.run false

    
let runInterrogate() = "Опрос" -->> fun () -> maybeErr{ 
    do! Comport.testPort appCfg.Hardware.ComportProducts
    while Thread2.isKeepRunning() do
        do! party.Interrogate ignore }


let setAddr addr = sprintf "Установка адреса %A" addr -->> fun () -> maybeErr{ 
    
    do! Mdbs.write appCfg.Hardware.ComportProducts 0uy ResetAddy.Code "установка адреса" addr
    let! _ =  Mdbs.read3decimal appCfg.Hardware.ComportProducts (byte addr) 0 "проверка установки адреса"
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

    let write() = run "Запись к-тов" ( List.map(fun x -> x, None) >> party.WriteKefs  )
    let read() = run "Считывание к-тов"  party.ReadKefs

module TermoChamber =
    let termocicling (count,  tempMin, tempMax, warmTime)  =         
        "Термоциклирование" -->> fun () -> maybeErr {
            let warmTime _ = warmTime
            let mutable n = 0
            for n = 1 to count do
                let what = sprintf "Термоцикл %d из %d" n count
                Logging.info "%s начат" what
                for temp in [tempMin; tempMax] do
                    Logging.info "%s, уставка %M\"C" what temp
                    do! setupTermo temp
                    do! Delay.perform 
                            (sprintf "%s, выдержка при %M\"C" what temp)
                            warmTime true 
                Logging.info "%s завершён" what
            Logging.info "Термоциклирование : перевод термокамеры в НКУ"
            do! TermoNorm.Setup()  
            do! Delay.perform "выдержка НКУ после термоциклирования" warmTime true                 
        }

    let read () = "Считывание температуры" -->> fun () -> maybeErr{        
        let! (t,stp) = Hardware.Termo.read ()
        ModalMessage.show Logging.Info 
            (sprintf "Температура %M\"C\nУставка %M\"C" t stp)
            "Температура термокамеры" 
        return! None }

    let private (-->>) s f = 
        s -->> fun () ->
            f () |> Result.someErr

    let start() = "Старт" -->> Hardware.Termo.start
    
    let stop() = "Стоп" -->> Hardware.Termo.stop
    
    let setSetpoint value = "Уставка" -->> fun () -> 
        Hardware.Termo.setSetpoint value

let testConnect _ = 
    "Проверка связи" <|> fun () -> 
        let oks, errs =
            [   if appCfg.Hardware.Pneumoblock.Enabled then
                    yield "Пневмоблок", Hardware.Pneumo.switch 0uy
                if appCfg.Hardware.Termochamber.Enabled then
                    yield "Термокамера", Hardware.Termo.stop() 
                if appCfg.Hardware.WarmDevice.Enabled then
                    yield "Устройство подогрева плат", Hardware.WarmingBoard.off()
                for p in party.Products do
                    yield p.What, p.ReadModbus(ReadVar Conc) |> Result.map(fun _ -> () ) ]
            |> List.partition (snd >> Result.isOk)
        if errs.IsEmpty then None else
        errs 
        |> Seq.toStr "\n" (fun (what, err) -> sprintf "%s : %s" what (Result.Unwrap.err err) )
        |> Some
    |> Thread2.run false     


let reworkTermo() = 
    "Перевод климатики" <||>
        [   "Начало шкалы" <||> computeAndWriteGroup KefT0
            "Середина шкалы" <||> computeAndWriteGroup KefTM
            "Конец шкалы" <||> computeAndWriteGroup KefTK ]
    |> Thread2.run true     
    

let sendProduction() = 
    "Выпуск в эксплуатацию" <|> fun () -> 
        maybeErr{
            do! 
                [   CoefSerialYearMil82, None
                    CoefPriborTypeMonthMil82, None ]
                |> party.WriteKefs
            do!
                [ 0..49 ]
                |> List.map Coef.tryGetByOrder
                |> List.choose id
                |> party.ReadKefs
        }

    |> Thread2.run true   
