module Mil82.View.TopBar 

open System
open System.Windows.Forms
open System.Drawing

open MainWindow

let placeHolder = 
    let x = new Panel(Parent = form, Dock = DockStyle.Top, Height = 42)
    form.Controls.Add <| new Panel(Dock = DockStyle.Top, Height = 3)
    x
let thread2 =      
    new Panel(Parent = placeHolder, Dock = DockStyle.Fill)
let right = new Panel(Parent = placeHolder, Dock = DockStyle.Right, AutoSize = true)

let thread1ButtonsBar = new Panel(Parent = placeHolder, Dock = DockStyle.Left, AutoSize = true)
    


    

let initialize = 

    let buttonShowAppDir =
        new Button( Parent = right, Height = 40, Width = 40, Visible = true,
                    ImageList = Widgets.Icons.instance.imageList1,
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Right, ImageKey = "folder")

    right.Controls.Add <| new Panel(Dock = DockStyle.Right, Width = 3)
    buttonShowAppDir.Click.Add <| fun _ ->  
        Diagnostics.Process.Start(IO.Path.appDir) 
        |> ignore

    setTooltip buttonShowAppDir "Перейти к каталогу приложения"
    
    let buttonReport =
        new Button( Parent = right, Height = 40, Width = 40, Visible = true,
                    ImageList = Widgets.Icons.instance.imageList1,
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Right, ImageKey = "pdf")

    right.Controls.Add <| new Panel(Dock = DockStyle.Right, Width = 3)
    buttonReport.Click.Add <| fun _ ->  
        Mil82.Pdf.report Mil82.AppContent.party.Party

    setTooltip buttonReport "паспорта и этикетки"

    let buttonSave = new Button(Parent = thread1ButtonsBar, AutoSize = true, Dock = DockStyle.Left,
                                FlatStyle = FlatStyle.Flat,
                                Text = "Cохранить", Visible = false)
    buttonSave.SetInfoStyle()
    setTooltip buttonSave "Cохранить изменения"
    Thread2.IsRunningChangedEvent.addHandler <| fun (_,is'running) ->
        thread1ButtonsBar.Visible <- not is'running

    Mil82.AppContent.subscribeOnChanged <| fun(_,v) -> 
        Control.performThreadSafeAction buttonSave <| fun () ->
            buttonSave.Visible <- v

    buttonSave.Click.Add <| fun _ -> 
        Mil82.AppContent.save()
    
    fun () -> ()