extern alias RefNetCoreApp31;
extern alias RefNet50;
extern alias RefNetStandard20;
extern alias RefNet472;

using Microsoft.CodeAnalysis.CSharp;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Basic.Reference.Assemblies.UnitTests
{
    using Net50 = RefNet50::Basic.Reference.Assemblies.Net50;
    using NetCoreApp31 = RefNetCoreApp31::Basic.Reference.Assemblies.NetCoreApp31;
    using NetStandard20 = RefNetStandard20::Basic.Reference.Assemblies.NetStandard20;
    using Net472 = RefNet472::Basic.Reference.Assemblies.Net472;

    public class SpecificSanityUnitTests
    {
        [Fact]
        public void NetCoreApp31Tests()
        {
            foreach (var portableRef in NetCoreApp31.All)
            {
                Assert.NotNull(portableRef);
            }
            Assert.True(NetCoreApp31.All.Count() > 50);
            Assert.Equal("Basic.Reference.Assemblies.NetCoreApp31", typeof(NetCoreApp31).Assembly.GetName().Name);
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
            Assert.Equal("Basic.Reference.Assemblies.Net50", typeof(Net50).Assembly.GetName().Name);
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
            Assert.Equal("Basic.Reference.Assemblies.NetStandard20", typeof(NetStandard20).Assembly.GetName().Name);
        }

        [Fact]
        public void Net472Tests()
        {
            foreach (var portableRef in Net472.All)
            {
                Assert.NotNull(portableRef);
            }
            Assert.True(Net472.All.Count() > 50);
            Assert.Equal("Basic.Reference.Assemblies.Net472", typeof(Net472).Assembly.GetName().Name);
        }

        [Fact]
        public void Net472Compilation()
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
                references: Net472.All);

            Assert.Empty(compilation.GetDiagnostics());
            using var stream = new MemoryStream();
            var emitResult = compilation.Emit(stream);
            Assert.True(emitResult.Success);
            Assert.Empty(emitResult.Diagnostics);
        }
    }
}
