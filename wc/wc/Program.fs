// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

 
open System
open System.IO

let doesExist path = 
    match File.Exists(path) with
    | true -> printfn "Valid file path "
    | false -> printfn "Please Insert a Valid File Path "

let words path = 
    let text = File.ReadAllText(path)
    let words = text.Split(' ','\t','\n','\r','\t','\v')
    printf"%i" words.Length
    
let lines path = 
    File.ReadAllLines(path) 
    |> Array.length
    |> printf"%i"
    
let bytes path = 
    File.ReadAllBytes(path) 
    |> Array.length
    |> printf"%i"

[<EntryPoint>]
    let main path =
        doesExist path.[0]
        lines path.[0] 
        words path.[0] 
        bytes path.[0]  
        0 // return an integer exit code

