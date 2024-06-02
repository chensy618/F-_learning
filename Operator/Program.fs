// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
// transform the string to an integer
let myNumber = 3
let myString = "3"
let first = "32"
let numberVersion = System.Int32.Parse first
printfn "The first number is: %d" numberVersion
// another transformation, using the int function. The first choice to do this
// F# is not allowed to define the same variable twice
let second = "32"
let numberVersion1 = int second
printfn "The second number is: %d" numberVersion1

//get a value from the user
System.Console.Write "Type a value: "
let str = System.Console.ReadLine()
printfn "You typed: %s, this is a string input" str

//operators
let no = 10
let isDivisibleByTwo = no % 2 = 0
// isDivisibleByTwo is a boolean
printfn "Divisible by two %b" isDivisibleByTwo

printfn "Type the first number: "
let firstNumber = System.Console.ReadLine()
printfn "Type the second number: "
let secondNumber = System.Console.ReadLine()
printfn "First number: %s, Second number: %s" firstNumber secondNumber
let sum = (int firstNumber) + (int secondNumber)
printfn "The sum is: %d" sum

// add two numbers
let add x y = x + y
let result = add (int firstNumber) (int secondNumber)
printfn "The add result is: %d" result
// subtract two numbers
let subtract x y = x - y
let result1 = subtract (int firstNumber) (int secondNumber)
printfn "The subtract result is: %d" result1
// multiply two numbers
let multiply x y = x * y
let result2 = multiply (int firstNumber) (int secondNumber)
printfn "The multiply result is: %d" result2
// divide two numbers
let divide x y = x / y
let result3 = divide (int firstNumber) (int secondNumber)
printfn "The divide result is: %d" result3
// modulo two numbers
let modulo x y = x % y
let result4 = modulo (int firstNumber) (int secondNumber)
printfn "The modulo result is: %d" result4
// check equality
let isEqual x y = x = y
let result5 = isEqual (int firstNumber) (int secondNumber)
printfn "The equality result is: %b" result5
// check inequality
let isNotEqual x y = x <> y
let result6 = isNotEqual (int firstNumber) (int secondNumber)
printfn "The inequality result is: %b" result6
