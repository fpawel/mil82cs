module atool

open Mil82
open System

type ProductKey =
    | V of Mil82.Var
    | K of Mil82.Coef

[<AutoOpen>]
module private Help1 = 

    let convFuncs xs = 
        let xToStr x = Map.ofList xs |> Map.find x
        let strToX str = xs |> List.map( function(x,y) -> y,x) |> Map.ofList |> Map.find str
        xToStr, strToX
        
    let coefToStr, _ =         
        Mil82.Coef.coefs
            |> List.map(fun k -> 
                let n = sprintf "%d" k.Order
                let s = if k.Order < 10 then "0"+n else n
                k, "K"+s)
            |> convFuncs

    let toFloat = System.Decimal.ToDouble

    let termoPtStr = function
        | TermoLow -> "t_low"
        | TermoNorm -> "t_norm"
        | TermoHigh -> "t_high"
        | Termo90 -> "t90"

    type StrFloatMap = Map<string, double>
    
    let prodKeys = 
        let xs = ResizeArray<ProductKey*string>()

        let keyGasVar (gas:ScalePt) (v:PhysVar) = 
            sprintf "gas%d_var%d" gas.Code v.Code

        for gas in ScalePt.values do
            xs.Add(V(Lin, Conc, gas, TermoNorm), sprintf "lin%d" gas.Code)

        let gases = [ScaleBeg; ScaleMid; ScaleEnd]

        for t in [TermoLow; TermoNorm; TermoHigh; Termo90] do
            for gas in gases do
                for v in PhysVar.values do                    
                    xs.Add(V(Termo, v, gas, t), sprintf "%s_%s" (termoPtStr t) (keyGasVar gas v) )

        for t in [TermoLow; TermoNorm; TermoHigh] do
            for gas in gases do
                for v in PhysVar.values do  
                    let key x = sprintf "%s_%s_%s" x (termoPtStr t) (keyGasVar gas v)
                    xs.Add(V(Test, v, gas, t), key "test")
                    xs.Add(V(RetNku, v, gas, t), sprintf "test2_%s" (keyGasVar gas v) )
                    xs.Add(V(Tex1, v, gas, t), key "tex1" )
                    xs.Add(V(Tex2, v, gas, t), key "tex2" )

        for k in Coef.coefs do
            xs.Add(K k, coefToStr k)
        
        xs.ToArray() 
        |> Array.toList

    let prodKeyToStr, strToProdKey = 
        convFuncs prodKeys

    let unixEpoch = DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)

    //let datetimeFromUnixTime(unixTime) =     
    //    unixEpoch.AddSeconds(unixTime)
    
    
    //let datetimeToUnixTime(date:DateTime) =     
    //    Convert.ToInt64((date - unixEpoch).TotalSeconds)
    

type Product = 
    {   Addr : byte
        Serial : int
        Device : string
        Values : StrFloatMap
    }
    static member Export(x:Mil82.Product) = 
        let n = Mil82.Product.getProductInfo x

        let xs = System.Collections.Generic.Dictionary<string,double>()

        for k,str in prodKeys do            
            match k with
            | V v -> x.VarValue.TryFind v
            | K k -> x.CoefValue.TryFind k                    
            |> Option.iter(fun value -> xs.Add(str, toFloat value) )
               
        {   Addr = x.Addr
            Serial = n.serial
            Device = "МИЛ-82"
            Values = xs
                |> Seq.map (|KeyValue|)
                |> Map.ofSeq
        }

type Party = 
    {   ProductType : string
        Name : string
        Values : StrFloatMap
        Products : Product list
    }

    static member New( (h,d):Mil82.Party.Content) =
        {   ProductType = h.ProductType.What
            Name = h.Name
            Values = 
                ScalePt.values
                |> List.choose( fun gas -> 
                    d.BallonConc.TryFind gas
                    |> Option.map(fun v -> sprintf "c%d" gas.Code, toFloat v))
                |> Map.ofList
            Products = List.map Product.Export d.Products
        }

