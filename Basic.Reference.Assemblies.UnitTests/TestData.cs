extern alias Combined;

using System.Collections.Generic;
using System.Linq;

using CombinedAssembly = Combined::Basic.Reference.Assemblies;

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
                    new object[] { "net461", Net461.References.All },
                    new object[] { "net472", Net472.References.All },
                    new object[] { "netcoreapp3.1", NetCoreApp31.References.All },
                    new object[] { "net5.0", Net50.References.All },
                    new object[] { "net6.0", Net60.References.All },
                    new object[] { "net7.0", Net70.References.All },
                    new object[] { "net8.0", Net70.References.All },

                    new object[] { "netstandard2.0", CombinedAssembly.NetStandard20.References.All },
                    new object[] { "net8.0", CombinedAssembly.Net80.References.All },
                };
            }
        }

        public static IEnumerable<object[]> LibraryReferences
        {
            get
            {
                return new object[][]
                {
                    new object[] { "netstandard1.3", NetStandard13.References.All },
                    new object[] { "netstandard2.0", NetStandard20.References.All },

                    new object[] { "netstandard2.0", CombinedAssembly.NetStandard20.References.All },
                };
            }
        }

        public static IEnumerable<object[]> AllReferences
        {
            get => LibraryReferences.Concat(ApplicationReferences);
        }

        public static IEnumerable<object[]> AllValues
        {
            get
            {
                return new object[][]
                {
                    new object[] { "netstandard1.3", NetStandard13.ReferenceInfos.AllValues },
                    new object[] { "netstandard2.0", NetStandard20.ReferenceInfos.AllValues },
                    new object[] { "net461", Net461.ReferenceInfos.AllValues },
                    new object[] { "net472", Net472.ReferenceInfos.AllValues },
                    new object[] { "netcoreapp3.1", NetCoreApp31.ReferenceInfos.AllValues },
                    new object[] { "net5.0", Net50.ReferenceInfos.AllValues },
                    new object[] { "net6.0", Net60.ReferenceInfos.AllValues },
                    new object[] { "net7.0", Net70.ReferenceInfos.AllValues },
                    new object[] { "net8.0", Net80.ReferenceInfos.AllValues },
                    new object[] { "net8.0", Net80.ReferenceInfos.AllValues },
                    new object[] { "net8.0", Net80.ReferenceInfos.AllValues },

                    new object[] { "netstandard2.0", CombinedAssembly.NetStandard20.ReferenceInfos.AllValues },
                    new object[] { "net472", CombinedAssembly.Net472.ReferenceInfos.AllValues },
                    new object[] { "net8.0", CombinedAssembly.Net80.ReferenceInfos.AllValues },
                };
            }
        }
    }
}
