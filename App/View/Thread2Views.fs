module Mil82.View.Thread2 

open System
open System.Windows.Forms
open System.Drawing
open System.Threading

open MyWinForms.Utils
open MyWinForms.TopDialog

open MainWindow

open Mil82.View

let private updLabelTime (tb:Label) startTime = 
    tb.Text <- sprintf "%s - %s" ( DateTime.toString startTime) (TimeSpan.toString <| DateTime.Now - startTime  ) 

let private par'bar = TopBar.thread2

let text'scenary'name = 
    let x = new Label(  Parent = par'bar, Height = 35, 
                        TextAlign = ContentAlignment.MiddleLeft, 
                        Dock = DockStyle.Left, Visible = false,
                        Font = new Font("Consolas", 12.f) ) 

    x.TextChanged.Add <| fun _ ->
        let sz = TextRenderer.MeasureText( x.Text, x.Font, Size(Int32.MaxValue, x.Height) )
        x.Width <- sz.Width + 10

    x

let closing'bar = 
    TopmostBar( form, Visible = false, Width = 400, Font = new Font("Consolas", 12.f),
                TextForeColor = Some Color.Brown, Placement = RightBottom,
                ButtonAccept = None, ButtonCancel = None,
                Text = "Выполнение прервано! Выполняется подготовка данных...") 

let btnStop = 
    new Button(Parent = par'bar, Height = 40, Width = 40, Visible = false,
               ImageList = Widgets.Icons.instance.imageList1,
               FlatStyle = FlatStyle.Flat,
               Dock = DockStyle.Left, ImageKey = "close")

let performing'bar = TopmostBar(form, Visible = false, MinTextHeight = 100, Width = 400, 
                                Font = new Font("Consolas", 12.f))

let modal'message'bar = 
            TopmostBar(form, Visible = false, Width = 400, Font = new Font("Consolas", 12.f),
                       Placement = Center, ButtonAccept = Some "Продолжить", ButtonCancel = None )

