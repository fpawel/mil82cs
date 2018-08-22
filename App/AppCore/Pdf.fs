module Mil82.Pdf

open System
open System.IO
open iTextSharp.text
open iTextSharp.text.pdf

let baseTimes = SysText.iTextHlp.FontSysGet("Times New Roman")
let font12red = Font(baseTimes, 12.f, Font.NORMAL, BaseColor.RED)
let font12bold = Font(baseTimes, 12.f, Font.BOLDITALIC)
let font12 = Font(baseTimes, 12.f, Font.ITALIC)
let tableCell (table :PdfPTable) font (text:string) = 
    let cell = PdfPCell(Phrase(text,font))
    table.AddCell(cell) 

let product  ((h,d):Party.Content) (p:Product)  =
    let (~%%) = ignore
    let kefs ks = 
        ks |> List.fold(fun a k -> 
            match a with 
            | Ok xs ->
                match Product.getKef k p with
                | Some v -> Ok ( xs @ [v] )
                | _ -> Err ( sprintf "K%d=?" k.Order)
            | Err s -> 
                Err ( s + ", " + sprintf "K%d=?" k.Order )
            ) (Ok [])

    let t = h.ProductType
    let tempLow = Party.getTermoTemperature d TermoLow
    let tempHigh = Party.getTermoTemperature d TermoHigh       

    let cell = PdfPCell()

    let par = Paragraph("ПАСПОРТ", Font(baseTimes, 14.f, Font.BOLD))
    par.Alignment <- Element.ALIGN_CENTER
    %% cell.AddElement(par)

    let par = Paragraph("ИК датчик МИЛ-82 ИБЯЛ.418414.111-" + t.What, Font(baseTimes, 12.f, Font.ITALIC))
    par.Alignment <- Element.ALIGN_CENTER
    %% cell.AddElement(par)

        

    let innerTable = PdfPTable(2)
    innerTable.WidthPercentage <- 100.f
                
    let add f s = 
        let c =  tableCell innerTable f s
        c.BorderColor <- BaseColor.WHITE
        c.BorderWidth <- 0.f
        //c.BorderColorBottom <- BaseColor.LIGHT_GRAY
        //c.BorderWidthBottom <- 1.f
        c.PaddingBottom <- 5.f

        
    let kefsf ks f = 
        match kefs ks with
        | Ok xs  -> 
            match f xs with
            | Ok s -> add font12 s
            | Err s -> add font12red s
        | Err s -> add font12red s

    add font12 "Поверочный компонент:" 
    add font12bold t.Gas.What
    add font12 "Диапазон измерений:"
    add font12bold (sprintf "0-%M %s" t.Scale.Value t.Gas.Units)
    add font12 "Температурный диапазон:"
    add font12bold (sprintf "%+M %+M*C" tempLow tempHigh)

    add font12 "Сигнал рабочего канала"
    kefsf [Coef21; CoefKw ] ( function
        | [_;0m] -> Err "K43=0"
        | [k21; k43]  -> Ok ( Decimal.toStr "0.#" (k21/k43) + " мВ")
        | _ -> failwith "?")

    add font12 "Сигнал сравнительного канала"
    kefsf [Coef20; CoefKr] ( function
        | [ _; 0m ] -> Err "k44=0"
        | [ k20; k44 ] -> Ok (Decimal.toStr "0.#" (k20/k44) + " мВ")
        | _ -> failwith "?" )        

    add font12 "Полезный сигнал"

    let kk22 = if h.ProductType.Gas = CO2 then 1000M else 100m
    
    kefsf [Coef22] ( function 
        | [k22] -> Ok ( Decimal.toStr "0.#"  (k22 / kk22) + " %") 
        | _ -> failwith "?" )

    add font12 "Заводской номер:" 
    add font12bold (string p.ProductInfo.serial)

    add font12 "Сетевой адрес:" 
    add font12bold (string p.Addr)

    add font12 "Дата изготовления"
    add font12bold (DateTime.Now.ToString("dd.MM.yyyy"))

    cell.AddElement innerTable

    let phr = Phrase("Подпись:", font12)
    %% phr.Add("________________")

    let par = Paragraph()
    %% par.Add phr
    par.SpacingBefore <- 5.f
    par.SpacingAfter <- 10.f
        
    cell.AddElement(par)
    cell.AddElement(Phrase(""))
    cell

