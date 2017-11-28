namespace Mil82

open System
open System.ComponentModel
open System.Text.RegularExpressions

type CoefAttribute(n : int, s: string) =
    inherit Attribute()
    member __.N = n
    member __.S = s


type Coef = 
    | [<Coef(0, "Номер версии ПО ДАК")>]
      CoefVerPo
    | [<Coef(1, "Номер исполнения ДАК")>]
      CoefPriborType
    | [<Coef(2, "Год выпуска ДАК")>]
      CoefYear
    | [<Coef(3, "Серийный номер ДАК")>]
      CoefSerNumberDAK
    | [<Coef(4, "Максимальное число регистров в таблице регистров прибора")>]
      CoefMaxCountReg
    | [<Coef(5, "Единицы измерения")>]
      CoefEdIzmer1
    | [<Coef(6, "Величина, измеряемая")>]
      CoefGasType1
    | [<Coef(7, "Диапазон измерений канала 1 (0-0,2 % об)")>]
      CoefShkala1
    | [<Coef(8, "Начало шкалы")>]
      CoefPredelLo1
    | [<Coef(9, "Конец шкалы")>]
      CoefPredelHi1
    | [<Coef(10, "Значение ПГС1 (начало шкалы)")>]
      CoefPgsChNull
    | [<Coef(11, "Значение ПГС3 (конец шкалы)")>]
      CoefPgsChSens
    | [<Coef(12, "Коэффициент калибровки нуля")>]
      CoefCh0
    | [<Coef(13, "Коэффициент калибровки чувствительности")>]
      CoefChK
    | [<Coef(14, "Порог переключения постоянных времени НЧ фильтров")>]
      CoefKyskch
    | [<Coef(15, "Постоянная времени второго ФНЧ фильтра")>]
      CoefTFncCh

    | [<Coef(16, "Коэфф. при 0-ой степени кривой линеаризации")>]
      CoefCchlin0
    | [<Coef(17, "Коэфф. при первой степени кривой линеаризации")>]
      CoefCchlin1
    | [<Coef(18, "Коэфф. при второй степени кривой линеаризации")>]
      CoefCchlin2
    | [<Coef(19, "Коэфф. при третьей степени кривой линеаризации")>]
      CoefCchlin3

    | [<Coef(20, "")>]
      Coef20
    | [<Coef(21, "")>]
      Coef21
    | [<Coef(22, "")>]
      Coef22
    
    | [<Coef(23, "Коэфф. при 0-ой степени полинома коррекции нуля от температуры")>]
      CoefChtNull0
    | [<Coef(24, "Коэфф. при 1-ой степени полинома коррекции нуля от температуры")>]
      CoefChtNull1
    | [<Coef(25, "Коэфф. при 2-ой степени полинома коррекции нуля от температуры")>]
      CoefChtNull2
    
    | [<Coef(26, "Коэфф. при 0-ой степени полинома кор. чувств. от температуры")>]
      CoefKChtSens0
    | [<Coef(27, "Коэфф. при 1-ой степени полинома кор. чувств. от температуры")>]
      CoefKChtSens1
    | [<Coef(28, "Коэфф. при 2-ой степени полинома кор. чувств. от температуры")>]
      CoefKChtSens2
    
    | [<Coef(29, "Температура последней корректировку нуля в НКУ при настройке")>]
      CoefTcalzeroNku
    | [<Coef(30, "Коэффициент калибровки нуля канала СН в НКУ при настройке")>]
      CoefChNku0
    | [<Coef(31, "Время прогрева, мин")>]
      CoefHeatingTimeMin
    | [<Coef(32, "Флаг первого включения")>]
      CoefRestart
    | [<Coef(33, "Сетевой адрес")>]
      CoefSelfaddr
    | [<Coef(34, "Температура последней корректировки >0<")>]
      CoefTcalzero
    | [<Coef(35, "Флаг включения защиты от некорректной калибровки")>]
      CoefMadSafe
    | [<Coef(36, "Постоянная времени ФНЧ фильтра канала T")>]
      CoefTFncTT
    
    | [<Coef(37, "Коэфф. при 0-ой степени полинома кор. середины шкалы от температуры")>]
      CoefKChtMid0
    | [<Coef(38, "Коэфф. при 1-ой степени полинома кор. середины шкалы от температуры")>]
      CoefKChtMid1
    | [<Coef(39, "Коэфф. при 2-ой степени полинома кор. середины шкалы от температуры")>]
      CoefKChtMid2

    | [<Coef(40, "Серийный номер (1-ые 4 цифры) и год выпуска (последние 2 цифры) МИЛ-82")>]
      CoefSerialYearMil82

    | [<Coef(41, "Постоянная времени ФНЧ рабочего канала")>]
      CoefTFnc
    | [<Coef(42, "Добротность ПФ рабочего канала")>]
      CoefQ
    | [<Coef(43, "Нормировачный коэффициент для рабочего канала")>]
      CoefKw
    | [<Coef(44, "Нормировачный коэффициент для сравнительного канала")>]
      CoefKr
    | [<Coef(45, "Постоянная времени ФНЧ сравнительного канала")>]
      CoefCb
    | [<Coef(46, "Добротность ПФ сравнительного канала")>]
      CoefCc

    | [<Coef(47, "Номер исполнения (1-ые 4 цифры) и месяц изготовления (последние 2 цифры) МИЛ-82")>]
      CoefPriborTypeMonthMil82

    | CoefCustom of int * string * (string option)

    

    


