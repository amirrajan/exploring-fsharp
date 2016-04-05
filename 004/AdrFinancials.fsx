open System

let split sep (x : String) = x.Split([|sep|])
let lastNItems num xs = xs |> Seq.skip (Seq.length xs - num)

let lines = IO.File.ReadAllLines("./Data/85830718_0216_AE.txt")


Seq.tail (Seq.except (lastNItems 3 lines) lines)
let sales = lines |> Seq.except (lastNItems 3 lines) |> Seq.tail

let firstLine = Seq.head sales |> split '\t'

let sale = Double.Parse(Seq.item 7 firstLine)
let currency = Seq.item 8 firstLine
let sr = Seq.item 9 firstLine
