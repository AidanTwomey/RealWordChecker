namespace RealWordChecker
open System.IO
open System

module WordChecker =

    let getAllWords =

        let searchPath = Path.Combine( System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "words.txt" )
        let dictionaryWords = File.ReadAllLines( searchPath ) |> Array.toSeq
        let extraWords = ["eoin";"twomey"]

        Seq.append dictionaryWords extraWords
        //dictionaryWords

    let isRealWord word =
        getAllWords |> Seq.contains word

