using System;
using System.Collections.Immutable;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Basic.Reference.Assemblies
{
    internal static class ResourceLoader
    {
        internal static Stream GetResourceStream(string name)
        {
            var assembly = typeof(ResourceLoader).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream(name);
            if (stream == null)
            {
                throw new InvalidOperationException($"Resource '{name}' not found in {assembly.FullName}.");
            }

            return stream;
        }

        internal static byte[] GetResourceBlob(string name)
        {
            using var stream = GetResourceStream(name);
            var bytes = new byte[stream.Length];
            using var memoryStream = new MemoryStream(bytes);
            stream.CopyTo(memoryStream);
            return bytes;
        }

        internal static ImmutableArray<byte> GetResourceBlobAsImmutable(string name)
        {
            var blob = GetResourceBlob(name);
            return ImmutableCollectionsMarshal.AsImmutableArray(blob);
        }

        internal static byte[] GetOrCreateResource(ref byte[]? resource, string name)
        {
            if (resource == null)
            {
                resource = GetResourceBlob(name);
            }

            return resource;
        }

        internal static string GetOrCreateResource(ref string resource, string name)
        {
            if (resource == null)
            {
                using var stream = GetResourceStream(name);
                using var streamReader = new StreamReader(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true);
                resource = streamReader.ReadToEnd();
            }

            return resource;
        }
    }
}
