#r @"..\packages\iTextSharp.5.5.12\lib\itextsharp.dll"
#r @"..\SysText\bin\Debug\SysText.dll"
#r @"..\NumericMethod\bin\Debug\NumericMethod.dll"

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
#load "AppCore/Alchemy.fs"
#load "AppCore/PaspPdf.fs"

open Mil82
open System

let party = Alchemy.createNewParty1("sdfsd",A31, 0m, 48m, 98m, 20uy)

PaspPdf.newReport party
PaspPdf.newStickers party

IO.Path.appDir
