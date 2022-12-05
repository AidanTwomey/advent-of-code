#load "rucksacks.fsx"
#load "priorities.fsx"

open Rucksacks
open Priorities

let rucksack = problem_input

let half (contents: string) =
    let mid = contents.Length / 2
    let length = contents.Length 
    (contents.Substring(0, mid) |> Seq.toList, contents.Substring(mid, mid))

let rec matchChar characters c =
    match characters with
    | h::t when c = h -> Some(c); 
    | head::tail      -> matchChar tail c
    | []              -> None

let common (first,second) = 
    second |> Seq.pick (matchChar first) 

let common3 (triple:string[]) = 
    let first = Seq.toList triple.[0]
    let shared = Seq.toList triple.[1] |> List.choose (matchChar first)
    common (shared, Seq.toList triple.[2])

let toPriority c =
    priorities.[c]

// let total =
//   rucksack.Split('\n') 
//     |> Seq.map half 
//     |> Seq.map common 
//     |> Seq.map toPriority
//     |> Seq.sum

let total =
  rucksack.Split('\n') 
  |> Seq.chunkBySize 3 
  |> Seq.map common3 
  |> Seq.map toPriority
  |> Seq.sum

printfn "%i" total