open System
open System.IO
open System.Text.RegularExpressions

let filename = __SOURCE_DIRECTORY__ + "\\koefs.cfg"

File.Exists filename

let cc (s:string) =
    let xs =  
        [|  for m in Regex.Matches(s, @"([A-Za-z][A-Za-z]*)_?") do
                if m.Success then
                    yield m.Groups.[1].Value 
            let m = Regex.Match(s, @"_(\d+)")
            if m.Success then
                yield m.Groups.[1].Value |]
        |> Array.choose(fun s -> 
            let s1 = String(s.[0],1).ToUpper()
            let s2 = s1 + s.Substring(1).ToLower() 
            if s2 = "Coef" then None else Some s2 )
    String.Join ("",xs)



let coefs = File.ReadAllLines filename |> Array.mapi (fun n s -> 
    let m = Regex.Match(s, @"^(\w+)\s+(-?\d+)\s*([^$]*)$")
    let (~%%) (n:int) = m.Groups.[n].Value
    let coef = cc s
    let defVal = Double.Parse <| %% 2
    let descr = (%% 3).Trim()
    coef, n, defVal, descr )

for coef, n, _, _ in coefs do 
    printfn "let %s = %d" coef n

for coef, n, defVal, descr in coefs do 
    if String.IsNullOrEmpty descr then
        printfn "%d, (%A, None)" n coef 
    else
        printfn "%d, (%A, Some %A)" n coef descr