module Delay = 
    
    
    [<AutoOpen>]
    module private P = 
        let private textHeight = (TextRenderer.MeasureText("X", performing'bar.Font)).Height
        let p = new Panel(Height = 50 + textHeight + 5, Left = 10)
                
        let progressBar = 
            new ProgressBar(Parent = p, Height = 15, Width = 315, Value = 0,  Minimum=0, Maximum = Int32.MaxValue)
        let btnSkip = new Button(Parent = p, Top = progressBar.Top, Left = 330, Height = 45, Width = 45,
                                        ImageList = Widgets.Icons.instance.imageList1, 
                                        FlatStyle = FlatStyle.Flat,
                                        ImageKey = "skip")
        let mutable text = ""
                
        let upd start'time get'time = p.PerformThreadSafeAction <| fun () ->
            let elepsed = DateTime.Now - start'time

            performing'bar.Text <- 
                sprintf "%s %s из %s" text (TimeSpan.toString elepsed) (TimeSpan.toString (get'time()))
            let value, maximum = int elepsed.TotalMilliseconds, int (get'time()).TotalMilliseconds
            if value < maximum then
                if value > progressBar.Maximum then
                    progressBar.Maximum <- Int32.MaxValue
                progressBar.Value <- int elepsed.TotalMilliseconds
                progressBar.Maximum <- int (get'time()).TotalMilliseconds
            

    let initialize =         
        
        btnSkip.Click.Add <| fun _ ->
            Mil82.PartyWorks.Delay.cancel()

        Mil82.PartyWorks.Delay.onStart.Value <- fun what get'time -> p.PerformThreadSafeAction <| fun () ->
            text <- what
            progressBar.Value <- 0                
            performing'bar.DoUpdate <| fun () ->
                p.Height <- btnSkip.Bottom + 10
                performing'bar.BottomControl <- Some ( p :> Control )

            upd DateTime.Now get'time

        Mil82.PartyWorks.Delay.onStop.Value <- fun () -> p.PerformThreadSafeAction <| fun () ->
            performing'bar.DoUpdate <| fun () ->                    
                performing'bar.BottomControl <- None

        Mil82.PartyWorks.Delay.onUpdate.Value <- upd
        fun () -> ()

let initialize = 
    Thread2.IsRunningChangedEvent.addHandler <| fun (_,isRunning) ->
        productsToolsLayer.Enabled <- not isRunning

    Delay.initialize()

    Thread2.add'keep'running <| function
        | _, false ->                 
            form.PerformThreadSafeAction <| fun () ->
                modal'message'bar.Visible <- false
        | _ -> ()

    Mil82.PartyWorks.ModalMessage.onShow.Value <- fun title level text ->            
        let t = modal'message'bar
        form.PerformThreadSafeAction <| fun () -> 
            t.Visible <- false
            t.Title <- title
            t.TextForeColor <- Some <| Logging.foreColor level
            t.Text <- text 
            t.Visible <- true

    Mil82.PartyWorks.ModalMessage.onClose.Value <- fun () ->            
        form.PerformThreadSafeAction <| fun () -> 
            modal'message'bar.Visible <- false

    Mil82.PartyWorks.ModalMessage.getIsVivisble.Value <- fun () ->
        modal'message'bar.Visible

    Thread2.show'performing'message.Value <- fun level text ->            
        form.PerformThreadSafeAction <| fun () -> performing'bar.DoUpdate <| fun () ->
            let text = if text.Length < 50 then text else text.Substring(0,47) + "..."
            performing'bar.Text <- text
            performing'bar.TextForeColor <- Some <| Logging.foreColor level

    Thread2.showScenaryReport.Value <- fun title level text ->
        let t = performing'bar
        form.PerformThreadSafeAction <| fun () -> t.DoUpdate <| fun () ->
            t.Placement <- RightBottom
            t.TopControl <- None
            t.BottomControl <- None
            t.Title <- title
            t.ButtonAccept <- Some "Закрыть"
            t.ButtonCancel <- None
            t.Text <- text
            t.TextForeColor <- Some <| Logging.foreColor level
    

    Thread2.IsRunningChangedEvent.addHandler <| fun (_,v) ->
        par'bar.PerformThreadSafeAction <| fun () ->
            text'scenary'name.Visible <- v
            if v then
                text'scenary'name.Text <- sprintf "Выполняется сценарий %A"  Thread2.scenary.Value.FullName

    Thread2.IsRunningChangedEvent.addHandler <| function
        | true,false -> form.PerformThreadSafeAction <| fun () ->
            closing'bar.Visible <- false        
        | _ -> ()
        
    btnStop.Click.Add <| fun _ ->
        Thread2.forceStop()
        Mil82.PartyWorks.Delay.cancel()
        btnStop.Visible <- false
        Logging.warn "выполнение сценария %A было прервано пользователем" Thread2.scenary.Value.FullName
        closing'bar.DoUpdate <| fun () ->
            closing'bar.Title <- Thread2.scenary.Value.Name
        
    Thread2.add'keep'running <| fun (_,keep'running) ->
        form.PerformThreadSafeAction <| fun () ->
            btnStop.Visible <- keep'running 

    btnStop.Click.Add <| fun _ ->        
        performing'bar.Visible <- false
    Thread2.add'operation'changed <| fun x ->
        form.PerformThreadSafeAction <| fun () ->   
            let x = 
                match x with
                | Some x -> x
                | None -> Thread2.scenary.Value
            performing'bar.Title <- sprintf "%s %s" x.RunInfo.Status x.FullName   
    Thread2.IsRunningChangedEvent.addHandler <| function
        | false,true -> 
            let t = performing'bar
            t.DoUpdate <| fun () ->                 
                t.Placement <- RightBottom
                t.BottomControl <- None
                t.ButtonAccept <- None
                t.ButtonCancel <- None
                t.Text <- ""
        | _ -> ()

    
    fun () -> ()