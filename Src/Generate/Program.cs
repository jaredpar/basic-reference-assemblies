﻿

using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;

var srcPath = GetSrcPath(args);
var combinedDir = Path.Combine(srcPath, "Basic.Reference.Assemblies");
var encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
NetCoreApp31();
Net50();
Net60();
Net60Windows();
Net70();
Net80();
Net80Windows();
Net90();
Net100();
AspNet80();
AspNet90();
AspNet100();
NetStandard13();
NetStandard20();
NetStandard21();
Net20();
Net35();
Net40();
Net461();
Net472();
CombinedReferenceInfo();

void NetCoreApp31()
{
    var content = GetGeneratedContent("NetCoreApp31", [@"microsoft.netcore.app.ref/3.1.0/ref/netcoreapp3.1"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.NetCoreApp31");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net50()
{
    var content = GetGeneratedContent("Net50", [@"microsoft.netcore.app.ref/5.0.0/ref/net5.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net50");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net60()
{
    var content = GetGeneratedContent("Net60", [@"microsoft.netcore.app.ref/6.0.27/ref/net6.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net60");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net60Windows()
{
    var content = GetGeneratedContent("Net60Windows", [@"microsoft.windowsdesktop.app.ref/6.0.27/ref/net6.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net60Windows");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net70()
{
    var content = GetGeneratedContent("Net70", [@"microsoft.netcore.app.ref/7.0.16/ref/net7.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net70");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net80()
{
    var content = GetGeneratedContent("Net80", [@"microsoft.netcore.app.ref/8.0.3/ref/net8.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net80");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);

    File.WriteAllText(Path.Combine(combinedDir, "Generated.Net80.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(combinedDir, "Generated.Net80.targets"), content.TargetsContent, encoding);
}

void Net80Windows()
{
    var content = GetGeneratedContent("Net80Windows", [@"microsoft.windowsdesktop.app.ref/8.0.8/ref/net8.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net80Windows");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net90()
{
    var content = GetGeneratedContent("Net90", [@"microsoft.netcore.app.ref/9.0.0/ref/net9.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net90");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}


void Net100()
{
    var content = GetGeneratedContent("Net100", [@"microsoft.netcore.app.ref/10.0.0-preview.4.25258.110/ref/net10.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net100");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void AspNet80()
{
    var content = GetGeneratedContent("AspNet80", [@"microsoft.netcore.app.ref/8.0.3/ref/net8.0", @"microsoft.aspnetcore.app.ref/8.0.3/ref/net8.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.AspNet80");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void AspNet90()
{
    var content = GetGeneratedContent("AspNet90", [@"microsoft.netcore.app.ref/9.0.0/ref/net9.0", @"microsoft.aspnetcore.app.ref/9.0.0/ref/net9.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.AspNet90");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}


void AspNet100()
{
    var content = GetGeneratedContent("AspNet100", [@"microsoft.netcore.app.ref/10.0.0-preview.4.25258.110/ref/net10.0", @"microsoft.aspnetcore.app.ref/10.0.0-preview.4.25258.110/ref/net10.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.AspNet100");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void NetStandard13()
{
    // netstandard1.3 is a special case because it's not a single package. Instead the collection of DLLs that make
    // up the TFM are just checked into the repo directly.
    var realPackagePath = Path.Combine(srcPath, "Resources", "netstandard1.3");
    var content = GetGeneratedContentCore("NetStandard13", [realPackagePath], [], srcPath, @"$(MSBuildThisFileDirectory)..");
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.NetStandard13");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void NetStandard20()
{
    var content = GetGeneratedContent(
        "NetStandard20",
        [@"netstandard.library/2.0.3/build/netstandard2.0/ref"],
        [
            @"microsoft.csharp/4.7.0/ref/netstandard2.0",
            @"microsoft.visualbasic/10.3.0/ref/netstandard2.0",
            @"system.threading.tasks.extensions/4.5.4/lib/netstandard2.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.NetStandard20");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
    File.WriteAllText(Path.Combine(combinedDir, "Generated.NetStandard20.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(combinedDir, "Generated.NetStandard20.targets"), content.TargetsContent, encoding);
}

void NetStandard21()
{
    var content = GetGeneratedContent(
        "NetStandard21",
        [@"netstandard.library.ref/2.1.0/ref/netstandard2.1"],
        [
            @"microsoft.csharp/4.7.0/ref/netstandard2.0",
            @"microsoft.visualbasic/10.3.0/ref/netstandard2.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.NetStandard21");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net20()
{
    var content = GetGeneratedContent("Net20", [@"microsoft.netframework.referenceassemblies.net20/1.0.3/build/.NETFramework/v2.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net20");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net40()
{
    var content = GetGeneratedContent("Net40", [@"microsoft.netframework.referenceassemblies.net40/1.0.3/build/.NETFramework/v4.0"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net40");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net35()
{
    var content = GetGeneratedContent("Net35", [@"microsoft.netframework.referenceassemblies.net35/1.0.3/build/.NETFramework/v3.5"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net35");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net461()
{
    var content = GetGeneratedContent(
        "Net461",
        [@"microsoft.netframework.referenceassemblies.net461/1.0.3/build/.NETFramework/v4.6.1"],
        [
            @"system.threading.tasks.extensions/4.5.4/lib/net461",
            @"system.valuetuple/4.5.0/lib/net461"
        ]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net461");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
}

void Net472()
{
    var content = GetGeneratedContent("Net472", [@"microsoft.netframework.referenceassemblies.net472/1.0.3/build/.NETFramework/v4.7.2"]);
    var targetDir = Path.Combine(srcPath, "Basic.Reference.Assemblies.Net472");
    File.WriteAllText(Path.Combine(targetDir, "Generated.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(targetDir, "Generated.targets"), content.TargetsContent, encoding);
    File.WriteAllText(Path.Combine(combinedDir, "Generated.Net472.cs"), content.CodeContent, encoding);
    File.WriteAllText(Path.Combine(combinedDir, "Generated.Net472.targets"), content.TargetsContent, encoding);
}

const string referenceInfo = """

    /// <summary>
    /// Contains different properties of a reference that are interesting for use in testing.
    /// </suummary>
    public readonly struct ReferenceInfo
    {
        /// <summary>
        /// The file name of the reference.
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// The image bytes of the reference
        /// </summary>
        public byte[] ImageBytes { get; }

        /// <summary>
        /// The reference loaded as a <see cref="PortableExecutableReference"/>
        /// </summary>
        public PortableExecutableReference Reference { get; }

        /// <summary>
        /// The MVID of this reference
        /// </summary>
        public Guid Mvid { get; }

        public ReferenceInfo(string fileName, byte[] imageBytes, PortableExecutableReference reference, Guid mvid)
        {
            FileName = fileName;
            ImageBytes = imageBytes;
            Reference = reference;
            Mvid = mvid;
        }

        public void Deconstruct(out string fileName, out byte[] imageBytes, out PortableExecutableReference reference, out Guid mvid)
        {
            fileName = FileName;
            imageBytes = ImageBytes;
            reference = Reference;
            mvid = Mvid;
        }

        public (string FileName, byte[] ImageBytes, PortableExecutableReference Reference, Guid Mvid) AsTuple() =>
            (FileName, ImageBytes, Reference, Mvid);
    }
    """;

void CombinedReferenceInfo()
{
    var content = $$"""
        // This is a generated file, please edit Generate\Program.cs to change the contents
        using Microsoft.CodeAnalysis;
        using System;

        namespace Basic.Reference.Assemblies;
        {{referenceInfo}}
        """;

    File.WriteAllText(Path.Combine(combinedDir, "ReferenceInfo.cs"), content, encoding);
}

string GetSrcPath(string[] args)
{
    var dir = Environment.CurrentDirectory;
    do
    {
        var filePath = Path.Combine(dir, "Src", "Generate", "Program.cs");
        if (File.Exists(filePath))
        {
            return Path.Combine(dir, "Src");
        }

        dir = Path.GetDirectoryName(dir);
    } while (dir != null);

    throw new Exception("Could not find workspace path");
}

static (Guid Mvid, bool IsAssembly)? GetMvid(string filePath)
{
    try
    {
        using var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        using var reader = new PEReader(fileStream, PEStreamOptions.LeaveOpen);
        var mdReader = reader.GetMetadataReader();
        GuidHandle handle = mdReader.GetModuleDefinition().Mvid;
        return (mdReader.GetGuid(handle), mdReader.IsAssembly);
    }
    catch (Exception)
    {
        // The ref assemblies often include a few native DLLs. These won't have MIVD so we can just ignore them.
        return null;
    }
}

static string GetReferenceInfoIndented(string indent)
{
    var builder = new StringBuilder();

    using var reader = new StringReader(referenceInfo);
    var first = true;
    while (reader.ReadLine() is string line)
    {
        if (!first)
        {
            builder.AppendLine();
        }

        if (!string.IsNullOrEmpty(line))
        {
            builder.Append($"{indent}{line}");
        }
        first = false;
    }
    return builder.ToString();
}

static string GetReferenceInfo(string containingTypeName) => $$"""
    #if !BASIC_REFERENCE_ASSEMBLIES_COMBINED
        public static partial class {{containingTypeName}}
        {
    {{GetReferenceInfoIndented("        ")}}
        }
    #endif
    """;

static (string CodeContent, string TargetsContent) GetGeneratedContentCore(string name, string[] packagePaths, string[] extraPackagePaths, string packagePrefix, string targetsPrefix)
{
    var targetsContent = new StringBuilder();
    targetsContent.AppendLine("""
        <Project>
            <ItemGroup>
        """);

    var resourcesContent = new StringBuilder();
    resourcesContent.AppendLine($$"""
        public static partial class {{name}}
        {
            public static class Resources
            {
        """);

    var refContent = new StringBuilder();
    refContent.AppendLine($$"""
        public static partial class {{name}}
        {
            public static class References
            {
        """);

    var refInfoContent = new StringBuilder();
    refInfoContent.AppendLine($$"""
        public static partial class {{name}}
        {
            public static class ReferenceInfos
            {
        """);

    ProcessDlls(
        name,
        packagePaths,
        packagePrefix,
        targetsPrefix,
        "References",
        targetsContent,
        resourcesContent,
        refContent,
        refInfoContent);

    var codeContent = new StringBuilder();
    codeContent.AppendLine($$"""
        // This is a generated file, please edit Src\Generate\Program.cs to change the contents

        using System;
        using System.Collections.Generic;
        using System.Collections.Immutable;
        using System.Linq;
        using Microsoft.CodeAnalysis;

        namespace Basic.Reference.Assemblies;
        """);

    codeContent.AppendLine(refInfoContent.ToString());
    codeContent.AppendLine(refContent.ToString());

    if (extraPackagePaths.Length > 0)
    {
        var extraRefContent = new StringBuilder();
        extraRefContent.AppendLine($$"""
            public static partial class {{name}}
            {
                public static class ExtraReferences
                {
            """);

        var extraRefInfoContent = new StringBuilder();
        extraRefInfoContent.AppendLine($$"""
            public static partial class {{name}}
            {
                public static class ExtraReferenceInfos
                {
            """);

        ProcessDlls(
            name,
            extraPackagePaths,
            packagePrefix,
            targetsPrefix,
            "ExtraReferences",
            targetsContent,
            resourcesContent,
            extraRefContent,
            extraRefInfoContent);
        codeContent.AppendLine(extraRefInfoContent.ToString());
        codeContent.AppendLine(extraRefContent.ToString());
    }

    resourcesContent.AppendLine("""

            }
        }
        """);

    codeContent.AppendLine(resourcesContent.ToString());
    codeContent.AppendLine(GetReferenceInfo(name));

    targetsContent.AppendLine("""
            </ItemGroup>
        </Project>
        """);

    return (codeContent.ToString(), targetsContent.ToString());

    void ProcessDlls(
        string name,
        string[] packagePaths,
        string packagePrefix,
        string targetsPrefix,
        string refName,
        StringBuilder targetsContent,
        StringBuilder resourcesContent, 
        StringBuilder refContent,
        StringBuilder refInfoContent)
    {
        var lowerName = name.ToLower();
        var allPropNames = new List<string>();
        foreach (var dllInfo in FindDlls(packagePaths, packagePrefix))
        {
            var dllName = Path.GetFileName(dllInfo.FilePath)!;
            var dll = Path.GetFileNameWithoutExtension(dllName);
            var logicalName = $"{lowerName}.{dll}";
            var dllResourcePath = Path.Join(targetsPrefix, dllInfo.RelativeFilePath);

            targetsContent.AppendLine($$"""
                        <EmbeddedResource Include="{{dllResourcePath}}" WithCulture="false">
                            <LogicalName>{{logicalName}}</LogicalName>
                            <Link>Resources\{{lowerName}}\{{dllName}}</Link>
                        </EmbeddedResource>
                """);

            var propName = dll.Replace(".", "");
            allPropNames.Add(propName);
            var fieldName = $"_{propName}";
            resourcesContent.AppendLine($$"""
                        /// <summary>
                        /// The image bytes for {{dllName}}
                        /// </summary>
                        public static byte[] {{propName}} => ResourceLoader.GetOrCreateResource(ref {{fieldName}}, "{{logicalName}}");
                        private static byte[]? {{fieldName}};

                """);

            refInfoContent.AppendLine($$"""

                        /// <summary>
                        /// The <see cref="ReferenceInfo"/> for {{dllName}}
                        /// </summary>
                        public static ReferenceInfo {{propName}} => new ReferenceInfo("{{dllName}}", Resources.{{propName}}, {{name}}.{{refName}}.{{propName}}, global::System.Guid.Parse("{{dllInfo.Mvid}}"));
                """);

            refContent.AppendLine($$"""
                        private static PortableExecutableReference? {{fieldName}};

                        /// <summary>
                        /// The <see cref="PortableExecutableReference"/> for {{dllName}}
                        /// </summary>
                        public static PortableExecutableReference {{propName}}
                        {
                            get
                            {
                                if ({{fieldName}} is null)
                                {
                                    {{fieldName}} = AssemblyMetadata.CreateFromImage(ResourceLoader.GetResourceBlobAsImmutable("{{logicalName}}")).GetReference(filePath: "{{dllName}}", display: "{{dll}} ({{lowerName}})");
                                }
                                return {{fieldName}};
                            }
                        }

                """);
        }

        refInfoContent.AppendLine("""
                    private static ImmutableArray<ReferenceInfo> _all;
                    public static ImmutableArray<ReferenceInfo> All
                    {
                        get
                        {
                            if (_all.IsDefault)
                            {
                                _all =
                                [
            """);

        refContent.AppendLine("""
                    private static ImmutableArray<PortableExecutableReference> _all;
                    public static ImmutableArray<PortableExecutableReference> All
                    {
                        get
                        {
                            if (_all.IsDefault)
                            {
                                _all =
                                [
            """);

        foreach (var propName in allPropNames)
        {
        refInfoContent.AppendLine($"                        {propName},");
        refContent.AppendLine($"                        {propName},");
        }

        refContent.AppendLine("""
                                ];
                            }
                            return _all;
                        }
                    }
                }
            }
            """);

        refInfoContent.AppendLine("""
                                ];
                            }
                            return _all;
                        }
                    }

                    public static IEnumerable<(string FileName, byte[] ImageBytes, PortableExecutableReference Reference, Guid Mvid)> AllValues => All.Select(x => x.AsTuple());
                }
            }
            """);
    }

    static IEnumerable<(string FilePath, string RelativeFilePath, Guid Mvid)> FindDlls(string[] packagePaths, string packagePrefix)
    {
        var dllPaths = new List<string>();
        foreach (var packagePath in packagePaths)
        {
            dllPaths.AddRange(Directory.GetFiles(packagePath, "*.dll"));
            var facadesPath = Path.Combine(packagePath, "Facades");
            if (Directory.Exists(facadesPath))
            {
                dllPaths.AddRange(Directory.GetFiles(facadesPath, "*.dll"));
            }
        }

        var allPropNames = new List<string>();
        foreach (var dllPath in dllPaths)
        {
            if (GetMvid(dllPath) is not var (mvid, isAssembly) || !isAssembly)
            {
                continue;
            }

            var relativeFilePath = dllPath.Substring(packagePrefix.Length);
            yield return (dllPath, relativeFilePath, mvid);
        }
    }
}

static (string CodeContent, string TargetsContent) GetGeneratedContent(string name, string[] packagePaths, string[]? extraPackagePaths = null)
{
    var nugetPackageRoot = Environment.GetEnvironmentVariable("NUGET_PACKAGES");
    if (string.IsNullOrEmpty(nugetPackageRoot))
    {
        nugetPackageRoot = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE")!, ".nuget", "packages");
    }

    var realPackagePaths = packagePaths.Select(x => Path.Combine(nugetPackageRoot, x)).ToArray();
    var realExtraPackagePaths = extraPackagePaths is not null 
        ? extraPackagePaths.Select(x => Path.Combine(nugetPackageRoot, x)).ToArray()
        : [];
    return GetGeneratedContentCore(name, realPackagePaths, realExtraPackagePaths, nugetPackageRoot, "$(NuGetPackageRoot)");
}
