namespace  Mil82.ViewModel

open System
open System.Text.RegularExpressions

open Mil82
open Mil82.Alchemy

[<AutoOpen>]
module private ViewModelProductHelpers =
    type P = Mil82.Product
    let appCfg = AppConfig.config
    type PSr = Chart.ProductSeriesInfo


type private K = PhysVarValues.K

[<AbstractClass>]
type Product1(p : P, getProductType, getPgs, partyId) =
    inherit ViewModelBase()    
    let mutable p = p

    let mutable connection : Result<string,string> option = None
    
    let getConcError scalePt = P.concError (getProductType()) (getPgs scalePt) scalePt p
    let getTex1Error scalePt = P.tex1Error (getProductType()) (getPgs scalePt) scalePt p
    let getTex2Error scalePt = P.tex2Error (getProductType()) (getPgs scalePt) scalePt p

    let getTermoError (scalePt,termoPt) = P.termoError (getProductType()) (getPgs scalePt) (scalePt,termoPt) p

    let getConcErrors() = 
        ScalePt.values 
        |> List.map(fun gas -> gas, getConcError gas )
        |> Map.ofList
            
    let getTermoErrors() = 
        Vars.gas_t_vars 
        |> List.map(fun var -> var, getTermoError var )
        |> Map.ofList

    let getVarsValues() = 
        Vars.vars
        |> List.map(fun ctx -> ctx, P.getVar ctx p )
        |> Map.ofList

    let getKefsValues() = 
        Coef.coefs
        |> List.map(fun ctx -> ctx, P.getKef ctx p )
        |> Map.ofList

    let mutable physVar = Map.empty

    let coefValueChangedEvent = Event<Product1 * Coef * decimal option >()
    
    [<CLIEvent>]
    member x.CoefValueChanged = coefValueChangedEvent.Publish

    member x.setPhysVarValue var value =        
        PhysVarValues.addValue {K.Party = partyId; K.Product = p.Id; K.Var = var } value
        MainWindow.form.PerformThreadSafeAction <| fun () ->
            Chart.addProductValue p.Id var value
        if Map.tryFind var physVar <> Some value then
            physVar <- Map.add var value physVar
            x.RaisePropertyChanged <| PhysVar.name var
            

    member x.getPhysVarValueUi var =
        Map.tryFind var physVar
        |> Option.map Decimal.toStr6
        |> Option.getWith ""

    member x.GetConcError = getConcError        

    member x.GetTex1Error = getTex1Error
    member x.GetTex2Error = getTex2Error

    member x.GetRetNkuError scalePt = 
        P.retNkuError (getProductType()) (getPgs scalePt) scalePt p
        
    member x.GetTermoError = getTermoError

    member x.Connection
        with get () = connection
        and set v = 
            if v <> connection then
                connection <- v
                x.RaisePropertyChanged "Connection"
                
    
    member x.IsChecked 
        with get () = p.IsChecked          
        and set v = 
            if v <> p.IsChecked then
                p <- { p with IsChecked = v}
                x.RaisePropertyChanged "IsChecked"
                if v then
                    Chart.addProductSeries
                        {   PSr.Product = p.Id
                            PSr.Party = partyId
                            PSr.Name = p.What}                
                else 
                    Chart.removeProductSeries p.Id |> ignore
    member x.Addr
        with get () = p.Addr          
        and set v = 
            if v <> p.Addr then
                p <- { p with Addr = v}
                x.RaisePropertyChanged "Addr"
                x.RaisePropertyChanged "What"
                Chart.setProductLegend p.Id x.What

    member x.ProdReady
        with get() =
            let i = p.ProductInfo
            i.month <> 0 && i.year <> 0 && i.kind <> 0
        and set v =
            if v<> x.ProdReady then
                let st = state { 
                    let year, month, kind = 
                        if v then 
                            let prodt =  getProductType() |> ProductType.index |> (+) 1 
                            let now = DateTime.Now in
                            now.Year - 2000, now.Month, prodt
                        else
                            0,0,0                    
                    do! { p.ProductInfo with 
                            year = year
                            month = month
                            kind = kind}
                        |> P.setProductInfo  } 
                in x.Product <- snd <| runState st p    
                x.RaisePropertyChanged "KindMonthYear"
                x.RaisePropertyChanged "ProdReady"

                
        

    member x.Serial
        with get () = p.ProductInfo.serial
        and set v = 
            if v <> p.ProductInfo.serial then
                let st = state { do! P.setProductInfo {p.ProductInfo with serial = v}} in
                    x.Product <- snd <| runState st p    
                Chart.setProductLegend p.Id x.What

    member x.KindMonthYear = 
        let i = p.ProductInfo
        sprintf "%d.%d.%d" i.kind i.month i.year 

    member x.ForceCalculateErrors() =
        let (~%%) = x.RaisePropertyChanged
        for gas in ScalePt.values do
            %% Property.concError gas 
            %% Property.retNkuError gas 
            %% Property.tex1Error gas 
            %% Property.tex2Error gas 
            for t in TermoPt.values do
                %% Property.termoError (gas,t) 

    
    member x.Product 
        with get () = p
        and set other =
            if p = other then () else
            let prevConcErrors =  getConcErrors()                
            let prevTermoError = getTermoErrors()
            let prevVarsValues = getVarsValues()
            let prevKefsValues = getKefsValues()
            
            
            p <- other

            let concErrors =  getConcErrors()
            let termoError = getTermoErrors()
            let varsValues = getVarsValues()
            let kefsValues = getKefsValues()

            ScalePt.values
            |> List.filter(fun gas -> prevConcErrors.[gas] <> concErrors.[gas] )
            |> List.iter (Property.concError >> x.RaisePropertyChanged)

            Vars.gas_t_vars 
            |> List.filter(fun var -> prevTermoError.[var] <> termoError.[var] )
            |> List.iter (Property.termoError >> x.RaisePropertyChanged) 

            Vars.vars
            |> List.filter(fun var -> prevVarsValues.[var] <> varsValues.[var] )
            |> List.iter (Property.var >> x.RaisePropertyChanged) 

            Coef.coefs
            |> List.filter(fun coef -> prevKefsValues.[coef] <> kefsValues.[coef] )
            |> List.iter (fun coef -> 
                coefValueChangedEvent.Trigger(x, coef, kefsValues.[coef]) )

            x.RaisePropertyChanged "Product"
            x.RaisePropertyChanged "What"
            x.RaisePropertyChanged "Serial"
            x.RaisePropertyChanged "KindMonthYear"
            x.RaisePropertyChanged "ProdReady"

    member x.What = P.what p

    member x.getKef kef = P.getKef kef p
    member x.setKef kef value =    
        if P.getKef kef p = value then () else
        let s = state{ do! P.setKef kef value}
        p <- runState s p |> snd
        coefValueChangedEvent.Trigger(x,kef,value)
        match kef with
        | CoefPriborTypeMonthMil82
        | CoefSerialYearMil82 -> 
            x.RaisePropertyChanged "Serial"
            x.RaisePropertyChanged "KindMonthYear"
            x.RaisePropertyChanged "ProdReady"
        | _ -> ()

    member x.getVar var = P.getVar var p
    member x.setVar ( (feat, physVar, scalePt, termoPt) as var) value =
        if P.getVar var p = value then () else
        let prevConcError = getConcError scalePt
        let prevTermoError = getTermoError (scalePt,termoPt)

        let s = state{ do! P.setVar var value}
        p <- runState s p |> snd
        var |> Property.var |> x.RaisePropertyChanged

        let newConcError = getConcError scalePt
        if newConcError <> prevConcError then
            scalePt |> Property.concError |> x.RaisePropertyChanged

        let newTermoError = getTermoError (scalePt,termoPt)
        if newTermoError <> prevTermoError then
            (scalePt,termoPt) |> Property.termoError |> x.RaisePropertyChanged

    member x.getKefUi kef = 
        P.getKef kef p 
        |> Option.map Decimal.toStr6
        |> Option.getWith ""

    member x.setKefUi kef value = 
        String.tryParseDecimal value
        |> x.setKef kef

    member x.getVarUi var = 
        P.getVar var p 
        |> Option.map Decimal.toStr6
        |> Option.getWith ""

    member x.setVarUi var value = 
        String.tryParseDecimal value
        |> x.setVar var

    
    member x.ReadModbus(ctx) = 
        let r = Mdbs.read3decimal appCfg.ComportProducts x.Addr (ReadContext.code ctx) (ReadContext.what ctx)
        match r, ctx with
        | Ok value, ReadVar var -> 
            x.setPhysVarValue var value
        | Ok value, ReadKef kef -> x.setKef kef (Some value)
        | _ -> ()

        x.Connection <- 
            r 
            |> Result.map(fun v -> sprintf "%s = %s" (ReadContext.what ctx) (Decimal.toStr6 v))
            |> Some 
        r

    member x.WriteModbus (ctx,value) = 
        let what = WriteContext.what ctx
        let r = Mdbs.write appCfg.ComportProducts x.Addr (WriteContext.code ctx) what value
        x.Connection <- 
            r 
            |> Result.map(fun v -> sprintf "%s <-- %s" (WriteContext.what ctx) (Decimal.toStr6 value))
            |> Some 
        r

    member x.ComputeKefGroup kefGroup = 
        x.Product <- snd <| runState (Alchemy.compute kefGroup getPgs (getProductType())) p