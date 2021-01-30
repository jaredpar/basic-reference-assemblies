using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Basic.Reference.Assemblies.UnitTests
{
    public class SanityUnitTests
    {
        [Fact]
        public void AllCanCompile()
        {
            var source = @"
using System;

public class C
{
    public Exception Exception;

    static void Main() 
    {
        Console.WriteLine(""Hello World"");
    }
}";

            foreach (var kind in Enum.GetValues<ReferenceAssemblyKind>())
            {
                var compilation = CSharpCompilation.Create(
                    "Example",
                    new[] { CSharpSyntaxTree.ParseText(source) },
                    references: ReferenceAssemblies.Get(kind));

                Assert.Empty(compilation.GetDiagnostics());
                using var stream = new MemoryStream();
                var emitResult = compilation.Emit(stream);
                Assert.True(emitResult.Success);
                Assert.Empty(emitResult.Diagnostics);
            }
        }

        [Fact]
        public void AllCanCompile2()
        {
            var source = @"
using System;

public class C
{
    public Exception Exception;

    static void Main() 
    {
        Console.WriteLine(""Hello World"");
    }
}";

            foreach (var kind in Enum.GetValues<ReferenceAssemblyKind>())
            {
                var compilation = CSharpCompilation.Create(
                    "Example",
                    new[] { CSharpSyntaxTree.ParseText(source) },
                    references: Array.Empty<MetadataReference>());
                compilation = compilation.WithReferenceAssemblies(kind);

                Assert.Empty(compilation.GetDiagnostics());
                using var stream = new MemoryStream();
                var emitResult = compilation.Emit(stream);
                Assert.True(emitResult.Success);
                Assert.Empty(emitResult.Diagnostics);
            }
        }
    }
}
