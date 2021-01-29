using Microsoft.CodeAnalysis.CSharp;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace DotNet.Reference.Assemblies.UnitTests
{
    public class SanityUnitTests
    {
        [Fact]
        public void NetCoreApp31Tests()
        {
            foreach (var portableRef in NetCoreApp31.All)
            {
                Assert.NotNull(portableRef);
            }
            Assert.True(NetCoreApp31.All.Count() > 50);
        }

        [Fact]
        public void NetCoreApp31Compilation()
        {
            var source = @"
using System;

class Program
{
    static void Main() 
    {
        Console.WriteLine(""Hello World"");
    }
}";
            var compilation = CSharpCompilation.Create(
                "Example",
                new[] { CSharpSyntaxTree.ParseText(source) },
                references: NetCoreApp31.All);

            Assert.Empty(compilation.GetDiagnostics());
            using var stream = new MemoryStream();
            var emitResult = compilation.Emit(stream);
            Assert.True(emitResult.Success);
            Assert.Empty(emitResult.Diagnostics);
        }

        [Fact]
        public void Net50Tests()
        {
            foreach (var portableRef in Net50.All)
            {
                Assert.NotNull(portableRef);
            }
            Assert.True(Net50.All.Count() > 50);
        }

        [Fact]
        public void Net50Compilation()
        {
            var source = @"
using System;

class Program
{
    static void Main() 
    {
        Console.WriteLine(""Hello World"");
    }
}";
            var compilation = CSharpCompilation.Create(
                "Example",
                new[] { CSharpSyntaxTree.ParseText(source) },
                references: Net50.All);

            Assert.Empty(compilation.GetDiagnostics());
            using var stream = new MemoryStream();
            var emitResult = compilation.Emit(stream);
            Assert.True(emitResult.Success);
            Assert.Empty(emitResult.Diagnostics);
        }

        [Fact]
        public void NetStandard20Tests()
        {
            foreach (var portableRef in NetStandard20.All)
            {
                Assert.NotNull(portableRef);
            }
            Assert.True(NetStandard20.All.Count() > 50);
        }
    }
}
