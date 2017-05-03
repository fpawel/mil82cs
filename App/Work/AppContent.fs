module Mil82.AppContent
open System
open Mil82

open Repository

[<AutoOpen>]
module private Helpers =
    let mutable parties = Repository.readPartiesHeaders()
    let isChanged = Ref.Observable(false) 
    let setChanged () =
        isChanged.Value <- true
    

let subscribeOnChanged f = isChanged.AddChanged f


let party =     
    let r = Party.openById AppConfig.config.View.PartyId parties
    let openedPartyHead,openedPartyData as openedPartyValue = 
        match r with
        | Err e -> 
            Logging.error "не удалось открыть ранее сохранённую партию : %s" e
            Alchemy.createNewParty()
        | Ok x -> x
    let party = 
        ViewModel.Party(openedPartyHead , openedPartyData )

    let addChangedListener (x:obj) =
        Runtime.PropertyChanged.add x ( fun _ -> 
            setChanged() )

    party.Products |> Seq.iter addChangedListener

    party.Products.AddingNew.Add(fun x -> 
        addChangedListener x.NewObject 
        setChanged() )

    party.Products.ListChanged.Add(fun _ -> 
        setChanged() )

    addChangedListener party
    parties <- Map.add openedPartyHead.Id openedPartyHead parties

    party

[<AutoOpen>]
module private Helpers1 =
    
    let setSaved () =     
        isChanged.Value <- false
        let h,_ as party = party.Party
        parties <- Map.add h.Id h parties
        AppConfig.config.View.PartyId <- h.Id
        AppConfig.save()
    type PSr = Chart.ProductSeriesInfo
    

let save<'a> (_ : 'a) =
    let ( partyHead,_) as partyValue = party.Party    
    PhysVarValues.save()
    if isChanged.Value then
        let r = Party.save partyValue
        match r with
        | Err e -> Logging.error "не удалось сохранить партию : %s" e
        | Ok () -> setSaved ()

let updateChartSeriesList () =
    Chart.clear()        
    let h,_ = party.Party
    let partyPath = Repository.PartyPath.fromPartyHead h
    party.Products 
    |> Seq.filter(fun p -> p.IsChecked)
    |> Seq.iter ( fun p -> 
        Chart.addProductSeries
            {   PSr.Product = p.Product.Id
                PSr.Party = partyPath
                PSr.Name = p.What}  )

let load partyId = 
    let r = Party.openById partyId parties
    match r with
    | Err e -> Some e
    | Ok p -> 
        party.Party <- p
        setSaved ()
        None
    

let getParties prodType serial month year =
    parties |> Map.toList |> List.map snd
    |> List.filter( fun p ->
        match prodType with 
        | Some prodType -> p.ProductType = prodType
        | _ -> true  )
    |> List.filter( fun p ->
        match serial with 
        | Some serial -> p.ProductInfo |> List.exists(fun y -> y.serial = serial)
        | _ -> true  )
    |> List.filter( fun p ->
        match month with 
        | Some month -> p.ProductInfo |> List.exists(fun y -> y.month = month)
        | _ -> true )
    |> List.filter( fun p ->
        match year with 
        | Some year -> p.ProductInfo |> List.exists(fun y -> y.year = year)
        | _ -> true )
    |> Repository.partiesHeadersDateTree 