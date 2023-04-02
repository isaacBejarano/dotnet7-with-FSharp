// For more information see https://aka.ms/fsharp-console-apps

open System

printfn "Welcome to the calculator program"
let sum = 0

printfn "Please enter number A"
let strInput1 = Console.ReadLine()
let intInput1 = int strInput1

printfn "Please enter number B"
let strInput2 = Console.ReadLine()
let intInput2 = Int32.Parse strInput2

printfn "Number1 is %i, Number2 is %i" intInput1 intInput2 // 2 slots for 2 variables
printfn "The Sum is %i" (intInput1 + intInput2 + sum)

// -------------

printfn "Now, let's write terser"
printfn "Please enter number A2"
let mutable input1 = Console.ReadLine()
printfn "Please enter number B2"
let input2 = Console.ReadLine()
printfn "Terser SUM: %i"  (int input1 + int input2)

let inmutableN = 8
let mutable mutableN = 8
mutableN <- 10
printfn "%b" (inmutableN = 8) // true
printfn "%b" (mutableN = 8) // false
printfn "%b" (mutableN <> 8) // true
