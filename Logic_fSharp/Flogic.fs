namespace FSharp 
module FLogic =
    open Microsoft.FSharp.Collections

    let rec reverse list = 
        match list with
        |[] -> []
        |[x] -> [x]
        | head::tail -> reverse tail @ [head]

    let rec quicksort list =
        match list with
        | [] -> []                         // return an empty list
        | firstElem::otherElements ->      // If the list is not empty  
        let smallerElements =          // extract the smaller ones  
            otherElements |> List.filter (fun e -> e < firstElem) |> quicksort              // and sort them
        let largerElements =           // extract the large ones
            otherElements |> List.filter (fun e -> e >= firstElem) |> quicksort              // and sort them
        // Combine the 3 parts into a new list and return it
        List.concat [smallerElements; [firstElem]; largerElements]