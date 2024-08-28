using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Reference.Assemblies.UnitTests;
internal static class Extensions
{
    public static Guid GetMvid(this PortableExecutableReference peReference)
    {
        if (peReference.GetMetadata() is AssemblyMetadata metadata &&
            metadata.GetModules() is {  Length: > 0 } modules)
        {
            return modules[0].GetModuleVersionId();
        }

        throw new InvalidOperationException();
    }
}
