module Mil82.View.Scenary

open System
open System.Windows.Forms
open System.Drawing
open System.ComponentModel

open MainWindow
open Mil82
open Mil82.ViewModel.Operations



[<AutoOpen>]
module private Helpers =

    type C = DataGridViewColumn
    type CheckBoxColumn = MyWinForms.GridViewCheckBoxColumn
    type TextColumn = DataGridViewTextBoxColumn
    let party = Mil82.AppContent.party
    let (~%%) x = x :> C
    let popupDialog = MyWinForms.PopupDialog.create
    type Dlg = MyWinForms.PopupDialog.Options

 
    type DelayContext with
        static member getWorks ctx =
            PartyWorks.allWorks
            |> List.choose( function 
                | Timed (op, ({DelayContext = EqualsTo ctx true } as d), _) -> Some (op,d)
                | _ -> None ) 

type DelayConfig() =
    let getDelay ctx =
        DelayContext.getWorks ctx
        |> Seq.tryHead
        |> Option.map( fun (_,d) -> d.Time )
        |> Option.withDefault (TimeSpan.FromMinutes 3.) 
        
    let setDelay ctx value = 
        if getDelay ctx <> value then            
            DelayContext.getWorks ctx
            |> List.iter( fun (i,_) -> 
                i.GetRunInfo().SetDelayTime value )
            
    [<DisplayName("Продувка")>]    
    [<Description("Длительность продувки газом, час:мин:с")>]
    [<TypeConverter(typeof<TimeSpanConverter>)>]
    member x.BlowDelay 
        with get() = getDelay BlowDelay
        and set value = setDelay BlowDelay value  

    [<DisplayName("Продувка воздухом")>]    
    [<Description("Длительность продувки воздухом, час:мин:с")>]
    [<TypeConverter(typeof<TimeSpanConverter>)>]
    member x.BlowAirDelay
        with get() = getDelay BlowAirDelay
        and set value = setDelay BlowAirDelay value  

    [<DisplayName("Техпрогон")>]    
    [<Description("Длительность техпрогона, час:мин:с")>]
    [<TypeConverter(typeof<TimeSpanConverter>)>]
    member x.TexprogonDelay
        with get() = getDelay TexprogonDelay
        and set value = setDelay TexprogonDelay value  

    [<DisplayName("Прогрев")>]    
    [<Description("Длительность прогрева термокамеры, час:мин:с")>]
    [<TypeConverter(typeof<TimeSpanConverter>)>]
    member x.WarmDelay
        with get() = getDelay WarmDelay
        and set value = setDelay WarmDelay value  

module private Popup =

    let clearLoggigng() =             
        fst <| popupDialog
            { Dlg.def() with 
                Dlg.Text = Some  "Пожалуйста, подтвердите необходимость очистки журнала выполнения сценария." 
                Dlg.ButtonAcceptText = "Очистить" 
                Dlg.Title = "Очистка журнала"
                Width = 300 }
            ( fun () -> Some () )
            ( fun () ->
                party.Journal <- Map.empty 
                treeListViewScenary.RebuildAll true )

    let delayTime() = 
        let d = DelayConfig()
        let g = new PropertyGrid(SelectedObject = d, Width = 400,
                                    Font = new Font("Consolas", 12.f),
                                    ToolbarVisible = false, Height = 500,
                                    PropertySort = PropertySort.Alphabetical)
        let popup = new MyWinForms.Popup(g)    
        popup


module private SelectedOperation = 

    let get() =
        let selectedItem = MainWindow.form.PerformThreadSafeAction ( fun () -> treeListViewScenary.SelectedItem)
        if selectedItem = null then None else
        match selectedItem.RowObject with
        | :? Operation as x -> Some x
        | _ -> None

    let showLoggigng() = 
        get()
        |> Option.iter(fun x -> 
            LoggingRichText.setLogging loggingJournal x.RunInfo.LoggingRecords )

    
