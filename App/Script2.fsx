open System
open System.IO
open System.Diagnostics

let emptyDirectory = new DirectoryInfo(Path.GetTempPath() + "\\TempEmptyDirectory-" + Guid.NewGuid().ToString())
let pth = @"c:\3\my-app\"
emptyDirectory.Create();
let proc = new Process()
let i = proc.StartInfo
i.FileName <- "robocopy.exe"
i.Arguments <- "\"" + emptyDirectory.FullName + "\" \"" + pth + "\" /mir /r:1 /w:1 /np /xj /sl"
i.UseShellExecute <- false
i.CreateNoWindow <- true
if proc.Start() then
    proc.WaitForExit()        
    emptyDirectory.Delete()
    (new DirectoryInfo(pth)).Attributes <- FileAttributes.Normal
    Directory.Delete(pth,true)
else
    printfn "error! cant start %A with %A" i.FileName i.Arguments
