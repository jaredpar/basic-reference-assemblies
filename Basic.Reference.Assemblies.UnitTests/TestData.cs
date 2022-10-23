using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Reference.Assemblies.UnitTests
{
    public static class TestData
    {
        public static IEnumerable<object[]> ApplicationReferences
        {
            get
            {
                return new object[][]
                {
                    new object[] { "net461", Net461.All },
                };
            }
        }

        public static IEnumerable<object[]> LibraryReferences
        {
            get
            {
                return new object[][]
                {
                    new object[] { "netstandard1.3", NetStandard13.All },
                    new object[] { "netstandard2.0", NetStandard20.All },
                };
            }
        }

        public static IEnumerable<object[]> AllReferences
        {
            get => LibraryReferences.Concat(ApplicationReferences);
        }
    }
}
