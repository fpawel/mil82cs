module Mil82.View.Products

open System
open System.Windows.Forms
open System.Drawing
open System.Collections.Generic

open MainWindow
open Mil82

[<AutoOpen>]
module private Helpers =

    type C = DataGridViewColumn
    type CheckBoxColumn = MyWinForms.GridViewCheckBoxColumn
    type TextColumn = DataGridViewTextBoxColumn
    let party = Mil82.AppContent.party
    let (~%%) x = x :> C

module Columns =

    let interrogate =    
        [   yield %% new TextColumn(DataPropertyName = "Connection", HeaderText = "Связь", Width = 80)
            for physvar in PhysVar.values do
                yield %% new TextColumn
                    (   DataPropertyName = PhysVar.name physvar, 
                        HeaderText = PhysVar.what physvar,
                        ReadOnly = true) ]

let updateCoefsGridRowsVisibility _ =   
    let visCoefs = IntRanges.parseList AppConfig.config.View.VisibleCoefs |> IntRanges.listToSet
    gridKefs.Rows 
    |> Seq.cast<DataGridViewRow>
    |> Seq.iteri(fun n row -> 
        row.Visible <- visCoefs.Contains n )

let initialize = 
    gridProducts.DataSource <- party.Products
    
    gridKefs.CellParsing.Add <| fun e ->
        if e.ColumnIndex < 3 then () else
        let col = gridKefs.Columns.[e.ColumnIndex]
        let row = gridKefs.Rows.[e.RowIndex]
        let cell = row.Cells.[e.ColumnIndex]
        let kef = Mil82.Coef.coefs.[e.RowIndex]
        let product = col.Tag :?> Mil82.ViewModel.Product1
        let value = if e.Value=null then "" else e.Value.ToString()
        product.setKefUi kef value

    let textboxSelectedCoefs = new RichTextBox( Parent = TabsheetKefs.BottomTab, Dock = DockStyle.Fill,
                                                BorderStyle = BorderStyle.None,
                                                Text = AppConfig.config.View.SelectedCoefs )

    let addsep n = 
        TabsheetKefs.BottomTab.Controls.Add
            ( new Panel(Dock = DockStyle.Top, Height = n) )

    addsep 3    
    let btnSelectCoef = new Button( Parent = TabsheetKefs.BottomTab, Dock = DockStyle.Top, 
                                    Text = "Выбрать", Height = 30, FlatStyle = FlatStyle.Flat,
                                    TextAlign = ContentAlignment.MiddleLeft)
    

    addsep 3    
    let btnUnselectCoef = new Button( Parent = TabsheetKefs.BottomTab, Dock = DockStyle.Top, 
                                      Text = "Снять выбор", Height = 30, FlatStyle = FlatStyle.Flat,
                                      TextAlign = ContentAlignment.MiddleLeft)
    
    addsep 15
    let b = new Button( Parent = TabsheetKefs.BottomTab, Dock = DockStyle.Top, 
                        Text = "Записать", Height = 30, FlatStyle = FlatStyle.Flat,
                        TextAlign = ContentAlignment.MiddleLeft)
    b.Click.AddHandler(fun _ _ ->
        PartyWorks.Kefs.write() )

    Thread2.IsRunningChangedEvent.addHandler <| fun (_,isRunning) ->
        b.Enabled <- not isRunning

    addsep 3
    let b = new Button( Parent = TabsheetKefs.BottomTab, Dock = DockStyle.Top, 
                        Text = "Считать", Height = 30, FlatStyle = FlatStyle.Flat,
                        TextAlign = ContentAlignment.MiddleLeft)
    b.Click.AddHandler(fun _ _ ->
        PartyWorks.Kefs.read() )
    Thread2.IsRunningChangedEvent.addHandler <| fun (_,isRunning) ->
        b.Enabled <- not isRunning

    addsep 15   

    let getSelectedCoefsValue() =  
        let x = AppConfig.config.View      
        Set.intersect 
            (MainWindow.SelectedCoefsRows.get())
            (IntRanges.parseSet x.VisibleCoefs)
        |> Set.filter (Coef.tryGetByOrder >> Option.isSome )
        |> IntRanges.setToList
        |> Seq.toStr " " (fun (n,m) -> 
            if n=m then n.ToString() else sprintf "%d-%d" n m )


    let rec textChangedHandler = EventHandler(fun _ _ -> 
        gridKefs.CellValueChanged.RemoveHandler cellValueChanged
        let x = AppConfig.config.View
        let xs =
            Set.intersect 
                (IntRanges.parseSet textboxSelectedCoefs.Text )
                (IntRanges.parseSet x.VisibleCoefs)
            |> Set.filter (Coef.tryGetByOrder >> Option.isSome )
        MainWindow.SelectedCoefsRows.set xs
        x.SelectedCoefs <- IntRanges.formatSet xs
        gridKefs.CellValueChanged.AddHandler cellValueChanged )

    
    and cellValueChanged = DataGridViewCellEventHandler(fun _ evt -> 
        if evt.ColumnIndex <> 0 then () else
        textboxSelectedCoefs.TextChanged.RemoveHandler textChangedHandler
        textboxSelectedCoefs.Text <- getSelectedCoefsValue()
        textboxSelectedCoefs.TextChanged.AddHandler textChangedHandler )

    gridKefs.CellValueChanged.AddHandler cellValueChanged
    textboxSelectedCoefs.TextChanged.AddHandler textChangedHandler
    textboxSelectedCoefs.Leave.AddHandler (fun _ _ -> 
        textboxSelectedCoefs.TextChanged.RemoveHandler textChangedHandler
        textboxSelectedCoefs.Text <- getSelectedCoefsValue()
        textboxSelectedCoefs.TextChanged.AddHandler textChangedHandler
        )

    let f x =   
        gridKefs.SelectedCells
        |> Seq.cast<DataGridViewCell>
        |> Seq.iter(fun cell -> 
            gridKefs.Rows.[cell.RowIndex].Cells.[0].Value <- x )

    btnSelectCoef.Click.AddHandler(fun _ _ ->        
        f true ) 

    btnUnselectCoef.Click.AddHandler(fun _ _ ->        
        f false ) 

    updateCoefsGridRowsVisibility()

    let col = gridKefs.Columns.[0] :?> MyWinForms.GridViewCheckBoxColumn
    let cell = col.HeaderCell :?> MyWinForms.DatagridViewCheckBoxHeaderCell
    
    cell.add_BeforCheckBoxChanged( MyWinForms.CheckBoxClickedHandler(fun index _ -> 
        gridKefs.CellValueChanged.RemoveHandler cellValueChanged
        textboxSelectedCoefs.TextChanged.RemoveHandler textChangedHandler  ) )

    cell.add_AfterCheckBoxChanged( MyWinForms.CheckBoxClickedHandler(fun index _ -> 
        textboxSelectedCoefs.Text <- getSelectedCoefsValue()

        gridKefs.CellValueChanged.AddHandler cellValueChanged
        textboxSelectedCoefs.TextChanged.AddHandler textChangedHandler ) )
    
    fun () -> ()