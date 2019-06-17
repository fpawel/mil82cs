namespace Mil82.ViewModel

open System
open System.ComponentModel
open System.Collections.Generic

open Mil82

[<AutoOpen>]
module private ViewModelPartyHelpers =

    type PartyPath = Repository.PartyPath

    type P = Mil82.ViewModel.Product
    type Col = System.Windows.Forms.DataGridViewTextBoxColumn
    type Cols = System.Windows.Forms.DataGridViewColumnCollection

    let getKefCol (p:P) =
        [ for c in MainWindow.gridKefs.Columns -> c ]
        |> List.filter ( fun c -> Object.ReferenceEquals(p, c.Tag) ) 
        |> List.head

    let removeKefCol p =
        MainWindow.gridKefs.Columns.Remove (getKefCol p)

    let updKef (p:P) (colIndex:int) (kef : Coef) = 
        let n = kef.Order
        let row = MainWindow.getRowOfCoef kef

        let cell = row.Cells.[colIndex]
        let value = p.getKefUi kef
        if cell.Value=null || (string) cell.Value <> value then
            row.Cells.[colIndex].Value <- value

    let createProductViewModel getPgs productType partyId p  = 

        let col = new Col(HeaderText = Mil82.Product.what p, Visible = p.IsChecked)
        MainWindow.gridKefs.Columns.Add( col ) |> ignore
        let x = ViewModel.Product(p, productType, getPgs, partyId)     
        Runtime.PropertyChanged.add x <| fun e ->
            match e.PropertyName with
            | "IsChecked" -> col.Visible <- x.IsChecked
            | "What" -> col.HeaderText <- x.What
            | _ -> ()

        x.CoefValueChanged.Add(fun (_, coef, _) -> 
            updKef x col.Index coef
            )
                
        Mil82.Coef.coefs |> List.iter( updKef x col.Index )
        col.Tag <- x
        x


type ProductTypesConverter() = 
    inherit StringConverter()
    override this.GetStandardValuesSupported _ = true
    override this.GetStandardValuesExclusive _ = true
    override this.GetStandardValues _ =       
        ProductType.values
        |> Seq.toArray
        |> Array.map( fun x -> x.What)
        |> TypeConverter.StandardValuesCollection
        
