namespace Mil82.ViewModel

open Mil82

type Product(p, getProdType, getPgs, partyId) =

    inherit ViewModel.Product1(p, getProdType, getPgs, partyId) 
    override x.RaisePropertyChanged propertyName = 
        ViewModelBase.raisePropertyChanged x propertyName

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

    member x.Var_Lin_Conc_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Lin_Conc_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Lin_Conc_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Lin_Conc_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Lin_Curr_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Lin_Curr_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Lin_Curr_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Lin_Curr_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Lin_Var1_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Lin_Var1_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Lin_Var1_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Lin_Var1_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Lin_Temp_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Lin_Temp_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Lin_Temp_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Lin_Temp_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Lin_Workk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Lin_Workk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Lin_Workk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Lin_Workk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Lin_Refk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Lin_Refk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Lin_Refk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Lin_Refk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Lin_Var8_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Lin_Var8_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Lin_Var8_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Lin_Var8_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Lin_Var8_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Lin_Var8_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Lin_Var8_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Lin_Var8_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Lin_Var8_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Lin_Var8_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Lin_Var8_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Lin_Var8_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Lin_Var8_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Lin_Var8_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Lin_Var8_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Lin_Var8_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Lin_Var10_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Lin_Var10_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Lin_Var10_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Lin_Var10_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Lin_Var10_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Lin_Var10_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Lin_Var10_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Lin_Var10_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Lin_Var10_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Lin_Var10_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Lin_Var10_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Lin_Var10_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Lin_Var10_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Lin_Var10_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Lin_Var10_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Lin_Var10_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Lin, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90) value

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

    member x.Var_Termo_Conc_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Termo_Conc_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Termo_Conc_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Termo_Conc_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Termo_Curr_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Termo_Curr_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Termo_Curr_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Termo_Curr_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Termo_Var1_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Termo_Var1_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Termo_Var1_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Termo_Var1_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Termo_Temp_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Termo_Temp_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Termo_Temp_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Termo_Temp_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Termo_Workk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Termo_Workk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Termo_Workk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Termo_Workk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Termo_Refk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Termo_Refk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Termo_Refk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Termo_Refk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Termo_Var8_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Termo_Var8_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Termo_Var8_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Termo_Var8_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Termo_Var8_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Termo_Var8_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Termo_Var8_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Termo_Var8_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Termo_Var8_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Termo_Var8_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Termo_Var8_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Termo_Var8_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Termo_Var8_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Termo_Var8_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Termo_Var8_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Termo_Var8_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Termo_Var10_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Termo_Var10_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Termo_Var10_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Termo_Var10_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Termo_Var10_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Termo_Var10_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Termo_Var10_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Termo_Var10_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Termo_Var10_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Termo_Var10_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Termo_Var10_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Termo_Var10_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Termo_Var10_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Termo_Var10_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Termo_Var10_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Termo_Var10_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Termo, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90) value

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

    member x.Var_Test_Conc_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Test_Conc_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Test_Conc_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Test_Conc_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Test_Curr_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Test_Curr_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Test_Curr_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Test_Curr_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Test_Var1_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Test_Var1_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Test_Var1_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Test_Var1_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Test_Temp_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Test_Temp_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Test_Temp_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Test_Temp_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Test_Workk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Test_Workk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Test_Workk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Test_Workk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Test_Refk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Test_Refk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Test_Refk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Test_Refk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Test_Var8_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Test_Var8_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Test_Var8_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Test_Var8_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Test_Var8_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Test_Var8_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Test_Var8_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Test_Var8_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Test_Var8_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Test_Var8_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Test_Var8_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Test_Var8_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Test_Var8_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Test_Var8_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Test_Var8_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Test_Var8_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Test_Var10_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Test_Var10_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Test_Var10_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Test_Var10_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Test_Var10_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Test_Var10_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Test_Var10_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Test_Var10_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Test_Var10_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Test_Var10_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Test_Var10_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Test_Var10_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Test_Var10_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Test_Var10_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Test_Var10_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Test_Var10_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Test, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90) value

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

    member x.Var_RetNku_Conc_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_RetNku_Conc_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_RetNku_Conc_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_RetNku_Conc_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_RetNku_Curr_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_RetNku_Curr_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_RetNku_Curr_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_RetNku_Curr_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_RetNku_Var1_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var1_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_RetNku_Var1_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var1_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_RetNku_Temp_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_RetNku_Temp_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_RetNku_Temp_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_RetNku_Temp_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_RetNku_Workk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_RetNku_Workk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_RetNku_Workk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_RetNku_Workk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_RetNku_Refk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_RetNku_Refk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_RetNku_Refk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_RetNku_Refk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_RetNku_Var8_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var8_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_RetNku_Var8_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var8_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_RetNku_Var8_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var8_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_RetNku_Var8_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var8_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_RetNku_Var8_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var8_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_RetNku_Var8_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var8_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_RetNku_Var8_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var8_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_RetNku_Var8_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var8_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_RetNku_Var10_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var10_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_RetNku_Var10_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var10_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_RetNku_Var10_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var10_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_RetNku_Var10_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var10_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_RetNku_Var10_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var10_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_RetNku_Var10_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var10_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_RetNku_Var10_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_RetNku_Var10_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_RetNku_Var10_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_RetNku_Var10_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.RetNku, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90) value

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

    member x.Var_Tex1_Conc_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex1_Conc_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex1_Conc_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex1_Conc_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex1_Curr_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex1_Curr_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex1_Curr_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex1_Curr_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex1_Var1_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var1_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex1_Var1_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var1_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex1_Temp_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex1_Temp_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex1_Temp_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex1_Temp_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex1_Workk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex1_Workk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex1_Workk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex1_Workk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex1_Refk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex1_Refk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex1_Refk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex1_Refk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex1_Var8_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var8_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex1_Var8_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var8_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex1_Var8_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var8_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex1_Var8_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var8_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Tex1_Var8_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var8_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex1_Var8_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var8_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex1_Var8_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var8_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex1_Var8_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var8_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex1_Var10_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var10_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex1_Var10_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var10_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex1_Var10_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var10_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex1_Var10_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var10_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Tex1_Var10_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var10_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex1_Var10_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var10_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex1_Var10_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex1_Var10_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex1_Var10_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex1_Var10_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex1, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90) value

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

    member x.Var_Tex2_Conc_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex2_Conc_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex2_Conc_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex2_Conc_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Conc, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex2_Curr_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex2_Curr_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex2_Curr_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex2_Curr_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Curr, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex2_Var1_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var1_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex2_Var1_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var1_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var1, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex2_Temp_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex2_Temp_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex2_Temp_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex2_Temp_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Temp, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex2_Workk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex2_Workk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex2_Workk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex2_Workk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Workk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex2_Refk_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex2_Refk_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex2_Refk_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex2_Refk_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Refk, ScalePt.ScaleMid2, TermoPt.Termo90) value

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

    member x.Var_Tex2_Var8_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var8_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex2_Var8_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var8_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex2_Var8_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var8_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex2_Var8_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var8_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Tex2_Var8_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var8_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex2_Var8_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var8_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex2_Var8_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var8_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex2_Var8_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var8_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var8, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.Var_Tex2_Var10_ScaleBeg_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var10_ScaleBeg_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoLow) value

    member x.Var_Tex2_Var10_ScaleBeg_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var10_ScaleBeg_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleBeg, TermoPt.Termo90) value

    member x.Var_Tex2_Var10_ScaleMid2_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var10_ScaleMid2_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoLow) value

    member x.Var_Tex2_Var10_ScaleMid2_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var10_ScaleMid2_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid2, TermoPt.Termo90) value

    member x.Var_Tex2_Var10_ScaleMid_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var10_ScaleMid_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoLow) value

    member x.Var_Tex2_Var10_ScaleMid_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var10_ScaleMid_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleMid, TermoPt.Termo90) value

    member x.Var_Tex2_Var10_ScaleEnd_TermoNorm
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoNorm) value

    member x.Var_Tex2_Var10_ScaleEnd_TermoLow
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoLow) value

    member x.Var_Tex2_Var10_ScaleEnd_TermoHigh
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.TermoHigh) value

    member x.Var_Tex2_Var10_ScaleEnd_Termo90
        with get () = x.getVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90)
        and set value = x.setVarUi (Feature.Tex2, PhysVar.Var10, ScalePt.ScaleEnd, TermoPt.Termo90) value

    member x.ConcError_ScaleBeg = x.GetConcError ScalePt.ScaleBeg 

    member x.RetNkuError_ScaleBeg = x.GetRetNkuError ScalePt.ScaleBeg 

    member x.Tex1Error_ScaleBeg = x.GetTex1Error ScalePt.ScaleBeg 

    member x.Tex2Error_ScaleBeg = x.GetTex2Error ScalePt.ScaleBeg 

    member x.TermoError_ScaleBeg_TermoNorm = x.GetTermoError (ScalePt.ScaleBeg, TermoPt.TermoNorm) 

    member x.TermoError_ScaleBeg_TermoLow = x.GetTermoError (ScalePt.ScaleBeg, TermoPt.TermoLow) 

    member x.TermoError_ScaleBeg_TermoHigh = x.GetTermoError (ScalePt.ScaleBeg, TermoPt.TermoHigh) 

    member x.TermoError_ScaleBeg_Termo90 = x.GetTermoError (ScalePt.ScaleBeg, TermoPt.Termo90) 

    member x.ConcError_ScaleMid2 = x.GetConcError ScalePt.ScaleMid2 

    member x.RetNkuError_ScaleMid2 = x.GetRetNkuError ScalePt.ScaleMid2 

    member x.Tex1Error_ScaleMid2 = x.GetTex1Error ScalePt.ScaleMid2 

    member x.Tex2Error_ScaleMid2 = x.GetTex2Error ScalePt.ScaleMid2 

    member x.TermoError_ScaleMid2_TermoNorm = x.GetTermoError (ScalePt.ScaleMid2, TermoPt.TermoNorm) 

    member x.TermoError_ScaleMid2_TermoLow = x.GetTermoError (ScalePt.ScaleMid2, TermoPt.TermoLow) 

    member x.TermoError_ScaleMid2_TermoHigh = x.GetTermoError (ScalePt.ScaleMid2, TermoPt.TermoHigh) 

    member x.TermoError_ScaleMid2_Termo90 = x.GetTermoError (ScalePt.ScaleMid2, TermoPt.Termo90) 

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

    member x.Var8 = x.getPhysVarValueUi PhysVar.Var8 

    member x.Var10 = x.getPhysVarValueUi PhysVar.Var10 
