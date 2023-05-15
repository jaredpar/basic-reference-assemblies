using Microsoft.CodeAnalysis;
using System;

namespace Basic.Reference.Assemblies
{
    public readonly struct ReferenceInfo
    {
        public string FileName { get; }
        public byte[] ImageBytes { get; }
        public PortableExecutableReference Reference { get; }
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
}