## Easy in-memory compilations for Roslyn

[Roslyn](https://github.com/dotnet/roslyn) is a powerful API for C# and Visual Basic compilations. Provide it code, a few options, and a set of references and it will provide an API to inspect the syntax, semantic model, diagnostics and even generate DLLs / EXEs. 

Getting reference assemblies to use with a `Compilation` is challenging because they are only shipped with development tools. In order to use them in a library, the developer must do the heavy lifting of packaging them up as resources in their library and unpacking them at runtime.

The [Basic.Reference.Assemblies](https://www.nuget.org/packages/Basic.Reference.Assemblies/) library takes care of this heavy lifting and provides reference assemblies for `net8.0`, `netstandard2.0` and `net472` target frameworks. These can be easily integrated into the existing Roslyn APIs.

## Usage Examples

```csharp
using Microsoft.CodeAnalysis.CSharp;
using Basic.Reference.Assemblies;
using System.IO;
using System.Reflection;

var code = @"
using System;
public static class Example
{
    public static void Main()
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
        references: ReferenceAssemblies.Net80);

using var stream = new MemoryStream();
var emitResults = compilation.Emit(stream);
stream.Position = 0;
var assembly = Assembly.Load(stream.ToArray());
var method = assembly.GetType("Example").GetMethod("Main");
method.Invoke(null, null); // Prints "Hello World"

```

This package also adds extensions methods for easily retargeting `Compilation` instances to different target frameworks.

```csharp
CSharpCompilation compilation = ...;
compilation = compilation.WithReferenceAssemblies(ReferenceAssemblyKind.Net80);
```

The expectation is that most developers will use [Basic.Reference.Assemblies](https://www.nuget.org/packages/Basic.Reference.Assemblies/). This package has reference assemblies for the latest supported target frameworks and provides APIs to easily switch between them in `Compilation` instances. 

## FAQ

### What if I only need a single target framework?
Developers who only need a single target framework and are extremely size conscious can grab the target framework specific package:

- [Basic.Reference.Assemblies.Net80](https://www.nuget.org/packages/Basic.Reference.Assemblies.Net80/)
- [Basic.Reference.Assemblies.NetStandard20](https://www.nuget.org/packages/Basic.Reference.Assemblies.NetStandard20/)
- [Basic.Reference.Assemblies.Net472](https://www.nuget.org/packages/Basic.Reference.Assemblies.Net472/)

Packages for older target frameworks are also available:

- [Basic.Reference.Assemblies.Net70](https://www.nuget.org/packages/Basic.Reference.Assemblies.Net70/)
- [Basic.Reference.Assemblies.Net60](https://www.nuget.org/packages/Basic.Reference.Assemblies.Net60/)
- [Basic.Reference.Assemblies.Net60Windows](https://www.nuget.org/packages/Basic.Reference.Assemblies.Net60Windows/)
- [Basic.Reference.Assemblies.Net50](https://www.nuget.org/packages/Basic.Reference.Assemblies.Net50/)
- [Basic.Reference.Assemblies.NetCoreApp31](https://www.nuget.org/packages/Basic.Reference.Assemblies.NetCoreApp31/)
- [Basic.Reference.Assemblies.NetStandard13](https://www.nuget.org/packages/Basic.Reference.Assemblies.NetStandard13/)
- [Basic.Reference.Assemblies.Net461](https://www.nuget.org/packages/Basic.Reference.Assemblies.Net461/)

### What is wrong with using `typeof(Enumerable).Assembly`?
Developers working on .NET Framework will often end up with the following pattern for creating `Compilation` instances:

```c#
Assembly systemCoreAssembly = typeof(System.Linq.Enumerable).Assembly;
string systemCorePath = systemCoreAssembly.Location;
MetadataReference systemCoreRef = AssemblyMetadata.CreateFromFile(path).GetReference();
```

This pattern will often work on .NET Framework but will fail when running on .NET Core. The reason for this is due to the differences in reference and implementation assemblies. Reference assemblies are designed for use at build time, while implementation assemblies are used at runtime. A particular type for a given target framework doesn't necessarily live in the same reference and implementation assembly. Also, the set of implementation assemblies can be larger than the reference assemblies for the same target framework.

The reason the above tends to work on .NET Framework is that the split between reference and implementation assemblies is not as pronounced. In most cases, there is a 1:1 relationship. On .NET Core, the split is much more pronounced, and it often requires probing for implementation assemblies to get a set which will work for building. This is a fragile process, though, and developers are much better off using the reference assemblies as intended by the .NET team.
