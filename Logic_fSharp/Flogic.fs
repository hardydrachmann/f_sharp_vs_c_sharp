namespace FSharp 
module FLogic =
    open Microsoft.FSharp.Collections

    let rec reverse list = 
        match list with
        |[] -> []
        |[x] -> [x]
        | head::tail -> reverse tail @ [head]