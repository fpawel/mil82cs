﻿module Mil82.Pasp

open System

open Tree
open Html

[<AutoOpen>]
module private Helpers = 
    let pasportBlock xs = 
        td ( (class' "pasport-block")::xs  )

    let value' = class' "value"

let private product ((h,d):Party.Content) (p:Product) =
    let t = h.ProductType
    let gas = t.Gas

    let tempLow = Party.getTermoTemperature d TermoLow
    let tempHigh = Party.getTermoTemperature d TermoHigh

    let ur =         
        match Product.getKefs [Coef21; CoefKw ] p with
        | [k21; k43] when k43<>0m -> Decimal.toStr6 (k21/k43)
        | _ -> ""

    let us = 
        match Product.getKefs [Coef20; CoefKr] p with
        | [ k20; k44 ] when k44<>0m -> Decimal.toStr6 (k20/k44)
        | _ -> ""

    let up =
        Product.getKef Coef22 p
        |> Option.map ( fun x -> Decimal.toStr6 (x / 100m)  )
        |> Option.withDefault ""

    let trs = [   
        tr[
            td [ %% "Поверочный компонент:"]
            td [ value'; %% gas.What]
        ]  
        tr[
            td [%% "Диапазон измерений:"]
            td [value'; %% sprintf "0-%M %s" t.Scale.Value gas.Units]
        ]
        tr[
            td [%% "Температурный диапазон:"]
            td [value'; %% sprintf "%+M %+M ⁰C" tempLow tempHigh ]
        ]
        tr[
            td [ 
                %% "Величины сигналов каналов:"
                rowspan 2
                valign "top"
                ]
            td [
                %% "U"; sub [ %% "р" ]; %% "="
                span[ value'; %% ur  ]
            ]
        ]
        tr[
            td [
                %% "U"; sub [ %% "cр" ]; %% "="
                span[ value'; %% us  ]
            ]
        ]
        tr[
            td [%% "Полезный сигнал:"]
            td [value'; %% up ]
        ]
        tr[
            td [%% "Заводской номер:"]
            td [value'; %% string p.ProductInfo.serial ]
        ]
        tr[
            td [%% "Дата изготовления:"]
            td [value'; %% DateTime.Now.ToString("dd.MM.yyyy") ]
        ]
    ]

    [   div [ class' "header1"; %% "Паспорт"]
        div [ 
            class' "product-type"
            %% "ИК датчик МИЛ-82"
            span [ 
                class' "product-type-1"
                %% ("ИБЯЛ.418414.111-" + t.What) 
            ] 
        ]
        table [
            tbody trs 
        ]
        div[
            %% "Подпись: _____________________" 
        ]
    ]
    

let private css = 
        IO.File.ReadAllText("content\\report.css")

let party ((h,d):Party.Content as party) = 
    let product = product party
    let trs = 
        List.window 2 d.Products 
        |> List.map( function
            | [p1;p2] -> [p1;p2] |> List.map (product >> pasportBlock)
            | [p1] -> [ pasportBlock <| (colspan 2)::(product p1)  ]
            | _ -> [] )
        |> List.map tr
    [ table [ tbody trs ] ]
    |> html5 css "Индивидуальные паспорта МИЛ-82"
    |> Seq.toStr "\n" stringify