[<AbstractClass>]
type Party1
        (   partyHeader:Mil82.Party.Head, 
            partyData : Mil82.Party.Data ) =
    inherit ViewModelBase() 

    let mutable partyHeader = partyHeader
    let mutable partyData = partyData
    let productType() = partyHeader.ProductType 
    let getPgs gas = Party.ballonConc gas partyData.BallonConc
    
    let products, setProducts = 
        let x = BindingList<P>()
        let setProducts xs = 
            x.Clear()
            xs |> List.map (createProductViewModel getPgs productType (PartyPath.fromPartyHead partyHeader))
            |> List.iter x.Add
        setProducts partyData.Products
        x, setProducts
    let getProducts() = products |> Seq.map(fun x -> x.Product) |> Seq.toList
    let updateProductsTypeAlchemy() = 
        for p in products do
            p.ForceCalculateErrors()

    let getChecked() =
        let xs = getProducts()
        if xs |> List.forall( fun x -> x.IsChecked ) then Nullable<bool>(true) else
        if xs |> List.forall( fun x -> not x.IsChecked ) then Nullable<bool>(false) else
        Nullable<bool>()
    let mutable productsChecked = Nullable<bool>()

    let setMainWindowTitle() = 
        MainWindow.form.Text <- 
            sprintf "Партия %s %s %A ПГС1=%M ПГС2=%M ПГС3=%M" 
                (DateTime.format "dd/MM/yy" partyHeader.Date)
                partyHeader.ProductType.What  
                partyHeader.Name
                (getPgs ScaleBeg) (getPgs ScaleMid) (getPgs ScaleEnd)
  
    do
        setMainWindowTitle()

    let addLoggingEvent = new Event<_>()

    [<Browsable(false)>]
    member private __.AddLoggingEvent = addLoggingEvent

    [<CLIEvent>]
    member __.OnAddLogging = addLoggingEvent.Publish
            
    [<Browsable(false)>]
    member __.Products = products

    [<Browsable(false)>]
    member x.Party 
        with get() = 
            let partyData = { partyData with Products = getProducts() }
            let partyHeader = 
                {   partyHeader with 
                        ProductInfo = 
                            partyData.Products 
                            |> List.map Product.getProductInfo }
            partyHeader, partyData
        and set ( otherHeader, otherPartyData) = 
            partyHeader <- otherHeader
            partyData <- otherPartyData
            products
            |> Seq.toList
            |> List.iter x.DeleteProduct
            setProducts otherPartyData.Products
            for gas in ScalePt.values do
                x.RaisePropertyChanged <| ScalePt.name gas
            for t in TermoPt.values do
                x.RaisePropertyChanged <| TermoPt.name t
            x.RaisePropertyChanged "ProductType"
            x.RaisePropertyChanged "Name"
            setMainWindowTitle()
            AppConfig.config.View.PartyId <- partyHeader.Id

    member __.NewValidAddr() = products |> Seq.map(fun x -> x.Addr)  |> Party.getNewValidAddy
    
    member x.AddNewProduct() = 
        Alchemy.createNewProduct (x.NewValidAddr()) x.GetPgs partyHeader.ProductType
        |> createProductViewModel getPgs productType (PartyPath.fromPartyHead partyHeader)
        |> products.Add 
        
    member __.DeleteProduct(product) = 
        let r = products.Remove( product )
        if not r then            
            failwith "Mil82.ViewModel.Party.DeleteProduct : missing element"
        removeKefCol product

    member x.UpdateProductsTypeAlchemy _ = updateProductsTypeAlchemy()
    member x.HasOneCheckedProduct() =
        products
        |> Seq.exists( fun p -> p.IsChecked )
    member x.HasNotOneCheckedProduct() =
        products
        |> Seq.exists( fun p -> p.IsChecked )
        |> not

    member x.DuplicationOfAddr() =
        let xs = HashSet<byte>()
        for p in products do
            let mutable n = 0
            for pp in products do   
                if p.Addr = pp.Addr then 
                    n <- n + 1
                    if n > 1 then
                        xs.Add(p.Addr) |> ignore
        if xs.Count = 0 then None else 
        Seq.toStr ", " string xs 
        |> sprintf "дублирование адресов: %s"
        |> Some


    member x.SetPgs (gas,value) =
        if Some value <>  partyData.BallonConc.TryFind gas then
            partyData <- { partyData with BallonConc = Map.add gas value partyData.BallonConc }
            x.RaisePropertyChanged <| ScalePt.name gas
            setMainWindowTitle()
            updateProductsTypeAlchemy()

    member x.SetTermoTemperature (t,value) =
        if Some value <>  partyData.TermoTemperature.TryFind t then
            partyData <- { partyData with TermoTemperature = Map.add t value partyData.TermoTemperature }
            x.RaisePropertyChanged <| TermoPt.name t

    member __.GetPgs pgs = getPgs pgs
    
    member __.GetTermoTemperature t = 
        Party.getTermoTemperature partyData t

    member x.ComputeKefGroup kefGroup = 
        products 
        |> Seq.filter(fun p -> p.IsChecked)
        |> Seq.iter( fun p ->
            p.Product <- 
                runState (Alchemy.compute kefGroup getPgs partyHeader.ProductType ) p.Product
                |> snd )

    member __.getProductType() = partyHeader.ProductType

    member x.``перевод климатики``() = 
        for p in x.Products do
            p.``перевод климатики``()

    [<Category("Партия")>]
    [<DisplayName("Исполнение")>]    
    [<Description("Исполнение приборов партии")>]
    [<TypeConverter (typeof<ProductTypesConverter>) >]
    member x.ProductType 
        with get() = partyHeader.ProductType.What
        and set v = 
            if v <> x.ProductType then
                let t = 
                    ProductType.values 
                    |> List.tryFind( fun t -> t.What = v)
                    |> Option.withDefault A00
                partyHeader <- { partyHeader with ProductType = t}
                x.RaisePropertyChanged "ProductType"
                setMainWindowTitle()
                updateProductsTypeAlchemy()
            
    [<Category("Партия")>]
    [<DisplayName("Наименование")>]    
    [<Description("Наименование партии")>]
    member x.Name 
        with get() = partyHeader.Name
        and set v = 
            if v <> x.Name then
                partyHeader <- { partyHeader with Name = v}
                x.RaisePropertyChanged "Name"
                setMainWindowTitle()

    [<Browsable(false)>]
    member x.Journal 
        with get() = partyData.PerformingJournal
        and set value =
            if value <> partyData.PerformingJournal then
                partyData <- { partyData with PerformingJournal =  value }
                x.RaisePropertyChanged "Journal"
    
[<AutoOpen>]
module private RunInfoHelpers =
    let private getHash (x:string) = x.GetHashCode()
    let now() = Some DateTime.Now
    let upd op y (x:Party1) = 
        x.Journal <- Map.add (getHash op) y x.Journal
    let tryGetOp op (x:Party1) = x.Journal.TryFind (getHash op)
    let getOp x party  = tryGetOp x party |> Option.getWithf PerformingOperation.createNew

type Party1 with
    
    member x.TryGetLogOperation operation  = tryGetOp operation x
    member x.GetLogOperation operation  = getOp operation x

    member x.LogStartOperation operation  = 
        upd operation  { RunStart = now(); RunEnd = None; LoggingRecords = []} x

    member x.LogStopOperation operation =
        upd operation { getOp operation x  with RunEnd = now() } x
    
    member x.WriteJournal operation level text = 
        let perfOp = getOp operation x
        upd operation { perfOp with LoggingRecords = (DateTime.Now,level,text)::perfOp.LoggingRecords } x
        x.AddLoggingEvent.Trigger (operation,level,text)