namespace Mil82

type Gas =
    | CO2 | CH4 | C3H8

    member x.What = Gas.what x
    member x.Units = Gas.units x

    static member context = function
        | CO2 -> 4, 7 
        | CH4 -> 5, 14 
        | C3H8 -> 7, 14
    static member what = function
        | CO2 -> "CO₂"
        | CH4 -> "CH₄"
        | C3H8 -> "C₃H₈"

    static member units = function
        | CO2 -> "% об.д."
        | _ -> "% НКПР"

    static member code = Gas.context >> fst
    static member unitsCode = Gas.context >> snd
    static member isCH = function  CO2 -> false | _ -> true 

    

type Scale =     
    
    | Sc4 | Sc10 | Sc20 | Sc50 | Sc100 
    
    member x.Value = Scale.value x

    static member context = function
        | Sc4   -> 57, 4m
        | Sc10  -> 7,  10m
        | Sc20  -> 9,  20m 
        | Sc50  -> 0,  50m 
        | Sc100 -> 21, 100m 
    static member code = Scale.context >> fst
    static member value = Scale.context >> snd

    


    

type ProductType =     
    | A00 | A01 | A02 
    | A10 | A11 | A20 
    | A21 
    | A30 | A31
    | A40
    static member ctx =  function
        | A00 -> 0,0, CO2,  Sc4,    5m,    0.1m, 60m
        | A01 -> 0,1, CO2,  Sc10,   5m,    0.1m, 60m
        | A02 -> 0,2, CO2,  Sc20,   5m,    0.1m, 60m
        | A10 -> 1,0, CH4,  Sc100,  7.5m,  0.5m, 60m
        | A11 -> 1,1, CH4,  Sc100,  7.5m,  0.5m, 60m
        | A20 -> 2,0, C3H8, Sc50,   12.5m, 0.5m, 30m
        | A21 -> 2,1, C3H8, Sc50,   12.5m, 0.5m, 30m
        | A30 -> 3,0, C3H8, Sc100,  12.5m, 0.5m, 30m
        | A31 -> 3,1, C3H8, Sc100,  12.5m, 0.5m, 30m
        | A40 -> 4,0, CH4,  Sc100,  7.5m,  0.5m, 60m
    member x.What = ProductType.what x

    member x.Gas = ProductType.gas x 
    member x.Scale = ProductType.scale x 
    
    static member gas x = let _,_,v,_,_,_,_ = ProductType.ctx x in v
    static member isCH = ProductType.gas >> function CO2 -> false | _ -> true
    static member scale x = let _,_,_,v,_,_,_ = ProductType.ctx x in v
    static member errorLimit x conc = 
        let gas = ProductType.gas x
        let scale = ProductType.scale x
        if gas=CH4 || gas=C3H8 || scale=Sc4 then 2.5m+0.05m*( abs conc) 
        elif scale=Sc10 then 0.5m
        elif scale=Sc20 then 1m
        else 1m

    static member what x = 
        let d1,d2,_,_,_,_,_ = ProductType.ctx x in
        sprintf "0%d.0%d" d1 d2


    


[<AutoOpen>]
module private Helpers =
    let values = FSharpType.unionCasesList<ProductType> 
    ()

type ProductType with 

    static member values = values

    static member index x = 
        List.findIndex ((=) x) values