namespace Mil82

open System
open System.ComponentModel
open System.Text.RegularExpressions

type CoefAttribute(n : int, d : decimal, s: string option, x : unit ) =
    inherit Attribute()
    new  (n,v:int) = 
        CoefAttribute(n, decimal v ,None, ())
    new  (n, v, s) = 
        CoefAttribute(n, decimal v, Some s, ())
    member __.N = n
    member __.S = s
    member __.D = d 


type Coef = 
    | [<Coef(0, 1, "Номер версии ПО")>]
      CoefVerPo
    | [<Coef(1, 4, "Номер исполнения прибора")>]
      CoefPriborType
    | [<Coef(2, 2012, "Год выпуска")>]
      CoefYear
    | [<Coef(3, 0, "Серийный номер")>]
      CoefSerNumber
    | [<Coef(4, 668, "Максимальное число регистров в таблице регистров прибора")>]
      CoefMaxCountReg
    | [<Coef(5, 7, "Единицы измерения")>]
      CoefEdIzmer1
    | [<Coef(6, 7, "Величина, измеряемая")>]
      CoefGasType1
    | [<Coef(7, 2, "Диапазон измерений канала 1 (0-0,2 % об)")>]
      CoefShkala1
    | [<Coef(8, 0, "Начало шкалы")>]
      CoefPredelLo1
    | [<Coef(9, 100, "Конец шкалы")>]
      CoefPredelHi1
    | [<Coef(10, 0, "Значение ПГС1 (начало шкалы)")>]
      CoefPgsChNull
    | [<Coef(11, 94, "Значение ПГС3 (конец шкалы)")>]
      CoefPgsChSens
    | [<Coef(12, 0, "Коэффициент калибровки нуля")>]
      CoefCh0
    | [<Coef(13, -1, "Коэффициент калибровки чувствительности")>]
      CoefChK
    | [<Coef(14, 2, "Порог переключения постоянных времени НЧ фильтров")>]
      CoefKyskch
    | [<Coef(15, 200, "Постоянная времени второго ФНЧ фильтра")>]
      CoefTFncCh
    | [<Coef(16, 0, "Коэфф. при 0-ой степени кривой линеаризации")>]
      CoefCchlin0
    | [<Coef(17, 1, "Коэфф. при первой степени кривой линеаризации")>]
      CoefCchlin1
    | [<Coef(18, 0, "Коэфф. при второй степени кривой линеаризации")>]
      CoefCchlin2
    | [<Coef(19, 0, "Коэфф. при третьей степени кривой линеаризации")>]
      CoefCchlin3
    | [<Coef(20, 0)>] CoefRefKanal0
    | [<Coef(21, 0)>] CoefChKanal0
    | [<Coef(22, 0)>] CoefKpsCh
    | [<Coef(23, 0, "Коэфф. при 0-ой степени полинома коррекции нуля от температуры")>]
      CoefChtNull0
    | [<Coef(24, 0, "Коэфф. при 1-ой степени полинома коррекции нуля от температуры")>]
      CoefChtNull1
    | [<Coef(25, 0, "Коэфф. при 2-ой степени полинома коррекции нуля от температуры")>]
      CoefChtNull2
    | [<Coef(26, 1, "Коэфф. при 0-ой степени полинома кор. чувств. от температуры")>]
      CoefKChtSens0
    | [<Coef(27, 0, "Коэфф. при 1-ой степени полинома кор. чувств. от температуры")>]
      CoefKChtSens1
    | [<Coef(28, 0, "Коэфф. при 2-ой степени полинома кор. чувств. от температуры")>]
      CoefKChtSens2
    | [<Coef(29, 0, "Температура последней корректировку нуля в НКУ при настройке")>]
      CoefTcalzeroNku
    | [<Coef(30, 0, "Коэффициент калибровки нуля канала СН в НКУ при настройке")>]
      CoefChNku0
    | [<Coef(31, 10, "Время прогрева, мин")>]
      CoefHeatingTimeMin
    | [<Coef(32, 4012, "Флаг первого включения")>]
      CoefRestart
    | [<Coef(33, 1, "Сетевой адрес")>]
      CoefSelfaddr
    | [<Coef(34, 20, "Температура последней корректировки >0<")>]
      CoefTcalzero
    | [<Coef(35, 0, "Флаг включения защиты от некорректной калибровки")>]
      CoefMadSafe
    | [<Coef(36, 200, "Постоянная времени ФНЧ канала T")>]
      CoefTFncTT
    | [<Coef(37, 200, "Коэфф. при 0-ой степени полинома кор. середины шкалы от температуры")>]
      CoefKChtMid0
    | [<Coef(38, 10, "Коэфф. при 1-ой степени полинома кор. середины шкалы от температуры")>]
      CoefKChtMid1
    | [<Coef(39, 48, "Коэфф. при 2-ой степени полинома кор. середины шкалы от температуры")>]
      CoefKChtMid2
    | [<Coef(40, 96, "Задрж. вкл. компенс. дрейфа нуля п. перех. про-цесса изменения конц. Cch (1*1,25 с)")>]
      CoefTDelayDreyfCch
    | [<Coef(41, 30, "Постоянная времени ФНЧ рабочего канала")>]
      CoefTFnc
    | [<Coef(42, 10, "Добротность ПФ рабочего канала")>]
      CoefQ
    | [<Coef(43, 1, "Нормировочный коэффициент для рабочего канала")>]
      CoefKw
    | [<Coef(44, 1, "Нормировочный коэффициент для сравнительного канала")>]
      CoefKr
    | [<Coef(45, 0, "Постоянная времени ФНЧ сравнительного канала")>]
      CoefCb
    | [<Coef(46, 0, "Добротность ПФ сравнительного канала")>]
      CoefCc
    | [<Coef(47, 0, "не используется")>]
      CoefDa
    | [<Coef(48, 0, "Коэфф. при 3-ей степени полинома коррекции нуля от температуры")>]
      CoefDb
    | [<Coef(49, 0, "Коэфф. при 3-ей степени полинома кор. чувств. от температуры")>]
      CoefDc
    | [<Coef(50, 1, "Определяемое вещество")>]
      CoefSubstance
    | [<Coef(51, 0, "Пропан")>]
      CoefPolinom1
    | [<Coef(52, 0)>] CoefA1
    | [<Coef(53, 1)>] CoefB1
    | [<Coef(54, 0)>] CoefC1
    | [<Coef(55, 0)>] CoefD1
    | [<Coef(56, 1)>] CoefK1
    | [<Coef(57, 0, "Газ сжиженный")>]
      CoefPolinom2
    | [<Coef(58, 0)>] CoefA2
    | [<Coef(59, 1)>] CoefB2
    | [<Coef(60, 0)>] CoefC2
    | [<Coef(61, 0)>] CoefD2
    | [<Coef(62, 1)>] CoefK2
    | [<Coef(63, 0, "Этан")>]
      CoefPolinom3
    | [<Coef(64, 0)>] CoefA3
    | [<Coef(65, 1)>] CoefB3
    | [<Coef(66, 0)>] CoefC3
    | [<Coef(67, 0)>] CoefD3
    | [<Coef(68, 1)>] CoefK3
    | [<Coef(69, 0, "n-Бутан")>]
      CoefPolinomN4
    | [<Coef(70, 0)>] CoefA4
    | [<Coef(71, 1)>] CoefB4
    | [<Coef(72, 0)>] CoefC4
    | [<Coef(73, 0)>] CoefD4
    | [<Coef(74, 1)>] CoefK4
    | [<Coef(75, 0, "i-Бутан")>]
      CoefPolinomI5
    | [<Coef(76, 0)>] CoefA5
    | [<Coef(77, 1)>] CoefB5
    | [<Coef(78, 0)>] CoefC5
    | [<Coef(79, 0)>] CoefD5
    | [<Coef(80, 1)>] CoefK5
    | [<Coef(81, 0, "Пентан")>]
      CoefPolinom6
    | [<Coef(82, 0)>] CoefA6
    | [<Coef(83, 1)>] CoefB6
    | [<Coef(84, 0)>] CoefC6
    | [<Coef(85, 0)>] CoefD6
    | [<Coef(86, 1)>] CoefK6
    | [<Coef(87, 0, "Гексан")>]
      CoefPolinom7
    | [<Coef(88, 0)>] CoefA7
    | [<Coef(89, 1)>] CoefB7
    | [<Coef(90, 0)>] CoefC7
    | [<Coef(91, 0)>] CoefD7
    | [<Coef(92, 1)>] CoefK7
    | [<Coef(93, 0)>] CoefPolinom8
    | [<Coef(94, 0)>] CoefA8
    | [<Coef(95, 1)>] CoefB8
    | [<Coef(96, 0)>] CoefC8
    | [<Coef(97, 0)>] CoefD8
    | [<Coef(98, 1)>] CoefK8
    | [<Coef(99, 0)>] CoefPolinom9
    | [<Coef(100, 0)>] CoefA9
    | [<Coef(101, 1)>] CoefB9
    | [<Coef(102, 0)>] CoefC9
    | [<Coef(103, 0)>] CoefD9
    | [<Coef(104, 1)>] CoefK9
    | [<Coef(105, 0)>] CoefPolinom10
    | [<Coef(106, 0)>] CoefA10
    | [<Coef(107, 1)>] CoefB10
    | [<Coef(108, 0)>] CoefC10
    | [<Coef(109, 0)>] CoefD10
    | [<Coef(110, 1)>] CoefK10
    | [<Coef(111, 0)>] CoefPolinom11
    | [<Coef(112, 0)>] CoefA11
    | [<Coef(113, 1)>] CoefB11
    | [<Coef(114, 0)>] CoefC11
    | [<Coef(115, 0)>] CoefD11
    | [<Coef(116, 1)>] CoefK11
    | [<Coef(117, 0)>] CoefPolinom12
    | [<Coef(118, 0)>] CoefA12
    | [<Coef(119, 1)>] CoefB12
    | [<Coef(120, 0)>] CoefC12
    | [<Coef(121, 0)>] CoefD12
    | [<Coef(122, 1)>] CoefK12
    | [<Coef(123, 0)>] CoefPolinom13
    | [<Coef(124, 0)>] CoefA13
    | [<Coef(125, 1)>] CoefB13
    | [<Coef(126, 0)>] CoefC13
    | [<Coef(127, 0)>] CoefD13
    | [<Coef(128, 1)>] CoefK13
    | [<Coef(129, 0)>] CoefPolinom14
    | [<Coef(130, 0)>] CoefA14
    | [<Coef(131, 1)>] CoefB14
    | [<Coef(132, 0)>] CoefC14
    | [<Coef(133, 0)>] CoefD14
    | [<Coef(134, 1)>] CoefK14
    | [<Coef(135, 0)>] CoefPolinom15
    | [<Coef(136, 0)>] CoefA15
    | [<Coef(137, 1)>] CoefB15
    | [<Coef(138, 0)>] CoefC15
    | [<Coef(139, 0)>] CoefD15
    | [<Coef(140, 1)>] CoefK15
    | [<Coef(141, 0)>] CoefPolinom16
    | [<Coef(142, 0)>] CoefA16
    | [<Coef(143, 1)>] CoefB16
    | [<Coef(144, 0)>] CoefC16
    | [<Coef(145, 0)>] CoefD16
    | [<Coef(146, 1)>] CoefK16
    | [<Coef(147, 0)>] CoefPolinom17
    | [<Coef(148, 0)>] CoefA17
    | [<Coef(149, 1)>] CoefB17
    | [<Coef(150, 0)>] CoefC17
    | [<Coef(151, 0)>] CoefD17
    | [<Coef(152, 1)>] CoefK17
    | [<Coef(153, 0)>] CoefPolinom18
    | [<Coef(154, 0)>] CoefA18
    | [<Coef(155, 1)>] CoefB18
    | [<Coef(156, 0)>] CoefC18
    | [<Coef(157, 0)>] CoefD18
    | [<Coef(158, 1)>] CoefK18
    | [<Coef(159, 0)>] CoefPolinom19
    | [<Coef(160, 0)>] CoefA19
    | [<Coef(161, 1)>] CoefB19
    | [<Coef(162, 0)>] CoefC19
    | [<Coef(163, 0)>] CoefD19
    | [<Coef(164, 1)>] CoefK19
    | [<Coef(165, 0)>] CoefPolinom20
    | [<Coef(166, 0)>] CoefA20
    | [<Coef(167, 1)>] CoefB20
    | [<Coef(168, 0)>] CoefC20
    | [<Coef(169, 0)>] CoefD20
    | [<Coef(170, 1)>] CoefK20
    | [<Coef(171, 0)>] CoefLinSub0
    | [<Coef(172, 1)>] CoefLinSub1
    | [<Coef(173, 0)>] CoefLinSub2
    | [<Coef(174, 0)>] CoefLinSub3
    | [<Coef(175, 0)>] CoefPolinom

