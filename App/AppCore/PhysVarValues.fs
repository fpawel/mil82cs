module Mil82.PhysVarValues

open System
open System.Collections.Generic
open System.IO

open Mil82
open Repository

type K = 
    {   Party : PartyPath
        Product : Id   
        Var : PhysVar }
type Value = DateTime * decimal

[<AutoOpen>]
module private Helpers = 
    let newValues = new Dictionary< K, Value list >()

    let readPhysVarValue (reader:BinaryReader) =
        try
            let date = new DateTime(reader.ReadInt64())
            let v = reader.ReadDecimal()
            Some(date, v)            
        with _ -> 
            None

    let getNewValues k =
        let b, v = newValues.TryGetValue k
        if b then v else []


let addValue k value = lock newValues <| fun () ->
    newValues.[k] <- (DateTime.Now, value) :: (getNewValues k)

let getSavedValues k = 
    let fn = PhysVar.filePath (false,k.Party,k.Product,k.Var)     
    if not <| File.Exists fn then [] else
    let x = new List< DateTime*decimal >()
    use fs = File.OpenRead(fn)
    let reader = new BinaryReader(fs)
    seq{
        while true do
            yield readPhysVarValue reader }
    |> Seq.takeWhile Option.isSome
    |> Seq.choose id
    |> Seq.toList

let save() = lock newValues <| fun () ->
    if newValues.Values.Count = 0 then () else
    
    let files = new Dictionary<K, BinaryWriter>()      
    let getWriter k =            
        match files.TryGetValue(k) with
        | true, x -> x
        | _ ->  
            let path = PhysVar.filePath(true, k.Party, k.Product, k.Var)
            let writer = new BinaryWriter(File.Open(path, FileMode.Append))
            files.Add(k, writer)
            writer               
    newValues |> Seq.iter( fun (KeyValue(k, List.Rev values)) -> 
        let writer = getWriter k
        for dateTime, value in values do
            writer.Write(  dateTime.Ticks)
            writer.Write(value) )
    files.Values |> Seq.iter ( fun x -> x.Close() )
    newValues.Clear()

let delete (partyPath,productId) = lock newValues <| fun () ->
    let folderPath = Product.folderPath (false,partyPath,productId)
    if Directory.Exists folderPath then
        Directory.Delete(folderPath, true)
    
    newValues.Keys
    |> Seq.toList
    |> List.filter(fun x -> x.Party.Id = partyPath.Id && x.Product = productId)
    |> List.iter( newValues.Remove >> ignore )

let getNewValues k = 
    let ret = ref []
    lock newValues <| fun () ->
        ret := getNewValues k |> List.rev
    !ret

