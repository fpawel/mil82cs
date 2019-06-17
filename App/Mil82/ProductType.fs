namespace Mil82

type Gas =
    | CO2 | CH4 | C3H8 | C6H14

    member x.What = 
        match x with 
        | CO2 -> "CO2"
        | CH4 -> "CH4"
        | C3H8 -> "C3H8"
        | C6H14 -> "C6H14"

    member x.Units = 
        match x with 
        | CO2 -> "% об.д."
        | _ -> "% НКПР"

    member x.Code = 
        match x with 
        | CO2 -> 4
        | CH4 -> 5
        | C3H8 -> 7
        | C6H14 -> 7

    member x.UnitsCode = 
        match x with 
        | CO2 ->  7 
        | CH4 ->  14 
        | C3H8 ->  14
        | C6H14 ->  14

    member x.IsCH = x <> CO2 

    

type Scale =         
    | Sc4 | Sc10 | Sc20 | Sc50 | Sc100 
    | Sc5_50
    
    member x.Begin = 
        match x with
        | Sc5_50 -> 5m 
        | _ -> 0m

    member x.End = 
        match x with 
        | Sc4   -> 4m
        | Sc10  -> 10m
        | Sc20  -> 20m 
        | Sc50  -> 50m 
        | Sc100 -> 100m
        | Sc5_50 -> 50m 

    member x.Code = 
        match x with 
        | Sc4   -> 57
        | Sc10  -> 7
        | Sc20  -> 9
        | Sc50  -> 0
        | Sc100 -> 21        
        | Sc5_50 -> 21

    member x.Scale = x.End - x.Begin

type ProductType =     
    | A00 | A01 | A02 
    | A10 | A11 | A20 
    | A21 
    | A30 | A31
    | A40
    | A50
    | A10_0
    | A10_1
    | A10_2
    | A10_3
    | A10_4
    | A10_5
    | A11_0
    | A11_1
    | A13_0
    | A13_1
    | A14
    | A16
    static member ctx =  function
        | A00 -> 0,0, CO2,  Sc4,    5m,    0.1m, 60m, -40m, 80m
        | A01 -> 0,1, CO2,  Sc10,   5m,    0.1m, 60m, -40m, 80m
        | A02 -> 0,2, CO2,  Sc20,   5m,    0.1m, 60m, -40m, 80m
        | A10 -> 1,0, CH4,  Sc100,  7.5m,  0.5m, 60m, -40m, 80m
        | A11 -> 1,1, CH4,  Sc100,  7.5m,  0.5m, 60m, -60m, 60m
        | A20 -> 2,0, C3H8, Sc50,   12.5m, 0.5m, 30m, -40m, 60m
        | A21 -> 2,1, C3H8, Sc50,   12.5m, 0.5m, 30m, -60m, 60m
        | A30 -> 3,0, C3H8, Sc100,  12.5m, 0.5m, 30m, -40m, 60m
        | A31 -> 3,1, C3H8, Sc100,  12.5m, 0.5m, 30m, -60m, 60m
        | A40 -> 4,0, CH4,  Sc100,  7.5m,  0.5m, 60m, -60m, 80m
        | A50 -> 5,0, C6H14,  Sc5_50,  1m,  30m, 30m, 15m, 80m
        | A10_0 -> 10,0, CO2,  Sc4,  1m,  30m, 30m, -40m, 80m
        | A10_1 -> 10,1, CO2,  Sc10,  1m,  30m, 30m, -40m, 80m
        | A10_2 -> 10,2, CO2,  Sc20,  1m,  30m, 30m, -40m, 80m
        | A10_3 -> 10,3, CO2,  Sc4,  1m,  30m, 30m, -60m, 80m
        | A10_4 -> 10,4, CO2,  Sc10,  1m,  30m, 30m, -60m, 80m
        | A10_5 -> 10,5, CO2,  Sc20,  1m,  30m, 30m, -60m, 80m
        | A11_0 -> 11,0, CH4,  Sc100,  1m,  30m, 30m, -40m, 80m
        | A11_1 -> 11,1, CH4,  Sc100,  1m,  30m, 30m, -60m, 80m

        | A13_0 -> 13,0, C3H8,  Sc100,  1m,  30m, 30m, -40m, 80m
        | A13_1 -> 13,1, C3H8,  Sc100,  1m,  30m, 30m, -60m, 80m
        | A14 -> 14,0, CH4,  Sc100,  1m,  30m, 30m, -60m, 80m
        | A16 -> 16,0, C3H8,  Sc100,  1m,  30m, 30m, -60m, 80m

    static member ctx2 =  function
        | A00 
        | A01 
        | A02 
        | A10 
        | A11 
        | A20 
        | A21 
        | A30 
        | A31 
        | A40 
        | A50 -> 5m,0m
        | _ -> 1m,1m

    member x.What = 
        let d1,d2,_,_,_,_,_,_,_ = ProductType.ctx x in
        let s1 = (if d1 < 10 then sprintf "0%d" else sprintf "%d") d1
        let s2 = (if d2 < 10 then sprintf "0%d" else sprintf "%d") d2
        sprintf "%s.%s" s1 s2
    
    member x.TempMin = let _,_,_,_,_,_,_,v,_ = ProductType.ctx x in v
    member x.TempMax = let _,_,_,_,_,_,_,_,v = ProductType.ctx x in v
    member x.Gas = let _,_,v,_,_,_,_,_,_ = ProductType.ctx x in v
    member x.Scale = let _,_,_,v,_,_,_,_,_ = ProductType.ctx x in v
    member x.K4 = let _,_,_,_,v,_,_,_,_ = ProductType.ctx x in v
    member x.K14 = let _,_,_,_,_,v,_,_,_ = ProductType.ctx x in v
    member x.K45 = let _,_,_,_,_,_,v,_,_ = ProductType.ctx x in v

    member x.K35 = let v,_ = ProductType.ctx2 x in v
    member x.K50 = let _,v = ProductType.ctx2 x in v

    member x.IsCH = x.Gas <> CO2 
    member x.ErrorLimit conc = 
        if x.Gas=CH4 || x.Gas=C3H8 || x.Scale=Sc4 then 2.5m+0.05m*( abs conc) 
        elif x.Scale=Sc10 then 0.5m
        elif x.Scale=Sc20 then 1m
        else 1m

[<AutoOpen>]
module private Helpers1 =
    let values = FSharpType.unionCasesList<ProductType> 
    ()

type ProductType with 

    static member values = values

    static member index x = 
        List.findIndex ((=) x) values