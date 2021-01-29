using System;
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
        public void Net50Tests()
        {
            foreach (var portableRef in Net50.All)
            {
                Assert.NotNull(portableRef);
            }
            Assert.True(Net50.All.Count() > 50);
        }
    }
}
