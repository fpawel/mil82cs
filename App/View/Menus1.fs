module Mil82.View.Menus1

open System
open System.Windows.Forms
open System.Drawing
open System.Collections.Generic
open System.ComponentModel
open System.ComponentModel.DataAnnotations

open MyWinForms.TopDialog
open MainWindow
open Mil82.ViewModel.Operations
open Thread2
open Mil82
open Mil82.PartyWorks
open Mil82.View

[<AutoOpen>]
module private Helpers =
    type P = Mil82.ViewModel.Product     
    let party = AppContent.party
    let popupDialog = MyWinForms.PopupDialog.create
    type Dlg = MyWinForms.PopupDialog.Options
    let none _ = None
    let form = MainWindow.form


    let getSelectedProducts() = 
        seq{ for x in gridProducts.SelectedCells -> x.RowIndex, x.OwningRow }
        |> Map.ofSeq
        |> Map.toList
        |> List.map( fun (_,x) -> x.DataBoundItem :?> P )

    let simpleMenu = MyWinForms.Utils.buttonsMenu (new Font("Consolas", 12.f)) ( Some 300 ) 

[<TypeConverter(typeof<ExpandableObjectConverter>)>]
type PartyInfo = 
    {   [<DisplayName("Наименование")>]    
        [<Description("Наименование партии")>]
        mutable Name : string

        [<DisplayName("Исполнение")>]    
        [<Description("Исполнение приборов партии")>]
        [<TypeConverter (typeof<Mil82.ViewModel.ProductTypesConverter>) >]
        mutable ProductType : string

        [<DisplayName("ПГС1")>]    
        [<Description("Концентрация ПГС1, начало шкалы")>]
        mutable Pgs1  : decimal
        [<DisplayName("ПГС2")>]    
        [<Description("Концентрация ПГС3, середина шкалы")>]
        mutable Pgs2  : decimal
        [<DisplayName("ПГС2")>]    
        [<Description("Концентрация ПГС4, конец шкалы")>]
        mutable Pgs3  : decimal 

        [<DisplayName("Количество приборов")>]    
        [<Description("Количество приборов в партии")>]
        mutable Count  : byte  }

module Parties = 
        
    type Node = 
        | Year of int 
        | Month of int * int
        | Day of int * int * int
        | Party of Party.Head

    let private setPartyNodeStyle(node:TreeNode) = 
        node.ForeColor <- Color.Blue
        node.BackColor <- Color.LightGray
        //node.NodeFont <- new Font( "Segue UI", 12.f, FontStyle.Bold )
    
    let createControl() = 
        let nodes = ResizeArray<Node * TreeNode>()
        let mutable selectedNode : TreeNode = null            
        let xs = 
            AppContent.getParties() |> Seq.map( fun (year,xs) -> 
                let xyear = TreeNode(sprintf "%d" year  )
                nodes.Add(Year year, xyear)

                xs |> Seq.iter( fun (month,xs) -> 
                    let xmonth = TreeNode(monthByNumber month  )
                    nodes.Add(Month (year,month), xmonth)
                    xyear.Nodes.Add xmonth |> ignore
                    xs |> Seq.iter( fun (day,xs) ->                         
                        let xday = TreeNode(sprintf "%d" day  )
                        nodes.Add(Day (year,month,day), xday)
                        xmonth.Nodes.Add xday |> ignore
                        xs |> Seq.iter( fun b -> 
                            let serials = Seq.toStr ", " (sprintf "%d") b.Serials
                            let node = TreeNode(sprintf "%s, %A, %s" b.ProductType.What b.Name serials)
                            if b.Id = (fst party.Party).Id  then
                                selectedNode <- node
                                setPartyNodeStyle node
                                setPartyNodeStyle xday
                                setPartyNodeStyle xmonth
                                setPartyNodeStyle xyear
                            nodes.Add(Party b, node)
                            xday.Nodes.Add node |> ignore ) ) ) 
                xyear )
            |> Seq.toArray
        let c= new TreeView(CheckBoxes = false, Font = new Font( "Segue UI", 12.f ))
        c.SelectedNode <- selectedNode    
        c.Nodes.AddRange xs
        c.SelectedNode <- selectedNode      
        c, nodes

