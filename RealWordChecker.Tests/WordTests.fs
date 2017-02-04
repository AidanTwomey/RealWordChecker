namespace RealWordChecker.Tests

open NUnit.Framework
open FsUnit
open RealWordChecker.WordChecker

module WordTests =

  [<TestFixture>]
  type WordTests() =

    [<TestCase("hello")>]
    [<TestCase("happy")>]
    member this.``hello should be a real word``(realWord) =
        isRealWord realWord |> should be True

    [<Test>]
    member this.``nagh should not be a real word``() =
        isRealWord "nagh" |> should be False

