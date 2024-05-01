// This is a generated file, please edit Generate\Program.cs to change the contents
using Microsoft.CodeAnalysis;
using System;

namespace Basic.Reference.Assemblies
{
    
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
}