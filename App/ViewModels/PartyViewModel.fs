namespace Mil82.ViewModel
open System
open System.ComponentModel
open Mil82

type Party(partyHeader, partyData) =

    inherit ViewModel.Party1(partyHeader, partyData) 
    override x.RaisePropertyChanged propertyName = 
        ViewModelBase.raisePropertyChanged x propertyName

    [<Category("Концентрация ПГС")>] 
    [<DisplayName("ПГС1")>]    
    [<Description("Концентрация ПГС1, начало шкалы")>]
    member x.ScaleBeg
        with get() = x.GetPgs ScalePt.ScaleBeg
        and set v = x.SetPgs (ScalePt.ScaleBeg, v) 

    [<Category("Концентрация ПГС")>] 
    [<DisplayName("ПГС2")>]    
    [<Description("Концентрация ПГС2, середина шкалы 2")>]
    member x.ScaleMid2
        with get() = x.GetPgs ScalePt.ScaleMid2
        and set v = x.SetPgs (ScalePt.ScaleMid2, v) 

    [<Category("Концентрация ПГС")>] 
    [<DisplayName("ПГС3")>]    
    [<Description("Концентрация ПГС3, середина шкалы")>]
    member x.ScaleMid
        with get() = x.GetPgs ScalePt.ScaleMid
        and set v = x.SetPgs (ScalePt.ScaleMid, v) 

    [<Category("Концентрация ПГС")>] 
    [<DisplayName("ПГС4")>]    
    [<Description("Концентрация ПГС4, конец шкалы")>]
    member x.ScaleEnd
        with get() = x.GetPgs ScalePt.ScaleEnd
        and set v = x.SetPgs (ScalePt.ScaleEnd, v) 

    [<Category("Температура")>] 
    [<DisplayName("НКУ")>]    
    [<Description("Нормальная температура")>]
    member x.TermoNorm 
        with get() = x.GetTermoTemperature TermoPt.TermoNorm
        and set v = x.SetTermoTemperature (TermoPt.TermoNorm,v) 

    [<Category("Температура")>] 
    [<DisplayName("T-")>]    
    [<Description("Пониженная температура")>]
    member x.TermoLow 
        with get() = x.GetTermoTemperature TermoPt.TermoLow
        and set v = x.SetTermoTemperature (TermoPt.TermoLow,v) 

    [<Category("Температура")>] 
    [<DisplayName("T+")>]    
    [<Description("Повышенная температура")>]
    member x.TermoHigh 
        with get() = x.GetTermoTemperature TermoPt.TermoHigh
        and set v = x.SetTermoTemperature (TermoPt.TermoHigh,v) 

    [<Category("Температура")>] 
    [<DisplayName("+90")>]    
    [<Description("Температура +90\"C")>]
    member x.Termo90 
        with get() = x.GetTermoTemperature TermoPt.Termo90
        and set v = x.SetTermoTemperature (TermoPt.Termo90,v) 