[<AutoOpen>]
module private Helpers1 =
    let coefs = FSharpType.unionCasesList<Coef>
    open System.IO
    type K = {
        n : int 
        s : string
        v : decimal }

    let filename = IO.Path.Combine( IO.Path.ofExe, "coefs.config" )

    let coefsCfg =
        if File.Exists filename |> not then Map.empty else
        IO.File.ReadAllLines filename 
        |> Array.choose (fun s -> 
            let m = Regex.Match(s, @"^(\d+)\s+(-?\d+)\s*([^$]*)$")
            if not m.Success then None else
            let (~%%) (n:int) = m.Groups.[n].Value
            let n = Int32.Parse     <| %% 1
            let v = Decimal.Parse   <| %% 2
            let s = %% 3
            let s = if String.IsNullOrEmpty s then None else Some s
            Some (n, ( s, v) ) )
        |> Map.ofArray

    let coefs1 = 
        coefs |> List.mapi(fun n coef -> 
            match FSharpValue.tryGetUnionCaseAttribute<CoefAttribute,Coef> coef with
            | None -> failwithf "Wrong Coef %d %A !" n coef
            | Some a -> 
                if a.N <> n then 
                    failwithf "Wrong number %A Coef %d %A - !" a.N n coef
                n, coef, a )
        |> List.map(fun (n, coef, a) -> 
            let s,d =
                match Map.tryFind n coefsCfg with
                | Some x -> x
                | None -> a.S, a.D
            coef, { s = s |> Option.getWith (sprintf "%A" coef ); v = d; n = n} )
        |> Map.ofList

    let coefs2 = 
        coefs1 
        |> Map.toList
        |> List.map(fun (coef,k) -> k.n, coef )
        |> Map.ofList

type Coef with
    member x.Order = coefs1.[x].n
    member x.Description = coefs1.[x].s
    member x.Reg = 224 + 2 * x.Order
    member x.Cmd = ( 0x80 <<< 8 ) + x.Order


    static member order (x:Coef) = x.Order
    static member readReg x = 224 + 2 * Coef.order x
    static member writeCmd x = ( 0x80 <<< 8 ) + Coef.order x
    static member coefs = coefs

    static member tryGetByOrder = coefs2.TryFind 