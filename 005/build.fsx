#r @"FSharpModules/FAKE/tools/FakeLib.dll"

open Fake
open Fake.FscHelper

Target "Program.exe" (fun _ ->
  ["program.fsx"] |> Fsc (fun p -> p)
  CreateDir "Program"
  MoveFile "Program" "Program.exe"
)

RunTargetOrDefault "Program.exe"
