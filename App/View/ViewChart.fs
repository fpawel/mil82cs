module Mil82.View.ChartDataBindings

open System
open System.Windows.Forms
open System.Drawing
open System.Text.RegularExpressions

open MainWindow

[<AutoOpen>]
module private Helpers =

    let invertChildrenOrder<'a when 'a :> Control> (c:'a) =
        let xs = 
            [ for x in c.Controls -> x ]
            |> List.rev
        c.Controls.Clear()
        xs |> List.iter c.Controls.Add 

    let addctrl1<'a,'b when 'a :> Control and 'b :> Control> (x:'a) (y:'b) f =
        f y
        x.Controls.Add(y)

    let addctrl x y  =
        addctrl1 x y (fun _ -> ())

    let addtop x y = addctrl1 x y <| fun _ -> 
        y.Dock <- DockStyle.Top

    let addright x y = addctrl1 x y <| fun _ -> 
        y.Dock <- DockStyle.Right

    type Button1(pffsetLeft, pffsetTop, text) =
        inherit Button()

        override x.OnPaint(e) =
            base.OnPaint(e)
            use p = new Pen(x.ForeColor)
            let pt = PointF(float32 pffsetLeft, float32 pffsetTop)
            e.Graphics.DrawString(text, x.Font, p.Brush, pt )

    let binding<'a when 'a : equality> (t:TextBox) textToValue valueToText eq subj prop scalingMeth =    
        
        let p = subj.GetType().GetProperty prop

        let getSubjValue() =
            p.GetValue( subj, null ) :?> 'a
        
        

        let ep = new ErrorProvider()
        ep.SetIconAlignment (t, ErrorIconAlignment.TopRight)
        ep.SetIconPadding (t, 2)
        ep.BlinkStyle <- ErrorBlinkStyle.NeverBlink

        let rec updCtrl() = 
            let value = getSubjValue()
            if value <> textToValue t.Text then
                t.TextChanged.RemoveHandler onTextChanged
                t.Text <- valueToText value
                t.TextChanged.AddHandler onTextChanged

        and onTextChanged = EventHandler(fun _ _ ->  
            
            textToValue t.Text |> updSubj              
            let error, color = 
                if not <| eq (getSubjValue()) (textToValue t.Text) then "не правильный ввод", Color.Red
                else "", Color.Black
            ep.SetError(t, error) 
            t.ForeColor <- color )
        
        and updSubj (value : 'a) =
            Runtime.PropertyChanged.removeAction subj onPropChanged
            p.SetValue( subj, value, null) 
            Runtime.PropertyChanged.addHandler subj onPropChanged

        and onPropChanged = Runtime.PropertyChanged.addAction subj <| fun _ e ->
            if not t.Focused then updCtrl() 
            
            
        t.TextChanged.AddHandler onTextChanged
        
        t.LostFocus.Add(fun _ -> 
            updCtrl() )

        t.MouseWheel.Add(fun e -> 
            let meth = subj.GetType().GetMethod(scalingMeth)
            meth.Invoke(subj, [| box e.Delta |])
            |> ignore )

        updSubj, updCtrl, getSubjValue
            
    let updown2<'a when 'a :> Control> (p:'a)=
        let btnInc text = 
            new Button( Text = text, Parent = p, Dock = DockStyle.Right, 
                            Width = 15, FlatStyle = FlatStyle.Flat)   
        let sep() = new Panel( Parent = p, Dock = DockStyle.Right, Width = 1)
        let _,b1,_,b2,_,b3 = sep(), btnInc "<", sep(), btnInc ">", sep(), btnInc "x"
        b1,b2,b3

    let incTextboxDigit (t:TextBox) inc =
        let s = t.Text
        let nsel = t.SelectionStart        
        let n = 
            if nsel >= s.Length then nsel-1 
            else nsel
        if n >= 0 && n <= s.Length && Char.IsDigit s.[n] then       
            String.tryParseDecimal t.Text |> Option.iter( fun value ->              
                let d = 
                    let digit = Int32.Parse (String(s.[n],1) )
                    let inc1 = if digit = 9 then -1 else 1
                    let v2 = 
                        s.Remove(n,1).Insert(n, sprintf "%d" (digit + inc1) )
                        |> String.tryParseDecimal 
                        |> Option.get
                    Math.Abs(value - v2)            
                t.Text <- sprintf "%M" <| value + (if inc then d else -d)
                t.SelectionStart <- n
                t.SelectionLength <- 1 )
        t.Focus() |> ignore
    
    let incTextboxNumber (t:TextBox) inc =
        let s = t.Text
        let nsel = t.SelectionStart

        let xs1 = 
            seq{ for n = nsel - 1 downto 0 do yield n }
            |> Seq.takeWhile (fun n -> Char.IsDigit s.[n])
            |> Seq.sort

        let xs2 = 
            seq{ for n = nsel to s.Length-1 do yield n }
            |> Seq.takeWhile (fun n -> Char.IsDigit s.[n])
        let xs = Seq.append xs1 xs2

        let n1,n2 = 
            if Seq.isEmpty xs then 0,0 else Seq.head xs, Seq.last xs + 1
            
        let b,v = s.Substring(n1,n2-n1) |>  Int32.TryParse 
        if b then
            let s1 = s.Remove(n1,n2-n1).Insert(n1, sprintf "%d" (v + (if inc then 1 else -1) ) )
            let b,_ = DateTime.TryParse s1
            if b then                 
                t.Text <- s1
                t.SelectionStart <- n1
                t.SelectionLength <- n2 - n1
        t.Focus() |> ignore

    

    let asvm = Mil82.Chart.axisScalingViewModel
    
    let floatEditBox prop scalingMeth =    
        
        let pn = new Panel(Dock = DockStyle.Top, Height = 25)
        let t = new TextBox(Parent = pn, Dock = DockStyle.Fill)
        let b1,b2,b3 = updown2 pn

        b2.Click.Add(fun _ -> incTextboxDigit t true )
        b1.Click.Add(fun _ -> incTextboxDigit t false )
        
        let textToValue = String.tryParseDecimal  >> Option.map float
        let valueToText (value : float option) =            
                value
                |> Option.map string
                |> Option.getWith ""
        
        let updSubj, updCtrl, getSubjValue = binding t textToValue valueToText (=) asvm prop scalingMeth
        b3.Click.Add(fun _ -> 
            updSubj None )
        pn

    let dateTimeEditBox prop scalingMeth =    
        let pn = new Panel(Height = 25)   

        addright pn <| new Panel(Width = 1)   
        let t = new TextBox(Parent = pn, Dock = DockStyle.Fill)   
        addright pn <| new Panel(Width = 1)   
        
        
        let textToValue text = 
            let b,value = DateTime.TryParse text
            if b then Some value else None
        let valueToText (value : DateTime option) =            
            value
            |> Option.map (fun x -> x.ToString "dd.MM.yy HH:mm:ss")
            |> Option.getWith ""
        let updSubj, updCtrl, getSubjValue = 
            binding t textToValue valueToText (fun x y -> DateTime.Equals(x,y) ) asvm prop scalingMeth
        
        let b1,b2,b3 = updown2 pn
        b2.Click.Add(fun _ -> incTextboxNumber t true )
        b1.Click.Add(fun _ -> incTextboxNumber t false )        
        b3.Click.Add(fun _ -> 
            updSubj None )
        pn

    let popupAxis width height ctrMin ctrMax = 
        let p1 = new Panel (Width = width, Height = height, Font = MainWindow.form.Font, 
                            BorderStyle = BorderStyle.FixedSingle)    
        

        let p = new Panel ( Parent = p1, Dock = DockStyle.Fill)       
         
        let separator() = addtop p <| new Panel( Height = 3) 
        separator()

        addtop p <| new Label( Text = "Начало шкалы:") 
        separator()
        addtop p ctrMin
        separator()

        addtop p <| new Label( Text = "Конец шкалы:") 
        separator()
        addtop p ctrMax
        separator()

        invertChildrenOrder p

        addctrl p1 (new Panel(Width = 5, Dock = DockStyle.Left ))
        addctrl p1 (new Panel(Width = 5, Dock = DockStyle.Right ))

        p1

    
    let btnAxis text dock popupWidth popupHeight ctrMin ctrMax = 
        let b = new Button( Text = text, Width = 59, Dock = dock, FlatStyle = FlatStyle.Flat)
        let popupP = popupAxis popupWidth popupHeight ctrMin ctrMax 
        b.Click.Add( fun _ ->             
            let popup = new MyWinForms.Popup(popupP :> Control)    
            popup.Show(b) )
        b

    // Прокрутка оси X при нажатии левой кнопки мыши
    module DragAxisXOnMouseLeft =
        let mutable private startDragPt : Point option = None
        let initialize =
            let chart = Mil82.Chart.chart
            let ar = chart.ChartAreas.[0]
            chart.MouseDown.Add ( fun evt ->
                startDragPt <- Some evt.Location )
            chart.MouseUp.Add ( fun evt ->
                startDragPt <- None )
            chart.MouseMove.Add( fun evt ->
                if evt.Button <> MouseButtons.Right then () else
                startDragPt |> Option.iter(fun startDragPt' -> 
                    let kx =  float (evt.X - startDragPt'.X)  / float chart.Width
                    let ax = ar.AxisX
                    let sv = ax.ScaleView
                    let lenx = sv.ViewMaximum - sv.ViewMinimum
                    let d = lenx * kx
                    sv.Position <- sv.Position - d

                    let ky = float (evt.Y - startDragPt'.Y) / float chart.Height
                    let ay = ar.AxisY
                    let sv = ay.ScaleView
                    let leny = sv.ViewMaximum - sv.ViewMinimum
                    let d = leny * ky
                    sv.Position <- sv.Position + d 
                    startDragPt <- Some evt.Location) )
            fun () -> ()

    module OrigZoomStore =
        let mutable oldSelStart = -1.
        let mutable oldSelEnd = -1.
        let button = new Button( Text = "Исх. размер", Width = 120, FlatStyle = FlatStyle.Flat,
                                 Visible = false)
        let initialize = 
            let chart = Mil82.Chart.chart
            let ar = chart.ChartAreas.[0]
            chart.AxisViewChanged.Add(fun evt -> 
                let newSelStart = ar.CursorX.SelectionStart
                let newSelEnd = ar.CursorX.SelectionEnd
                if abs (oldSelEnd - newSelEnd) > 0. then
                    oldSelStart <- newSelStart
                    oldSelEnd <- newSelEnd
                    button.Visible <- true )
            button.Click.Add(fun _ ->
                ar.AxisX.ScaleView.ZoomReset(Int32.MaxValue);
                ar.AxisY.ScaleView.ZoomReset(Int32.MaxValue);
                button.Visible <- false )
            fun () -> ()
    

[<AutoOpen>]
module private Helpers1 =
    open System.Windows.Forms.DataVisualization.Charting

    let initChart1 (chart:Chart) =
        let ar = chart.ChartAreas.[0]        
        let c = ar.CursorX
        c.IntervalType <- DateTimeIntervalType.Seconds
        c.IsUserSelectionEnabled <- true
        let c = ar.CursorY
        c.IntervalType <- DateTimeIntervalType.Auto
        c.Interval <- 0.001
        c.IsUserSelectionEnabled <- true

let initialize =
    
    asvm.InitializeAxisTimer()    
    let p = new Panel( Height = 25)
    let separator() = addtop TabsheetChart.BottomTab <| new Panel( Height = 3)
    separator()    
    addtop TabsheetChart.BottomTab p 
    separator()
    btnAxis 
        "X" DockStyle.Left 230 130 
        (dateTimeEditBox "MinDateTime" "scaleMinX")
        (dateTimeEditBox "MaxDateTime" "scaleMaxX")
    |> addctrl p
    btnAxis 
        "Y" DockStyle.Right 200 130 
        (floatEditBox "MinY" "scaleMinY")
        (floatEditBox "MaxY" "scaleMaxY")
    |> addctrl p
    addtop TabsheetChart.BottomTab p 
    separator()
    let b = new Button( Text = "Очистить", Width = 120, FlatStyle = FlatStyle.Flat)    
    addtop TabsheetChart.BottomTab b 
    separator()    

    let chart = Mil82.Chart.chart
    
    b.Click.Add( fun _ ->
        MyWinForms.ChartUtils.erraseVisiblePoints chart )

    addtop TabsheetChart.BottomTab OrigZoomStore.button 
    separator()

    invertChildrenOrder TabsheetChart.BottomTab

    DragAxisXOnMouseLeft.initialize()
    OrigZoomStore.initialize()    
    initChart1 chart

    fun () -> () 