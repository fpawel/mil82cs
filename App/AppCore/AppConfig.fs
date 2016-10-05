module AppConfig

open System
open System.IO

open System
open System.Collections.ObjectModel
open System.ComponentModel
open System.ComponentModel.DataAnnotations
open System.Drawing.Design

open MyWinForms.Converters

module View = 
    type Grid =  
        {   mutable ColWidths : int list
            mutable ColumnHeaderHeight : int }

    type Config =  
        {   mutable PartyId : string
            mutable Grids : Map<string,Grid>   
            mutable ScnDetailTextSplitterDistance : int  
            mutable SelectedCoefs : string 
            mutable VisibleCoefs : string
            mutable VisiblePhysVars : Set<Mil82.PhysVar>
            
            }

[<TypeConverter(typeof<ExpandableObjectConverter>)>]
type ApplicatioConfig = 
    {   [<Category("Пневмоблок")>] 
        [<DisplayName("Адрес пневмоблока")>]
        [<Description("Адрес MODBUS пневмоблока")>]
        mutable PneumoAddy : byte

        [<Category("Пневмоблок")>] 
        [<DisplayName("Использовать")>]
        [<Description("Использовать пневмоблок при автоматической настройке")>]
        [<TypeConverter(typeof<YesNoConverter>)>]
        mutable UsePneumoblock : bool
        
        [<Category("СОМ порты")>]    
        [<DisplayName("Приборы")>]
        [<Description("Параметры приёмопередачи СОМ порта, к которому подключены настраиваемые приборы чеерз преобразователь интерфейсов RS232, RS485")>]
        ComportProducts : ComportConfig.Config
        
        [<Category("СОМ порты")>]    
        [<DisplayName("Пневмоблок")>]
        [<Description("Параметры приёмопередачи СОМ порта, к которому подключен пневмоблок")>]
        ComportPneumo : ComportConfig.Config

        [<Category("СОМ порты")>]    
        [<DisplayName("Термокамера")>]
        [<Description("Параметры приёмопередачи СОМ порта, к которому подключена термокамера")>]
        ComportTermo : ComportConfig.Config

        [<Category("СОМ порты")>]    
        [<DisplayName("Подогрев плат")>]
        [<Description("Параметры приёмопередачи СОМ порта, к которому подключено устройство подогрева плат")>]
        ComportOven : ComportConfig.Config

        [<Category("Термокомпенсация")>]    
        [<DisplayName("Таймаут перевода")>]
        [<Description("Максимальная длительность перевода термокамеры")>]
        mutable TermoWarmTimeOut : TimeSpan

        [<Category("Термокомпенсация")>]
        [<DisplayName("Погрешность перевода")>]
        [<Description("Погрешность перевода термокамеры, \"С")>]
        mutable TermoWarmError : decimal

        [<Category("Термокомпенсация")>] 
        [<DisplayName("Термокамера")>]
        [<Description("Использовать термокамеру при автоматической настройке термокомпенсации")>]
        [<TypeConverter(typeof<YesNoConverter>)>]
        mutable UseTermochamber : bool

        [<Category("Термокомпенсация")>] 
        [<DisplayName("Середина шкалы")>]
        [<Description("Выполнять снятие данных в середине шкалы при автоматической настройке термокомпенсации")>]
        [<TypeConverter(typeof<YesNoConverter>)>]
        mutable UseMidleScale : bool

        [<Category("Подогрев плат")>]
        [<DisplayName("Адрес MODBUS")>]
        [<Description("MODBUS адрес устройства подогрева плат")>]
        mutable WarmDeviceAddr : byte

        [<Category("Подогрев плат")>]
        [<DisplayName("Подогрев плат")>]
        [<Description("Использовать подогрев плат")>]
        [<TypeConverter(typeof<YesNoConverter>)>]
        mutable UseWarmBoard : bool

        [<Category("Подогрев плат")>]
        [<DisplayName("Температура включения подогрева плат, \"С")>]
        [<Description("Начало температурного диапазона работы устройства подогрева плат, \"С")>]
        mutable TemperatureWarmBoardOn : decimal

        [<Category("Подогрев плат")>]
        [<DisplayName("Температура выключения подогрева плат, \"С")>]
        [<Description("Конец температурного диапазона работы устройства подогрева плат, \"С")>]
        mutable TemperatureWarmBoardOff : decimal

        
        
        [<Browsable(false)>]
        View : View.Config  }
    static member create() = {   
        View = 
            {   PartyId = ""
                Grids = Map.empty
                ScnDetailTextSplitterDistance = 0 
                SelectedCoefs = "0-150"
                VisibleCoefs = "0-150"
                VisiblePhysVars = Set.ofList Mil82.PhysVar.values }
        PneumoAddy = 100uy
        UseMidleScale = false
        UsePneumoblock = true
        UseTermochamber = true
        TermoWarmTimeOut = TimeSpan.FromHours 4.
        TermoWarmError = 2m
        ComportProducts = ComportConfig.Config.withDescr "приборы"
        ComportPneumo = ComportConfig.Config.withDescr "пневмоблок"
        ComportTermo = ComportConfig.Config.withDescr "термокамера"
        ComportOven = ComportConfig.Config.withDescr "ОВЕН" 
        WarmDeviceAddr = 0x63uy
        UseWarmBoard = false
        TemperatureWarmBoardOn = -40m
        TemperatureWarmBoardOff = -30m }

let config, save = Json.Config.create "app.config.json" ApplicatioConfig.create