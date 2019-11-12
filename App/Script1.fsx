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


for x in Mil82.PhysVar.values do
    printfn "регистр %d, %s" x.Code (x.Dscr.ToLower())

for x in Mil82.Coef.coefs do
    printfn "регистр %d, код записи %d, %A %s" x.Reg x.Cmd x (x.Description.ToLower())

for x in Mil82.Command.values do
    printfn "команда %d, %s" x.Code (x.What.ToLower())
