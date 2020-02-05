#I @"C:\DOTNETPATH\src\github.com\mil82cs\FSharp.Json\bin\Release\netstandard2.0\"
#r @"FSharp.Json.dll"

#r @"C:\DOTNETPATH\src\github.com\mil82cs\packages\FsPickler.2.3.0\lib\net40\FsPickler.dll"

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
#load "AppCore/Repository.fs"

open FSharp.Json

// let json = Json.serialize x
// printfn "%s" json
    