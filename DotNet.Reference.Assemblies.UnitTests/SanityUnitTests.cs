using System;
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
        }
    }
}
