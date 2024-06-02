// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

[<EntryPoint>]
let main argv =
    let aNumber = 0
    printfn "aNumber = %s" aNumber
    // this is type-check error, string cannot match int
    0
