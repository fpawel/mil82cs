namespace Mil82.ViewModel
open System
open System.ComponentModel
open Mil82

type InterrogateConverter() =
    inherit MyWinForms.Converters.BooleanTypeConverter("Опрашивать", "Не опрашивать")

[<TypeConverter(typeof<ExpandableObjectConverter>)>]
type SelectPhysVars() = 
    let cfg = AppConfig.config.View 

    [<DisplayName("Конц.")>]
    [<Description("Концентрация")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Conc 
        with get() =
            Set.contains Conc cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Conc cfg.VisiblePhysVars            
            

    [<DisplayName("Iизл")>]
    [<Description("Ток излучателя")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Curr 
        with get() =
            Set.contains Curr cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Curr cfg.VisiblePhysVars            
            

    [<DisplayName("Var1")>]
    [<Description("Var1")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Var1 
        with get() =
            Set.contains Var1 cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Var1 cfg.VisiblePhysVars            
            

    [<DisplayName("Т\"С")>]
    [<Description("Температура")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Temp 
        with get() =
            Set.contains Temp cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Temp cfg.VisiblePhysVars            
            

    [<DisplayName("Uраб")>]
    [<Description("Рабочий канал")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Workk 
        with get() =
            Set.contains Workk cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Workk cfg.VisiblePhysVars            
            

    [<DisplayName("Uоп")>]
    [<Description("Опорный канал")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Refk 
        with get() =
            Set.contains Refk cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Refk cfg.VisiblePhysVars            

    [<DisplayName("Var8")>]
    [<Description("Var8")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Var8
        with get() =
            Set.contains Var8 cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Var8 cfg.VisiblePhysVars

    [<DisplayName("Var10")>]
    [<Description("Var10")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Var10
        with get() =
            Set.contains Var10 cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Var10 cfg.VisiblePhysVars

    [<DisplayName("Var200")>]
    [<Description("Var200")>]
    [<TypeConverter (typeof<InterrogateConverter>) >]
    member x.Var200
        with get() =
            Set.contains Var200 cfg.VisiblePhysVars 
        and set value =
            cfg.VisiblePhysVars <- 
                (if value then Set.add else Set.remove) Var200 cfg.VisiblePhysVars
            

    override x.ToString() = cfg.VisiblePhysVars |> Seq.toStr ", " PhysVar.what
