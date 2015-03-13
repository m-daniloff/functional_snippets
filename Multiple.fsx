let (|Multiple|_|) m n =
    if n%m=0 then Some Multiple
    else None

let (|Fizz|_|) = (|Multiple|_|) 3
let (|Buzz|_|) = (|Multiple|_|) 5

let FizzBuzz n =
    match n with
    | Fizz & Buzz -> n
    | Fizz -> n
    | Buzz -> n
    | _ -> 0

let input = [1..999]


let sumList list = List.fold(fun acc elem -> acc + FizzBuzz elem) 0 list;;