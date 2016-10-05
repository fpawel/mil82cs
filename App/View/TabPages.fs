module Mil82.View.TabPages

open System
open System.Windows.Forms
open System.Drawing
open System.Collections.Generic

open MyWinForms.Utils
open WinFormsControlUtils

open MainWindow
open Mil82
open Mil82.View.Products

type private P = Mil82.ViewModel.Product
type private VE = Mil82.Alchemy.ValueError


module TabsheetVars =
    type Page = {PhysVar : PhysVar; Feature : Feature; TermoPt : TermoPt} 
    let mutable private page = { PhysVar = Conc; Feature = Lin; TermoPt = TermoNorm}
    let update () = 
        setActivePageTitle <| sprintf "%s, %s, %s" page.Feature.What1 page.PhysVar.Dscr page.TermoPt.Dscr
        gridProducts.Columns.``remove all but [n] first columns`` 3
        for gas in ScalePt.values do
            let s = Property.var (page.Feature, page.PhysVar, gas, page.TermoPt)
            gridProducts.Columns.AddColumn( new DataGridViewTextBoxColumn( DataPropertyName = s,  HeaderText = gas.What) )

    let private addp () =         
        let p = new Panel(Parent = TabsheetVars.BottomTab, Dock = DockStyle.Top)
        let _ = new Panel(Parent = TabsheetVars.BottomTab, Dock = DockStyle.Top, Height = 10)
        p

    module Termo =
        let get,set = 
            radioButtons (addp ()) TermoPt.values TermoPt.what <| fun x -> 
                page <- {page with TermoPt = x }
                update()
    module Feat =
        let get,set = 
            radioButtons (addp ()) Feature.values Feature.what1 <| fun x -> 
                page <- {page with Feature = x }
                update()
    module PhysVar =
        let get,set = 
            radioButtons (addp ()) PhysVar.values PhysVar.what <| fun x -> 
                page <- {page with PhysVar = x }
                update()

module TabsheetChart = 
    
    let update() =
        setActivePageTitle <| sprintf "График. %s" Chart.physVar.Dscr 
        AppContent.updateChartSeriesList ()
        let m =Chart.axisScalingViewModel
        m.MaxDateTime <- None
        m.MinDateTime <- None
        m.MinY <- None
        m.MaxY <- None
    
    module PhysVar =
        let get,set = 
            let panelSelectVar = new Panel(Parent = TabsheetChart.BottomTab, Dock = DockStyle.Top)
            let _ = new Panel(Parent = TabsheetChart.BottomTab, Dock = DockStyle.Top, Height = 10)
        
            radioButtons panelSelectVar PhysVar.values PhysVar.what <| fun x -> 
                Chart.physVar <- x
                update()

