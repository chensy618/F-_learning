// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
open System

let cardDescription (card: int) : string =
    let cardno: int = card % 13

    if cardno = 1 then "Ace"
    elif cardno = 11 then "Jack"
    elif cardno = 12 then "Queen"
    elif cardno = 0 then "King"
    else string cardno

let suit (no: int) : string =
    let suitno = no / 13

    if suitno = 0 then "Hearts"
    elif suitno = 1 then "Spades"
    elif suitno = 2 then "Diamonds"
    else "Clubs"

[<EntryPoint>]
let main argv =
    let cards = [ 1; 10; 2; 34 ]

    for card in cards do
        printfn "The card is: %s of %s" (cardDescription card) (suit card)

    0 // return an integer exit code
