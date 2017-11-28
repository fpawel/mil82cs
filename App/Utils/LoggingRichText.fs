module LoggingRichText

open System
open System.Windows.Forms
open System.Drawing

open Tree
open Html

open Logging

let private appendText (r:RichTextBox) (text,color) = 
    r.SelectionStart <- r.TextLength
    r.SelectionLength <- 0
    r.SelectionColor <- color
    r.AppendText text
    r.SelectionColor <- r.ForeColor

let private appendLine r (dt:DateTime, level, text) = 
    appendText r (sprintf "%A " dt, Color.DarkGreen)
    appendText r (text + "\n", Logging.foreColor level  )

    
let setLogging (r:RichTextBox) logging  = 
    r.Text <- ""
    List.iter (appendLine r) logging
    

let addRecord r level text = 
    appendLine r (DateTime.Now, level, text  )
    r.ScrollToCaret()