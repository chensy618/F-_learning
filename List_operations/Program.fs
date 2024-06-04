// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let cards = [ 1..5 ]
// iterate 1 2 3 4 5
List.iter (fun x -> printf "%i" x) cards
// it's the same as the following code
for i in cards do
    printf "%i" i
// map function
type Person = { FirstName: string; LastName: string }

let people =
    [ { FirstName = "Albert"
        LastName = "Einstein" }
      { FirstName = "Marie"
        LastName = "Curie" } ]

let nobelPrizeWinners =
    List.map (fun person -> person.FirstName + person.LastName) people

printfn "%A" nobelPrizeWinners // ["John"; "Jane"]
// compare with the following code
printfn "%A" people // [{FirstName = "Albert"; LastName = "Einstein";}; {FirstName = "Marie"; LastName = "Curie";}]

// filter function
let evenNumbers = List.filter (fun x -> x % 2 = 0) cards
printfn "%A" evenNumbers // [2; 4]

//sort function
let list = [ 5; 3; 1; 2; 4 ]
let sortedList = List.sort list
printfn "%A" sortedList // [1; 2; 3; 4; 5]

// sortby function
let fruits = [ "apple"; "banana"; "cherry" ]
let sortedFruits = List.sortBy (fun (fruits: string) -> fruits.Length) fruits
printfn "%A" sortedFruits // ["apple"; "banana"; "cherry"]

// sortwith function
type MagicCreature =
    { Name: string
      Level: int
      Attack: int }

let creatures =
    [ { Name = "Dragon"
        Level = 2
        Attack = 20 }
      { Name = "Orc"; Level = 1; Attack = 5 }
      { Name = "Demon"
        Level = 2
        Attack = 10 } ]

// comparison function, -1 = less than, 0 = equal, 1 = greater than
let compareCreatures c1 c2 =
    if c1.Level < c2.Level then -1
    else if c1.Level > c2.Level then 1
    else if c1.Attack < c2.Attack then -1
    else if c1.Attack > c2.Attack then 1
    else 0

let sortedCreatures = List.sortWith compareCreatures creatures
printfn "%A" sortedCreatures // { Name="Orc"; Level=1; Attack=5 }, { Name="Demon"; Level=2; Attack=10 }, { Name="Dragon"; Level=2; Attack=20 }


// find function
let findCreature = List.find (fun creature -> creature.Name = "Orc") creatures
printfn "%A" findCreature // { Name="Orc"; Level=1; Attack=5 }

// tryfind function
let findValue aValue aList =
    let found = aList |> List.tryFind (fun x -> x = aValue)

    match found with
    | Some value -> printfn "Found %A" value
    | None -> printfn "Not found"

findValue 1 list // Found 1
findValue 6 list // Not found

let found = List.tryFindIndex (fun x -> x = 4) list

match found with
| Some index -> printfn "%i" index
| None -> printfn "Not found"

// arithmatic operations
let sum = List.sum list
printfn "%i" sum // 15

//sumby function
let sumBy = List.sumBy (fun x -> x * x) list

type OrderItem =
    { Name: string
      Quantity: float
      Price: float }

let orderItems =
    [ { Name = "Apple"
        Quantity = 2.0
        Price = 1.5 }
      { Name = "Banana"
        Quantity = 3.0
        Price = 2.5 } ]

let total = List.sumBy (fun item -> item.Quantity * float item.Price) orderItems
printfn "%f" total // 10.500000

// average function
let numbers = [ 1.0; 2.5; 3.9 ]
let average = List.average numbers
printfn "%f" average // 2.466667

// averageby function
type WeatherMeasure = { Temperature: float; Humidity: float }

let measures =
    [ { Temperature = 20.0; Humidity = 0.5 }
      { Temperature = 25.0; Humidity = 0.6 } ]

let averageTemperature = List.averageBy (fun x -> x.Temperature) measures
printfn "%f" averageTemperature // 22.500000
