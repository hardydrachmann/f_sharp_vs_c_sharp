namespace FSharp 
module FLogic =
    open Microsoft.FSharp.Collections
    
    // Be carefull: Recursive functions are not good for large lists (may result in a stack overflow)
    let rec reverse list = 
        match list with
        | [] -> []
        | [x] -> [x]
        | head::tail -> reverse tail @ [head]

    let rec quicksort list =
        match list with
        | [] -> []                                                      // return an empty list
        | pivot::tail ->                                                // If the list is not empty  
        let smallerElements =                                           // extract the smaller ones  
            tail |> List.filter (fun e -> e < pivot) |> quicksort       // and sort them
        let largerElements =                                            // extract the large ones
            tail |> List.filter (fun e -> e >= pivot) |> quicksort      // and sort them
        List.concat [smallerElements; [pivot]; largerElements]          // Combine the 3 parts into a new list and return it
        
    let mutable sum = 0
    let calculate list =
        list |> List.map (fun x -> sum <- sum + x) |> printfn "%A" 
        sum