let initialize =
    
    treeListViewScenary.CanExpandGetter <- fun x -> 
        match x with
        | :? Operation as x -> 
            match x with
            | Scenary _ -> true
            | _ -> false
        | _ -> false

    treeListViewScenary.ChildrenGetter <- fun x ->
        let xs = 
            match x with
            | :? Operation as x -> x.Children 
            | _ -> [] 
        xs :> Collections.IEnumerable
    
    treeListViewScenary.SelectionChanged.Add <| fun _ ->
        SelectedOperation.showLoggigng()
        
    ScenaryColumn.name.AspectGetter <- fun x -> 
        match x with
        | :? Operation as x -> box x.Name 
        | _ -> null

    ScenaryColumn.status.AspectGetter <- fun x -> 
        match x with
        | :? Operation as x -> box x.RunInfo.Status 
        | _ -> null

    ScenaryColumn.time.AspectGetter <- fun x -> 
        match x with
        | :? Operation as x -> box x.RunInfo.DelayTime
        | _ -> null

    // при изменении сценария изменить treeListViewScenary
    Thread2.scenary.AddChanged <| fun (_,x) -> 
        treeListViewScenary.SetObjects ([x] :> Collections.IEnumerable)
        treeListViewScenary.CheckedObjectsEnumerable <- ([x] :> Collections.IEnumerable)

        LoggingRichText.setLogging loggingJournal x.RunInfo.LoggingRecords
        treeListViewScenary.ExpandAll()

    Thread2.scenary.Set PartyWorks.mil82

    party.OnAddLogging.Add <| fun (operation, level,text) ->
        SelectedOperation.get()
        |> Option.iter( fun op ->             
            let xs = Operation.tree op
            if xs |> List.exists( fun o -> o.FullName = operation) then
                loggingJournal.PerformThreadSafeAction <| fun () -> 
                    LoggingRichText.addRecord loggingJournal level text )

    Thread2.PerfomOperationEvent.Add <| function
        | operation,true ->
            match SelectedOperation.get() with            
            | Some op when op.FullName = operation.FullName -> 
                loggingJournal.PerformThreadSafeAction <| fun () ->
                    loggingJournal.Text <- ""                   
            | _ -> ()
        | _ -> ()
    
    treeListViewScenary.FormatRow.Add(fun e -> 
        let x = e.Model :?> Operation
        let apply a b c d =
            e.Item.BackColor <- a
            e.Item.ForeColor <- b
            e.Item.SelectedBackColor <- Nullable c
            e.Item.SelectedForeColor <- Nullable d
        if x.RunInfo.WasPerformed then
            apply Color.Bisque Color.Black SystemColors.HighlightText SystemColors.Highlight
        if x.RunInfo.HasErrors then
            apply Color.LightGray Color.Red Color.MidnightBlue Color.Yellow
        if x.RunInfo.IsPerforming then
            apply Color.Aquamarine Color.Black SystemColors.HighlightText SystemColors.Highlight)

    
    let cellEditStarting (e:BrightIdeasSoftware.CellEditEventArgs) =
        match e.RowObject :?> Operation with
        | Timed _ as x ->
            let mutable rect = e.Control.Bounds
            let offset = 
                match x.RunInfo.Level with
                | 1 -> -30
                | 2 -> -40
                | 3 -> -65
                | n -> -20 * n
            rect.Offset(offset,0)
            rect.Width <- max 100 rect.Width
            e.Control.Bounds <- rect
        | _ -> e.Cancel <- true
    treeListViewScenary.CellEditStarting.Add cellEditStarting

    let сellEditFinishing (e:BrightIdeasSoftware.CellEditEventArgs) =
        match e.RowObject :?> Operation with
        | Timed _ as x ->
            x.RunInfo.DelayTime <- string e.NewValue
            treeListViewScenary.RefreshItem(e.ListViewItem)
        | _ -> ()
    treeListViewScenary.CellEditFinishing.Add сellEditFinishing



    let _ = new Panel( Parent = TabsheetScenary.BottomTab, Dock = DockStyle.Top, Height = 3)
    let b = new Button( Parent = TabsheetScenary.BottomTab, Dock = DockStyle.Top, 
                        Text = "Очистить журнал", Height = 45, FlatStyle = FlatStyle.Flat,
                        TextAlign = ContentAlignment.MiddleLeft)
    b.Click.AddHandler(fun _ _ ->
        Popup.clearLoggigng().Show b )

    let _ = new Panel( Parent = TabsheetScenary.BottomTab, Dock = DockStyle.Top, Height = 3)
    let b = new Button( Parent = TabsheetScenary.BottomTab, Dock = DockStyle.Top, 
                        Text = "Длит. задержек", Height = 45, FlatStyle = FlatStyle.Flat,
                        TextAlign = ContentAlignment.MiddleLeft)
    b.Click.AddHandler(fun _ _ ->
        Popup.delayTime().Show b )

    fun () -> ()