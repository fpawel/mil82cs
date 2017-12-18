module Thread2

open System
open System.ComponentModel

open Mil82
open Mil82.ViewModel.Operations
open MainWindow


let showScenaryReport = Ref.Initializable<_>(sprintf "showScenaryReport %s:%s" __LINE__ __SOURCE_FILE__ )
let showPerformingMessage = Ref.Initializable<_>(sprintf "showPerformingMessage %s:%s" __LINE__ __SOURCE_FILE__ )

[<AutoOpen>]
module private Helpers1 =
    let none _ = None
    let safe = Windows.Forms.Control.performThreadSafeAction
    let party = AppContent.party    
    let scenaryKeepRunning = Ref.Observable(false)

let isKeepRunning () = scenaryKeepRunning.Get()
let notKeepRunning() = not (scenaryKeepRunning.Get())
let forceStop() = scenaryKeepRunning.Value <- false

let addKeepRunningChanged f = 
    scenaryKeepRunning.AddChanged f    

let scenary = 
    let valueRef = Ref.Observable(Operation.CreateSingle("scenary_op", none) none)

    // при изменении сценария 
    valueRef.AddChanged <| fun (_,scenary) -> 
        
        // изменить treeListViewScenary
        let asIEnumerable = [scenary] :> Collections.IEnumerable
        treeListViewScenary.SetObjects asIEnumerable
        treeListViewScenary.CheckedObjectsEnumerable <- asIEnumerable        
        treeListViewScenary.ExpandAll()

        // показать в журнале сообщения, которые относятся к этому сценарию
        let loggingRecords = 
            let xs = scenary.RunInfo.LoggingRecords
            if xs.Length < 1000 then xs else                 
            [ for n = xs.Length - 1000 to xs.Length - 1 do 
                    yield xs.[n] ]
        LoggingRichText.setLogging MainWindow.loggingJournal scenary.RunInfo.LoggingRecords
        

    valueRef

