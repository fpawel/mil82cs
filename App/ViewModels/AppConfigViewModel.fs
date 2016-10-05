namespace Mil82.ViewModel

open System
open System.ComponentModel

open AppConfig

[<AbstractClass>]
type AppConfigViewModel() = 
    inherit ViewModelBase()

    [<Category("СОМ порты")>]    
    [<DisplayName("СОМ Приборы")>]
    [<Description("Имя СОМ порта, к которому подключены настраиваемые приборы чеерз преобразователь интерфейсов RS232, RS485")>]
    [<TypeConverter (typeof<ComportConfig.ComPortNamesConverter>) >]
    member x.ComportProducts
        with get() = config.ComportProducts.PortName
        and set v = 
            if v <> config.ComportProducts.PortName then
                config.ComportProducts.PortName <- v
                x.RaisePropertyChanged "ComportProducts"

    [<Category("СОМ порты")>]    
    [<DisplayName("СОМ пневмоблок")>]
    [<Description("Имя СОМ порта, к которому подключен пневмоблок")>]
    [<TypeConverter (typeof<ComportConfig.ComPortNamesConverter>) >]
    member x.ComportPneumo
        with get() = config.ComportPneumo.PortName
        and set v = 
            if v <> config.ComportPneumo.PortName then
                config.ComportPneumo.PortName <- v
                x.RaisePropertyChanged "ComportPneumo"

    [<Category("СОМ порты")>]    
    [<DisplayName("СОМ термокамера")>]
    [<Description("Имя СОМ порта, к которому подключена термокамера")>]
    [<TypeConverter (typeof<ComportConfig.ComPortNamesConverter>) >]
    member x.ComportTermo
        with get() = config.ComportTermo.PortName
        and set v = 
            if v <> config.ComportTermo.PortName then
                config.ComportTermo.PortName <- v
                x.RaisePropertyChanged "ComportTermo"

    [<Category("СОМ порты")>]    
    [<DisplayName("СОМ подогрев плат")>]
    [<Description("Имя СОМ порта, к которому подключено устройства подогрева плат")>]
    [<TypeConverter (typeof<ComportConfig.ComPortNamesConverter>) >]
    member x.ComportOven
        with get() = config.ComportOven.PortName
        and set v = 
            if v <> config.ComportOven.PortName then
                config.ComportOven.PortName <- v
                x.RaisePropertyChanged "ComportOven"

    
    [<DisplayName("Используемые коэффициенты")>]
    [<Description("Диаипазоны порядковых номеров используемых коэффициентов")>]
    member x.VisibleCoefs 
        with get() = config.View.VisibleCoefs
        and set v = 
            if v <> config.View.VisibleCoefs then
                config.View.VisibleCoefs <- v
                x.RaisePropertyChanged "VisibleCoefs"

    [<DisplayName("Опрос")>]
    [<Description("Опрашиваемые параметры прибора")>]
    member val SelectPhysVars = SelectPhysVars()
    

    