let addProducts (b:Button) = 
    let tb = new TextBox(Width = 200, Dock = DockStyle.Left, Text = "1")
    let getValue() = 
        let b,v = Int32.TryParse tb.Text
        if b  && v > 0 && v<21 then
            Some v
        else
            None
    tb.MouseWheel.Add <| fun e ->
        let b,v = Int32.TryParse tb.Text
        if b then
            let d = if e.Delta>0 then 1 else (-1)
            if v<>0 || d>0 then
                tb.Text <- sprintf "%d" <| v + d  
    let errorProvider = 
        new ErrorProvider( BlinkStyle = ErrorBlinkStyle.NeverBlink )
    errorProvider.SetIconAlignment (tb, ErrorIconAlignment.MiddleRight)
    errorProvider.SetIconPadding (tb, 2)
    tb.Validating.Add <| fun e ->
        match getValue() with
        | Some _ -> errorProvider.Clear()                
        | None ->
            errorProvider.SetError(tb, sprintf "Введено не пралильное значение количества добавляемых в партию приборов %A. Пожалуйста, введите число от 1 до 20" tb.Text )
            e.Cancel <- true

    let dialog,validate  =             
        popupDialog
            { Dlg.def() with 
                Dlg.Text = Some "Пожалуйста, введите количество добавляемых в партию приборов от 1 до 20" 
                Dlg.ButtonAcceptText = "Добавить" 
                Dlg.Title = "Добавить приборы"
                Width = 300
                Dlg.Content = 
                    let p = new Panel(Height = tb.Height + 10)
                    p.Controls.Add(tb)
                    p }
            getValue 
            ( fun value -> 
                iterate value party.AddNewProduct )
    tb.TextChanged.Add <| fun _ -> validate()
    dialog.Show(b)

let deleteProducts (b:Button) =
    let delete() =  
        getSelectedProducts()
        |> List.iter (fun p -> 
            party.DeleteProduct p
            Chart.removeProductSeries p.Product.Id |> ignore )
    let dialog, _  =            
        popupDialog
            { Dlg.def() with 
                Dlg.Text = 
                    getSelectedProducts() 
                    |> Seq.toStr ", " (fun x -> sprintf "#%d №%d" x.Addr x.Serial)
                    |> sprintf "Пожалуйста, подтвердите необходимость удаления приборов %s" 
                    |> Some
                Dlg.ButtonAcceptText = "Удалить" 
                Dlg.Title = "Удалить приборы" }
            ( fun () -> Some () )
            delete
    dialog.Show(b)

let createNewParty (b:Button) = 
    let d = 
        {   Name = "Партия СТМ-30"
            ProductType = Mil82.A00.What
            Pgs1 = 0m
            Pgs2 = 49m
            Pgs3 = 98m 
            Count = 1uy}
    let g = new PropertyGrid(SelectedObject = d, 
                                ToolbarVisible = false, Height = 250,
                                PropertySort = PropertySort.Alphabetical)
    let popup1,_ = 
        popupDialog
            { Dlg.def() with 
                Text = None 
                Content = g
                ButtonAcceptText = "Создать новую партию"
                Title = "Создать новую партию"
                Width = 400 }
            ( fun () -> Some () )
            ( fun () ->
                let prodType = 
                    ProductType.values 
                    |> List.tryFind ( ProductType.what >> (=) d.ProductType)
                    |> Option.getWith A00
                let b = Alchemy.createNewParty1 (d.Name, prodType, d.Pgs1, d.Pgs2, d.Pgs3, d.Count)
                party.Party <- b
                AppContent.save()
                TabPages.TabChart.update()
                Scenary.updateGridViewBinding() )
    popup1.Closing.Add <| fun e ->
        if MyWinForms.Utils.isPropGridEditing g then
            e.Cancel <- true
    popup1.Show(b)

let openParty (button : Button) = 
    let c, nodes = Parties.createControl()
    c.Height <- 600
    let nodes1 = nodes |> Seq.map( fun (x,y) -> y.GetHashCode(),x) |> Map.ofSeq
    let getBatch() = 
        let x = c.SelectedNode
        if x=null then None else
        match nodes1.[x.GetHashCode()] with
        | Parties.Party x -> Some x
        | _ -> None

    let dialog,validate  = 
        popupDialog
            { Dlg.def() with 
                Dlg.ButtonAcceptText = "Открыть" 
                Width = 450
                Dlg.Content = c 
                Dlg.Title = "Открыть партию"}
            getBatch
            ( fun b ->
                match AppContent.load b.Id with
                | None -> 
                    Scenary.updateGridViewBinding()
                    TabPages.TabChart.update()
                | Some error -> 
                    MessageBox.Show(sprintf "Не удалось открыть данные партии %A, %A. %s" 
                                        b.Date b.ProductType error, 
                                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error )
                    |> ignore )
    c.AfterSelect.Add <| fun _ -> validate()
    
    dialog.Show(button)
    c.Select()
    c.Focus() |> ignore


