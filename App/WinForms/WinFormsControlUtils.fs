[<AutoOpen>]
module WinFormsControlUtils 

open System.Windows.Forms
open System.Drawing

[<AutoOpen>]
module Helpers1 =
    let rec loopControls (x:Control) chooser mapper = seq{
        match chooser x with
        | None -> ()
        | Some y -> 
            yield mapper y
        for x in x.Controls do
            yield! loopControls x chooser mapper }

type Control with
    static member performThreadSafeAction<'a> (ctrl:Control) (f:unit -> 'a) =
        if ctrl.InvokeRequired then 
            let mutable x : 'a option = None
            ctrl.Invoke <| new  MethodInvoker( fun () -> x <- Some (f()) ) |> ignore
            x.Value
        else f()

    member x.PerformThreadSafeAction f = Control.performThreadSafeAction x f

    member x.EnumControls(chooser,mapper) = loopControls x chooser mapper
    member x.enumControls chooser mapper = loopControls x chooser mapper

    member x.SetInfoStyle () = 
        x.BackColor <- Color.Navy
        x.ForeColor <- Color.White
        x.MouseEnter.Add <| fun _ ->  x.BackColor <- Color.DodgerBlue
        x.MouseLeave.Add <| fun _ ->  x.BackColor <- Color.Navy

type DataGridViewColumnCollection with 
    static member addColumn<'a when 'a :> DataGridViewColumn > (cols:DataGridViewColumnCollection) (col:'a)  =
        cols.Add col |> ignore
    
    static member addColumns xs (cols:DataGridViewColumnCollection) =
        xs |> Seq.iter ( cols.Add >> ignore)

    member x.AddColumn(col) = DataGridViewColumnCollection.addColumn x col
    member x.AddColumns(cols) = DataGridViewColumnCollection.addColumns cols x
    member x.``remove all but [n] first columns`` n = 
        while x.Count > n do
            x.RemoveAt(x.Count-1)

type DataGridView with
    static member updateBinding (g:DataGridView) = 
        let d = g.DataSource
        g.DataSource <- null
        g.DataSource <- d

    member x.UpdateBinding() = DataGridView.updateBinding x
        