// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
// sets
let logEntryMonday = "First entry"
let logEntryTuesday = "Second entry"
let logEntryWednesday = "Third entry"
// it will be better to use a set
let logEntryWeek = [ "First entry"; "Second entry"; "Third entry" ]
// list : ordered collection of elements, immutable, and elements of same type
// array: An array is a fixed-size, mutable collection of data elements of the same type, ordered contiguously with an index starting at zero. Being mutable means that data elements can be easily added and removed, but performance may be reduced.
// Sequence: A sequence is a logical sequence of elements of the same type. Sequences can make real-time sense because they can handle large collections of data well without using all the elements. Also, it computes elements only when they are needed. Therefore, in some cases, sequences can provide better performance than lists.
// list creation
let cards = [ "Ace"; "King"; "Queen" ]
//let cards2 = [ 2; "Ace"; "King" ] // error, not permitted
let cards2 = [ "1"; "2"; "3"; "4"; "5" ]
let number = [ 1..10 ]
// append elements to list
let new_list = "Jack" :: cards
// combine lists
let combined_list = cards @ cards2
// using append function
let fulllist1 = cards |> List.append [ "NEW" ]
let fulllist2 = cards |> List.append cards2
// accessing elements
let first = cards.[0]
let last = cards.[cards.Length - 1]
let list = [ 0; 1; 2; 3; 4; 5 ]
list.Item 1

// let drawCard (list: int list) =
//     printfn "%i" list.Head
//     list.Tail
let hand = []

let drawCard (tuple: int list * int list) =
    let deck = fst tuple
    let draw = snd tuple
    let firstCard = deck.Head
    printfn "%i" firstCard

    let hand = draw |> List.append [ firstCard ]
    (deck.Tail, hand)


[<EntryPoint>]
let main argv =
    let d, h = (list, hand) |> drawCard |> drawCard
    printfn "Deck: %A Hand: %A" d h // Deck: [2; 3; 4; 5] Hand: [1; 0]
    0 // return an integer exit code
