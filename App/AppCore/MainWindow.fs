﻿module MainWindow

open System
open System.Windows.Forms
open System.Drawing
open System.Windows.Forms.DataVisualization.Charting

open MyWinForms.Utils

[<AutoOpen>]
module private Helpers =

    type TextColumn = DataGridViewTextBoxColumn
    
    let tooltip = new ToolTip(AutoPopDelay = 5000, InitialDelay = 1000,  ReshowDelay = 500, ShowAlways = true)

let form =     
    let x = new Form(Font = new Font("Consolas", 12.f), WindowState = FormWindowState.Maximized )
    let path = IO.Path.Combine( IO.Path.ofExe, "icon.ico")
    try        
        let customIcon = new Icon( path )
        x.Icon <- customIcon
    with e ->
        Logging.error "fail to set icon.ico from %A : %A" path e
    x

let setTooltip<'a when 'a :> Control > (x:'a) text = 
    tooltip.SetToolTip(x, text)



let mainLayer = new Panel( Parent = form, Dock = DockStyle.Fill)

let rightTabContentPlaceholder,setActivePageTitle = 
    let par1 = new Panel(Parent = mainLayer, Dock = DockStyle.Fill)
    let rightTabPagePlaceholder = new Panel(Parent = par1, Dock = DockStyle.Fill)

    let p = new Panel(Dock = DockStyle.Top, Height = 30, Parent = par1)
    let _ = new Panel(Parent = p, Dock = DockStyle.Top, Height = 5)
    let x = new Label(Parent = p, Dock = DockStyle.Top, 
                        Height = 20, TextAlign = ContentAlignment.MiddleLeft)
    let _ = new Panel(Parent = p, Dock = DockStyle.Top, Height = 5)
    x.SetInfoStyle()
    rightTabPagePlaceholder,(fun s -> x.Text <- s )

let tabButtonsPlaceholder, leftBottomTabContentPlaceHolder = 
    let _ = new Panel(Parent = mainLayer, Dock = DockStyle.Left, Width = 3)
    let x = new Panel(Parent = mainLayer, Dock = DockStyle.Left, Width = 135)

    let left_bottom_TabContentPlaceHolder = new Panel(Parent = x, Dock = DockStyle.Fill)        
    
    
    let _ = new Panel(Parent = x, Dock = DockStyle.Top, Height = 30)
    let left_top_TabButtonsPlaceholder = new Panel(Parent = x, Dock = DockStyle.Top)
    

    let _ = new Panel(Parent = mainLayer, Dock = DockStyle.Left, Width = 3)
    left_top_TabButtonsPlaceholder, left_bottom_TabContentPlaceHolder

let bottomLayer = 
    let _ = new Panel(Parent = mainLayer, Dock = DockStyle.Bottom, Height = 3)
    let x = new Panel(Parent = mainLayer, Dock = DockStyle.Bottom, Height = 25)
    let _ = new Panel(Parent = mainLayer, Dock = DockStyle.Bottom, Height = 3)    
    x

let labelPerformingInfo = 
    new Label(Parent = bottomLayer, Dock = DockStyle.Fill, Text = "",
                TextAlign = ContentAlignment.MiddleLeft )

module HardwareInfo = 
    let private (~%%) x = MyWinForms.Components.LeftInfoBlock(bottomLayer, x)
    let oven = %% "Подогрев плат"
    let termo = %% "Термокамера"
    let peumo = %% "ПГС"

    let initialize = 
        [   oven;  termo; peumo 
        ] |> List.iter (fun x -> 
            x.hide() )
        fun() -> ()


type Tabsheet = 
    | TabsheetParty
    | TabsheetChart
    | TabsheetKefs
    | TabsheetScenary
    | TabsheetVars
    | TabsheetErrors
    member x.Title = Tabsheet.title x
    static member values = FSharpType.unionCasesList<Tabsheet>
    
    static member title = function
        | TabsheetParty ->   "Партия"
        | TabsheetChart ->   "График"
        | TabsheetKefs ->    "Коэф-ты"
        | TabsheetScenary -> "Сценарий"
        | TabsheetVars ->    "Данные"
        | TabsheetErrors ->  "Погрешность"   

    static member descr = function
        | TabsheetParty ->   "Партия настраиваемых приборов"
        | TabsheetChart ->   "Графики измеряемых параметров приборов партии"
        | TabsheetKefs ->    "Коэффициенты приборов партии"
        | TabsheetScenary -> "Сценарий настройки приборов партии"
        | TabsheetVars ->    "Данные приборов партии"
        | TabsheetErrors ->  "Измеренная погрешность концентрации приборов партии"   

module private TabPagesHelp =
    let content = 
        Tabsheet.values 
        |> List.map(fun x -> 
            let p1 = new Panel( Dock = DockStyle.Fill, Parent = rightTabContentPlaceholder, Visible = false, AutoScroll = true)
            let p2 = new Panel( Dock = DockStyle.Fill, Parent = leftBottomTabContentPlaceHolder, Visible = false, AutoScroll = true)
            x, (p1,p2))
        |> Map.ofList

type Tabsheet with
    member x.BottomTab = snd TabPagesHelp.content.[x]
    member x.RightTab = fst TabPagesHelp.content.[x]
    static member content x =
        TabPagesHelp.content.[x]
    member x.ShowContent() =
        Tabsheet.showContent x
    static member showContent tabPage =        
        Tabsheet.values 
        |> List.iter ( fun x -> 
            let v = x=tabPage
            x.BottomTab.Visible <- v
            x.RightTab.Visible <- v)

    
let loggingJournal = 
    new RichTextBox(Parent = TabsheetScenary.RightTab, BackColor = TabsheetScenary.RightTab.BackColor, 
                        Dock = DockStyle.Fill, ReadOnly = true)

module ScenaryColumn =
    let name = 
        let x = 
            new BrightIdeasSoftware.OLVColumn(Text = "Операция", MinimumWidth = 200, Width = 350, 
                                                    IsEditable = false,
                                                    WordWrap = true, Sortable = false)
        x

    let time = 
        let x = new BrightIdeasSoftware.OLVColumn(Text = "Задержка", MinimumWidth = 90, Sortable = false )
        x.CellEditUseWholeCell <- Nullable false
        x

    let status = new BrightIdeasSoftware.OLVColumn(Text = "Статус", MinimumWidth = 90, Sortable = false, IsEditable = false)


let treeListViewScenary = 
    let splt = new Splitter(Parent = TabsheetScenary.RightTab, Dock = DockStyle.Left, Width = 3, BackColor = Color.LightGray)
    
    let pan = new Panel (Parent = TabsheetScenary.RightTab, Dock = DockStyle.Left,
                            MinimumSize = Size(300,0), MaximumSize = Size(1000,0),
                            Width = AppConfig.config.View.ScnDetailTextSplitterDistance)
    let x = new BrightIdeasSoftware.TreeListView()
    x.Parent <- pan
    x.Dock <- DockStyle.Fill
    x.UseNotifyPropertyChanged <- true
    x.CellEditActivation <- BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
    let eddec = new BrightIdeasSoftware.EditingCellBorderDecoration ( UseLightbox = true )
    
    x.AddDecoration( eddec )
    

    form.FormClosing.Add <| fun _ ->
        AppConfig.config.View.ScnDetailTextSplitterDistance <- x.Width

    x.Columns.Clear()
    x.Columns.Add ScenaryColumn.name |> ignore
    x.Columns.Add ScenaryColumn.time |> ignore
    x.Columns.Add ScenaryColumn.status |> ignore

    x.HierarchicalCheckboxes <- true


    x

let gridProducts = 
    new DataGridView (                 
            AutoGenerateColumns = false, 
            Dock = DockStyle.Fill,
            BackgroundColor = TabsheetScenary.RightTab.BackColor,
            Name = "PartyDataGrid",
            ColumnHeadersHeight = 40, //DataSource = party.Products, 
            Parent = TabsheetParty.RightTab,
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
            RowHeadersWidth = 30,
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None,
            AllowUserToResizeRows = false,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,                                
            BorderStyle = BorderStyle.None  )

    

let productsToolsLayer = new Panel(Parent = TabsheetParty.BottomTab, Dock = DockStyle.Left, Width = 40 ) 

let gridKefs =  
    let x = 
        new DataGridView( Parent = TabsheetKefs.RightTab,  
                        AutoGenerateColumns = false, 
                        Dock = DockStyle.Fill,
                        BackgroundColor = form.BackColor,
                        Name = "KefsGrid",
                        ColumnHeadersHeight = 40, 
                        RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
                        RowHeadersWidth = 30,
                        AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None,
                        AllowUserToResizeRows = false,
                        AllowUserToAddRows = false,
                        AllowUserToDeleteRows = false,                                
                        BorderStyle = BorderStyle.None  )
    x.Columns.Add( new MyWinForms.GridViewCheckBoxColumn() ) |> ignore

    ["№"; "Коэф-т"] |> List.iter(fun s -> 
        x.Columns.Add( new TextColumn( ReadOnly = true, HeaderText = s ) ) |> ignore )
    
    Mil82.Coef.coefs |> List.iteri(fun n kef -> 
        x.Rows.Add() |> ignore
        let row = x.Rows.[x.Rows.Count-1]
        row.Tag <- kef
        row.Cells.[1].Value <- kef.Order 
        row.Cells.[2].Value <- kef.Description)    
    x

let getRowOfCoef  =
    let xs =
        gridKefs.Rows 
        |> Seq.cast<DataGridViewRow>
        |> Seq.map( fun row -> row.Tag :?> Mil82.Coef, row )
        |> Map.ofSeq
    fun coef -> xs.[coef]

let getCoefOfRow  =
    let xs =
        gridKefs.Rows 
        |> Seq.cast<DataGridViewRow>
        |> Seq.map( fun row -> row.GetHashCode(), row.Tag :?> Mil82.Coef )
        |> Map.ofSeq

    fun (row:DataGridViewRow) -> xs.[row.GetHashCode()]


module SelectedCoefsRows =

    let get() = 
        form.PerformThreadSafeAction <| fun () ->
            gridKefs.Rows 
            |> Seq.cast<DataGridViewRow>
            |> Seq.map(fun row ->
                let coef = getCoefOfRow row
                coef.Order,  
                    let x = row.Cells.[0].Value in
                    if x = null then false else
                    x :?> bool)
            |> Seq.filter snd
            |> Seq.map fst
            |> Set.ofSeq
            
    let set coefs =
        form.PerformThreadSafeAction <| fun () ->
            gridKefs.Rows 
            |> Seq.cast<DataGridViewRow>
            |> Seq.iter(fun row -> 
                row.Cells.[0].Value <- Set.contains (getCoefOfRow row).Order coefs
                )

    
let errorMessageBox title message = 
    Logging.error "%A, %s" title message
    form.PerformThreadSafeAction <| fun () ->
        MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Error ) 
        |> ignore

