# csharp-test

## How to target .net 6.0 (when already installed dotnet 7)

- Change csproj files to target net6.0
- Download tar.gz files from https://dotnet.microsoft.com/en-us/download/dotnet/6.0
- Move to a folder (tmp), extract all files
- When giving dotnet commands, refer to the file path they were extracted, i.e. ```~/tmp/dotnet build```

Alternatively, remove the dotnet 7 somehow, and then extract above files within a PATH folder.
