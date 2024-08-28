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
internal static class CompilationUtil
{
    public static MemoryStream CompileToLibrary(string code, string assemblyName)
    {
        var references =
#if NET
            Net80.References.All;
#else
            Net461.References.All;
#endif
        var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
        var compilation = CSharpCompilation.Create(
            assemblyName,
            [CSharpSyntaxTree.ParseText(code)],
            references,
            options);

        var peStream = new MemoryStream();
        var emitResult = compilation.Emit(peStream);
        if (!emitResult.Success)
        {
            throw new Exception(GetMessage(emitResult.Diagnostics));
        }

        peStream.Position = 0;
        return peStream;

        static string GetMessage(IEnumerable<Diagnostic> diagnostics)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Compilation failed with the following errors:");
            foreach (var d in diagnostics)
            {
                builder.AppendLine(d.ToString());
            }
            return builder.ToString();
        }
    }

    public static Assembly CompileToLibraryAndLoad(string code, string assemblyName)
    {
        var stream = CompileToLibrary(code, assemblyName);
        return Load(stream, assemblyName);
    }

    /// <summary>
    /// Compile and run the code expecting to find a static Lib.Go method
    /// </summary>
    public static string? CompileAndRun(string code, string assemblyName)
    {
        var assembly = CompileToLibraryAndLoad(code, assemblyName);
        var libType = assembly
            .GetTypes()
            .Where(x => x.Name == "Lib")
            .Single();
        var method = libType.GetMethod("Go", BindingFlags.Static | BindingFlags.NonPublic);
        var obj = method!.Invoke(null, null);
        return (string?)obj;
    }

    public static Assembly Load(MemoryStream stream, string assemblyName)
    {
        stream.Position = 0;
#if NET
        var alc = new System.Runtime.Loader.AssemblyLoadContext(assemblyName);
        return alc.LoadFromStream(stream);
#else
        return Assembly.Load(stream.ToArray());
#endif
    }
}