let popupNumberDialog<'a>     
    prompt title tryParse work 
    (btn : Button) 
    (parentPopup : MyWinForms.Popup) =
    let tb = new TextBox(Width = 290, Text = (party.NewValidAddr() |> string) )                    
    let dialog,validate  = 
        popupDialog 
            { Dlg.def() with 
                Text = Some prompt
                ButtonAcceptText = "Применить" 
                Title = title
                Width = 300
                Content = tb }
            ( fun () -> 
                tryParse tb.Text)
            ( fun (value : 'a) ->  
                parentPopup.Hide()
                work value ) 
    tb.TextChanged.Add <| fun _ -> validate()                        
    dialog.Show btn

let modbusToolsPopup = 
    let setAddr = 
        popupNumberDialog 
            "Ведите адрес MODBUS от 1 до 127" 
            "Установка адреса MODBUS"
            ( fun s ->
                let b,v = Byte.TryParse s
                if b  && v > 0uy && v<128uy then Some v else None)
            (decimal >> setAddr)
    
    [   yield "Установка адреса", setAddr
        yield!
            Command.values
            |> List.filter( (<>) ResetAddy ) 
            |> List.map( fun cmd -> 
                (sprintf "MDBUS: %s" cmd.What), 
                    popupNumberDialog 
                        (sprintf "Введите значение аргумента команды %A" cmd.What)
                        cmd.What
                        String.tryParseDecimal
                        (fun value -> sendCommand (cmd,value) ) ) ]
    |> simpleMenu
    
let pneumoToolsPopup =         
    [   yield! ScalePt.values |> List.map ( fun gas -> 
            ScalePt.what gas, fun _ _  -> PartyWorks.Pneumoblock.switch gas )
        yield "Выкл.", fun _ _ -> PartyWorks.Pneumoblock.close()  ]
    |> simpleMenu

let termoToolsPopup = 

    let setpoint = 
        popupNumberDialog 
            "Введите значение уставки термокамеры"
            "Задать уставку термокамеры"
            String.tryParseDecimal
            PartyWorks.TermoChamber.setSetpoint
    [   yield "Старт", fun _ _ -> PartyWorks.TermoChamber.start()
        yield "Стоп", fun _ _ -> PartyWorks.TermoChamber.stop()
        yield "Уставка", setpoint  ]
    |> simpleMenu
    
open Mil82.View.TopBar

let showSelectScenaryDialog : Windows.Forms.Control -> unit = 
    let tv = 
        new MyWinForms.Components.TriStateCheckTreeView
                (Font = new Font( "Segue UI", 12.f ),
                    Height = 600)
    let mp = Dictionary<TreeNode,Operation>()
    let ndmp = Dictionary<string,TreeNode>()
    let rec populate (parnd:TreeNode) (x:Operation) = 
        let nd = new TreeNode(Checked = true, Text = x.Name)
        mp.[nd] <- x
        ndmp.[x.FullName] <- nd
        nd 
        |> (if parnd=null then tv.Nodes else parnd.Nodes).Add
        |> ignore
        match x with 
        | Operation.Scenary (_,xs) -> xs |> List.iter (populate nd)                
        | _ -> ()
                        
    populate null mil82
     
    let getOperation() = 
        let node = tv.SelectedNode
        if node=null then None else 
        mp.[node] |> Operation.Choose1 ( fun y -> 
            ndmp.[y.FullName].StateImageIndex > 0 ) 
    
    let dialog,validate  = 
        popupDialog
            { Dlg.def() with 
                Dlg.ButtonAcceptText = "Выбрать" 
                Width = 450
                Dlg.Content = tv 
                Dlg.Title = "Выбрать сценарий"}
            getOperation
            ( fun operation ->
                Thread2.scenary.Set operation )

    tv.StateImageIndexChanged.Add <| fun _ ->
        validate()
    tv.AfterSelect.Add <| fun _ ->
        validate()
    let root = tv.Nodes.[0]
//    root.Checked <- false   
    root.Checked <- true   
    root.Expand()
    for node in root.Nodes do
       node.Expand() 
    tv.Select()
    tv.Focus() |> ignore
    validate()
    dialog.Show

let initialize =
    let buttonRun = new Button( Parent = TopBar.thread1ButtonsBar, Dock = DockStyle.Left, AutoSize = true,
                                ImageKey = "run",
                                Text = (sprintf "%A" Thread2.scenary.Value.FullName),
                                ImageAlign = ContentAlignment.MiddleLeft,
                                TextImageRelation = TextImageRelation.ImageBeforeText,
                                TextAlign = ContentAlignment.MiddleCenter,
                                FlatStyle = FlatStyle.Flat,
                                ImageList = Widgets.Icons.instance.imageList1)
    TopBar.thread1ButtonsBar.Controls.Add <| new Panel(Dock = DockStyle.Left, Width = 3)
    MainWindow.setTooltip buttonRun ("Выполнить " + buttonRun.Text)
    buttonRun.Click.Add <| fun _ ->  
        Thread2.run true Thread2.scenary.Value
    Thread2.scenary.AddChanged <| fun (_,x) ->
        buttonRun.Text <- sprintf "%A" x.FullName
        MainWindow.setTooltip buttonRun ("Выполнить " + buttonRun.Text)
        buttonRun.AutoSize <- false
        buttonRun.AutoSize <- true

    let (<==) (text,tooltip) f = 
        let b = new Button( Parent = TopBar.thread1ButtonsBar, Dock = DockStyle.Left, 
                            FlatStyle = FlatStyle.Flat,
                            Text = text, AutoSize = true )
        b.Click.Add <| fun _ ->  
            f b    
        MainWindow.setTooltip b tooltip
        TopBar.thread1ButtonsBar.Controls.Add <| new Panel(Dock = DockStyle.Left, Width = 3)
        
        
    do 
        let s1 = "Опрос","Опрос выбранных параметров приборов партии"    
        s1 <== fun _ ->
            runInterrogate()
    
    ("Modbus", "Ручное управление приборами") <== fun x ->
        modbusToolsPopup.Show x

    ("Пневмоблок", "Ручное управление пневмоблоком") <== fun x ->
        pneumoToolsPopup.Show x   

    ("Термокамера", "Ручное управление термокамерой") <== fun x ->
        termoToolsPopup.Show x   

    do
        let x = 
            new Button( Parent = TopBar.thread1ButtonsBar, Dock = DockStyle.Left, AutoSize = true,
                        ImageKey = "three_lines", Width = 40, Height = 40,
                        FlatStyle = FlatStyle.Flat,
                        ImageList = Widgets.Icons.instance.imageList1)
        MainWindow.setTooltip x "Выбрать сценарий настройки"
        x.Click.Add <| fun _ ->  
            showSelectScenaryDialog x
        TopBar.thread1ButtonsBar.Controls.Add <| new Panel(Dock = DockStyle.Left, Width = 3)

    

    let imgbtn1 key tooltip f1 f = 
        let x = 
            new Button( Parent = productsToolsLayer, Dock = DockStyle.Top, AutoSize = true,
                        ImageKey = key, Width = 40, Height = 40,
                        FlatStyle = FlatStyle.Flat,
                        ImageList = Widgets.Icons.instance.imageList1)
        f1 x
        MainWindow.setTooltip x tooltip
        x.Click.Add <| fun _ ->  
            f x
        productsToolsLayer.Controls.Add <| new Panel(Dock = DockStyle.Top, Height = 3)

    let imgbtn key tooltip f = imgbtn1 key tooltip (fun _ -> ()) f 

    imgbtn1 "removeitem" "Удалить выбранные приборы из партии" 
        ( fun b ->
            b.Visible <- false
            let g = gridProducts
            g.SelectionChanged.Add <| fun _ ->
                b.Visible <- g.SelectedCells.Count > 0 ) 
        deleteProducts
    
    imgbtn "additem" "Добавить в партию новые приборы" addProducts

    imgbtn "open" "Открыть ранее сохранённую партию" (fun b -> openParty b )

    imgbtn "add" "Создать новую партию" createNewParty

    let buttonStendSettings = 
        new Button( Parent = right, Height = 40, Width = 40, Visible = true,
                    ImageList = Widgets.Icons.instance.imageList1,
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Right, ImageKey = "tools1")
    right.Controls.Add <| new Panel(Dock = DockStyle.Right, Width = 3)
    setTooltip buttonStendSettings "Параметры \"железа\""
    buttonStendSettings.Click.Add <| fun _ ->            
        let popup = MyWinForms.Utils.popupConfig "Параметры \"железа\"" AppConfig.config PropertySort.CategorizedAlphabetical
        popup.Font <- form.Font
        popup.Show(buttonStendSettings)

    let buttonSettings = 
        new Button( Parent = right, Height = 40, Width = 40, Visible = true,
                    ImageList = Widgets.Icons.instance.imageList1,
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Right, ImageKey = "settings")
    right.Controls.Add <| new Panel(Dock = DockStyle.Right, Width = 3)
    setTooltip buttonSettings "Параметры приложения" 

    buttonSettings.Click.Add <| fun _ ->            
        let popup = MyWinForms.Utils.popupConfig "Параметры" Mil82.AppContent.party PropertySort.CategorizedAlphabetical
        popup.Font <- form.Font        
        popup.Closed.Add  Mil82.View.Products.updateCoefsGridRowsVisibility
        popup.Show(buttonSettings)
        

    fun () -> ()