module TabsheetErrors =
    type K = 
        | Main | Termo | Tex
        member x.What = K.what x
        static member what = function
            | Main  -> "Основная"
            | Termo -> "Температурная"
            | Tex   -> "Техпрогон"

        static member props = function
            | Main  -> 
                [   for gas in ScalePt.values do
                        yield gas.What, "Основная погрешность", Property.concError gas
                    for gas in ScalePt.values do
                        yield gas.What, "Возврат н.к.у.", Property.retNkuError gas ]
            | Termo -> 
                [   for gas in ScalePt.values do
                        yield gas.What + "-", "Погрешность на пониженной температуре", Property.termoError (gas,TermoLow)
                    for gas in ScalePt.values do
                        yield gas.What + "+", "Погрешность на повышенной температуре", Property.termoError (gas,TermoHigh)
                    for gas in ScalePt.values do
                        yield gas.What + " 90\"С", "Погрешность на 90\"C", Property.termoError (gas,Termo90) ]
            | Tex   -> 
                [   for gas in ScalePt.values do
                        yield gas.What, "Техпрогон 1", Property.tex1Error gas
                    for gas in ScalePt.values do
                        yield gas.What, "Техпрогон 2", Property.tex2Error gas ]

    
    
    let getProductOfRow (g:DataGridView) (e:DataGridViewCellFormattingEventArgs) =
        g.Rows.[e.RowIndex].DataBoundItem :?> P

    type private Fn = { 
        f : P -> VE option
        s : string }
    let private colsFns = 
        let x = Dictionary<int, Fn>()
        gridProducts.ColumnRemoved.Add(fun e -> 
            x.Remove(e.Column.GetHashCode()) |> ignore
            )
        x

         

    let formatCell page (g:DataGridView) (e:DataGridViewCellFormattingEventArgs) s ve =  
        let row = g.Rows.[e.RowIndex]
        let col = g.Columns.[e.ColumnIndex]        
        let cell = row.Cells.[e.ColumnIndex]
        let p = getProductOfRow g e
        let decToStr = Decimal.toStr "0.###"
        let what = sprintf "%s, %s" p.What s
        
        ve |> Option.map( fun (ve : VE) ->  
            
            let foreColor, backColor = if ve.IsError then Color.Red, Color.LightGray else Color.Navy, Color.Azure 
            let toolTip = 
                [|  yield "Снятое значение", decToStr ve.Value                     
                    yield "Номинал", decToStr ve.Nominal
                    yield "Предел погрешности", decToStr ve.Limit  |]
                |> Array.map( fun (p,v) -> sprintf "%s = %s" p v)
                |> fun v -> String.Join("\n", v)                
            ve.Value, foreColor, backColor, toolTip  )
        |> function
        | None -> cell.ToolTipText <- sprintf "%s - нет данных" what
        | Some (value, foreColor, backColor, text) ->
            cell.Style.ForeColor <- foreColor
            cell.Style.BackColor <- backColor
            cell.ToolTipText <- sprintf "%s\n%s" what text
            e.Value <- decToStr value
            e.FormattingApplied <- true
             

    let mutable private page = Main
    let update () = 
        setActivePageTitle (page.What + " погрешность")
        gridProducts.Columns.``remove all but [n] first columns`` 3
        for h,s,p in K.props page do
            let col = new DataGridViewTextBoxColumn( DataPropertyName = p,  HeaderText = h)
            colsFns.[col.GetHashCode()] <- 
                {   f = fun product ->
                        let t = typeof<P>
                        let prop = t.GetProperty p
                        prop.GetValue(product,null) :?> VE option
                    s = s }
            gridProducts.Columns.AddColumn col

    
    
    let get,set = 
        let p1 = new Panel(Parent = TabsheetErrors.BottomTab, Dock = DockStyle.Top)
        let _ = new Panel(Parent = TabsheetErrors.BottomTab, Dock = DockStyle.Top, Height = 10)

        gridProducts.CellFormatting.Add <| fun e ->
            let column = gridProducts.Columns.[e.ColumnIndex]
            if column.GetHashCode() = Mil82.View.Products.Columns.interrogate.[0].GetHashCode() then
                let text, fore, back =
                    match e.Value :?> Result<string,string> option with
                    | Some (Ok s) -> s, Color.Black, Color.White
                    | Some (Err s) -> s, Color.Red, Color.LightGray
                    | _ -> "", Color.Black, Color.White
                e.Value <- text
                let row = gridProducts.Rows.[e.RowIndex]
                let cell = row.Cells.[e.ColumnIndex]
                cell.Style.ForeColor <- fore
                cell.Style.BackColor <- back
            else
                let b,f = colsFns.TryGetValue (column.GetHashCode())
                if b then 
                    let p = getProductOfRow gridProducts e
                    formatCell page gridProducts e f.s (f.f p)
            

        radioButtons p1 [Main; Termo; Tex] K.what <| fun x -> 
            page <- x
            update()
    

let private onSelect = function
    | TabsheetParty -> 
        gridProducts.Columns.``remove all but [n] first columns`` 3
        gridProducts.Columns.AddColumns  Products.Columns.interrogate
        gridProducts.Parent <- TabsheetParty.RightTab
    | TabsheetVars ->
        gridProducts.Columns.``remove all but [n] first columns`` 3
        gridProducts.Parent <- TabsheetVars.RightTab
        TabsheetVars.update()
    | TabsheetErrors ->
        gridProducts.Columns.``remove all but [n] first columns`` 3
        gridProducts.Parent <- TabsheetErrors.RightTab
        TabsheetErrors.update()
        
    | TabsheetChart ->
        gridProducts.Parent <- null
        TabsheetChart.update()
    | _ -> ()
        
let getSelected, setSelected =
    radioButtons 
        tabButtonsPlaceholder 
        Tabsheet.values
        Tabsheet.title
        (fun tabPage -> 
            setActivePageTitle tabPage.Title
            onSelect tabPage
            tabPage.ShowContent() ) 

module TabChart =
    let update() = 
        if getSelected() = TabsheetChart then
            AppContent.updateChartSeriesList ()