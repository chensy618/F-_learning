// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let cardno = 12

let carddescription =
    if cardno = 1 || cardno = 14 then "Ace"
    elif cardno = 11 then "Jack"
    elif cardno = 12 then "Queen"
    elif cardno = 13 then "King"
    else "Number card"

printfn "The card is: %s" carddescription
