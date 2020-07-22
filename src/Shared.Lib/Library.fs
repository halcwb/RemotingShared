namespace Shared.Lib


type Counter = { Value : int }


module Say =

    open System.IO

    let hello name =
        printfn "Hello %s" name


    let someIOAction = Path.GetTempPath
    