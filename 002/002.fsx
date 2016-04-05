#I "./FsharpModules/Http.fs/lib/net40"
#I "./FSharpModules/FSharp.Data/lib/net40"

#r "HttpClient.dll"
#r "FSharp.Data.dll"

open System
open HttpClient
open FSharp.Data
open FSharp.Data.JsonExtensions
open System.Collections.Generic

let response = "http://api.fixer.io/latest" |> createRequest Get |> getResponse

let map = JsonValue.Parse response.EntityBody.Value

printfn "%A" map.["base"]
printfn "%A" map.["rates"]
printfn "%A" map.["rates"].["AUD"]