[<AutoOpen>]
module private Helpers2 =
    open System.IO

    open Microsoft.FSharp.Reflection 

    let filename = IO.Path.Combine( IO.Path.ofExe, "coefs.config" )

    let predefCoefs1 =         
        FSharpType.GetUnionCases typeof<Coef> 
        |> Array.choose( fun case -> 
            if case.GetFields().Length = 0 then
                FSharpValue.MakeUnion(case,[||]) :?> Coef |> Some 
            else None)

    let attr1 = FSharpValue.tryGetUnionCaseAttribute<CoefAttribute,Coef> >> Option.get

    let order1 = function
        | CoefCustom (n,_,_) -> n
        | x -> (attr1 x).N

    let customCoefs1 = 
        if File.Exists filename |> not then  [||] else
        File.ReadAllLines filename 
        |> Array.choose (fun s -> 
            let m = Regex.Match(s, @"^(\d+)\s+(\w+)\s*([^$]*)$")
            if not m.Success then None else 
            let (~%%) (n:int) = m.Groups.[n].Value
            let n = Int32.Parse (%% 1)
            let coef = %% 2
            let descr = (%% 3).Trim()
            let descr = if String.IsNullOrEmpty descr then None else Some descr
            Some(CoefCustom(n, coef, descr)) ) 
        |> Array.filter(fun coef -> 
            predefCoefs1 
            |> Array.exists(fun coefx -> order1 coefx = order1 coef) 
            |> not )

    
    let  descr1 = function
        | CoefCustom (_, _, Some s) -> s
        | CoefCustom (_, s, _) -> s
        | x -> (attr1 x).S

    let orderToCoefMap = 
        Array.append customCoefs1 predefCoefs1 
        |> Array.map (fun x -> order1 x, x)
        |> Map.ofArray

    let coefToOrderMap = 
        orderToCoefMap |> Map.toList |> List.map revpair |> Map.ofList

    let coefs = orderToCoefMap |> Map.toList |> List.map snd

    let predefCoefs = Array.toList predefCoefs1

    

type Coef with
    member x.Order = 
        match x with
        | CoefCustom (n,_,_) -> n
        | _ -> coefToOrderMap.[x]

    member x.Description = 
        match x with
        | CoefCustom (_, _, Some s) -> s
        | CoefCustom (_, s, _) -> s
        | _ -> (attr1 x).S

    member x.Reg = 224 + 2 * x.Order
    member x.Cmd = ( 0x80 <<< 8 ) + x.Order


    static member order (x:Coef) = x.Order
    static member readReg x = 224 + 2 * Coef.order x
    static member writeCmd x = ( 0x80 <<< 8 ) + Coef.order x
    static member coefs = coefs

    static member tryGetByOrder = orderToCoefMap.TryFind 