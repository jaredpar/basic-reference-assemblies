
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Xunit;

namespace Basic.Reference.Assemblies.UnitTests;

public sealed class CoreUnitTests
{

    [Fact]
    public void Issue43()
    {
        var references = new List<MetadataReference>(Basic.Reference.Assemblies.Net70.References.All)
        {
            MetadataReference.CreateFromFile(Assembly.GetExecutingAssembly().Location)
        };

        Assert.NotEmpty(references);
    }
}