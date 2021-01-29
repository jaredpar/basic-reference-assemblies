# Simplify in memory compilation for .NET Core

[Roslyn](https://github.com/dotnet/roslyn) is a powerful API for C# and Visual 
Basic compilations. Provide it code, a few options and a set of references and 
it will provide an API to inspect the syntax, semantic model, diagnostics and 
even generate DLLs / EXEs. 

These technologies are very straight forward to use when running on .NET 
Framework because implementation assemblies can substitute for reference 
assemblies. That means if a user wants to add a reference to `System.Core.dll'
to the compiler all they need to do is use the runtime assembly:

```c#
Assembly systemCoreAssembly = typeof(System.Linq.Enumerable).Assembly;
string systemCorePath = systemCoreAssembly.Location;
MetadataReference systemCoreRef = AssemblyMetadata.CreateFromFile(string path).GetReference();
```

This does not work on .NET Core though because there is a strong split between 
reference and implementation assemblies. The above code will give you access to 
the implementation assembly on .NET Core and is not a supported input for 
compilation. Instead you need to get the actual reference assembly.

Unfortunately .NET Core and .NET Standard only ship reference assemblies as 
physical files. These are not easily consumable at runtime in a .NET library 
or application. Hence any .NET app which wants to use the reference assemblies 
must do the heavy lifting of packaging them up as resources and unpacking them
at runtime. 

The `DotNet.Reference.Assemblies` libraries takes care of this heavy lifting 
and provides the reference assemblies for `netstandard2.0`, `netcoreapp3.1` and
`net5.0`. These can be easily integrated into the existing Roslyn APIs.

```c#
var code = @"
using System;
static class Program
{
    static void Main()
    {
        var tuple = (Part1: ""hello"", Part2: ""world"");
        Console.WriteLine($""{tuple.Part1} {tuple.Part2}"");
    }
}
";

var compilation = CSharpCompilation
    .Create(
        "HelloWorld.dll",
        new[] { CSharpSyntaxTree.ParseText(code) },
        references: Net50.All);

using var fileStream = new FileStream(@"p:\temp\helloworld.exe", FileMode.Create, FileAccess.ReadWrite);
var emitResults = compilation.Emit(fileStream);
```

These make it much simpler to approach compilation inside your libraries
or application.

**Note** .NET Framework also has a split between reference and implementation 
assemblies but it is not as strong as on .NET Core.
