#I "../../packages"
#I "../../packages/FParsec.1.0.2/lib/net40-client/"
#r "FParsec.dll"
#r "FParsecCS.dll"

#I "../../packages/FsPickler.2.3.0/lib/net40/"
#r "FsPickler.dll"

#I "../../NumericMethod/bin/Release"
#r "NumericMethod.dll"

#I "../../MyWinForms/bin/Release"
#r "MyWinForms.dll"

#load "../Utils/FsharpRuntime.fs"
#load "../Utils/State.fs"
#load "../Utils/StrUtils.fs"
#load "../Utils/PathUtils.fs"
#load "../Utils/DateTimeUtils.fs"
#load "../Utils/Logging.fs"
#load "../Mil82/Kef.fs"
#load "../Mil82/ProductType.fs"
#load "../Mil82/Mil82.fs"

#load "../Utils/Utils.fs" 

open StrUtils

#load "../Utils/Ref.fs" 
#load "../Utils/Tree.fs" 
#load "../Utils/Html.fs" 
#load "../Utils/Runtime.fs" 
#load "../Utils/Bin.fs" 
#load "../Utils/Hex.fs" 
#load "../WinForms/WinFormsControlUtils.fs" 
#load "../WinForms/WinFormsConverters.fs" 


#load "../WinForms/Components/PopupDialog.fs"
#load "../WinForms/Components/TopDialog.fs"
#load "../WinForms/Components/TriStateCheckTreeView.fs"
#load "../WinForms/Components/LeftInfoBlock.fs" 

#load "../Json/Json.fs" 
#load "../Json/JsonSerialization.fs" 
#load "../Json/JsonConfig.fs" 
#load "../AppCore/ComportConfig.fs" 
#load "../AppCore/Comport.fs" 
#load "../AppCore/AppConfig.fs" 
#load "../AppCore/MainWindow.fs" 
#load "../AppCore/Mdbs.fs" 
#load "../AppCore/Hardware.fs" 
#load "../AppCore/Repository.fs" 
#load "../AppCore/PhysVarValues.fs" 
#load "../AppCore/Alchemy.fs" 
#load "../ViewModels/ViewModel.fs" 
#load "../ViewModels/ProductViewModel.fs" 
#load "../ViewModels/ProductViewModel.Generated.fs" 

#load "../ViewModels/ConfigViewModel.fs" 
#load "../ViewModels/PartyViewModel.fs" 
#load "../ViewModels/PartyViewModel.Generated.fs" 
#load  "../Work/AppContent.fs" 

open System
open Mil82


let party = Mil82.AppContent.party
AppContent.subscribeOnChanged (fun(x,y) -> if x<>y then printfn "changed - %A" y )

let p = party.Products.[0]


type K = PhysVarValues.K

let k =
    let h,_ = party.Party    
    {   K.Party = Repository.PartyPath.fromPartyHead h
        K.Product = p.Product.Id
        K.Var = Conc }

let addv v =    
    PhysVarValues.addValue k v

addv 0.1m
addv 0.2m
addv 0.3m

AppContent.save()

let ss (x:DateTime,y) = 
    sprintf "(%s, %M)" (x.ToLongTimeString()) y

PhysVarValues.getNewValues k |> Seq.toStr "\n" ss
|> printfn "new :\n%s"
PhysVarValues.getSavedValues k |> Seq.toStr "\n" ss
|> printfn "saved :\n%s"



PhysVarValues.delete (k.Party, k.Product)