using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;

namespace Basic.Reference.Assemblies;
public static class ReferenceAssemblies
{
    public static IEnumerable<PortableExecutableReference> Net80 => Basic.Reference.Assemblies.Net80.References.All;
    public static IEnumerable<PortableExecutableReference> NetStandard20 => Basic.Reference.Assemblies.NetStandard20.References.All;
    public static IEnumerable<PortableExecutableReference> Net472 => Basic.Reference.Assemblies.Net472.References.All;

    public static IEnumerable<PortableExecutableReference> Get(ReferenceAssemblyKind kind) => kind switch
    {
        ReferenceAssemblyKind.Net80 => Net80,
        ReferenceAssemblyKind.NetStandard20 => NetStandard20,
        ReferenceAssemblyKind.Net472 => Net472,
        _ => throw new Exception($"Invalid kind: {kind}")
    };
}

public enum ReferenceAssemblyKind
{
    Net80,
    NetStandard20,
    Net472,
}

public static class Extensions
{
    public static T WithReferenceAssemblies<T>(this T compilation, ReferenceAssemblyKind kind)
        where T : Compilation
    {
        var references = ReferenceAssemblies.Get(kind);
        return (T)(compilation.WithReferences(references));
    }
}
