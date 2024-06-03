// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
//grammer of function:
//let <function name> <parameters> = <function body>
let add x y = x + y
// F# does not use return keyword, the final expression in the function is the return value
let addAndMultiply x y z =
    let sum = x + y
    let product = sum * z
    product

// calling the function
addAndMultiply 2 3 4
let result = addAndMultiply 2 3 4
printfn "The sum is %d" result
// or we could use this syntax
printfn "other calling statement %i" (addAndMultiply 2 3 4)

// F# is a statically typed language, so the type of the function is inferred by the compiler
// let add a b = a + b
// let sum = add 2 3
//this is a error because the function is expected to have int type
//let concat = add "Hello " "World"

// if we don't want the compiler to infer the type, we can specify it explicitly
// below is allowed
let addnew a b = a + b
let concat = addnew "Hello" "World"
printfn "%s" concat

// we can also specify the type of the function explicitly
let addExplicit (a: int) (b: int) : int = a + b
let addStr (a: string) (b: string) : string = a + b

let str = addStr "new" "world"
printfn "%s" str

let cardFace (card: int) : string =
    let no = card % 13

    if no = 14 || no = 1 then "Ace"
    elif no = 11 then "Jack"
    elif no = 12 then "Queen"
    elif no = 13 then "King"
    else string no

let card = cardFace 15
printfn "%s" card
