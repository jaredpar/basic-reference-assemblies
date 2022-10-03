Updating Reference Assembly Versions
===

# Creating a new Target Framework
To create a new Target Framework assembly do the following. Note: this is written for creating `net7.0` but can be applied to any target framework by using the approriate moniker:

First need to find the version of the Microsoft.NETCore.App.Ref to use. Navigate to the [NuPkg link](https://www.nuget.org/packages/Microsoft.NETCore.App.Ref) and find the latest version. In this case we'll be using 7.0.0-rc.1.22426.10. 

Create the directory `Basic.Reference.Assemblies.Net70` and add a project file with the following format:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <IsPackable>true</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NETCore.App.Ref" Version="7.0.0-rc.1.22426.10" IncludeAssets="none" PrivateAssets="all" GeneratePathProperty="true" />
  </ItemGroup>

  <Import Project="Generated.targets" />
</Project>
```

Run `dotnet restore` to ensure the NuPkg is downloaded to the machine. Update the `Generate.ps1` file to have an entry for the new target framework

**Note**: the version on disk can differ from what is put in the csproj file. If `Generate.ps1` fails check to see if the version on disk was slightly different and just use that.

```ps1
# Net70
$map = Get-Content "Net70" 'microsoft.netcore.app.ref\7.0.0-rc.2.22469.6\ref\net7.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net70"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.Net70.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.Net70.targets") -Encoding Utf8
```

Open the Basic.Reference.Assemblies.sln file in Visual Studio. Use `Add Existing Project` to include `Basic.Reference.Assemblies.Net70.csproj` in the solution. Then open `Basic.Reference.Assemblies.csproj` and ensure the new Generated targets are imported

```xml
  <Import Project="Generated.Net70.targets" />
```

Open `publish.yml` and add an entry for the target framework

```yml
      - name: Pack Net70
        run: dotnet pack --no-build -p:IncludeSymbols=false -p:RepositoryCommit=${GITHUB_SHA} -p:PackageVersion="${{ github.event.inputs.version }}" -c Release Basic.Reference.Assemblies.Net70/Basic.Reference.Assemblies.Net70.csproj -o .
```

# Upgrading existing Target Framework
To upgrade an existing target framework do the following:

1. Navigate to https://www.nuget.org/packages/Microsoft.NETCore.App.Ref and find the latest version for the target framework. For say `net6.0` that will be the latest version begining with `6.0`. 
2. Move to that version in the appropriate project file. For say `net6.0` that wil be Basic.Reference.Assemblies.Net60.csproj
3. Move to that version in Generate.ps1 for the target framework 
4. Run `Scripts\Generate.ps1`