//let stickerFont = SysText.iTextHlp.FontSysGet("GOST Type A")
let stickerFont = SysText.iTextHlp.FontSysGet("Arial")

let sticker ((h,d):Party.Content) (p:Product) = 
    let cell = PdfPCell()
    cell.Border <- 0
    cell.UseAscender <- true
    cell.Padding <- 3.f
    cell.FixedHeight <- 19.f

    let pi = p.ProductInfo
    let strMonth = 
        let s = string pi.month in
        if pi.month < 10 then "0" + s else  s

    let t = h.ProductType
    let tempLow = Party.getTermoTemperature d TermoLow
    let tempHigh = Party.getTermoTemperature d TermoHigh

    let str1 = 
        sprintf "МИЛ-82 Зав.№%d сет.адр.%d %s мес.%d" 
            pi.serial p.Addr strMonth (2000 + pi.year)

    let str2 = 
        sprintf "%s 0-%M %s 418414.111-%s %+M %+M*С" 
            t.Gas.What t.Scale.Value t.Gas.Units t.What tempLow tempHigh

    cell.CellEvent <- 
        {   new IPdfPCellEvent with 
                override x.CellLayout( cell, position, canvases) = 
                    //Grab the line canvas for drawing lines on
                    let cb = canvases.[PdfPTable.LINECANVAS]
                    //Create a new rectangle using our previously supplied spacing
                    cb.Rectangle(
                        position.Left + 2.f,
                        position.Bottom + 2.f,
                        (position.Right - 2.f) - (position.Left + 2.f),
                        (position.Top - 2.f) - (position.Bottom + 2.f)
                        )
                    cb.SetColorStroke(BaseColor.LIGHT_GRAY)
                    cb.Stroke()
                    let cb = canvases.[PdfPTable.TEXTCANVAS]
                    cb.BeginText()
                    cb.SetFontAndSize(stickerFont, 7.f)
                    cb.ShowTextAligned(Element.ALIGN_LEFT, str1, position.Left + 4.f, position.Top - 8.f, 0.f)
                    cb.ShowTextAligned(Element.ALIGN_LEFT, str2, position.Left + 4.f, position.Top - 14.f, 0.f)                        
                    cb.EndText()
        }
        

    cell

let stickers ((h,d):Party.Content as party) =
    let (~%%) = ignore
    
    let table = PdfPTable(4)    
    table.WidthPercentage <- 100.f
    table.SetWidthPercentage( Array.init 4 (fun _ -> 140.f), PageSize.A4)

    let xs = d.Products |> List.filter (fun p -> 
        let i = p.ProductInfo 
        i.month <> 0 && i.year <> 0 && i.kind <> 0)

    xs |> List.iter (sticker party >> table.AddCell >> ignore ) 

    for i = xs.Length % 4 to 3 do
        table.AddCell(new PdfPCell()) |> ignore

    table
    


let report ((h,d):Party.Content as party) =
    let (~%%) = ignore
    let filename = IO.Path.Combine(IO.Path.GetTempPath(), Guid.NewGuid().ToString() + ".pdf")

    let document = new Document(PageSize.A4.Rotate(), 30.f, 30.f, 20.f, 20.f);
    let writer = PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create))
    document.Open()
    
    let table = PdfPTable(2)    
    table.WidthPercentage <- 100.f    

    let products = 
        d.Products 
        |> List.filter (fun p -> 
            let i = p.ProductInfo 
            i.month <> 0 && i.year <> 0 && i.kind <> 0)


    products |> List.iter (product party >> table.AddCell >> ignore ) 

    if products.Length % 2 = 1 then
        table.AddCell(new PdfPCell()) |> ignore

    %% document.Add(table)
    %% document.NewPage()
    %% document.Add(stickers party)
    document.Close()
    writer.Close()
    %% Diagnostics.Process.Start("explorer.exe", "/select, \"" + filename + "\"")
    %% Diagnostics.Process.Start filename 
    