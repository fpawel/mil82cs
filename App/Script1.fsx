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


for x in Mil82.ProductType.values do
    printfn """['%s'] = {
    gas = %s,
    scale = %M,
    temp_min = %M,
    temp_max = %M,
    coefficient = {
        [4] = %M,
        [14] = %M,
        [35] = %M,
        [45] = %M,
        [50] = %M,
    },
},""" x.What x.Gas.What x.Scale.End x.TempMin x.TempMax x.K4 x.K14 x.K35 x.K45 x.K50
