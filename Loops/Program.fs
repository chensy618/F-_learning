// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let list = [ 1; 2; 3; 4; 5 ]
// loop in the list
for i in list do
    printfn "The number is: %d" i

// loop until a condition is met, from smallest to largest
for i = 1 to 10 do
    printfn "The number is: %d" i

// loop until a condition is met, from largest to smallest
for i = 10 downto 1 do
    printfn "The number is: %d" i

// while loop
open System
let mutable quit = false
let no = 11

while not quit do
    printfn "Type a number: "
    let str = Console.ReadLine()
    let number = int str

    if number = no then
        printfn "You guessed the number"
        quit <- true
    else
        printfn "Try again"
