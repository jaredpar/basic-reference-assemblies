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

                // NetStandard1.3 comes with several no warn options we need here
                if (kind == ReferenceAssemblyKind.NetStandard13)
                {
                    compilation = NoWarn(compilation, "CS1702");
                    compilation = NoWarn(compilation, "CS1701");
                }

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

                // NetStandard1.3 comes with several no warn options we need here
                if (kind == ReferenceAssemblyKind.NetStandard13)
                {
                    compilation = NoWarn(compilation, "CS1702");
                    compilation = NoWarn(compilation, "CS1701");
                }

                Assert.Empty(compilation.GetDiagnostics());
                using var stream = new MemoryStream();
                var emitResult = compilation.Emit(stream);
                Assert.True(emitResult.Success);
                Assert.Empty(emitResult.Diagnostics);
            }
        }

        private static CSharpCompilation NoWarn(CSharpCompilation compilation, string id)
        {
            var diagnosticMap = compilation.Options.SpecificDiagnosticOptions;
            diagnosticMap = diagnosticMap.SetItem(id, ReportDiagnostic.Suppress);
            var options = compilation.Options.WithSpecificDiagnosticOptions(diagnosticMap);
            return compilation.WithOptions(options);
        }
    }
}