[<AutoOpen>]
module private Helpers2 =
    // операция, выполняемая в текущий момент
    let operationCurrentRunning = 
        let x = Ref.Observable(None)
        Logging.addLogger <| fun l s ->        
            match  x.Value with
            | Some (op:Operation) -> 
                op.RunInfo.AddLogging l s  
                showPerformingMessage.Value l s
            | _ -> ()            
        |> ignore
        x

    open System.Windows.Forms
    
    let showCantExitMessage() = 
        let s = "Нельзя выйти из приложения пока идёт настройка приборов."
        MessageBox.Show(s,"СТМ-30М", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        |> ignore

let addOperationCurrentRunningChangedHandler f = 
    operationCurrentRunning.AddChanged (snd >> f)

let private isRrunning = 
    let x = Ref.Observable(false)
    form.Closing.Add <| fun e ->
        if x.Value then 
            e.Cancel <- true
            forceStop()
            showCantExitMessage()
    x

module IsRunningChangedEvent =
    let addHandler f = 
        isRrunning.AddChanged <| fun e -> 
            safe form <| fun () -> 
                f e 

type PerformBuilder() =
    let (>>=) p rest = 
        match p with         
        | None when notKeepRunning() -> None
        | None -> rest()
        | x -> x 
    
    member b.Bind(p, rest) = p >>= rest

    member b.Bind(p, rest) = 
        match p with 
        | Ok _ when notKeepRunning() -> None
        | Ok x -> rest x
        | Err x -> Some x         

    member b.Delay(f : unit -> string option) = f

    member x.Run(f) = f()

    member x.While(cond, f) =
        if isKeepRunning() && cond() then f() >>= fun _ -> x.While(cond, f)
        else None

    member x.For(e:seq<_>,f) = 
        let cursor = e.GetEnumerator()
        let body () =  f cursor.Current        
        try
            x.While(cursor.MoveNext, x.Delay(body) )
        with _ ->
            cursor.Dispose()
            reraise()
        
    member b.ReturnFrom (x : string option) = x

    member b.ReturnFrom (x : Result<string,_>) = 
        match x with
        | Err x -> Some x
        | Ok _ -> None

    member b.Return (error:string) = Some error
    member b.Return (x:unit) = None    

    member b.Combine(m, f ) = 
        m >>= f
        
    member b.Zero() = None

    member x.TryWith(p, handler) = 
        try 
            p()
        with  exn -> 
            handler exn 

    member m.TryFinally(f, finalizer) = 
        try 
            f()
        finally 
            finalizer()

let maybeErr = PerformBuilder ()


let sleep50() = Threading.Thread.Sleep 50

let sleep t = 
    let start = DateTime.Now
    while DateTime.Now - start < t && isKeepRunning() do
        System.Threading.Thread.Sleep 50
    None

let sleep_ms t =  
    t |> float |> TimeSpan.FromMilliseconds |> sleep
    

let doWork work = 
    if notKeepRunning() then None
    elif party.HasNotOneCheckedProduct() then Some "выполнение прервано, так как не выбрано ни одного прибора"
    else work()

let private perfomOperationEvent = new Event<_>()
[<CLIEvent>]
let PerfomOperationEvent = perfomOperationEvent.Publish

let private stopHardwareWork() =
    let cop s1 s2 f = 
        Option.map
            (   sprintf "Не удалось %s после выполнения сценария, %s" s1 ) 
            (   Logging.warn "Выполняется %s после выполнения сценария" s2
                f() |> Result.someErr ) 


    [   if Hardware.Pneumo.isOpened() then 
            yield cop "закрыть пневмоблок" "закрытие пневмоблока" <| fun () -> 
                  Hardware.Pneumo.switch(0uy)
        match Hardware.Termo.state.Value with
        | Some (Ok Hardware.Termo.Stop) | None -> ()
        | _ -> yield cop "остановить термокамеру" "остановка термокамеры" <| fun () -> 
            Hardware.Termo.stop () ]

let private beginRun op = 
    let prev'op = operationCurrentRunning.Get()
    operationCurrentRunning.Set (Some op)
    showPerformingMessage.Value Logging.Info ""
    perfomOperationEvent.Trigger(op,true)
    fun () -> 
        operationCurrentRunning.Set prev'op
        perfomOperationEvent.Trigger(op,false)

let private isOperationUncheckedByUser operation = 
    form.PerformThreadSafeAction(fun () -> 
        let mutable found = false 
        let mutable result = false 
        let mutable n = 0
        while n < treeListViewScenary.Items.Count && not found do
            let item = treeListViewScenary.Items.[n]            
            if Object.ReferenceEquals( treeListViewScenary.GetModelObject(item.Index) ,operation) then
                result <- item.StateImageIndex = 0
                found <- true
            n <- n + 1
        result 
        )
let run stopHardware (x : Operation) =
    if scenary.Value.FullName <> x.FullName then 
        scenary.Set x
    operationCurrentRunning.Set (Some x)
    scenaryKeepRunning.Value <- true
    isRrunning.Set true   
    Logging.info "Начало выполнения сценария %A" x.FullName 
    let dostart, dostop = MyWinForms.Utils.timer 10000 ( fun _ -> AppContent.save() )
    dostart()

    MainWindow.treeListViewScenary.SelectObject x
    MainWindow.loggingJournal.Text <- ""
    
    async{
        let r = Operation.Perform beginRun isKeepRunning isOperationUncheckedByUser x
        let scenaryWasBreakedByUser = not scenaryKeepRunning.Value
        scenaryKeepRunning.Value <- false
            
        let level,message = 
            [   yield r 
                if stopHardware then 
                    yield! stopHardwareWork()  ]
            |> fun rs ->
                if rs |> List.exists Option.isSome then 
                    Logging.Error, rs 
                                    |> List.choose id 
                                    |> Seq.toStr "\n" id 
                                    |> sprintf "Выполнение завершилось с ошибкой. %s"
                elif Operation.WasErrorWhenRunning x then
                    Logging.Warn, "при выполнении произошли ошибки"
                elif scenaryWasBreakedByUser then
                    Logging.Warn, "выполнение было прервано"
                else
                    Logging.Info, "Выполнено"
                                    
        safe form dostop
        Comport.Ports.closeOpenedPorts (fun _ _ -> true) 
        Logging.write level "Окончание выполнения сценария %A - %s" x.FullName message
        let title = sprintf "%s %s" x.RunInfo.Status x.FullName
        showScenaryReport.Value title level message 
        operationCurrentRunning.Set None 
        isRrunning.Set false
        for p in party.Products do
            p.Connection <- None 
        AppContent.save() }
    |> Async.Start