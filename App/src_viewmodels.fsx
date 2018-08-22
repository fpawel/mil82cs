#load "Utils/FsharpRuntime.fs"
#load "Utils/State.fs"
#load "Utils/StrUtils.fs"
#load "Utils/PathUtils.fs"
#load "Utils/DateTimeUtils.fs"
#load "Utils/Logging.fs"
#load "Utils/Utils.fs"
#load "Mil82/Coef.fs"
#load "Mil82/ProductType.fs"
#load "Mil82/Mil82.fs"

open Mil82

let createSourcefile path (source : string []) = 
    System.IO.File.WriteAllLines (__SOURCE_DIRECTORY__ + "/" + path, source)

let fkef (k:Coef) = 
    printfn "| [<Coef(%d, %A)>]" k.Order k.Description
    printfn "  %A" k

let kefss() = 
    List.iter fkef Coef.coefs

let createSourceFile_ProductViewModel() = 
  [|  
    yield """namespace Mil82.ViewModel

open Mil82

type Product(p, getProdType, getPgs, partyId) =

    inherit ViewModel.Product1(p, getProdType, getPgs, partyId) 
    override x.RaisePropertyChanged propertyName = 
        ViewModelBase.raisePropertyChanged x propertyName"""

    for f in Feature.values do
        for v in PhysVar.values do
            for gas in ScalePt.values do
                for t in TermoPt.values do
                    let k1 = 
                        sprintf "(Feature.%s, PhysVar.%s, ScalePt.%s, TermoPt.%s)" 
                            (Feature.name f) (PhysVar.name v) (ScalePt.name gas) (TermoPt.name t)
                    yield sprintf """
    member x.%s
        with get () = x.getVarUi %s
        and set value = x.setVarUi %s value"""  (Property.var (f,v,gas,t)) k1 k1 
        
    for gas in ScalePt.values do
        yield sprintf """
    member x.%s = x.GetConcError ScalePt.%s """  (Property.concError gas) (ScalePt.name gas) 
        yield sprintf """
    member x.%s = x.GetRetNkuError ScalePt.%s """  (Property.retNkuError gas) (ScalePt.name gas) 

        yield sprintf """
    member x.%s = x.GetTex1Error ScalePt.%s """  (Property.tex1Error gas) (ScalePt.name gas) 

        yield sprintf """
    member x.%s = x.GetTex2Error ScalePt.%s """  (Property.tex2Error gas) (ScalePt.name gas) 

        for t in TermoPt.values do
            yield sprintf """
    member x.%s = x.GetTermoError (ScalePt.%s, TermoPt.%s) """  
                    (Property.termoError (gas,t) ) 
                    (ScalePt.name gas) 
                    (TermoPt.name t)  
    for var in PhysVar.values do
        let name = PhysVar.name var
        yield sprintf """
    member x.%s = x.getPhysVarValueUi PhysVar.%s """  
                    name
                    name |]

    |> createSourcefile "ViewModels/ProductViewModel.fs" 

let createSourceFile_PartyViewModel() = 
  [|  
    yield """namespace Mil82.ViewModel
open System
open System.ComponentModel
open Mil82

type Party(partyHeader, partyData) =

    inherit ViewModel.Party1(partyHeader, partyData) 
    override x.RaisePropertyChanged propertyName = 
        ViewModelBase.raisePropertyChanged x propertyName"""

    
        
    for gas in ScalePt.values do
        let whatPgs = ScalePt.what gas
        let whatScale = ScalePt.whatScale gas
        let name = ScalePt.name gas
        yield sprintf """
    [<Category("Концентрация ПГС")>] 
    [<DisplayName("%s")>]    
    [<Description("Концентрация %s, %s")>]
    member x.%s
        with get() = x.GetPgs ScalePt.%s
        and set v = x.SetPgs (ScalePt.%s, v) """  whatPgs whatPgs whatScale name name name
        
    for t in TermoPt.values  do
        let what = TermoPt.what t
        let descr = TermoPt.dscr t
        let name = TermoPt.name t

        yield sprintf """
    [<Category("Температура")>] 
    [<DisplayName("%s")>]    
    [<Description("%s")>]
    member x.%s 
        with get() = x.GetTermoTemperature TermoPt.%s
        and set v = x.SetTermoTemperature (TermoPt.%s,v) """  
                what descr name name name  |]
    |> createSourcefile "ViewModels/PartyViewModel.fs" 

createSourceFile_ProductViewModel()
createSourceFile_PartyViewModel()


