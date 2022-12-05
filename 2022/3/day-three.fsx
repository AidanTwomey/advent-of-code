#load "rucksacks.fsx"
#load "priorities.fsx"

open Rucksacks
open Priorities

let rucksack = test_input

let half (contents: string) =
    let mid = contents.Length / 2
    let length = contents.Length 
    (contents.Substring(0, mid) |> Seq.toList, contents.Substring(mid, mid))

let common (first,second) = 
    let rec matchChar characters c =
        match characters with
        | h::t when c = h -> Some(c); 
        | head::tail      -> matchChar tail c
        | []              -> None
    second |> Seq.pick (matchChar first) 

let toPriority c =
    priorities.[c]

let total =
  rucksack.Split('\n') 
    |> Seq.map half 
    |> Seq.map common 
    |> Seq.map toPriority
    |> Seq.sum

printfn "%i" total