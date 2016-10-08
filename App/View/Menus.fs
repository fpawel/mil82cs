module Mil82.View.Menus

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
            SelectScenaryDialog.showSelectScenaryDialog x
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
        PartyProductsDialogs.deleteProducts
    
    imgbtn "additem" "Добавить в партию новые приборы" PartyProductsDialogs.addProducts

    imgbtn "open" "Открыть ранее сохранённую партию" OpenPartyDialog.showDialog

    imgbtn "add" "Создать новую партию" PartyProductsDialogs.createNewParty

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
        popup.Closed.Add( fun _ ->
            Mil82.View.Products.updateCoefsGridRowsVisibility()
            Mil82.View.Products.updatePhysVarsGridColsVisibility()
            )
        popup.Show(buttonSettings)
        

    fun () -> ()