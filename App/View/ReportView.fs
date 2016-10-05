module Mil82.View.Report 

open System
open System.Windows.Forms
open System.Drawing

open Mil82
open Mil82.View

type private Dck = DockStyle

let placeHolder = new Panel(Dock = Dck.Fill)

let ie = 
    let x = 
        new WebBrowser(Parent = placeHolder, Dock = Dck.Fill, Url = null,
                       IsWebBrowserContextMenuEnabled = false, AllowWebBrowserDrop = false)
    x
let toolbar = new Panel(Parent = placeHolder, Dock = Dck.Top, Height = 40)



let private (~%%) k = 
    let x = new Button(Parent = toolbar, Height = 40, Width = 40, 
                       ImageList = Widgets.Icons.instance.imageList1,
                       FlatStyle = FlatStyle.Flat,
                       Dock = Dck.Right, ImageKey = k)
    let _ = new Panel(Parent = toolbar, Dock = Dck.Right, Width = 5)
    x

let btnSave = %% "save"
let btnPrint = %% "print"
let btnClose = %% "close"



let initialize =
    btnClose.Click.Add <| fun _ ->
        placeHolder.Parent <- null
        MainWindow.mainLayer.Visible <- true
        TopBar.placeHolder.Visible <- true


    TopBar.buttonReport.Click.Add <| fun _ ->  
        //ie.DocumentText <- ViewModels.Party.party.GetReport()
        MainWindow.mainLayer.Visible <- false
        TopBar.placeHolder.Visible <- false
        placeHolder.Parent <- MainWindow.form
        placeHolder.BringToFront()

    btnSave.Click.Add <| fun _ ->
        let dlg = 
            new SaveFileDialog
                (Filter = "веб-страница (*.html)|*.html|Все файлы (*.*)|*.*",
                 FilterIndex = 1, RestoreDirectory = true )
        if dlg.ShowDialog() <> DialogResult.OK then () else
        IO.File.WriteAllText
            (dlg.FileName, ie.Document.Body.Parent.OuterHtml, 
                Text.Encoding.GetEncoding(ie.Document.Encoding))

        (*
        Stream myStream ;
     SaveFileDialog saveFileDialog1 = new SaveFileDialog();

     saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"  ;
     saveFileDialog1.FilterIndex = 2 ;
     saveFileDialog1.RestoreDirectory = true ;

     if(saveFileDialog1.ShowDialog() == DialogResult.OK)
     {
         if((myStream = saveFileDialog1.OpenFile()) != null)
         {
             // Code to write the stream goes here.
             myStream.Close();
         }
     }
        *)


        

    fun () -> ()