let onExeption (e:Exception) = 
    Logging.error "Исключение %A" e 
    form.PerformThreadSafeAction <| fun () ->
        MessageBox.Show( sprintf "%A" e ,"Исключение", MessageBoxButtons.OK, MessageBoxIcon.Error ) 
        |> ignore
    System.Environment.Exit(1)
    failwith ""

open AppConfig
open AppConfig.View

let initialize =
    let getAllGrids() = 
        form.enumControls
            (fun x -> 
                if x.GetType()=  typeof<DataGridView>  then                     
                    Some (x :?> DataGridView) 
                else None)
            id
    form.FormClosing.Add <| fun _ -> 
        config.View.Grids <-
            getAllGrids()
            |> Seq.map( fun g -> 
                g.Name,
                    {   ColWidths = [for c in g.Columns -> c.Width]
                        ColumnHeaderHeight = g.ColumnHeadersHeight } )     
            |> Map.ofSeq
        

    let rec h = EventHandler( fun _ _ -> 
        form.Activated.RemoveHandler h
        
        for g in getAllGrids() do 
            let dt = config.View.Grids.TryFind g.Name
            
            g.ColumnHeadersHeight <-
                match dt with
                | Some { ColumnHeaderHeight = h} -> h
                | _ -> g.ColumnHeadersHeight
                |> max (let sz = TextRenderer.MeasureText( "X", g.ColumnHeadersDefaultCellStyle.Font )
                        sz.Height + 7 )
            [for c in g.Columns -> c ]  |> List.iteri( fun n c -> 
                let w = 
                    match dt with            
                    | Some { ColWidths = dt } when n < dt.Length ->  dt.[n]
                    | _ -> 
                        let sz = TextRenderer.MeasureText( c.HeaderText, c.HeaderCell.Style.Font )
                        sz.Width + 10
                c.Width <- max 50 w ))

    form.Activated.AddHandler h
    HardwareInfo.initialize()
    Set.intersect
        (IntRanges.parseSet config.View.SelectedCoefs)
        (IntRanges.parseSet config.View.VisibleCoefs)
    |> Set.filter ( Mil82.Coef.tryGetByOrder >> Option.isSome )
    |> SelectedCoefsRows.set 
    fun () -> ()