#r @"FSharpModules/FAKE/tools/FakeLib.dll"

open Fake
open Fake.FscHelper

let commonDlls = [
  "/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/mscorlib.dll"
  "/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/System.dll"
  "/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/System.Numerics.dll"
  "/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/System.Data.dll"
  "/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/System.Web.dll"
  "/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/System.Xml.Linq.dll"
  "/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/FSharp.Core.dll"
]

//really simple build
Target "HelloWorld.exe" (fun _ ->
  ["HelloWorld.fsx"] |> Fsc (fun p -> { p with References = commonDlls })
  CreateDir "HelloWorld"
  MoveFile "HelloWorld" "HelloWorld.exe"
  commonDlls |> List.iter (fun f -> CopyFile "HelloWorld" f)
)

RunTargetOrDefault "HelloWorld.exe"
