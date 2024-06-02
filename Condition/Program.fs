// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
// if <condition> then <expression>
printfn "Type your age: "
let str = System.Console.ReadLine()
let age = int str

if age < 65 then
    printfn "Citizen"
else
    printfn "Senior citizen"

// use if to construct a boolean expression
let years = 64
let message = if years < 65 then "Citizen" else "Senior citizen"
printfn "message %s" message

let years1 = 66

if years1 > 65 then
    printfn "Senior citizen"
else
    printfn "Citizen"

// let someCondition = true
// let value = if someCondition then "hello" else 1 // not allowed
// then <expression> must be of the same type as else <expression>
let someCondition = true
let value = if someCondition then "hello" else "1" // allowed

// if <condition> then <expression> elif <condition> then <expression> else <expression>
let age1 = 64

let message1 =
    if age1 < 18 then "Child"
    elif age1 < 65 then "Citizen"
    else "Senior citizen"

printfn "message1 %s" message1
