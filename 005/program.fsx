#load "proj.fsx"

open Module1
open Module2
open Module3
open Module4

sayHelloModule1 () |> printfn "%s"
sayHelloModule2 () |> printfn "%s"
sayHelloModule3 () |> printfn "%s"
sayHello () |> printfn "%s"
