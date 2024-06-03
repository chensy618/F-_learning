// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
// combination of functions, call the functions and return a new function
let add x y = x + y
let multiply x y = x * y

let addAndMultiply a =
    let sum = add a 2
    let product = multiply sum 3
    product

printfn "The result is %d" (addAndMultiply 2)

// use >> to combine functions
let add2 a = a + 2
let multiply3 a = a * 3
let addAndMultiply2 = add2 >> multiply3

printfn "%i" (addAndMultiply 2) // 12

// pipe operator
let list = [ 1; 2; 3; 4; 5 ]
let sort (list: int list) = List.sort list

let print (list: int list) = List.iter (fun x -> printf "%i" x) list
// 在最后一行代码中，从一系列整数开始：list，这些整数充当第一个函数 sort() 的输入。 将该操作的结果送入 print()。 管道和组合的主要区别：管道是从一些数据（在本例中是一个整数列表）开始，然后引导它完成一组函数。
list |> sort |> print // 1 2 3 4 5

let cards = [ 21; 3; 1; 7; 9; 23 ]

let cardFace card =
    let no = card % 13

    if no = 1 then "Ace"
    elif no = 0 then "King"
    elif no = 12 then "Queen"
    elif no = 11 then "Jack"
    else string no

let suit card =
    let no = card / 13

    if no = 0 then "Hearts"
    elif no = 1 then "Spades"
    elif no = 2 then "Diamonds"
    else "Clubs"

let shuffle list =
    let random = System.Random()
    list |> List.sortBy (fun _ -> random.Next())

let printCard card =
    printfn "%s of %s" (cardFace card) (suit card)

let printAll list = List.iter (fun x -> printCard x) list

let take (no: int) (list) = List.take no list

cards |> shuffle |> take 3 |> printAll
