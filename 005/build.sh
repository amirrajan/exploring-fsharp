mono ../nuget.exe install FAKE -ExcludeVersion -OutputDirectory FSharpModules -Version 4.3.1

mono FSharpModules/FAKE/tools/FAKE.exe build.fsx
