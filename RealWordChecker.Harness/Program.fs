// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System
open RealWordChecker.WordChecker

[<EntryPoint>]
let main argv = 

    while 1 > 0 do 
        let word = Console.ReadLine()
        let result = isRealWord word
        Console.WriteLine( "{0} is a {1} word", word, if (result) then "real" else "NONSENSE" )

    0 // return an integer exit code

