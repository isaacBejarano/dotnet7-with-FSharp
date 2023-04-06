// For more information see https://aka.ms/fsharp-console-apps

open System // namespace

let mutable n = 11

let memo =
 if n = 1 || n = 14 then "Ace" //  ∃ "if" -> ∃ "else" mandatory
 else if n = 11 then "Jack" 
 elif n = 12 then "Queen" // "elif" shorthand for "else if"
 elif n = 13 then "King" // "then" ~ TS brackets
 else n.ToString() // ~ string n 

let cardDesc n =
 if n = 1 || n = 14 then "Ace" //  ∃ "if" -> ∃ "else" mandatory
 else if n = 11 then "Jack" 
 elif n = 12 then "Queen" // "elif" shorthand for "else if"
 elif n = 13 then "King" // "then" ~ TS brackets
 else string n // ~ n.ToString()

// Console vs API res concats
System.Console.WriteLine("Your hand is " + "\"" + cardDesc n + "\"") // explicit -> requires no namespace System open
Console.WriteLine("Your hand is still \"{0}\"", cardDesc n) // implicit -> requires opening of namespace System
printfn "\"%s\" responded the API" (cardDesc n) // F#

Console.WriteLine(
//  string 'A'  // evaluates to "A"
//  string 0xff // evaluates to "255"
 string -10  // evaluates to "-10"
//  'A'.ToString()  
//  0xff.ToString() 
//  -10.ToString()  // cannot string on the fly
)
 
Console.WriteLine("-------------- \n Enter a number pliz")
let arg = Console.ReadLine() 
n <- int arg + 10 // ~ Int32.Parse(arg) n
printfn "\"%s\" (%i) NEW responded the API. \n Memo: \"%s\"" (cardDesc n) n memo
