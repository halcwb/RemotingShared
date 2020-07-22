namespace Counter.Lib

/// Some external library that
/// retrieves a counter type from a file

type Counter = { Value : int }


module Counter =

    open System.IO

    let hello name =
        printfn "Hello %s" name


    let getCounter () =
        // dummy method that uses some IO that
        // simulates getting the counter value
        // from a file, for example
        Path.GetTempPath () |> ignore
        { Value = 1 }
    