﻿module Json.Config

open System
open System.IO

open Json.Serialization

let private retDummy<'a> (filename, dummy  : unit -> 'a) errorText =    
    dummy(), Some (sprintf "ошибка файла конфигурации json \"%s\": %s" filename errorText ) 

let read filename dummy =    
    let filename =  IO.Path.Combine( IO.Path.appDir, filename)
    let retDummy = retDummy (filename, dummy)
    let x, e = 
        if IO.File.Exists filename then 
            try
                match parse (IO.File.ReadAllText(filename)) with
                | Ok x -> x, None
                | Err x -> retDummy x
            with e -> retDummy <| sprintf "%A" e
        else
            retDummy "файл не существует"
    match e with
    | Some e -> Logging.error "%s" e
    | _ -> ()
    x

let write filename x' = 
    let filename =  IO.Path.Combine( IO.Path.appDir, filename)
    let x = stringify x'
    let r =
        try
            File.WriteAllText(filename, x)
            Ok ()
        with e ->
            Err <| sprintf "oшибка записи файла конфигурации json %A: %A" filename e 

    match r with
    | Err e -> Logging.error "%s" e
    | _ -> ()

let create filename dummy =         
    let config = read filename dummy
    let save() = write filename config
    config, save