// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let b = true
printfn "b = %b" b
let b2 = not b
printfn "b2 = %b" b2
let name = "Chris"
let mutable name2 = "Chris"
name2 <- "Bob"
printfn "name = %s" name
printfn "name2 = %s" name2
let age = 42
let PI = 3.14159
let sum: float = 1.0 + 2.0
printfn "sum = %f" sum
let myname = "Luis"
let company = "Microsoft"
printfn $"My name is {myname} and I work at {company}"
let firstnumber = 1
let secondnumber = 2
printfn $"The sum of {firstnumber} and {secondnumber} is {firstnumber + secondnumber}"
