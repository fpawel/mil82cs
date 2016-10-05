namespace Mil82.ViewModel

open Mil82

type Product(p, getProdType, getPgs, partyId) =

    inherit ViewModel.Product1(p, getProdType, getPgs, partyId) 
    override x.RaisePropertyChanged propertyName = 
        ViewModelBase.raisePropertyChanged x propertyName

    member x.CoefVerPo
        with get () = x.getKefUi Coef.CoefVerPo
        and set value = x.setKefUi Coef.CoefVerPo value 

    member x.CoefPriborType
        with get () = x.getKefUi Coef.CoefPriborType
        and set value = x.setKefUi Coef.CoefPriborType value 

    member x.CoefYear
        with get () = x.getKefUi Coef.CoefYear
        and set value = x.setKefUi Coef.CoefYear value 

    member x.CoefSerNumber
        with get () = x.getKefUi Coef.CoefSerNumber
        and set value = x.setKefUi Coef.CoefSerNumber value 

    member x.CoefMaxCountReg
        with get () = x.getKefUi Coef.CoefMaxCountReg
        and set value = x.setKefUi Coef.CoefMaxCountReg value 

    member x.CoefEdIzmer1
        with get () = x.getKefUi Coef.CoefEdIzmer1
        and set value = x.setKefUi Coef.CoefEdIzmer1 value 

    member x.CoefGasType1
        with get () = x.getKefUi Coef.CoefGasType1
        and set value = x.setKefUi Coef.CoefGasType1 value 

    member x.CoefShkala1
        with get () = x.getKefUi Coef.CoefShkala1
        and set value = x.setKefUi Coef.CoefShkala1 value 

    member x.CoefPredelLo1
        with get () = x.getKefUi Coef.CoefPredelLo1
        and set value = x.setKefUi Coef.CoefPredelLo1 value 

    member x.CoefPredelHi1
        with get () = x.getKefUi Coef.CoefPredelHi1
        and set value = x.setKefUi Coef.CoefPredelHi1 value 

    member x.CoefPgsChNull
        with get () = x.getKefUi Coef.CoefPgsChNull
        and set value = x.setKefUi Coef.CoefPgsChNull value 

    member x.CoefPgsChSens
        with get () = x.getKefUi Coef.CoefPgsChSens
        and set value = x.setKefUi Coef.CoefPgsChSens value 

    member x.CoefCh0
        with get () = x.getKefUi Coef.CoefCh0
        and set value = x.setKefUi Coef.CoefCh0 value 

    member x.CoefChK
        with get () = x.getKefUi Coef.CoefChK
        and set value = x.setKefUi Coef.CoefChK value 

    member x.CoefKyskch
        with get () = x.getKefUi Coef.CoefKyskch
        and set value = x.setKefUi Coef.CoefKyskch value 

    member x.CoefTFncCh
        with get () = x.getKefUi Coef.CoefTFncCh
        and set value = x.setKefUi Coef.CoefTFncCh value 

    member x.CoefCchlin0
        with get () = x.getKefUi Coef.CoefCchlin0
        and set value = x.setKefUi Coef.CoefCchlin0 value 

    member x.CoefCchlin1
        with get () = x.getKefUi Coef.CoefCchlin1
        and set value = x.setKefUi Coef.CoefCchlin1 value 

    member x.CoefCchlin2
        with get () = x.getKefUi Coef.CoefCchlin2
        and set value = x.setKefUi Coef.CoefCchlin2 value 

    member x.CoefCchlin3
        with get () = x.getKefUi Coef.CoefCchlin3
        and set value = x.setKefUi Coef.CoefCchlin3 value 

    member x.CoefRefKanal0
        with get () = x.getKefUi Coef.CoefRefKanal0
        and set value = x.setKefUi Coef.CoefRefKanal0 value 

    member x.CoefChKanal0
        with get () = x.getKefUi Coef.CoefChKanal0
        and set value = x.setKefUi Coef.CoefChKanal0 value 

    member x.CoefKpsCh
        with get () = x.getKefUi Coef.CoefKpsCh
        and set value = x.setKefUi Coef.CoefKpsCh value 

    member x.CoefChtNull0
        with get () = x.getKefUi Coef.CoefChtNull0
        and set value = x.setKefUi Coef.CoefChtNull0 value 

    member x.CoefChtNull1
        with get () = x.getKefUi Coef.CoefChtNull1
        and set value = x.setKefUi Coef.CoefChtNull1 value 

    member x.CoefChtNull2
        with get () = x.getKefUi Coef.CoefChtNull2
        and set value = x.setKefUi Coef.CoefChtNull2 value 

    member x.CoefKChtSens0
        with get () = x.getKefUi Coef.CoefKChtSens0
        and set value = x.setKefUi Coef.CoefKChtSens0 value 

    member x.CoefKChtSens1
        with get () = x.getKefUi Coef.CoefKChtSens1
        and set value = x.setKefUi Coef.CoefKChtSens1 value 

    member x.CoefKChtSens2
        with get () = x.getKefUi Coef.CoefKChtSens2
        and set value = x.setKefUi Coef.CoefKChtSens2 value 

    member x.CoefTcalzeroNku
        with get () = x.getKefUi Coef.CoefTcalzeroNku
        and set value = x.setKefUi Coef.CoefTcalzeroNku value 

    member x.CoefChNku0
        with get () = x.getKefUi Coef.CoefChNku0
        and set value = x.setKefUi Coef.CoefChNku0 value 

    member x.CoefHeatingTimeMin
        with get () = x.getKefUi Coef.CoefHeatingTimeMin
        and set value = x.setKefUi Coef.CoefHeatingTimeMin value 

    member x.CoefRestart
        with get () = x.getKefUi Coef.CoefRestart
        and set value = x.setKefUi Coef.CoefRestart value 

    member x.CoefSelfaddr
        with get () = x.getKefUi Coef.CoefSelfaddr
        and set value = x.setKefUi Coef.CoefSelfaddr value 

    member x.CoefTcalzero
        with get () = x.getKefUi Coef.CoefTcalzero
        and set value = x.setKefUi Coef.CoefTcalzero value 

    member x.CoefMadSafe
        with get () = x.getKefUi Coef.CoefMadSafe
        and set value = x.setKefUi Coef.CoefMadSafe value 

    member x.CoefTFncTT
        with get () = x.getKefUi Coef.CoefTFncTT
        and set value = x.setKefUi Coef.CoefTFncTT value 

    member x.CoefKChtMid0
        with get () = x.getKefUi Coef.CoefKChtMid0
        and set value = x.setKefUi Coef.CoefKChtMid0 value 

    member x.CoefKChtMid1
        with get () = x.getKefUi Coef.CoefKChtMid1
        and set value = x.setKefUi Coef.CoefKChtMid1 value 

    member x.CoefKChtMid2
        with get () = x.getKefUi Coef.CoefKChtMid2
        and set value = x.setKefUi Coef.CoefKChtMid2 value 

    member x.CoefTDelayDreyfCch
        with get () = x.getKefUi Coef.CoefTDelayDreyfCch
        and set value = x.setKefUi Coef.CoefTDelayDreyfCch value 

    member x.CoefTFnc
        with get () = x.getKefUi Coef.CoefTFnc
        and set value = x.setKefUi Coef.CoefTFnc value 

    member x.CoefQ
        with get () = x.getKefUi Coef.CoefQ
        and set value = x.setKefUi Coef.CoefQ value 

    member x.CoefKw
        with get () = x.getKefUi Coef.CoefKw
        and set value = x.setKefUi Coef.CoefKw value 

    member x.CoefKr
        with get () = x.getKefUi Coef.CoefKr
        and set value = x.setKefUi Coef.CoefKr value 

    member x.CoefCb
        with get () = x.getKefUi Coef.CoefCb
        and set value = x.setKefUi Coef.CoefCb value 

    member x.CoefCc
        with get () = x.getKefUi Coef.CoefCc
        and set value = x.setKefUi Coef.CoefCc value 

    member x.CoefDa
        with get () = x.getKefUi Coef.CoefDa
        and set value = x.setKefUi Coef.CoefDa value 

    member x.CoefDb
        with get () = x.getKefUi Coef.CoefDb
        and set value = x.setKefUi Coef.CoefDb value 

    member x.CoefDc
        with get () = x.getKefUi Coef.CoefDc
        and set value = x.setKefUi Coef.CoefDc value 

    member x.CoefSubstance
        with get () = x.getKefUi Coef.CoefSubstance
        and set value = x.setKefUi Coef.CoefSubstance value 

    member x.CoefPolinom1
        with get () = x.getKefUi Coef.CoefPolinom1
        and set value = x.setKefUi Coef.CoefPolinom1 value 

    member x.CoefA1
        with get () = x.getKefUi Coef.CoefA1
        and set value = x.setKefUi Coef.CoefA1 value 

    member x.CoefB1
        with get () = x.getKefUi Coef.CoefB1
        and set value = x.setKefUi Coef.CoefB1 value 

    member x.CoefC1
        with get () = x.getKefUi Coef.CoefC1
        and set value = x.setKefUi Coef.CoefC1 value 

    member x.CoefD1
        with get () = x.getKefUi Coef.CoefD1
        and set value = x.setKefUi Coef.CoefD1 value 

    member x.CoefK1
        with get () = x.getKefUi Coef.CoefK1
        and set value = x.setKefUi Coef.CoefK1 value 

    member x.CoefPolinom2
        with get () = x.getKefUi Coef.CoefPolinom2
        and set value = x.setKefUi Coef.CoefPolinom2 value 

    member x.CoefA2
        with get () = x.getKefUi Coef.CoefA2
        and set value = x.setKefUi Coef.CoefA2 value 

    member x.CoefB2
        with get () = x.getKefUi Coef.CoefB2
        and set value = x.setKefUi Coef.CoefB2 value 

    member x.CoefC2
        with get () = x.getKefUi Coef.CoefC2
        and set value = x.setKefUi Coef.CoefC2 value 

    member x.CoefD2
        with get () = x.getKefUi Coef.CoefD2
        and set value = x.setKefUi Coef.CoefD2 value 

    member x.CoefK2
        with get () = x.getKefUi Coef.CoefK2
        and set value = x.setKefUi Coef.CoefK2 value 

    member x.CoefPolinom3
        with get () = x.getKefUi Coef.CoefPolinom3
        and set value = x.setKefUi Coef.CoefPolinom3 value 

    member x.CoefA3
        with get () = x.getKefUi Coef.CoefA3
        and set value = x.setKefUi Coef.CoefA3 value 

    member x.CoefB3
        with get () = x.getKefUi Coef.CoefB3
        and set value = x.setKefUi Coef.CoefB3 value 

    member x.CoefC3
        with get () = x.getKefUi Coef.CoefC3
        and set value = x.setKefUi Coef.CoefC3 value 

    member x.CoefD3
        with get () = x.getKefUi Coef.CoefD3
        and set value = x.setKefUi Coef.CoefD3 value 

    member x.CoefK3
        with get () = x.getKefUi Coef.CoefK3
        and set value = x.setKefUi Coef.CoefK3 value 

    member x.CoefPolinomN4
        with get () = x.getKefUi Coef.CoefPolinomN4
        and set value = x.setKefUi Coef.CoefPolinomN4 value 

    member x.CoefA4
        with get () = x.getKefUi Coef.CoefA4
        and set value = x.setKefUi Coef.CoefA4 value 

    member x.CoefB4
        with get () = x.getKefUi Coef.CoefB4
        and set value = x.setKefUi Coef.CoefB4 value 

    member x.CoefC4
        with get () = x.getKefUi Coef.CoefC4
        and set value = x.setKefUi Coef.CoefC4 value 

    member x.CoefD4
        with get () = x.getKefUi Coef.CoefD4
        and set value = x.setKefUi Coef.CoefD4 value 

    member x.CoefK4
        with get () = x.getKefUi Coef.CoefK4
        and set value = x.setKefUi Coef.CoefK4 value 

    member x.CoefPolinomI5
        with get () = x.getKefUi Coef.CoefPolinomI5
        and set value = x.setKefUi Coef.CoefPolinomI5 value 

    member x.CoefA5
        with get () = x.getKefUi Coef.CoefA5
        and set value = x.setKefUi Coef.CoefA5 value 

    member x.CoefB5
        with get () = x.getKefUi Coef.CoefB5
        and set value = x.setKefUi Coef.CoefB5 value 

    member x.CoefC5
        with get () = x.getKefUi Coef.CoefC5
        and set value = x.setKefUi Coef.CoefC5 value 

    member x.CoefD5
        with get () = x.getKefUi Coef.CoefD5
        and set value = x.setKefUi Coef.CoefD5 value 

    member x.CoefK5
        with get () = x.getKefUi Coef.CoefK5
        and set value = x.setKefUi Coef.CoefK5 value 

    member x.CoefPolinom6
        with get () = x.getKefUi Coef.CoefPolinom6
        and set value = x.setKefUi Coef.CoefPolinom6 value 

    member x.CoefA6
        with get () = x.getKefUi Coef.CoefA6
        and set value = x.setKefUi Coef.CoefA6 value 

    member x.CoefB6
        with get () = x.getKefUi Coef.CoefB6
        and set value = x.setKefUi Coef.CoefB6 value 

    member x.CoefC6
        with get () = x.getKefUi Coef.CoefC6
        and set value = x.setKefUi Coef.CoefC6 value 

    member x.CoefD6
        with get () = x.getKefUi Coef.CoefD6
        and set value = x.setKefUi Coef.CoefD6 value 

    member x.CoefK6
        with get () = x.getKefUi Coef.CoefK6
        and set value = x.setKefUi Coef.CoefK6 value 

    member x.CoefPolinom7
        with get () = x.getKefUi Coef.CoefPolinom7
        and set value = x.setKefUi Coef.CoefPolinom7 value 

    member x.CoefA7
        with get () = x.getKefUi Coef.CoefA7
        and set value = x.setKefUi Coef.CoefA7 value 

    member x.CoefB7
        with get () = x.getKefUi Coef.CoefB7
        and set value = x.setKefUi Coef.CoefB7 value 

    member x.CoefC7
        with get () = x.getKefUi Coef.CoefC7
        and set value = x.setKefUi Coef.CoefC7 value 

    member x.CoefD7
        with get () = x.getKefUi Coef.CoefD7
        and set value = x.setKefUi Coef.CoefD7 value 

    member x.CoefK7
        with get () = x.getKefUi Coef.CoefK7
        and set value = x.setKefUi Coef.CoefK7 value 

    member x.CoefPolinom8
        with get () = x.getKefUi Coef.CoefPolinom8
        and set value = x.setKefUi Coef.CoefPolinom8 value 

    member x.CoefA8
        with get () = x.getKefUi Coef.CoefA8
        and set value = x.setKefUi Coef.CoefA8 value 

    member x.CoefB8
        with get () = x.getKefUi Coef.CoefB8
        and set value = x.setKefUi Coef.CoefB8 value 

    member x.CoefC8
        with get () = x.getKefUi Coef.CoefC8
        and set value = x.setKefUi Coef.CoefC8 value 

    member x.CoefD8
        with get () = x.getKefUi Coef.CoefD8
        and set value = x.setKefUi Coef.CoefD8 value 

    member x.CoefK8
        with get () = x.getKefUi Coef.CoefK8
        and set value = x.setKefUi Coef.CoefK8 value 

    member x.CoefPolinom9
        with get () = x.getKefUi Coef.CoefPolinom9
        and set value = x.setKefUi Coef.CoefPolinom9 value 

    member x.CoefA9
        with get () = x.getKefUi Coef.CoefA9
        and set value = x.setKefUi Coef.CoefA9 value 

    member x.CoefB9
        with get () = x.getKefUi Coef.CoefB9
        and set value = x.setKefUi Coef.CoefB9 value 

    member x.CoefC9
        with get () = x.getKefUi Coef.CoefC9
        and set value = x.setKefUi Coef.CoefC9 value 

    member x.CoefD9
        with get () = x.getKefUi Coef.CoefD9
        and set value = x.setKefUi Coef.CoefD9 value 

    member x.CoefK9
        with get () = x.getKefUi Coef.CoefK9
        and set value = x.setKefUi Coef.CoefK9 value 

    member x.CoefPolinom10
        with get () = x.getKefUi Coef.CoefPolinom10
        and set value = x.setKefUi Coef.CoefPolinom10 value 

    member x.CoefA10
        with get () = x.getKefUi Coef.CoefA10
        and set value = x.setKefUi Coef.CoefA10 value 

    member x.CoefB10
        with get () = x.getKefUi Coef.CoefB10
        and set value = x.setKefUi Coef.CoefB10 value 

    member x.CoefC10
        with get () = x.getKefUi Coef.CoefC10
        and set value = x.setKefUi Coef.CoefC10 value 

    member x.CoefD10
        with get () = x.getKefUi Coef.CoefD10
        and set value = x.setKefUi Coef.CoefD10 value 

    member x.CoefK10
        with get () = x.getKefUi Coef.CoefK10
        and set value = x.setKefUi Coef.CoefK10 value 

    member x.CoefPolinom11
        with get () = x.getKefUi Coef.CoefPolinom11
        and set value = x.setKefUi Coef.CoefPolinom11 value 

    member x.CoefA11
        with get () = x.getKefUi Coef.CoefA11
        and set value = x.setKefUi Coef.CoefA11 value 

    member x.CoefB11
        with get () = x.getKefUi Coef.CoefB11
        and set value = x.setKefUi Coef.CoefB11 value 

    member x.CoefC11
        with get () = x.getKefUi Coef.CoefC11
        and set value = x.setKefUi Coef.CoefC11 value 

    member x.CoefD11
        with get () = x.getKefUi Coef.CoefD11
        and set value = x.setKefUi Coef.CoefD11 value 

    member x.CoefK11
        with get () = x.getKefUi Coef.CoefK11
        and set value = x.setKefUi Coef.CoefK11 value 

    member x.CoefPolinom12
        with get () = x.getKefUi Coef.CoefPolinom12
        and set value = x.setKefUi Coef.CoefPolinom12 value 

    member x.CoefA12
        with get () = x.getKefUi Coef.CoefA12
        and set value = x.setKefUi Coef.CoefA12 value 

    member x.CoefB12
        with get () = x.getKefUi Coef.CoefB12
        and set value = x.setKefUi Coef.CoefB12 value 

    member x.CoefC12
        with get () = x.getKefUi Coef.CoefC12
        and set value = x.setKefUi Coef.CoefC12 value 

    member x.CoefD12
        with get () = x.getKefUi Coef.CoefD12
        and set value = x.setKefUi Coef.CoefD12 value 

    member x.CoefK12
        with get () = x.getKefUi Coef.CoefK12
        and set value = x.setKefUi Coef.CoefK12 value 

    member x.CoefPolinom13
        with get () = x.getKefUi Coef.CoefPolinom13
        and set value = x.setKefUi Coef.CoefPolinom13 value 

    member x.CoefA13
        with get () = x.getKefUi Coef.CoefA13
        and set value = x.setKefUi Coef.CoefA13 value 

    member x.CoefB13
        with get () = x.getKefUi Coef.CoefB13
        and set value = x.setKefUi Coef.CoefB13 value 

    member x.CoefC13
        with get () = x.getKefUi Coef.CoefC13
        and set value = x.setKefUi Coef.CoefC13 value 

    member x.CoefD13
        with get () = x.getKefUi Coef.CoefD13
        and set value = x.setKefUi Coef.CoefD13 value 

    member x.CoefK13
        with get () = x.getKefUi Coef.CoefK13
        and set value = x.setKefUi Coef.CoefK13 value 

    member x.CoefPolinom14
        with get () = x.getKefUi Coef.CoefPolinom14
        and set value = x.setKefUi Coef.CoefPolinom14 value 

    member x.CoefA14
        with get () = x.getKefUi Coef.CoefA14
        and set value = x.setKefUi Coef.CoefA14 value 

    member x.CoefB14
        with get () = x.getKefUi Coef.CoefB14
        and set value = x.setKefUi Coef.CoefB14 value 

    member x.CoefC14
        with get () = x.getKefUi Coef.CoefC14
        and set value = x.setKefUi Coef.CoefC14 value 

    member x.CoefD14
        with get () = x.getKefUi Coef.CoefD14
        and set value = x.setKefUi Coef.CoefD14 value 

    member x.CoefK14
        with get () = x.getKefUi Coef.CoefK14
        and set value = x.setKefUi Coef.CoefK14 value 

    member x.CoefPolinom15
        with get () = x.getKefUi Coef.CoefPolinom15
        and set value = x.setKefUi Coef.CoefPolinom15 value 

    member x.CoefA15
        with get () = x.getKefUi Coef.CoefA15
        and set value = x.setKefUi Coef.CoefA15 value 

    member x.CoefB15
        with get () = x.getKefUi Coef.CoefB15
        and set value = x.setKefUi Coef.CoefB15 value 

    member x.CoefC15
        with get () = x.getKefUi Coef.CoefC15
        and set value = x.setKefUi Coef.CoefC15 value 

    member x.CoefD15
        with get () = x.getKefUi Coef.CoefD15
        and set value = x.setKefUi Coef.CoefD15 value 

    member x.CoefK15
        with get () = x.getKefUi Coef.CoefK15
        and set value = x.setKefUi Coef.CoefK15 value 

    member x.CoefPolinom16
        with get () = x.getKefUi Coef.CoefPolinom16
        and set value = x.setKefUi Coef.CoefPolinom16 value 

    member x.CoefA16
        with get () = x.getKefUi Coef.CoefA16
        and set value = x.setKefUi Coef.CoefA16 value 

    member x.CoefB16
        with get () = x.getKefUi Coef.CoefB16
        and set value = x.setKefUi Coef.CoefB16 value 

    member x.CoefC16
        with get () = x.getKefUi Coef.CoefC16
        and set value = x.setKefUi Coef.CoefC16 value 

    member x.CoefD16
        with get () = x.getKefUi Coef.CoefD16
        and set value = x.setKefUi Coef.CoefD16 value 

    member x.CoefK16
        with get () = x.getKefUi Coef.CoefK16
        and set value = x.setKefUi Coef.CoefK16 value 

    member x.CoefPolinom17
        with get () = x.getKefUi Coef.CoefPolinom17
        and set value = x.setKefUi Coef.CoefPolinom17 value 

    member x.CoefA17
        with get () = x.getKefUi Coef.CoefA17
        and set value = x.setKefUi Coef.CoefA17 value 

    member x.CoefB17
        with get () = x.getKefUi Coef.CoefB17
        and set value = x.setKefUi Coef.CoefB17 value 

    member x.CoefC17
        with get () = x.getKefUi Coef.CoefC17
        and set value = x.setKefUi Coef.CoefC17 value 

    member x.CoefD17
        with get () = x.getKefUi Coef.CoefD17
        and set value = x.setKefUi Coef.CoefD17 value 

    member x.CoefK17
        with get () = x.getKefUi Coef.CoefK17
        and set value = x.setKefUi Coef.CoefK17 value 

    member x.CoefPolinom18
        with get () = x.getKefUi Coef.CoefPolinom18
        and set value = x.setKefUi Coef.CoefPolinom18 value 

    member x.CoefA18
        with get () = x.getKefUi Coef.CoefA18
        and set value = x.setKefUi Coef.CoefA18 value 

    member x.CoefB18
        with get () = x.getKefUi Coef.CoefB18
        and set value = x.setKefUi Coef.CoefB18 value 

    member x.CoefC18
        with get () = x.getKefUi Coef.CoefC18
        and set value = x.setKefUi Coef.CoefC18 value 

    member x.CoefD18
        with get () = x.getKefUi Coef.CoefD18
        and set value = x.setKefUi Coef.CoefD18 value 

    member x.CoefK18
        with get () = x.getKefUi Coef.CoefK18
        and set value = x.setKefUi Coef.CoefK18 value 

    member x.CoefPolinom19
        with get () = x.getKefUi Coef.CoefPolinom19
        and set value = x.setKefUi Coef.CoefPolinom19 value 

    member x.CoefA19
        with get () = x.getKefUi Coef.CoefA19
        and set value = x.setKefUi Coef.CoefA19 value 

    member x.CoefB19
        with get () = x.getKefUi Coef.CoefB19
        and set value = x.setKefUi Coef.CoefB19 value 

    member x.CoefC19
        with get () = x.getKefUi Coef.CoefC19
        and set value = x.setKefUi Coef.CoefC19 value 

    member x.CoefD19
        with get () = x.getKefUi Coef.CoefD19
        and set value = x.setKefUi Coef.CoefD19 value 

    member x.CoefK19
        with get () = x.getKefUi Coef.CoefK19
        and set value = x.setKefUi Coef.CoefK19 value 

    member x.CoefPolinom20
        with get () = x.getKefUi Coef.CoefPolinom20
        and set value = x.setKefUi Coef.CoefPolinom20 value 

    member x.CoefA20
        with get () = x.getKefUi Coef.CoefA20
        and set value = x.setKefUi Coef.CoefA20 value 

    member x.CoefB20
        with get () = x.getKefUi Coef.CoefB20
        and set value = x.setKefUi Coef.CoefB20 value 

    member x.CoefC20
        with get () = x.getKefUi Coef.CoefC20
        and set value = x.setKefUi Coef.CoefC20 value 

    member x.CoefD20
        with get () = x.getKefUi Coef.CoefD20
        and set value = x.setKefUi Coef.CoefD20 value 

    member x.CoefK20
        with get () = x.getKefUi Coef.CoefK20
        and set value = x.setKefUi Coef.CoefK20 value 

    member x.CoefLinSub0
        with get () = x.getKefUi Coef.CoefLinSub0
        and set value = x.setKefUi Coef.CoefLinSub0 value 

    member x.CoefLinSub1
        with get () = x.getKefUi Coef.CoefLinSub1
        and set value = x.setKefUi Coef.CoefLinSub1 value 

    member x.CoefLinSub2
        with get () = x.getKefUi Coef.CoefLinSub2
        and set value = x.setKefUi Coef.CoefLinSub2 value 

    member x.CoefLinSub3
        with get () = x.getKefUi Coef.CoefLinSub3
        and set value = x.setKefUi Coef.CoefLinSub3 value 

    member x.CoefPolinom
        with get () = x.getKefUi Coef.CoefPolinom
        and set value = x.setKefUi Coef.CoefPolinom value 

    member x.Var_Lin_Conc_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Lin_Conc_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Lin_Conc_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Lin_Conc_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Lin_Conc_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Lin_Conc_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Lin_Conc_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Lin_Conc_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Lin_Conc_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Lin_Conc_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Lin_Conc_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Lin_Conc_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Lin_Curr_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Lin_Curr_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Lin_Curr_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Lin_Curr_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Lin_Curr_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Lin_Curr_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Lin_Curr_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Lin_Curr_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Lin_Curr_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Lin_Curr_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Lin_Curr_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Lin_Curr_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Lin_Var1_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Lin_Var1_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Lin_Var1_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Lin_Var1_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Lin_Var1_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Lin_Var1_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Lin_Var1_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Lin_Var1_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Lin_Var1_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Lin_Var1_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Lin_Var1_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Lin_Var1_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Lin_Temp_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Lin_Temp_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Lin_Temp_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Lin_Temp_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Lin_Temp_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Lin_Temp_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Lin_Temp_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Lin_Temp_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Lin_Temp_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Lin_Temp_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Lin_Temp_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Lin_Temp_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Lin_Workk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Lin_Workk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Lin_Workk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Lin_Workk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Lin_Workk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Lin_Workk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Lin_Workk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Lin_Workk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Lin_Workk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Lin_Workk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Lin_Workk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Lin_Workk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Lin_Refk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Lin_Refk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Lin_Refk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Lin_Refk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Lin_Refk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Lin_Refk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Lin_Refk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Lin_Refk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Lin_Refk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Lin_Refk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Lin_Refk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Lin_Refk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Termo_Conc_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Termo_Conc_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Termo_Conc_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Termo_Conc_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Termo_Conc_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Termo_Conc_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Termo_Conc_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Termo_Conc_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Termo_Conc_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Termo_Conc_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Termo_Conc_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Termo_Conc_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Termo_Curr_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Termo_Curr_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Termo_Curr_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Termo_Curr_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Termo_Curr_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Termo_Curr_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Termo_Curr_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Termo_Curr_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Termo_Curr_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Termo_Curr_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Termo_Curr_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Termo_Curr_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Termo_Var1_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Termo_Var1_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Termo_Var1_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Termo_Var1_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Termo_Var1_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Termo_Var1_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Termo_Var1_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Termo_Var1_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Termo_Var1_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Termo_Var1_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Termo_Var1_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Termo_Var1_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Termo_Temp_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Termo_Temp_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Termo_Temp_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Termo_Temp_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Termo_Temp_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Termo_Temp_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Termo_Temp_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Termo_Temp_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Termo_Temp_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Termo_Temp_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Termo_Temp_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Termo_Temp_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Termo_Workk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Termo_Workk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Termo_Workk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Termo_Workk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Termo_Workk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Termo_Workk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Termo_Workk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Termo_Workk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Termo_Workk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Termo_Workk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Termo_Workk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Termo_Workk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Termo_Refk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Termo_Refk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Termo_Refk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Termo_Refk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Termo_Refk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Termo_Refk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Termo_Refk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Termo_Refk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Termo_Refk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Termo_Refk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Termo_Refk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Termo_Refk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Test_Conc_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Test_Conc_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Test_Conc_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Test_Conc_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Test_Conc_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Test_Conc_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Test_Conc_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Test_Conc_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Test_Conc_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Test_Conc_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Test_Conc_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Test_Conc_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Test_Curr_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Test_Curr_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Test_Curr_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Test_Curr_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Test_Curr_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Test_Curr_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Test_Curr_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Test_Curr_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Test_Curr_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Test_Curr_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Test_Curr_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Test_Curr_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Test_Var1_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Test_Var1_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Test_Var1_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Test_Var1_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Test_Var1_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Test_Var1_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Test_Var1_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Test_Var1_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Test_Var1_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Test_Var1_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Test_Var1_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Test_Var1_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Test_Temp_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Test_Temp_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Test_Temp_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Test_Temp_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Test_Temp_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Test_Temp_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Test_Temp_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Test_Temp_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Test_Temp_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Test_Temp_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Test_Temp_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Test_Temp_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Test_Workk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Test_Workk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Test_Workk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Test_Workk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Test_Workk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Test_Workk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Test_Workk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Test_Workk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Test_Workk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Test_Workk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Test_Workk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Test_Workk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Test_Refk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Test_Refk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Test_Refk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Test_Refk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Test_Refk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Test_Refk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Test_Refk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Test_Refk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Test_Refk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Test_Refk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Test_Refk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Test_Refk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_RetNku_Conc_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_RetNku_Conc_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_RetNku_Conc_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_RetNku_Conc_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_RetNku_Conc_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_RetNku_Conc_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_RetNku_Conc_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_RetNku_Conc_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_RetNku_Conc_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_RetNku_Conc_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_RetNku_Conc_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_RetNku_Conc_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_RetNku_Curr_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_RetNku_Curr_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_RetNku_Curr_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_RetNku_Curr_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_RetNku_Curr_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_RetNku_Curr_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_RetNku_Curr_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_RetNku_Curr_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_RetNku_Curr_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_RetNku_Curr_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_RetNku_Curr_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_RetNku_Curr_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_RetNku_Var1_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var1_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_RetNku_Var1_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var1_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_RetNku_Var1_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var1_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_RetNku_Var1_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var1_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_RetNku_Var1_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var1_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_RetNku_Var1_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var1_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_RetNku_Temp_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_RetNku_Temp_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_RetNku_Temp_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_RetNku_Temp_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_RetNku_Temp_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_RetNku_Temp_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_RetNku_Temp_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_RetNku_Temp_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_RetNku_Temp_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_RetNku_Temp_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_RetNku_Temp_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_RetNku_Temp_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_RetNku_Workk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_RetNku_Workk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_RetNku_Workk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_RetNku_Workk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_RetNku_Workk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_RetNku_Workk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_RetNku_Workk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_RetNku_Workk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_RetNku_Workk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_RetNku_Workk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_RetNku_Workk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_RetNku_Workk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_RetNku_Refk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_RetNku_Refk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_RetNku_Refk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_RetNku_Refk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_RetNku_Refk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_RetNku_Refk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_RetNku_Refk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_RetNku_Refk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_RetNku_Refk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_RetNku_Refk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_RetNku_Refk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_RetNku_Refk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex1_Conc_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex1_Conc_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex1_Conc_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex1_Conc_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex1_Conc_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex1_Conc_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex1_Conc_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex1_Conc_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex1_Conc_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex1_Conc_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex1_Conc_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex1_Conc_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex1_Curr_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex1_Curr_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex1_Curr_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex1_Curr_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex1_Curr_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex1_Curr_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex1_Curr_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex1_Curr_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex1_Curr_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex1_Curr_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex1_Curr_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex1_Curr_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex1_Var1_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var1_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex1_Var1_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var1_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex1_Var1_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var1_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex1_Var1_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var1_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex1_Var1_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var1_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex1_Var1_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var1_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex1_Temp_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex1_Temp_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex1_Temp_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex1_Temp_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex1_Temp_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex1_Temp_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex1_Temp_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex1_Temp_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex1_Temp_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex1_Temp_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex1_Temp_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex1_Temp_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex1_Workk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex1_Workk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex1_Workk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex1_Workk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex1_Workk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex1_Workk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex1_Workk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex1_Workk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex1_Workk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex1_Workk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex1_Workk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex1_Workk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex1_Refk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex1_Refk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex1_Refk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex1_Refk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex1_Refk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex1_Refk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex1_Refk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex1_Refk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex1_Refk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex1_Refk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex1_Refk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex1_Refk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex2_Conc_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex2_Conc_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex2_Conc_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex2_Conc_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex2_Conc_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex2_Conc_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex2_Conc_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex2_Conc_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex2_Conc_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex2_Conc_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex2_Conc_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex2_Conc_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex2_Curr_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex2_Curr_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex2_Curr_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex2_Curr_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex2_Curr_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex2_Curr_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex2_Curr_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex2_Curr_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex2_Curr_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex2_Curr_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex2_Curr_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex2_Curr_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex2_Var1_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var1_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex2_Var1_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var1_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex2_Var1_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var1_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex2_Var1_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var1_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex2_Var1_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var1_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex2_Var1_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var1_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex2_Temp_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex2_Temp_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex2_Temp_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex2_Temp_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex2_Temp_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex2_Temp_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex2_Temp_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex2_Temp_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex2_Temp_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex2_Temp_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex2_Temp_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex2_Temp_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex2_Workk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex2_Workk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex2_Workk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex2_Workk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex2_Workk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex2_Workk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex2_Workk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex2_Workk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex2_Workk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex2_Workk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex2_Workk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex2_Workk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex2_Refk_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex2_Refk_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex2_Refk_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex2_Refk_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex2_Refk_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex2_Refk_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex2_Refk_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex2_Refk_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex2_Refk_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex2_Refk_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex2_Refk_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex2_Refk_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.ConcError_ScaleBeg = x.GetConcError ScalePt.ScaleBeg 

    member x.RetNkuError_ScaleBeg = x.GetRetNkuError ScalePt.ScaleBeg 

    member x.Tex1Error_ScaleBeg = x.GetTex1Error ScalePt.ScaleBeg 

    member x.Tex2Error_ScaleBeg = x.GetTex2Error ScalePt.ScaleBeg 

    member x.TermoError_ScaleBeg_TermoNorm = x.GetTermoError (ScalePt.ScaleBeg, TermoPt.TermoNorm) 

    member x.TermoError_ScaleBeg_TermoLow = x.GetTermoError (ScalePt.ScaleBeg, TermoPt.TermoLow) 

    member x.TermoError_ScaleBeg_TermoHigh = x.GetTermoError (ScalePt.ScaleBeg, TermoPt.TermoHigh) 

    member x.TermoError_ScaleBeg_Termo90 = x.GetTermoError (ScalePt.ScaleBeg, TermoPt.Termo90) 

    member x.ConcError_ScaleMid = x.GetConcError ScalePt.ScaleMid 

    member x.RetNkuError_ScaleMid = x.GetRetNkuError ScalePt.ScaleMid 

    member x.Tex1Error_ScaleMid = x.GetTex1Error ScalePt.ScaleMid 

    member x.Tex2Error_ScaleMid = x.GetTex2Error ScalePt.ScaleMid 

    member x.TermoError_ScaleMid_TermoNorm = x.GetTermoError (ScalePt.ScaleMid, TermoPt.TermoNorm) 

    member x.TermoError_ScaleMid_TermoLow = x.GetTermoError (ScalePt.ScaleMid, TermoPt.TermoLow) 

    member x.TermoError_ScaleMid_TermoHigh = x.GetTermoError (ScalePt.ScaleMid, TermoPt.TermoHigh) 

    member x.TermoError_ScaleMid_Termo90 = x.GetTermoError (ScalePt.ScaleMid, TermoPt.Termo90) 

    member x.ConcError_ScaleEnd = x.GetConcError ScalePt.ScaleEnd 

    member x.RetNkuError_ScaleEnd = x.GetRetNkuError ScalePt.ScaleEnd 

    member x.Tex1Error_ScaleEnd = x.GetTex1Error ScalePt.ScaleEnd 

    member x.Tex2Error_ScaleEnd = x.GetTex2Error ScalePt.ScaleEnd 

    member x.TermoError_ScaleEnd_TermoNorm = x.GetTermoError (ScalePt.ScaleEnd, TermoPt.TermoNorm) 

    member x.TermoError_ScaleEnd_TermoLow = x.GetTermoError (ScalePt.ScaleEnd, TermoPt.TermoLow) 

    member x.TermoError_ScaleEnd_TermoHigh = x.GetTermoError (ScalePt.ScaleEnd, TermoPt.TermoHigh) 

    member x.TermoError_ScaleEnd_Termo90 = x.GetTermoError (ScalePt.ScaleEnd, TermoPt.Termo90) 

    member x.Conc = x.getPhysVarValueUi PhysVar.Conc 

    member x.Curr = x.getPhysVarValueUi PhysVar.Curr 

    member x.Var1 = x.getPhysVarValueUi PhysVar.Var1 

    member x.Temp = x.getPhysVarValueUi PhysVar.Temp 

    member x.Workk = x.getPhysVarValueUi PhysVar.Workk 

    member x.Refk = x.getPhysVarValueUi PhysVar.Refk 
