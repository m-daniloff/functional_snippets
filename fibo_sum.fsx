﻿let nums =
  seq { let n = 10
        yield n + 1
        printfn "second.."
        yield n + 2 };;
// Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
// By starting with 1 and 2, the first 10 terms will be:

// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

// By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
// find the sum of the even-valued terms.

let rec fibonacci n =
    match n with
    | 1 -> 1
    | 2 -> 2
    | n -> fibonacci (n - 1) + fibonacci (n - 2)

// hardcoded interval 1 to 40
// 
let sequence =
  seq {for i in [1..40] do
        let y = fibonacci i
        if (y < 4000000) then yield y }

let result = sequence |> Seq.filter (fun x -> x%2 = 0) |> Seq.sum