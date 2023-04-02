// For more information see https://aka.ms/fsharp-console-apps

open System

// using mutable
let mutable name1 = "Chris"
name1 <- "Mutated" // this statement is now allowed unless "mutable" added to variable definition
printfn $"{name1}"

// stick to Functional -> Immutability
let name2 = "Eva"
let myFn arg =
  $"Immutable {arg} cloned to modify"
printfn $"{myFn name2}"

// Type inferred
let str1 = "Zero"
// Type forced
let str2: string = "0"

// F# printing (preferred)
let coda = "Coda"
printf $"{str1}-inlineA"
printf $"{str1}-inlineB"
printfn ""
printfn $"{str1}-blockA"
printfn $"{str1 + coda}-blockB" // concat

// Common NET printing (optional)
let age = 1_000_000
let NETformatted = String.Format("Variable with value {0} was formatted to {1} NET-wise", 1000000, age)
Console.WriteLine NETformatted // No parenthesis required if only using a variable with no string concat

let name = "Specifier"
printfn "Hi string %s" name // concat via %s strings pecifier
printfn "Hi signed int %i" -1_000 // concat via %i int specifier
printfn "Hi unsigned int%i" 1_000u // concat via %i int specifier
printfn "Hi boolean int %b" true // concat via %b boolean specifier

// 1.A. Read input from the console

System.Console.WriteLine "System methods don't require to use System namespace explicitly. Only importing it."
Console.WriteLine "Enter your Name: "
let inputText = Console.ReadLine()

// 1.B. Print to Console vs. Print to Response
Console.WriteLine("Your name is " + inputText)
Console.WriteLine("Your duplicated name is {0}",inputText)
printfn "Your name is %s" inputText

// 2. Convert between data types
let str3 = "4"
let convertedStr3NETwise1 =  System.Int32.Parse str3
let convertedStr3NETwise2 =  Int32.Parse str3
printfn "%i" convertedStr3NETwise2 // printfn requires always a String to cponcatenate to
// printfn str3 // ERROR / no string concatenated
let str4 = "4"
let convertedStr4FSharpwise1 =  int str3
let convertedStr4FSharpwise2 =  int32 str3
printfn "%i" convertedStr4FSharpwise2 // printfn requires always a String to cponcatenate to

// 3. Mathematical Operators
// Ojo! Therte's no strict equality and equality and assiggnation have same sign
let num = 10
let bMultipleOf5 = num % 5 = 0 
let bPair = num % 2 = 0 
let bEqualTo5 = num = 5 
let bDistinctFrom10 = num <> 10 
printfn "%b" bMultipleOf5
printfn "%b" bPair
printfn "%b" bEqualTo5
printfn "%b" bDistinctFrom10

