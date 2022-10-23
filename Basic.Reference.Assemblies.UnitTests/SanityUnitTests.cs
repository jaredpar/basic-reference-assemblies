using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Basic.Reference.Assemblies.UnitTests
{
    public class SanityUnitTests
    {
        [Theory]
        [MemberData(nameof(TestData.ApplicationReferences), MemberType = typeof(TestData))]
        public void AllAppCanCompile(string targetFramework, IEnumerable<MetadataReference> references)
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

            var compilation = CSharpCompilation.Create(
                "Example",
                new[] { CSharpSyntaxTree.ParseText(source) },
                references: references);

            Assert.Empty(compilation.GetDiagnostics());
            using var stream = new MemoryStream();
            var emitResult = compilation.Emit(stream);
            Assert.True(emitResult.Success);
            Assert.Empty(emitResult.Diagnostics);
            Assert.NotEmpty(targetFramework);
        }

        [Theory]
        [MemberData(nameof(TestData.AllReferences), MemberType = typeof(TestData))]
        public void AllLibraryCanCompile(string targetFramework, IEnumerable<MetadataReference> references)
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

            var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            var compilation = CSharpCompilation.Create(
                "Example",
                new[] { CSharpSyntaxTree.ParseText(source) },
                options: options,
                references: references);

            // NetStandard1.3 comes with several no warn options we need here
            if (targetFramework == "netstandard1.3")
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

        private static CSharpCompilation NoWarn(CSharpCompilation compilation, string id)
        {
            var diagnosticMap = compilation.Options.SpecificDiagnosticOptions;
            diagnosticMap = diagnosticMap.SetItem(id, ReportDiagnostic.Suppress);
            var options = compilation.Options.WithSpecificDiagnosticOptions(diagnosticMap);
            return compilation.WithOptions(options);
        }
    }
}
