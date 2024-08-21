# Updating Reference Assembly Versions

## Creating a new Target Framework

To create a new Target Framework assembly do the following. Note: this is written for creating `net7.0` but can be applied to any target framework by using the appropriate moniker:

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

Run `dotnet restore` on `Basic.Reference.Assemblies.Net70.csproj` to ensure the NuPkg is downloaded to the machine. Update `Generate\Program.cs` file to have an entry for the new target framework

```csharp
void Net70()
{
    var content = GetGeneratedContent("Net70", [@"microsoft.netcore.app.ref\7.0.16\ref\net7.0"]);
    var targetDir = Path.Combine(workspacePath, "Basic.Reference.Assemblies.Net70");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}
```

Open the Basic.Reference.Assemblies.sln file in Visual Studio. Use `Add Existing Project` to include `Basic.Reference.Assemblies.Net70.csproj` in the solution. Then open `Basic.Reference.Assemblies.csproj` and ensure the new Generated targets are imported

```xml
  <Import Project="Generated.Net70.targets" />
```

## Upgrading existing Target Framework

To upgrade an existing target framework do the following:

1. Navigate to https://www.nuget.org/packages/Microsoft.NETCore.App.Ref and find the latest version for the target framework. For say `net6.0` that will be the latest version begining with `6.0`. 
2. Move to that version in the appropriate project file. For say `net6.0` that wil be Basic.Reference.Assemblies.Net60.csproj
3. Move to that version in `Generate\Program.cs` for the target framework
4. Run `dotnet run Generate\Generate.csproj`
