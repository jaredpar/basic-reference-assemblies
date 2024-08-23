// This is a generated file, please edit Src\Generate\Program.cs to change the contents

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Basic.Reference.Assemblies;
public static partial class NetStandard20
{
    public static class ExtraReferenceInfos
    {

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for Microsoft.CSharp.dll
        /// </summary>
        public static ReferenceInfo MicrosoftCSharp => new ReferenceInfo("Microsoft.CSharp.dll", Resources.MicrosoftCSharp, NetStandard20.ExtraReferences.MicrosoftCSharp, global::System.Guid.Parse("481b904b-3433-4e80-b896-766a3cc8e857"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for Microsoft.VisualBasic.dll
        /// </summary>
        public static ReferenceInfo MicrosoftVisualBasic => new ReferenceInfo("Microsoft.VisualBasic.dll", Resources.MicrosoftVisualBasic, NetStandard20.ExtraReferences.MicrosoftVisualBasic, global::System.Guid.Parse("b61ee3c6-71d0-4726-931a-fa448a2e8f0e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Threading.Tasks.Extensions.dll
        /// </summary>
        public static ReferenceInfo SystemThreadingTasksExtensions => new ReferenceInfo("System.Threading.Tasks.Extensions.dll", Resources.SystemThreadingTasksExtensions, NetStandard20.ExtraReferences.SystemThreadingTasksExtensions, global::System.Guid.Parse("619062a8-972f-4ae5-bbee-e36ac541d14f"));
        private static ImmutableArray<ReferenceInfo> _all;
        public static ImmutableArray<ReferenceInfo> All
        {
            get
            {
                if (_all.IsDefault)
                {
                    _all =
                    [
                        MicrosoftCSharp,
                        MicrosoftVisualBasic,
                        SystemThreadingTasksExtensions,
                    ];
                }
                return _all;
            }
        }

        public static IEnumerable<(string FileName, byte[] ImageBytes, PortableExecutableReference Reference, Guid Mvid)> AllValues => All.Select(x => x.AsTuple());
    }
}

public static partial class NetStandard20
{
    public static class ExtraReferences
    {
        private static PortableExecutableReference? _MicrosoftCSharp;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for Microsoft.CSharp.dll
        /// </summary>
        public static PortableExecutableReference MicrosoftCSharp
        {
            get
            {
                if (_MicrosoftCSharp is null)
                {
                    _MicrosoftCSharp = AssemblyMetadata.CreateFromImage(Resources.MicrosoftCSharp).GetReference(filePath: "Microsoft.CSharp.dll", display: "Microsoft.CSharp (netstandard20)");
                }
                return _MicrosoftCSharp;
            }
        }

        private static PortableExecutableReference? _MicrosoftVisualBasic;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for Microsoft.VisualBasic.dll
        /// </summary>
        public static PortableExecutableReference MicrosoftVisualBasic
        {
            get
            {
                if (_MicrosoftVisualBasic is null)
                {
                    _MicrosoftVisualBasic = AssemblyMetadata.CreateFromImage(Resources.MicrosoftVisualBasic).GetReference(filePath: "Microsoft.VisualBasic.dll", display: "Microsoft.VisualBasic (netstandard20)");
                }
                return _MicrosoftVisualBasic;
            }
        }

        private static PortableExecutableReference? _SystemThreadingTasksExtensions;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Threading.Tasks.Extensions.dll
        /// </summary>
        public static PortableExecutableReference SystemThreadingTasksExtensions
        {
            get
            {
                if (_SystemThreadingTasksExtensions is null)
                {
                    _SystemThreadingTasksExtensions = AssemblyMetadata.CreateFromImage(Resources.SystemThreadingTasksExtensions).GetReference(filePath: "System.Threading.Tasks.Extensions.dll", display: "System.Threading.Tasks.Extensions (netstandard20)");
                }
                return _SystemThreadingTasksExtensions;
            }
        }

        private static ImmutableArray<PortableExecutableReference> _all;
        public static ImmutableArray<PortableExecutableReference> All
        {
            get
            {
                if (_all.IsDefault)
                {
                    _all =
                    [
                        MicrosoftCSharp,
                        MicrosoftVisualBasic,
                        SystemThreadingTasksExtensions,
                    ];
                }
                return _all;
            }
        }
    }
}

public static partial class NetStandard20
{
    public static class Resources
    {
        /// <summary>
        /// The image bytes for Microsoft.Win32.Primitives.dll
        /// </summary>
        public static byte[] MicrosoftWin32Primitives => ResourceLoader.GetOrCreateResource(ref _MicrosoftWin32Primitives, "netstandard20.Microsoft.Win32.Primitives");
        private static byte[]? _MicrosoftWin32Primitives;

        /// <summary>
        /// The image bytes for mscorlib.dll
        /// </summary>
        public static byte[] mscorlib => ResourceLoader.GetOrCreateResource(ref _mscorlib, "netstandard20.mscorlib");
        private static byte[]? _mscorlib;

        /// <summary>
        /// The image bytes for netstandard.dll
        /// </summary>
        public static byte[] netstandard => ResourceLoader.GetOrCreateResource(ref _netstandard, "netstandard20.netstandard");
        private static byte[]? _netstandard;

        /// <summary>
        /// The image bytes for System.AppContext.dll
        /// </summary>
        public static byte[] SystemAppContext => ResourceLoader.GetOrCreateResource(ref _SystemAppContext, "netstandard20.System.AppContext");
        private static byte[]? _SystemAppContext;

        /// <summary>
        /// The image bytes for System.Collections.Concurrent.dll
        /// </summary>
        public static byte[] SystemCollectionsConcurrent => ResourceLoader.GetOrCreateResource(ref _SystemCollectionsConcurrent, "netstandard20.System.Collections.Concurrent");
        private static byte[]? _SystemCollectionsConcurrent;

        /// <summary>
        /// The image bytes for System.Collections.dll
        /// </summary>
        public static byte[] SystemCollections => ResourceLoader.GetOrCreateResource(ref _SystemCollections, "netstandard20.System.Collections");
        private static byte[]? _SystemCollections;

        /// <summary>
        /// The image bytes for System.Collections.NonGeneric.dll
        /// </summary>
        public static byte[] SystemCollectionsNonGeneric => ResourceLoader.GetOrCreateResource(ref _SystemCollectionsNonGeneric, "netstandard20.System.Collections.NonGeneric");
        private static byte[]? _SystemCollectionsNonGeneric;

        /// <summary>
        /// The image bytes for System.Collections.Specialized.dll
        /// </summary>
        public static byte[] SystemCollectionsSpecialized => ResourceLoader.GetOrCreateResource(ref _SystemCollectionsSpecialized, "netstandard20.System.Collections.Specialized");
        private static byte[]? _SystemCollectionsSpecialized;

        /// <summary>
        /// The image bytes for System.ComponentModel.Composition.dll
        /// </summary>
        public static byte[] SystemComponentModelComposition => ResourceLoader.GetOrCreateResource(ref _SystemComponentModelComposition, "netstandard20.System.ComponentModel.Composition");
        private static byte[]? _SystemComponentModelComposition;

        /// <summary>
        /// The image bytes for System.ComponentModel.dll
        /// </summary>
        public static byte[] SystemComponentModel => ResourceLoader.GetOrCreateResource(ref _SystemComponentModel, "netstandard20.System.ComponentModel");
        private static byte[]? _SystemComponentModel;

        /// <summary>
        /// The image bytes for System.ComponentModel.EventBasedAsync.dll
        /// </summary>
        public static byte[] SystemComponentModelEventBasedAsync => ResourceLoader.GetOrCreateResource(ref _SystemComponentModelEventBasedAsync, "netstandard20.System.ComponentModel.EventBasedAsync");
        private static byte[]? _SystemComponentModelEventBasedAsync;

        /// <summary>
        /// The image bytes for System.ComponentModel.Primitives.dll
        /// </summary>
        public static byte[] SystemComponentModelPrimitives => ResourceLoader.GetOrCreateResource(ref _SystemComponentModelPrimitives, "netstandard20.System.ComponentModel.Primitives");
        private static byte[]? _SystemComponentModelPrimitives;

        /// <summary>
        /// The image bytes for System.ComponentModel.TypeConverter.dll
        /// </summary>
        public static byte[] SystemComponentModelTypeConverter => ResourceLoader.GetOrCreateResource(ref _SystemComponentModelTypeConverter, "netstandard20.System.ComponentModel.TypeConverter");
        private static byte[]? _SystemComponentModelTypeConverter;

        /// <summary>
        /// The image bytes for System.Console.dll
        /// </summary>
        public static byte[] SystemConsole => ResourceLoader.GetOrCreateResource(ref _SystemConsole, "netstandard20.System.Console");
        private static byte[]? _SystemConsole;

        /// <summary>
        /// The image bytes for System.Core.dll
        /// </summary>
        public static byte[] SystemCore => ResourceLoader.GetOrCreateResource(ref _SystemCore, "netstandard20.System.Core");
        private static byte[]? _SystemCore;

        /// <summary>
        /// The image bytes for System.Data.Common.dll
        /// </summary>
        public static byte[] SystemDataCommon => ResourceLoader.GetOrCreateResource(ref _SystemDataCommon, "netstandard20.System.Data.Common");
        private static byte[]? _SystemDataCommon;

        /// <summary>
        /// The image bytes for System.Data.dll
        /// </summary>
        public static byte[] SystemData => ResourceLoader.GetOrCreateResource(ref _SystemData, "netstandard20.System.Data");
        private static byte[]? _SystemData;

        /// <summary>
        /// The image bytes for System.Diagnostics.Contracts.dll
        /// </summary>
        public static byte[] SystemDiagnosticsContracts => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsContracts, "netstandard20.System.Diagnostics.Contracts");
        private static byte[]? _SystemDiagnosticsContracts;

        /// <summary>
        /// The image bytes for System.Diagnostics.Debug.dll
        /// </summary>
        public static byte[] SystemDiagnosticsDebug => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsDebug, "netstandard20.System.Diagnostics.Debug");
        private static byte[]? _SystemDiagnosticsDebug;

        /// <summary>
        /// The image bytes for System.Diagnostics.FileVersionInfo.dll
        /// </summary>
        public static byte[] SystemDiagnosticsFileVersionInfo => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsFileVersionInfo, "netstandard20.System.Diagnostics.FileVersionInfo");
        private static byte[]? _SystemDiagnosticsFileVersionInfo;

        /// <summary>
        /// The image bytes for System.Diagnostics.Process.dll
        /// </summary>
        public static byte[] SystemDiagnosticsProcess => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsProcess, "netstandard20.System.Diagnostics.Process");
        private static byte[]? _SystemDiagnosticsProcess;

        /// <summary>
        /// The image bytes for System.Diagnostics.StackTrace.dll
        /// </summary>
        public static byte[] SystemDiagnosticsStackTrace => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsStackTrace, "netstandard20.System.Diagnostics.StackTrace");
        private static byte[]? _SystemDiagnosticsStackTrace;

        /// <summary>
        /// The image bytes for System.Diagnostics.TextWriterTraceListener.dll
        /// </summary>
        public static byte[] SystemDiagnosticsTextWriterTraceListener => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsTextWriterTraceListener, "netstandard20.System.Diagnostics.TextWriterTraceListener");
        private static byte[]? _SystemDiagnosticsTextWriterTraceListener;

        /// <summary>
        /// The image bytes for System.Diagnostics.Tools.dll
        /// </summary>
        public static byte[] SystemDiagnosticsTools => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsTools, "netstandard20.System.Diagnostics.Tools");
        private static byte[]? _SystemDiagnosticsTools;

        /// <summary>
        /// The image bytes for System.Diagnostics.TraceSource.dll
        /// </summary>
        public static byte[] SystemDiagnosticsTraceSource => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsTraceSource, "netstandard20.System.Diagnostics.TraceSource");
        private static byte[]? _SystemDiagnosticsTraceSource;

        /// <summary>
        /// The image bytes for System.Diagnostics.Tracing.dll
        /// </summary>
        public static byte[] SystemDiagnosticsTracing => ResourceLoader.GetOrCreateResource(ref _SystemDiagnosticsTracing, "netstandard20.System.Diagnostics.Tracing");
        private static byte[]? _SystemDiagnosticsTracing;

        /// <summary>
        /// The image bytes for System.dll
        /// </summary>
        public static byte[] System => ResourceLoader.GetOrCreateResource(ref _System, "netstandard20.System");
        private static byte[]? _System;

        /// <summary>
        /// The image bytes for System.Drawing.dll
        /// </summary>
        public static byte[] SystemDrawing => ResourceLoader.GetOrCreateResource(ref _SystemDrawing, "netstandard20.System.Drawing");
        private static byte[]? _SystemDrawing;

        /// <summary>
        /// The image bytes for System.Drawing.Primitives.dll
        /// </summary>
        public static byte[] SystemDrawingPrimitives => ResourceLoader.GetOrCreateResource(ref _SystemDrawingPrimitives, "netstandard20.System.Drawing.Primitives");
        private static byte[]? _SystemDrawingPrimitives;

        /// <summary>
        /// The image bytes for System.Dynamic.Runtime.dll
        /// </summary>
        public static byte[] SystemDynamicRuntime => ResourceLoader.GetOrCreateResource(ref _SystemDynamicRuntime, "netstandard20.System.Dynamic.Runtime");
        private static byte[]? _SystemDynamicRuntime;

        /// <summary>
        /// The image bytes for System.Globalization.Calendars.dll
        /// </summary>
        public static byte[] SystemGlobalizationCalendars => ResourceLoader.GetOrCreateResource(ref _SystemGlobalizationCalendars, "netstandard20.System.Globalization.Calendars");
        private static byte[]? _SystemGlobalizationCalendars;

        /// <summary>
        /// The image bytes for System.Globalization.dll
        /// </summary>
        public static byte[] SystemGlobalization => ResourceLoader.GetOrCreateResource(ref _SystemGlobalization, "netstandard20.System.Globalization");
        private static byte[]? _SystemGlobalization;

        /// <summary>
        /// The image bytes for System.Globalization.Extensions.dll
        /// </summary>
        public static byte[] SystemGlobalizationExtensions => ResourceLoader.GetOrCreateResource(ref _SystemGlobalizationExtensions, "netstandard20.System.Globalization.Extensions");
        private static byte[]? _SystemGlobalizationExtensions;

        /// <summary>
        /// The image bytes for System.IO.Compression.dll
        /// </summary>
        public static byte[] SystemIOCompression => ResourceLoader.GetOrCreateResource(ref _SystemIOCompression, "netstandard20.System.IO.Compression");
        private static byte[]? _SystemIOCompression;

        /// <summary>
        /// The image bytes for System.IO.Compression.FileSystem.dll
        /// </summary>
        public static byte[] SystemIOCompressionFileSystem => ResourceLoader.GetOrCreateResource(ref _SystemIOCompressionFileSystem, "netstandard20.System.IO.Compression.FileSystem");
        private static byte[]? _SystemIOCompressionFileSystem;

        /// <summary>
        /// The image bytes for System.IO.Compression.ZipFile.dll
        /// </summary>
        public static byte[] SystemIOCompressionZipFile => ResourceLoader.GetOrCreateResource(ref _SystemIOCompressionZipFile, "netstandard20.System.IO.Compression.ZipFile");
        private static byte[]? _SystemIOCompressionZipFile;

        /// <summary>
        /// The image bytes for System.IO.dll
        /// </summary>
        public static byte[] SystemIO => ResourceLoader.GetOrCreateResource(ref _SystemIO, "netstandard20.System.IO");
        private static byte[]? _SystemIO;

        /// <summary>
        /// The image bytes for System.IO.FileSystem.dll
        /// </summary>
        public static byte[] SystemIOFileSystem => ResourceLoader.GetOrCreateResource(ref _SystemIOFileSystem, "netstandard20.System.IO.FileSystem");
        private static byte[]? _SystemIOFileSystem;

        /// <summary>
        /// The image bytes for System.IO.FileSystem.DriveInfo.dll
        /// </summary>
        public static byte[] SystemIOFileSystemDriveInfo => ResourceLoader.GetOrCreateResource(ref _SystemIOFileSystemDriveInfo, "netstandard20.System.IO.FileSystem.DriveInfo");
        private static byte[]? _SystemIOFileSystemDriveInfo;

        /// <summary>
        /// The image bytes for System.IO.FileSystem.Primitives.dll
        /// </summary>
        public static byte[] SystemIOFileSystemPrimitives => ResourceLoader.GetOrCreateResource(ref _SystemIOFileSystemPrimitives, "netstandard20.System.IO.FileSystem.Primitives");
        private static byte[]? _SystemIOFileSystemPrimitives;

        /// <summary>
        /// The image bytes for System.IO.FileSystem.Watcher.dll
        /// </summary>
        public static byte[] SystemIOFileSystemWatcher => ResourceLoader.GetOrCreateResource(ref _SystemIOFileSystemWatcher, "netstandard20.System.IO.FileSystem.Watcher");
        private static byte[]? _SystemIOFileSystemWatcher;

        /// <summary>
        /// The image bytes for System.IO.IsolatedStorage.dll
        /// </summary>
        public static byte[] SystemIOIsolatedStorage => ResourceLoader.GetOrCreateResource(ref _SystemIOIsolatedStorage, "netstandard20.System.IO.IsolatedStorage");
        private static byte[]? _SystemIOIsolatedStorage;

        /// <summary>
        /// The image bytes for System.IO.MemoryMappedFiles.dll
        /// </summary>
        public static byte[] SystemIOMemoryMappedFiles => ResourceLoader.GetOrCreateResource(ref _SystemIOMemoryMappedFiles, "netstandard20.System.IO.MemoryMappedFiles");
        private static byte[]? _SystemIOMemoryMappedFiles;

        /// <summary>
        /// The image bytes for System.IO.Pipes.dll
        /// </summary>
        public static byte[] SystemIOPipes => ResourceLoader.GetOrCreateResource(ref _SystemIOPipes, "netstandard20.System.IO.Pipes");
        private static byte[]? _SystemIOPipes;

        /// <summary>
        /// The image bytes for System.IO.UnmanagedMemoryStream.dll
        /// </summary>
        public static byte[] SystemIOUnmanagedMemoryStream => ResourceLoader.GetOrCreateResource(ref _SystemIOUnmanagedMemoryStream, "netstandard20.System.IO.UnmanagedMemoryStream");
        private static byte[]? _SystemIOUnmanagedMemoryStream;

        /// <summary>
        /// The image bytes for System.Linq.dll
        /// </summary>
        public static byte[] SystemLinq => ResourceLoader.GetOrCreateResource(ref _SystemLinq, "netstandard20.System.Linq");
        private static byte[]? _SystemLinq;

        /// <summary>
        /// The image bytes for System.Linq.Expressions.dll
        /// </summary>
        public static byte[] SystemLinqExpressions => ResourceLoader.GetOrCreateResource(ref _SystemLinqExpressions, "netstandard20.System.Linq.Expressions");
        private static byte[]? _SystemLinqExpressions;

        /// <summary>
        /// The image bytes for System.Linq.Parallel.dll
        /// </summary>
        public static byte[] SystemLinqParallel => ResourceLoader.GetOrCreateResource(ref _SystemLinqParallel, "netstandard20.System.Linq.Parallel");
        private static byte[]? _SystemLinqParallel;

        /// <summary>
        /// The image bytes for System.Linq.Queryable.dll
        /// </summary>
        public static byte[] SystemLinqQueryable => ResourceLoader.GetOrCreateResource(ref _SystemLinqQueryable, "netstandard20.System.Linq.Queryable");
        private static byte[]? _SystemLinqQueryable;

        /// <summary>
        /// The image bytes for System.Net.dll
        /// </summary>
        public static byte[] SystemNet => ResourceLoader.GetOrCreateResource(ref _SystemNet, "netstandard20.System.Net");
        private static byte[]? _SystemNet;

        /// <summary>
        /// The image bytes for System.Net.Http.dll
        /// </summary>
        public static byte[] SystemNetHttp => ResourceLoader.GetOrCreateResource(ref _SystemNetHttp, "netstandard20.System.Net.Http");
        private static byte[]? _SystemNetHttp;

        /// <summary>
        /// The image bytes for System.Net.NameResolution.dll
        /// </summary>
        public static byte[] SystemNetNameResolution => ResourceLoader.GetOrCreateResource(ref _SystemNetNameResolution, "netstandard20.System.Net.NameResolution");
        private static byte[]? _SystemNetNameResolution;

        /// <summary>
        /// The image bytes for System.Net.NetworkInformation.dll
        /// </summary>
        public static byte[] SystemNetNetworkInformation => ResourceLoader.GetOrCreateResource(ref _SystemNetNetworkInformation, "netstandard20.System.Net.NetworkInformation");
        private static byte[]? _SystemNetNetworkInformation;

        /// <summary>
        /// The image bytes for System.Net.Ping.dll
        /// </summary>
        public static byte[] SystemNetPing => ResourceLoader.GetOrCreateResource(ref _SystemNetPing, "netstandard20.System.Net.Ping");
        private static byte[]? _SystemNetPing;

        /// <summary>
        /// The image bytes for System.Net.Primitives.dll
        /// </summary>
        public static byte[] SystemNetPrimitives => ResourceLoader.GetOrCreateResource(ref _SystemNetPrimitives, "netstandard20.System.Net.Primitives");
        private static byte[]? _SystemNetPrimitives;

        /// <summary>
        /// The image bytes for System.Net.Requests.dll
        /// </summary>
        public static byte[] SystemNetRequests => ResourceLoader.GetOrCreateResource(ref _SystemNetRequests, "netstandard20.System.Net.Requests");
        private static byte[]? _SystemNetRequests;

        /// <summary>
        /// The image bytes for System.Net.Security.dll
        /// </summary>
        public static byte[] SystemNetSecurity => ResourceLoader.GetOrCreateResource(ref _SystemNetSecurity, "netstandard20.System.Net.Security");
        private static byte[]? _SystemNetSecurity;

        /// <summary>
        /// The image bytes for System.Net.Sockets.dll
        /// </summary>
        public static byte[] SystemNetSockets => ResourceLoader.GetOrCreateResource(ref _SystemNetSockets, "netstandard20.System.Net.Sockets");
        private static byte[]? _SystemNetSockets;

        /// <summary>
        /// The image bytes for System.Net.WebHeaderCollection.dll
        /// </summary>
        public static byte[] SystemNetWebHeaderCollection => ResourceLoader.GetOrCreateResource(ref _SystemNetWebHeaderCollection, "netstandard20.System.Net.WebHeaderCollection");
        private static byte[]? _SystemNetWebHeaderCollection;

        /// <summary>
        /// The image bytes for System.Net.WebSockets.Client.dll
        /// </summary>
        public static byte[] SystemNetWebSocketsClient => ResourceLoader.GetOrCreateResource(ref _SystemNetWebSocketsClient, "netstandard20.System.Net.WebSockets.Client");
        private static byte[]? _SystemNetWebSocketsClient;

        /// <summary>
        /// The image bytes for System.Net.WebSockets.dll
        /// </summary>
        public static byte[] SystemNetWebSockets => ResourceLoader.GetOrCreateResource(ref _SystemNetWebSockets, "netstandard20.System.Net.WebSockets");
        private static byte[]? _SystemNetWebSockets;

        /// <summary>
        /// The image bytes for System.Numerics.dll
        /// </summary>
        public static byte[] SystemNumerics => ResourceLoader.GetOrCreateResource(ref _SystemNumerics, "netstandard20.System.Numerics");
        private static byte[]? _SystemNumerics;

        /// <summary>
        /// The image bytes for System.ObjectModel.dll
        /// </summary>
        public static byte[] SystemObjectModel => ResourceLoader.GetOrCreateResource(ref _SystemObjectModel, "netstandard20.System.ObjectModel");
        private static byte[]? _SystemObjectModel;

        /// <summary>
        /// The image bytes for System.Reflection.dll
        /// </summary>
        public static byte[] SystemReflection => ResourceLoader.GetOrCreateResource(ref _SystemReflection, "netstandard20.System.Reflection");
        private static byte[]? _SystemReflection;

        /// <summary>
        /// The image bytes for System.Reflection.Extensions.dll
        /// </summary>
        public static byte[] SystemReflectionExtensions => ResourceLoader.GetOrCreateResource(ref _SystemReflectionExtensions, "netstandard20.System.Reflection.Extensions");
        private static byte[]? _SystemReflectionExtensions;

        /// <summary>
        /// The image bytes for System.Reflection.Primitives.dll
        /// </summary>
        public static byte[] SystemReflectionPrimitives => ResourceLoader.GetOrCreateResource(ref _SystemReflectionPrimitives, "netstandard20.System.Reflection.Primitives");
        private static byte[]? _SystemReflectionPrimitives;

        /// <summary>
        /// The image bytes for System.Resources.Reader.dll
        /// </summary>
        public static byte[] SystemResourcesReader => ResourceLoader.GetOrCreateResource(ref _SystemResourcesReader, "netstandard20.System.Resources.Reader");
        private static byte[]? _SystemResourcesReader;

        /// <summary>
        /// The image bytes for System.Resources.ResourceManager.dll
        /// </summary>
        public static byte[] SystemResourcesResourceManager => ResourceLoader.GetOrCreateResource(ref _SystemResourcesResourceManager, "netstandard20.System.Resources.ResourceManager");
        private static byte[]? _SystemResourcesResourceManager;

        /// <summary>
        /// The image bytes for System.Resources.Writer.dll
        /// </summary>
        public static byte[] SystemResourcesWriter => ResourceLoader.GetOrCreateResource(ref _SystemResourcesWriter, "netstandard20.System.Resources.Writer");
        private static byte[]? _SystemResourcesWriter;

        /// <summary>
        /// The image bytes for System.Runtime.CompilerServices.VisualC.dll
        /// </summary>
        public static byte[] SystemRuntimeCompilerServicesVisualC => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeCompilerServicesVisualC, "netstandard20.System.Runtime.CompilerServices.VisualC");
        private static byte[]? _SystemRuntimeCompilerServicesVisualC;

        /// <summary>
        /// The image bytes for System.Runtime.dll
        /// </summary>
        public static byte[] SystemRuntime => ResourceLoader.GetOrCreateResource(ref _SystemRuntime, "netstandard20.System.Runtime");
        private static byte[]? _SystemRuntime;

        /// <summary>
        /// The image bytes for System.Runtime.Extensions.dll
        /// </summary>
        public static byte[] SystemRuntimeExtensions => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeExtensions, "netstandard20.System.Runtime.Extensions");
        private static byte[]? _SystemRuntimeExtensions;

        /// <summary>
        /// The image bytes for System.Runtime.Handles.dll
        /// </summary>
        public static byte[] SystemRuntimeHandles => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeHandles, "netstandard20.System.Runtime.Handles");
        private static byte[]? _SystemRuntimeHandles;

        /// <summary>
        /// The image bytes for System.Runtime.InteropServices.dll
        /// </summary>
        public static byte[] SystemRuntimeInteropServices => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeInteropServices, "netstandard20.System.Runtime.InteropServices");
        private static byte[]? _SystemRuntimeInteropServices;

        /// <summary>
        /// The image bytes for System.Runtime.InteropServices.RuntimeInformation.dll
        /// </summary>
        public static byte[] SystemRuntimeInteropServicesRuntimeInformation => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeInteropServicesRuntimeInformation, "netstandard20.System.Runtime.InteropServices.RuntimeInformation");
        private static byte[]? _SystemRuntimeInteropServicesRuntimeInformation;

        /// <summary>
        /// The image bytes for System.Runtime.Numerics.dll
        /// </summary>
        public static byte[] SystemRuntimeNumerics => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeNumerics, "netstandard20.System.Runtime.Numerics");
        private static byte[]? _SystemRuntimeNumerics;

        /// <summary>
        /// The image bytes for System.Runtime.Serialization.dll
        /// </summary>
        public static byte[] SystemRuntimeSerialization => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeSerialization, "netstandard20.System.Runtime.Serialization");
        private static byte[]? _SystemRuntimeSerialization;

        /// <summary>
        /// The image bytes for System.Runtime.Serialization.Formatters.dll
        /// </summary>
        public static byte[] SystemRuntimeSerializationFormatters => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeSerializationFormatters, "netstandard20.System.Runtime.Serialization.Formatters");
        private static byte[]? _SystemRuntimeSerializationFormatters;

        /// <summary>
        /// The image bytes for System.Runtime.Serialization.Json.dll
        /// </summary>
        public static byte[] SystemRuntimeSerializationJson => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeSerializationJson, "netstandard20.System.Runtime.Serialization.Json");
        private static byte[]? _SystemRuntimeSerializationJson;

        /// <summary>
        /// The image bytes for System.Runtime.Serialization.Primitives.dll
        /// </summary>
        public static byte[] SystemRuntimeSerializationPrimitives => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeSerializationPrimitives, "netstandard20.System.Runtime.Serialization.Primitives");
        private static byte[]? _SystemRuntimeSerializationPrimitives;

        /// <summary>
        /// The image bytes for System.Runtime.Serialization.Xml.dll
        /// </summary>
        public static byte[] SystemRuntimeSerializationXml => ResourceLoader.GetOrCreateResource(ref _SystemRuntimeSerializationXml, "netstandard20.System.Runtime.Serialization.Xml");
        private static byte[]? _SystemRuntimeSerializationXml;

        /// <summary>
        /// The image bytes for System.Security.Claims.dll
        /// </summary>
        public static byte[] SystemSecurityClaims => ResourceLoader.GetOrCreateResource(ref _SystemSecurityClaims, "netstandard20.System.Security.Claims");
        private static byte[]? _SystemSecurityClaims;

        /// <summary>
        /// The image bytes for System.Security.Cryptography.Algorithms.dll
        /// </summary>
        public static byte[] SystemSecurityCryptographyAlgorithms => ResourceLoader.GetOrCreateResource(ref _SystemSecurityCryptographyAlgorithms, "netstandard20.System.Security.Cryptography.Algorithms");
        private static byte[]? _SystemSecurityCryptographyAlgorithms;

        /// <summary>
        /// The image bytes for System.Security.Cryptography.Csp.dll
        /// </summary>
        public static byte[] SystemSecurityCryptographyCsp => ResourceLoader.GetOrCreateResource(ref _SystemSecurityCryptographyCsp, "netstandard20.System.Security.Cryptography.Csp");
        private static byte[]? _SystemSecurityCryptographyCsp;

        /// <summary>
        /// The image bytes for System.Security.Cryptography.Encoding.dll
        /// </summary>
        public static byte[] SystemSecurityCryptographyEncoding => ResourceLoader.GetOrCreateResource(ref _SystemSecurityCryptographyEncoding, "netstandard20.System.Security.Cryptography.Encoding");
        private static byte[]? _SystemSecurityCryptographyEncoding;

        /// <summary>
        /// The image bytes for System.Security.Cryptography.Primitives.dll
        /// </summary>
        public static byte[] SystemSecurityCryptographyPrimitives => ResourceLoader.GetOrCreateResource(ref _SystemSecurityCryptographyPrimitives, "netstandard20.System.Security.Cryptography.Primitives");
        private static byte[]? _SystemSecurityCryptographyPrimitives;

        /// <summary>
        /// The image bytes for System.Security.Cryptography.X509Certificates.dll
        /// </summary>
        public static byte[] SystemSecurityCryptographyX509Certificates => ResourceLoader.GetOrCreateResource(ref _SystemSecurityCryptographyX509Certificates, "netstandard20.System.Security.Cryptography.X509Certificates");
        private static byte[]? _SystemSecurityCryptographyX509Certificates;

        /// <summary>
        /// The image bytes for System.Security.Principal.dll
        /// </summary>
        public static byte[] SystemSecurityPrincipal => ResourceLoader.GetOrCreateResource(ref _SystemSecurityPrincipal, "netstandard20.System.Security.Principal");
        private static byte[]? _SystemSecurityPrincipal;

        /// <summary>
        /// The image bytes for System.Security.SecureString.dll
        /// </summary>
        public static byte[] SystemSecuritySecureString => ResourceLoader.GetOrCreateResource(ref _SystemSecuritySecureString, "netstandard20.System.Security.SecureString");
        private static byte[]? _SystemSecuritySecureString;

        /// <summary>
        /// The image bytes for System.ServiceModel.Web.dll
        /// </summary>
        public static byte[] SystemServiceModelWeb => ResourceLoader.GetOrCreateResource(ref _SystemServiceModelWeb, "netstandard20.System.ServiceModel.Web");
        private static byte[]? _SystemServiceModelWeb;

        /// <summary>
        /// The image bytes for System.Text.Encoding.dll
        /// </summary>
        public static byte[] SystemTextEncoding => ResourceLoader.GetOrCreateResource(ref _SystemTextEncoding, "netstandard20.System.Text.Encoding");
        private static byte[]? _SystemTextEncoding;

        /// <summary>
        /// The image bytes for System.Text.Encoding.Extensions.dll
        /// </summary>
        public static byte[] SystemTextEncodingExtensions => ResourceLoader.GetOrCreateResource(ref _SystemTextEncodingExtensions, "netstandard20.System.Text.Encoding.Extensions");
        private static byte[]? _SystemTextEncodingExtensions;

        /// <summary>
        /// The image bytes for System.Text.RegularExpressions.dll
        /// </summary>
        public static byte[] SystemTextRegularExpressions => ResourceLoader.GetOrCreateResource(ref _SystemTextRegularExpressions, "netstandard20.System.Text.RegularExpressions");
        private static byte[]? _SystemTextRegularExpressions;

        /// <summary>
        /// The image bytes for System.Threading.dll
        /// </summary>
        public static byte[] SystemThreading => ResourceLoader.GetOrCreateResource(ref _SystemThreading, "netstandard20.System.Threading");
        private static byte[]? _SystemThreading;

        /// <summary>
        /// The image bytes for System.Threading.Overlapped.dll
        /// </summary>
        public static byte[] SystemThreadingOverlapped => ResourceLoader.GetOrCreateResource(ref _SystemThreadingOverlapped, "netstandard20.System.Threading.Overlapped");
        private static byte[]? _SystemThreadingOverlapped;

        /// <summary>
        /// The image bytes for System.Threading.Tasks.dll
        /// </summary>
        public static byte[] SystemThreadingTasks => ResourceLoader.GetOrCreateResource(ref _SystemThreadingTasks, "netstandard20.System.Threading.Tasks");
        private static byte[]? _SystemThreadingTasks;

        /// <summary>
        /// The image bytes for System.Threading.Tasks.Parallel.dll
        /// </summary>
        public static byte[] SystemThreadingTasksParallel => ResourceLoader.GetOrCreateResource(ref _SystemThreadingTasksParallel, "netstandard20.System.Threading.Tasks.Parallel");
        private static byte[]? _SystemThreadingTasksParallel;

        /// <summary>
        /// The image bytes for System.Threading.Thread.dll
        /// </summary>
        public static byte[] SystemThreadingThread => ResourceLoader.GetOrCreateResource(ref _SystemThreadingThread, "netstandard20.System.Threading.Thread");
        private static byte[]? _SystemThreadingThread;

        /// <summary>
        /// The image bytes for System.Threading.ThreadPool.dll
        /// </summary>
        public static byte[] SystemThreadingThreadPool => ResourceLoader.GetOrCreateResource(ref _SystemThreadingThreadPool, "netstandard20.System.Threading.ThreadPool");
        private static byte[]? _SystemThreadingThreadPool;

        /// <summary>
        /// The image bytes for System.Threading.Timer.dll
        /// </summary>
        public static byte[] SystemThreadingTimer => ResourceLoader.GetOrCreateResource(ref _SystemThreadingTimer, "netstandard20.System.Threading.Timer");
        private static byte[]? _SystemThreadingTimer;

        /// <summary>
        /// The image bytes for System.Transactions.dll
        /// </summary>
        public static byte[] SystemTransactions => ResourceLoader.GetOrCreateResource(ref _SystemTransactions, "netstandard20.System.Transactions");
        private static byte[]? _SystemTransactions;

        /// <summary>
        /// The image bytes for System.ValueTuple.dll
        /// </summary>
        public static byte[] SystemValueTuple => ResourceLoader.GetOrCreateResource(ref _SystemValueTuple, "netstandard20.System.ValueTuple");
        private static byte[]? _SystemValueTuple;

        /// <summary>
        /// The image bytes for System.Web.dll
        /// </summary>
        public static byte[] SystemWeb => ResourceLoader.GetOrCreateResource(ref _SystemWeb, "netstandard20.System.Web");
        private static byte[]? _SystemWeb;

        /// <summary>
        /// The image bytes for System.Windows.dll
        /// </summary>
        public static byte[] SystemWindows => ResourceLoader.GetOrCreateResource(ref _SystemWindows, "netstandard20.System.Windows");
        private static byte[]? _SystemWindows;

        /// <summary>
        /// The image bytes for System.Xml.dll
        /// </summary>
        public static byte[] SystemXml => ResourceLoader.GetOrCreateResource(ref _SystemXml, "netstandard20.System.Xml");
        private static byte[]? _SystemXml;

        /// <summary>
        /// The image bytes for System.Xml.Linq.dll
        /// </summary>
        public static byte[] SystemXmlLinq => ResourceLoader.GetOrCreateResource(ref _SystemXmlLinq, "netstandard20.System.Xml.Linq");
        private static byte[]? _SystemXmlLinq;

        /// <summary>
        /// The image bytes for System.Xml.ReaderWriter.dll
        /// </summary>
        public static byte[] SystemXmlReaderWriter => ResourceLoader.GetOrCreateResource(ref _SystemXmlReaderWriter, "netstandard20.System.Xml.ReaderWriter");
        private static byte[]? _SystemXmlReaderWriter;

        /// <summary>
        /// The image bytes for System.Xml.Serialization.dll
        /// </summary>
        public static byte[] SystemXmlSerialization => ResourceLoader.GetOrCreateResource(ref _SystemXmlSerialization, "netstandard20.System.Xml.Serialization");
        private static byte[]? _SystemXmlSerialization;

        /// <summary>
        /// The image bytes for System.Xml.XDocument.dll
        /// </summary>
        public static byte[] SystemXmlXDocument => ResourceLoader.GetOrCreateResource(ref _SystemXmlXDocument, "netstandard20.System.Xml.XDocument");
        private static byte[]? _SystemXmlXDocument;

        /// <summary>
        /// The image bytes for System.Xml.XmlDocument.dll
        /// </summary>
        public static byte[] SystemXmlXmlDocument => ResourceLoader.GetOrCreateResource(ref _SystemXmlXmlDocument, "netstandard20.System.Xml.XmlDocument");
        private static byte[]? _SystemXmlXmlDocument;

        /// <summary>
        /// The image bytes for System.Xml.XmlSerializer.dll
        /// </summary>
        public static byte[] SystemXmlXmlSerializer => ResourceLoader.GetOrCreateResource(ref _SystemXmlXmlSerializer, "netstandard20.System.Xml.XmlSerializer");
        private static byte[]? _SystemXmlXmlSerializer;

        /// <summary>
        /// The image bytes for System.Xml.XPath.dll
        /// </summary>
        public static byte[] SystemXmlXPath => ResourceLoader.GetOrCreateResource(ref _SystemXmlXPath, "netstandard20.System.Xml.XPath");
        private static byte[]? _SystemXmlXPath;

        /// <summary>
        /// The image bytes for System.Xml.XPath.XDocument.dll
        /// </summary>
        public static byte[] SystemXmlXPathXDocument => ResourceLoader.GetOrCreateResource(ref _SystemXmlXPathXDocument, "netstandard20.System.Xml.XPath.XDocument");
        private static byte[]? _SystemXmlXPathXDocument;

        /// <summary>
        /// The image bytes for Microsoft.CSharp.dll
        /// </summary>
        public static byte[] MicrosoftCSharp => ResourceLoader.GetOrCreateResource(ref _MicrosoftCSharp, "netstandard20.Microsoft.CSharp");
        private static byte[]? _MicrosoftCSharp;

        /// <summary>
        /// The image bytes for Microsoft.VisualBasic.dll
        /// </summary>
        public static byte[] MicrosoftVisualBasic => ResourceLoader.GetOrCreateResource(ref _MicrosoftVisualBasic, "netstandard20.Microsoft.VisualBasic");
        private static byte[]? _MicrosoftVisualBasic;

        /// <summary>
        /// The image bytes for System.Threading.Tasks.Extensions.dll
        /// </summary>
        public static byte[] SystemThreadingTasksExtensions => ResourceLoader.GetOrCreateResource(ref _SystemThreadingTasksExtensions, "netstandard20.System.Threading.Tasks.Extensions");
        private static byte[]? _SystemThreadingTasksExtensions;


    }
}

public static partial class NetStandard20
{
    public static class ReferenceInfos
    {

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for Microsoft.Win32.Primitives.dll
        /// </summary>
        public static ReferenceInfo MicrosoftWin32Primitives => new ReferenceInfo("Microsoft.Win32.Primitives.dll", Resources.MicrosoftWin32Primitives, NetStandard20.References.MicrosoftWin32Primitives, global::System.Guid.Parse("ef0f8705-999f-47b0-9bff-1ee1eb8433e0"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for mscorlib.dll
        /// </summary>
        public static ReferenceInfo mscorlib => new ReferenceInfo("mscorlib.dll", Resources.mscorlib, NetStandard20.References.mscorlib, global::System.Guid.Parse("3b0b9936-7b08-4d72-9c59-7c37d121c685"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for netstandard.dll
        /// </summary>
        public static ReferenceInfo netstandard => new ReferenceInfo("netstandard.dll", Resources.netstandard, NetStandard20.References.netstandard, global::System.Guid.Parse("6dadd22e-0197-42ce-80aa-efef99855be0"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.AppContext.dll
        /// </summary>
        public static ReferenceInfo SystemAppContext => new ReferenceInfo("System.AppContext.dll", Resources.SystemAppContext, NetStandard20.References.SystemAppContext, global::System.Guid.Parse("65de4324-2b89-4243-b95d-92cec0939e0a"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Collections.Concurrent.dll
        /// </summary>
        public static ReferenceInfo SystemCollectionsConcurrent => new ReferenceInfo("System.Collections.Concurrent.dll", Resources.SystemCollectionsConcurrent, NetStandard20.References.SystemCollectionsConcurrent, global::System.Guid.Parse("a23616b5-238b-4f51-9c18-851933186bb3"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Collections.dll
        /// </summary>
        public static ReferenceInfo SystemCollections => new ReferenceInfo("System.Collections.dll", Resources.SystemCollections, NetStandard20.References.SystemCollections, global::System.Guid.Parse("23ceb428-fda9-4f80-8e62-c7731fe00182"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Collections.NonGeneric.dll
        /// </summary>
        public static ReferenceInfo SystemCollectionsNonGeneric => new ReferenceInfo("System.Collections.NonGeneric.dll", Resources.SystemCollectionsNonGeneric, NetStandard20.References.SystemCollectionsNonGeneric, global::System.Guid.Parse("334d1c39-5c06-460e-8f4b-88f1b9e08c94"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Collections.Specialized.dll
        /// </summary>
        public static ReferenceInfo SystemCollectionsSpecialized => new ReferenceInfo("System.Collections.Specialized.dll", Resources.SystemCollectionsSpecialized, NetStandard20.References.SystemCollectionsSpecialized, global::System.Guid.Parse("1e16d32a-b060-4128-a5bc-d620568d2180"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.ComponentModel.Composition.dll
        /// </summary>
        public static ReferenceInfo SystemComponentModelComposition => new ReferenceInfo("System.ComponentModel.Composition.dll", Resources.SystemComponentModelComposition, NetStandard20.References.SystemComponentModelComposition, global::System.Guid.Parse("efa9b4d8-6c50-4c84-a8c1-16c478b1e108"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.ComponentModel.dll
        /// </summary>
        public static ReferenceInfo SystemComponentModel => new ReferenceInfo("System.ComponentModel.dll", Resources.SystemComponentModel, NetStandard20.References.SystemComponentModel, global::System.Guid.Parse("52d8232f-00e6-4c38-abac-39babc57763c"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.ComponentModel.EventBasedAsync.dll
        /// </summary>
        public static ReferenceInfo SystemComponentModelEventBasedAsync => new ReferenceInfo("System.ComponentModel.EventBasedAsync.dll", Resources.SystemComponentModelEventBasedAsync, NetStandard20.References.SystemComponentModelEventBasedAsync, global::System.Guid.Parse("d984eca0-269b-40be-9326-3cd41799698d"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.ComponentModel.Primitives.dll
        /// </summary>
        public static ReferenceInfo SystemComponentModelPrimitives => new ReferenceInfo("System.ComponentModel.Primitives.dll", Resources.SystemComponentModelPrimitives, NetStandard20.References.SystemComponentModelPrimitives, global::System.Guid.Parse("1b6028a5-0fb0-4382-9ccc-063f5932157c"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.ComponentModel.TypeConverter.dll
        /// </summary>
        public static ReferenceInfo SystemComponentModelTypeConverter => new ReferenceInfo("System.ComponentModel.TypeConverter.dll", Resources.SystemComponentModelTypeConverter, NetStandard20.References.SystemComponentModelTypeConverter, global::System.Guid.Parse("c7eac0fc-1738-4883-811e-e62665243eb6"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Console.dll
        /// </summary>
        public static ReferenceInfo SystemConsole => new ReferenceInfo("System.Console.dll", Resources.SystemConsole, NetStandard20.References.SystemConsole, global::System.Guid.Parse("d4480ce8-665a-4dbb-b6da-73e5fe655911"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Core.dll
        /// </summary>
        public static ReferenceInfo SystemCore => new ReferenceInfo("System.Core.dll", Resources.SystemCore, NetStandard20.References.SystemCore, global::System.Guid.Parse("906a86c8-c762-416c-ada6-2a91b392bba0"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Data.Common.dll
        /// </summary>
        public static ReferenceInfo SystemDataCommon => new ReferenceInfo("System.Data.Common.dll", Resources.SystemDataCommon, NetStandard20.References.SystemDataCommon, global::System.Guid.Parse("e98988a9-60ca-4d42-80b0-2c12d0820f3c"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Data.dll
        /// </summary>
        public static ReferenceInfo SystemData => new ReferenceInfo("System.Data.dll", Resources.SystemData, NetStandard20.References.SystemData, global::System.Guid.Parse("f35d3439-9348-44a8-b5df-c1faa7284f43"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.Contracts.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsContracts => new ReferenceInfo("System.Diagnostics.Contracts.dll", Resources.SystemDiagnosticsContracts, NetStandard20.References.SystemDiagnosticsContracts, global::System.Guid.Parse("30a01407-740f-4237-b354-49b8ae79399b"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.Debug.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsDebug => new ReferenceInfo("System.Diagnostics.Debug.dll", Resources.SystemDiagnosticsDebug, NetStandard20.References.SystemDiagnosticsDebug, global::System.Guid.Parse("ba328045-3535-4614-b017-cea4aa4a751f"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.FileVersionInfo.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsFileVersionInfo => new ReferenceInfo("System.Diagnostics.FileVersionInfo.dll", Resources.SystemDiagnosticsFileVersionInfo, NetStandard20.References.SystemDiagnosticsFileVersionInfo, global::System.Guid.Parse("12950f87-2e39-4c97-92f2-1d60c137525e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.Process.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsProcess => new ReferenceInfo("System.Diagnostics.Process.dll", Resources.SystemDiagnosticsProcess, NetStandard20.References.SystemDiagnosticsProcess, global::System.Guid.Parse("45b73c34-14e8-4a20-8f25-cdaee05dddc2"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.StackTrace.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsStackTrace => new ReferenceInfo("System.Diagnostics.StackTrace.dll", Resources.SystemDiagnosticsStackTrace, NetStandard20.References.SystemDiagnosticsStackTrace, global::System.Guid.Parse("a585abfd-6ee0-4983-a16a-11f8189a9892"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.TextWriterTraceListener.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsTextWriterTraceListener => new ReferenceInfo("System.Diagnostics.TextWriterTraceListener.dll", Resources.SystemDiagnosticsTextWriterTraceListener, NetStandard20.References.SystemDiagnosticsTextWriterTraceListener, global::System.Guid.Parse("dc3bcb14-3c90-466c-a0d1-4f4e0fbaf7f1"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.Tools.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsTools => new ReferenceInfo("System.Diagnostics.Tools.dll", Resources.SystemDiagnosticsTools, NetStandard20.References.SystemDiagnosticsTools, global::System.Guid.Parse("89a9a21c-faf8-4b63-9758-997b7af8f96e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.TraceSource.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsTraceSource => new ReferenceInfo("System.Diagnostics.TraceSource.dll", Resources.SystemDiagnosticsTraceSource, NetStandard20.References.SystemDiagnosticsTraceSource, global::System.Guid.Parse("4585cf1a-8a30-4cd2-b2fc-722f069ea6ac"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Diagnostics.Tracing.dll
        /// </summary>
        public static ReferenceInfo SystemDiagnosticsTracing => new ReferenceInfo("System.Diagnostics.Tracing.dll", Resources.SystemDiagnosticsTracing, NetStandard20.References.SystemDiagnosticsTracing, global::System.Guid.Parse("761fd567-a8ad-4312-8149-5aa3b0ab40d8"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.dll
        /// </summary>
        public static ReferenceInfo System => new ReferenceInfo("System.dll", Resources.System, NetStandard20.References.System, global::System.Guid.Parse("4b5030eb-e663-44e9-a8a2-3cf3c5e8be6a"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Drawing.dll
        /// </summary>
        public static ReferenceInfo SystemDrawing => new ReferenceInfo("System.Drawing.dll", Resources.SystemDrawing, NetStandard20.References.SystemDrawing, global::System.Guid.Parse("4395da3d-aaec-43a0-87c3-4201e65b1667"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Drawing.Primitives.dll
        /// </summary>
        public static ReferenceInfo SystemDrawingPrimitives => new ReferenceInfo("System.Drawing.Primitives.dll", Resources.SystemDrawingPrimitives, NetStandard20.References.SystemDrawingPrimitives, global::System.Guid.Parse("eb1b0fcc-cab8-490f-b427-8c111b33b8f2"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Dynamic.Runtime.dll
        /// </summary>
        public static ReferenceInfo SystemDynamicRuntime => new ReferenceInfo("System.Dynamic.Runtime.dll", Resources.SystemDynamicRuntime, NetStandard20.References.SystemDynamicRuntime, global::System.Guid.Parse("8ebb9848-2539-4eac-97f1-b67d9f9a1784"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Globalization.Calendars.dll
        /// </summary>
        public static ReferenceInfo SystemGlobalizationCalendars => new ReferenceInfo("System.Globalization.Calendars.dll", Resources.SystemGlobalizationCalendars, NetStandard20.References.SystemGlobalizationCalendars, global::System.Guid.Parse("d5041a8d-1147-4c6f-af68-6828fe374b3a"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Globalization.dll
        /// </summary>
        public static ReferenceInfo SystemGlobalization => new ReferenceInfo("System.Globalization.dll", Resources.SystemGlobalization, NetStandard20.References.SystemGlobalization, global::System.Guid.Parse("55c2321c-3861-487f-a1f2-fe3ffc5a1be9"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Globalization.Extensions.dll
        /// </summary>
        public static ReferenceInfo SystemGlobalizationExtensions => new ReferenceInfo("System.Globalization.Extensions.dll", Resources.SystemGlobalizationExtensions, NetStandard20.References.SystemGlobalizationExtensions, global::System.Guid.Parse("066ebc42-59a4-4361-a48a-440acad51283"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.Compression.dll
        /// </summary>
        public static ReferenceInfo SystemIOCompression => new ReferenceInfo("System.IO.Compression.dll", Resources.SystemIOCompression, NetStandard20.References.SystemIOCompression, global::System.Guid.Parse("71a6e267-93f1-49bb-8eed-dc2cef063971"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.Compression.FileSystem.dll
        /// </summary>
        public static ReferenceInfo SystemIOCompressionFileSystem => new ReferenceInfo("System.IO.Compression.FileSystem.dll", Resources.SystemIOCompressionFileSystem, NetStandard20.References.SystemIOCompressionFileSystem, global::System.Guid.Parse("d98db1a7-fa1b-455c-b078-a250d53d61cf"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.Compression.ZipFile.dll
        /// </summary>
        public static ReferenceInfo SystemIOCompressionZipFile => new ReferenceInfo("System.IO.Compression.ZipFile.dll", Resources.SystemIOCompressionZipFile, NetStandard20.References.SystemIOCompressionZipFile, global::System.Guid.Parse("6b3a44ab-2d51-443b-abc2-01aee73b82a1"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.dll
        /// </summary>
        public static ReferenceInfo SystemIO => new ReferenceInfo("System.IO.dll", Resources.SystemIO, NetStandard20.References.SystemIO, global::System.Guid.Parse("130de927-6b0b-4fbc-a27f-1504efaf28e9"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.FileSystem.dll
        /// </summary>
        public static ReferenceInfo SystemIOFileSystem => new ReferenceInfo("System.IO.FileSystem.dll", Resources.SystemIOFileSystem, NetStandard20.References.SystemIOFileSystem, global::System.Guid.Parse("286e02b0-de63-4544-8f58-e93a976fbb1f"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.FileSystem.DriveInfo.dll
        /// </summary>
        public static ReferenceInfo SystemIOFileSystemDriveInfo => new ReferenceInfo("System.IO.FileSystem.DriveInfo.dll", Resources.SystemIOFileSystemDriveInfo, NetStandard20.References.SystemIOFileSystemDriveInfo, global::System.Guid.Parse("82a33ac4-d3d6-4228-a119-af040c7ba69f"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.FileSystem.Primitives.dll
        /// </summary>
        public static ReferenceInfo SystemIOFileSystemPrimitives => new ReferenceInfo("System.IO.FileSystem.Primitives.dll", Resources.SystemIOFileSystemPrimitives, NetStandard20.References.SystemIOFileSystemPrimitives, global::System.Guid.Parse("748c02c0-ca6f-4df8-a613-3c7f2cb72b39"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.FileSystem.Watcher.dll
        /// </summary>
        public static ReferenceInfo SystemIOFileSystemWatcher => new ReferenceInfo("System.IO.FileSystem.Watcher.dll", Resources.SystemIOFileSystemWatcher, NetStandard20.References.SystemIOFileSystemWatcher, global::System.Guid.Parse("cd2590a0-b4b3-4d63-b9ca-8d9bc6cac698"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.IsolatedStorage.dll
        /// </summary>
        public static ReferenceInfo SystemIOIsolatedStorage => new ReferenceInfo("System.IO.IsolatedStorage.dll", Resources.SystemIOIsolatedStorage, NetStandard20.References.SystemIOIsolatedStorage, global::System.Guid.Parse("25053238-1504-4dd9-84cb-d160cbeb878d"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.MemoryMappedFiles.dll
        /// </summary>
        public static ReferenceInfo SystemIOMemoryMappedFiles => new ReferenceInfo("System.IO.MemoryMappedFiles.dll", Resources.SystemIOMemoryMappedFiles, NetStandard20.References.SystemIOMemoryMappedFiles, global::System.Guid.Parse("ce3bba0d-3b61-431d-b80f-c3738123e9f4"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.Pipes.dll
        /// </summary>
        public static ReferenceInfo SystemIOPipes => new ReferenceInfo("System.IO.Pipes.dll", Resources.SystemIOPipes, NetStandard20.References.SystemIOPipes, global::System.Guid.Parse("018b5c94-d8ac-44a0-af64-2c47d6bd6101"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.IO.UnmanagedMemoryStream.dll
        /// </summary>
        public static ReferenceInfo SystemIOUnmanagedMemoryStream => new ReferenceInfo("System.IO.UnmanagedMemoryStream.dll", Resources.SystemIOUnmanagedMemoryStream, NetStandard20.References.SystemIOUnmanagedMemoryStream, global::System.Guid.Parse("a84a808b-dc08-4a3f-97a4-321ae5e09ab9"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Linq.dll
        /// </summary>
        public static ReferenceInfo SystemLinq => new ReferenceInfo("System.Linq.dll", Resources.SystemLinq, NetStandard20.References.SystemLinq, global::System.Guid.Parse("7d1c9ef6-52b1-47d4-8322-1587ce76473e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Linq.Expressions.dll
        /// </summary>
        public static ReferenceInfo SystemLinqExpressions => new ReferenceInfo("System.Linq.Expressions.dll", Resources.SystemLinqExpressions, NetStandard20.References.SystemLinqExpressions, global::System.Guid.Parse("2948a49f-1f4b-4d91-acb0-478ae0750133"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Linq.Parallel.dll
        /// </summary>
        public static ReferenceInfo SystemLinqParallel => new ReferenceInfo("System.Linq.Parallel.dll", Resources.SystemLinqParallel, NetStandard20.References.SystemLinqParallel, global::System.Guid.Parse("64404394-9333-45ae-a656-6a7e6076b849"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Linq.Queryable.dll
        /// </summary>
        public static ReferenceInfo SystemLinqQueryable => new ReferenceInfo("System.Linq.Queryable.dll", Resources.SystemLinqQueryable, NetStandard20.References.SystemLinqQueryable, global::System.Guid.Parse("f4f38f1c-dee7-49cd-aa7e-5d142fb264b3"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.dll
        /// </summary>
        public static ReferenceInfo SystemNet => new ReferenceInfo("System.Net.dll", Resources.SystemNet, NetStandard20.References.SystemNet, global::System.Guid.Parse("03b25722-587f-4ac6-bc9b-990ab080a796"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.Http.dll
        /// </summary>
        public static ReferenceInfo SystemNetHttp => new ReferenceInfo("System.Net.Http.dll", Resources.SystemNetHttp, NetStandard20.References.SystemNetHttp, global::System.Guid.Parse("9cff04e6-ad06-41df-8701-42e093a650d5"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.NameResolution.dll
        /// </summary>
        public static ReferenceInfo SystemNetNameResolution => new ReferenceInfo("System.Net.NameResolution.dll", Resources.SystemNetNameResolution, NetStandard20.References.SystemNetNameResolution, global::System.Guid.Parse("12f44405-45cb-4fa0-9eb3-dd98b73b8645"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.NetworkInformation.dll
        /// </summary>
        public static ReferenceInfo SystemNetNetworkInformation => new ReferenceInfo("System.Net.NetworkInformation.dll", Resources.SystemNetNetworkInformation, NetStandard20.References.SystemNetNetworkInformation, global::System.Guid.Parse("6de0a65b-a0ff-402c-9357-285f5fff9453"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.Ping.dll
        /// </summary>
        public static ReferenceInfo SystemNetPing => new ReferenceInfo("System.Net.Ping.dll", Resources.SystemNetPing, NetStandard20.References.SystemNetPing, global::System.Guid.Parse("ee6cf2ba-af06-4af3-8abc-079aba4f4bdf"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.Primitives.dll
        /// </summary>
        public static ReferenceInfo SystemNetPrimitives => new ReferenceInfo("System.Net.Primitives.dll", Resources.SystemNetPrimitives, NetStandard20.References.SystemNetPrimitives, global::System.Guid.Parse("1c2f9f91-8799-4a65-b7cb-713154250e73"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.Requests.dll
        /// </summary>
        public static ReferenceInfo SystemNetRequests => new ReferenceInfo("System.Net.Requests.dll", Resources.SystemNetRequests, NetStandard20.References.SystemNetRequests, global::System.Guid.Parse("c08be717-b602-4e97-ba04-df88234e4cd1"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.Security.dll
        /// </summary>
        public static ReferenceInfo SystemNetSecurity => new ReferenceInfo("System.Net.Security.dll", Resources.SystemNetSecurity, NetStandard20.References.SystemNetSecurity, global::System.Guid.Parse("47f8d05a-06b1-4a70-a2f6-695fa2220499"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.Sockets.dll
        /// </summary>
        public static ReferenceInfo SystemNetSockets => new ReferenceInfo("System.Net.Sockets.dll", Resources.SystemNetSockets, NetStandard20.References.SystemNetSockets, global::System.Guid.Parse("8aca7941-1a14-4352-9b0a-eb2a662df386"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.WebHeaderCollection.dll
        /// </summary>
        public static ReferenceInfo SystemNetWebHeaderCollection => new ReferenceInfo("System.Net.WebHeaderCollection.dll", Resources.SystemNetWebHeaderCollection, NetStandard20.References.SystemNetWebHeaderCollection, global::System.Guid.Parse("49ae481f-3910-4d03-8acb-3291592fe881"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.WebSockets.Client.dll
        /// </summary>
        public static ReferenceInfo SystemNetWebSocketsClient => new ReferenceInfo("System.Net.WebSockets.Client.dll", Resources.SystemNetWebSocketsClient, NetStandard20.References.SystemNetWebSocketsClient, global::System.Guid.Parse("e85872bf-f407-45a0-9b5f-b68df79d67ca"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Net.WebSockets.dll
        /// </summary>
        public static ReferenceInfo SystemNetWebSockets => new ReferenceInfo("System.Net.WebSockets.dll", Resources.SystemNetWebSockets, NetStandard20.References.SystemNetWebSockets, global::System.Guid.Parse("d0d141cd-fdb3-48b6-a40c-ec8fbdb22212"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Numerics.dll
        /// </summary>
        public static ReferenceInfo SystemNumerics => new ReferenceInfo("System.Numerics.dll", Resources.SystemNumerics, NetStandard20.References.SystemNumerics, global::System.Guid.Parse("f4e001aa-a6bb-47dc-8a74-e0c187fb9007"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.ObjectModel.dll
        /// </summary>
        public static ReferenceInfo SystemObjectModel => new ReferenceInfo("System.ObjectModel.dll", Resources.SystemObjectModel, NetStandard20.References.SystemObjectModel, global::System.Guid.Parse("9e95c71c-76d5-49dc-abb6-42539bcad76b"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Reflection.dll
        /// </summary>
        public static ReferenceInfo SystemReflection => new ReferenceInfo("System.Reflection.dll", Resources.SystemReflection, NetStandard20.References.SystemReflection, global::System.Guid.Parse("7fe1520d-e2ed-4555-b750-e59c8379dd46"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Reflection.Extensions.dll
        /// </summary>
        public static ReferenceInfo SystemReflectionExtensions => new ReferenceInfo("System.Reflection.Extensions.dll", Resources.SystemReflectionExtensions, NetStandard20.References.SystemReflectionExtensions, global::System.Guid.Parse("5b438317-bc02-478b-b4a6-e58cd9c5886d"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Reflection.Primitives.dll
        /// </summary>
        public static ReferenceInfo SystemReflectionPrimitives => new ReferenceInfo("System.Reflection.Primitives.dll", Resources.SystemReflectionPrimitives, NetStandard20.References.SystemReflectionPrimitives, global::System.Guid.Parse("b58cfcf2-0552-4cfb-b22f-e768e310a971"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Resources.Reader.dll
        /// </summary>
        public static ReferenceInfo SystemResourcesReader => new ReferenceInfo("System.Resources.Reader.dll", Resources.SystemResourcesReader, NetStandard20.References.SystemResourcesReader, global::System.Guid.Parse("97cf5ab4-bd8e-43ee-afaa-001fd2e53bed"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Resources.ResourceManager.dll
        /// </summary>
        public static ReferenceInfo SystemResourcesResourceManager => new ReferenceInfo("System.Resources.ResourceManager.dll", Resources.SystemResourcesResourceManager, NetStandard20.References.SystemResourcesResourceManager, global::System.Guid.Parse("43610aa7-8b31-4652-8f9c-8176637b248f"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Resources.Writer.dll
        /// </summary>
        public static ReferenceInfo SystemResourcesWriter => new ReferenceInfo("System.Resources.Writer.dll", Resources.SystemResourcesWriter, NetStandard20.References.SystemResourcesWriter, global::System.Guid.Parse("c74dc64c-434b-4634-ba6f-dffe8c9ba149"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.CompilerServices.VisualC.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeCompilerServicesVisualC => new ReferenceInfo("System.Runtime.CompilerServices.VisualC.dll", Resources.SystemRuntimeCompilerServicesVisualC, NetStandard20.References.SystemRuntimeCompilerServicesVisualC, global::System.Guid.Parse("d006d627-2174-4738-b6ab-b319bc371761"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.dll
        /// </summary>
        public static ReferenceInfo SystemRuntime => new ReferenceInfo("System.Runtime.dll", Resources.SystemRuntime, NetStandard20.References.SystemRuntime, global::System.Guid.Parse("31414faf-61cf-4420-91eb-440369fc5b0a"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.Extensions.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeExtensions => new ReferenceInfo("System.Runtime.Extensions.dll", Resources.SystemRuntimeExtensions, NetStandard20.References.SystemRuntimeExtensions, global::System.Guid.Parse("1e074a5b-c852-47e6-ae6f-de38fd664457"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.Handles.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeHandles => new ReferenceInfo("System.Runtime.Handles.dll", Resources.SystemRuntimeHandles, NetStandard20.References.SystemRuntimeHandles, global::System.Guid.Parse("fb475d8b-180e-42f8-9173-20bcbe3dbc8c"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.InteropServices.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeInteropServices => new ReferenceInfo("System.Runtime.InteropServices.dll", Resources.SystemRuntimeInteropServices, NetStandard20.References.SystemRuntimeInteropServices, global::System.Guid.Parse("b0156c63-daa5-42f3-8a6f-b62237390df4"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.InteropServices.RuntimeInformation.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeInteropServicesRuntimeInformation => new ReferenceInfo("System.Runtime.InteropServices.RuntimeInformation.dll", Resources.SystemRuntimeInteropServicesRuntimeInformation, NetStandard20.References.SystemRuntimeInteropServicesRuntimeInformation, global::System.Guid.Parse("c451e154-cfd1-4b6e-b999-1f208d072aec"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.Numerics.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeNumerics => new ReferenceInfo("System.Runtime.Numerics.dll", Resources.SystemRuntimeNumerics, NetStandard20.References.SystemRuntimeNumerics, global::System.Guid.Parse("de2926e0-fff1-4817-ae23-fea7c6dfd039"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.Serialization.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeSerialization => new ReferenceInfo("System.Runtime.Serialization.dll", Resources.SystemRuntimeSerialization, NetStandard20.References.SystemRuntimeSerialization, global::System.Guid.Parse("06cc3fcb-70f1-4ca1-9f88-e346222a7d1d"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.Serialization.Formatters.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeSerializationFormatters => new ReferenceInfo("System.Runtime.Serialization.Formatters.dll", Resources.SystemRuntimeSerializationFormatters, NetStandard20.References.SystemRuntimeSerializationFormatters, global::System.Guid.Parse("b6e44dc3-6b4a-4e8b-9043-c5d1417a591f"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.Serialization.Json.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeSerializationJson => new ReferenceInfo("System.Runtime.Serialization.Json.dll", Resources.SystemRuntimeSerializationJson, NetStandard20.References.SystemRuntimeSerializationJson, global::System.Guid.Parse("01d25e44-f90f-4a46-8d7d-c5b28aa7c55e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.Serialization.Primitives.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeSerializationPrimitives => new ReferenceInfo("System.Runtime.Serialization.Primitives.dll", Resources.SystemRuntimeSerializationPrimitives, NetStandard20.References.SystemRuntimeSerializationPrimitives, global::System.Guid.Parse("e1ad87b9-dc4d-48f1-8e69-357084d09b5e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Runtime.Serialization.Xml.dll
        /// </summary>
        public static ReferenceInfo SystemRuntimeSerializationXml => new ReferenceInfo("System.Runtime.Serialization.Xml.dll", Resources.SystemRuntimeSerializationXml, NetStandard20.References.SystemRuntimeSerializationXml, global::System.Guid.Parse("fd757745-15e4-463f-be7e-d908b0f36f66"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Security.Claims.dll
        /// </summary>
        public static ReferenceInfo SystemSecurityClaims => new ReferenceInfo("System.Security.Claims.dll", Resources.SystemSecurityClaims, NetStandard20.References.SystemSecurityClaims, global::System.Guid.Parse("abeeea24-31a5-4221-b1b0-afa85455be1a"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Security.Cryptography.Algorithms.dll
        /// </summary>
        public static ReferenceInfo SystemSecurityCryptographyAlgorithms => new ReferenceInfo("System.Security.Cryptography.Algorithms.dll", Resources.SystemSecurityCryptographyAlgorithms, NetStandard20.References.SystemSecurityCryptographyAlgorithms, global::System.Guid.Parse("aeaa8653-4363-4328-a71a-35e7e7744022"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Security.Cryptography.Csp.dll
        /// </summary>
        public static ReferenceInfo SystemSecurityCryptographyCsp => new ReferenceInfo("System.Security.Cryptography.Csp.dll", Resources.SystemSecurityCryptographyCsp, NetStandard20.References.SystemSecurityCryptographyCsp, global::System.Guid.Parse("d2bc56e2-8c89-4dfc-9b3c-4f156604453c"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Security.Cryptography.Encoding.dll
        /// </summary>
        public static ReferenceInfo SystemSecurityCryptographyEncoding => new ReferenceInfo("System.Security.Cryptography.Encoding.dll", Resources.SystemSecurityCryptographyEncoding, NetStandard20.References.SystemSecurityCryptographyEncoding, global::System.Guid.Parse("7d517353-d2d3-4657-83d3-e3be94ec882a"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Security.Cryptography.Primitives.dll
        /// </summary>
        public static ReferenceInfo SystemSecurityCryptographyPrimitives => new ReferenceInfo("System.Security.Cryptography.Primitives.dll", Resources.SystemSecurityCryptographyPrimitives, NetStandard20.References.SystemSecurityCryptographyPrimitives, global::System.Guid.Parse("b652ef6b-a6a8-46b2-a588-b08ef3ba0358"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Security.Cryptography.X509Certificates.dll
        /// </summary>
        public static ReferenceInfo SystemSecurityCryptographyX509Certificates => new ReferenceInfo("System.Security.Cryptography.X509Certificates.dll", Resources.SystemSecurityCryptographyX509Certificates, NetStandard20.References.SystemSecurityCryptographyX509Certificates, global::System.Guid.Parse("d87d1f61-03a2-4cb9-90be-def6f0a37630"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Security.Principal.dll
        /// </summary>
        public static ReferenceInfo SystemSecurityPrincipal => new ReferenceInfo("System.Security.Principal.dll", Resources.SystemSecurityPrincipal, NetStandard20.References.SystemSecurityPrincipal, global::System.Guid.Parse("a965a0b3-946f-4227-89d4-ab82163b3a66"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Security.SecureString.dll
        /// </summary>
        public static ReferenceInfo SystemSecuritySecureString => new ReferenceInfo("System.Security.SecureString.dll", Resources.SystemSecuritySecureString, NetStandard20.References.SystemSecuritySecureString, global::System.Guid.Parse("fe85f4c8-d55e-41eb-995f-89cfc9770cfe"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.ServiceModel.Web.dll
        /// </summary>
        public static ReferenceInfo SystemServiceModelWeb => new ReferenceInfo("System.ServiceModel.Web.dll", Resources.SystemServiceModelWeb, NetStandard20.References.SystemServiceModelWeb, global::System.Guid.Parse("9073e110-050d-4d4c-bf87-58447c848b26"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Text.Encoding.dll
        /// </summary>
        public static ReferenceInfo SystemTextEncoding => new ReferenceInfo("System.Text.Encoding.dll", Resources.SystemTextEncoding, NetStandard20.References.SystemTextEncoding, global::System.Guid.Parse("13f366fd-0e98-4483-8290-cb85a6a1936e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Text.Encoding.Extensions.dll
        /// </summary>
        public static ReferenceInfo SystemTextEncodingExtensions => new ReferenceInfo("System.Text.Encoding.Extensions.dll", Resources.SystemTextEncodingExtensions, NetStandard20.References.SystemTextEncodingExtensions, global::System.Guid.Parse("3cf4acfc-a0a3-4b6c-97df-33dc6758ac30"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Text.RegularExpressions.dll
        /// </summary>
        public static ReferenceInfo SystemTextRegularExpressions => new ReferenceInfo("System.Text.RegularExpressions.dll", Resources.SystemTextRegularExpressions, NetStandard20.References.SystemTextRegularExpressions, global::System.Guid.Parse("93d69975-856b-46eb-8852-5ba51378cc8e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Threading.dll
        /// </summary>
        public static ReferenceInfo SystemThreading => new ReferenceInfo("System.Threading.dll", Resources.SystemThreading, NetStandard20.References.SystemThreading, global::System.Guid.Parse("a5b2646b-c705-4e62-958a-c57f173d816b"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Threading.Overlapped.dll
        /// </summary>
        public static ReferenceInfo SystemThreadingOverlapped => new ReferenceInfo("System.Threading.Overlapped.dll", Resources.SystemThreadingOverlapped, NetStandard20.References.SystemThreadingOverlapped, global::System.Guid.Parse("fdd92a12-8c43-4cff-93a4-cff4f05beca8"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Threading.Tasks.dll
        /// </summary>
        public static ReferenceInfo SystemThreadingTasks => new ReferenceInfo("System.Threading.Tasks.dll", Resources.SystemThreadingTasks, NetStandard20.References.SystemThreadingTasks, global::System.Guid.Parse("19bbe456-2b89-4bbb-8559-b36ddb27c871"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Threading.Tasks.Parallel.dll
        /// </summary>
        public static ReferenceInfo SystemThreadingTasksParallel => new ReferenceInfo("System.Threading.Tasks.Parallel.dll", Resources.SystemThreadingTasksParallel, NetStandard20.References.SystemThreadingTasksParallel, global::System.Guid.Parse("6128a3c1-cb91-40fa-a85a-b67288e9259f"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Threading.Thread.dll
        /// </summary>
        public static ReferenceInfo SystemThreadingThread => new ReferenceInfo("System.Threading.Thread.dll", Resources.SystemThreadingThread, NetStandard20.References.SystemThreadingThread, global::System.Guid.Parse("68078a5c-5ab4-47be-b14b-e13c6623d821"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Threading.ThreadPool.dll
        /// </summary>
        public static ReferenceInfo SystemThreadingThreadPool => new ReferenceInfo("System.Threading.ThreadPool.dll", Resources.SystemThreadingThreadPool, NetStandard20.References.SystemThreadingThreadPool, global::System.Guid.Parse("1d902f2e-db97-4b87-a0e8-6daf56ab644b"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Threading.Timer.dll
        /// </summary>
        public static ReferenceInfo SystemThreadingTimer => new ReferenceInfo("System.Threading.Timer.dll", Resources.SystemThreadingTimer, NetStandard20.References.SystemThreadingTimer, global::System.Guid.Parse("f105874b-2ba7-4d68-85f8-c809e73f7cbb"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Transactions.dll
        /// </summary>
        public static ReferenceInfo SystemTransactions => new ReferenceInfo("System.Transactions.dll", Resources.SystemTransactions, NetStandard20.References.SystemTransactions, global::System.Guid.Parse("4cc2dcb5-2e9c-4d24-9f48-ed48d748ee1b"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.ValueTuple.dll
        /// </summary>
        public static ReferenceInfo SystemValueTuple => new ReferenceInfo("System.ValueTuple.dll", Resources.SystemValueTuple, NetStandard20.References.SystemValueTuple, global::System.Guid.Parse("d26b5aca-918b-498e-9a93-ee11a5417f3a"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Web.dll
        /// </summary>
        public static ReferenceInfo SystemWeb => new ReferenceInfo("System.Web.dll", Resources.SystemWeb, NetStandard20.References.SystemWeb, global::System.Guid.Parse("b768b2e1-2c37-4143-b467-de8d85a53db4"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Windows.dll
        /// </summary>
        public static ReferenceInfo SystemWindows => new ReferenceInfo("System.Windows.dll", Resources.SystemWindows, NetStandard20.References.SystemWindows, global::System.Guid.Parse("cc2f586f-2cad-4b49-9e71-6413e614ffd0"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.dll
        /// </summary>
        public static ReferenceInfo SystemXml => new ReferenceInfo("System.Xml.dll", Resources.SystemXml, NetStandard20.References.SystemXml, global::System.Guid.Parse("960b8399-190c-475b-b73b-4cee64ef748e"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.Linq.dll
        /// </summary>
        public static ReferenceInfo SystemXmlLinq => new ReferenceInfo("System.Xml.Linq.dll", Resources.SystemXmlLinq, NetStandard20.References.SystemXmlLinq, global::System.Guid.Parse("11699873-b29a-4337-9876-8900fdadd2df"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.ReaderWriter.dll
        /// </summary>
        public static ReferenceInfo SystemXmlReaderWriter => new ReferenceInfo("System.Xml.ReaderWriter.dll", Resources.SystemXmlReaderWriter, NetStandard20.References.SystemXmlReaderWriter, global::System.Guid.Parse("5bacc974-91a3-4e11-9a03-31717ddfd525"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.Serialization.dll
        /// </summary>
        public static ReferenceInfo SystemXmlSerialization => new ReferenceInfo("System.Xml.Serialization.dll", Resources.SystemXmlSerialization, NetStandard20.References.SystemXmlSerialization, global::System.Guid.Parse("f80e10ac-164f-4dfd-8f61-d4a723b1f4c1"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.XDocument.dll
        /// </summary>
        public static ReferenceInfo SystemXmlXDocument => new ReferenceInfo("System.Xml.XDocument.dll", Resources.SystemXmlXDocument, NetStandard20.References.SystemXmlXDocument, global::System.Guid.Parse("5b4afa9f-da2b-48fd-a404-910b287beee0"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.XmlDocument.dll
        /// </summary>
        public static ReferenceInfo SystemXmlXmlDocument => new ReferenceInfo("System.Xml.XmlDocument.dll", Resources.SystemXmlXmlDocument, NetStandard20.References.SystemXmlXmlDocument, global::System.Guid.Parse("48c1d554-2d7c-4b4f-9047-ad9ed0cf9b35"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.XmlSerializer.dll
        /// </summary>
        public static ReferenceInfo SystemXmlXmlSerializer => new ReferenceInfo("System.Xml.XmlSerializer.dll", Resources.SystemXmlXmlSerializer, NetStandard20.References.SystemXmlXmlSerializer, global::System.Guid.Parse("6b7556ae-8a81-446b-829f-c60fc8b5c834"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.XPath.dll
        /// </summary>
        public static ReferenceInfo SystemXmlXPath => new ReferenceInfo("System.Xml.XPath.dll", Resources.SystemXmlXPath, NetStandard20.References.SystemXmlXPath, global::System.Guid.Parse("7efaf249-c336-4fba-afbf-ae099104a110"));

        /// <summary>
        /// The <see cref="ReferenceInfo"/> for System.Xml.XPath.XDocument.dll
        /// </summary>
        public static ReferenceInfo SystemXmlXPathXDocument => new ReferenceInfo("System.Xml.XPath.XDocument.dll", Resources.SystemXmlXPathXDocument, NetStandard20.References.SystemXmlXPathXDocument, global::System.Guid.Parse("4b57c086-8352-40ab-8005-061eb4e5620d"));
        private static ImmutableArray<ReferenceInfo> _all;
        public static ImmutableArray<ReferenceInfo> All
        {
            get
            {
                if (_all.IsDefault)
                {
                    _all =
                    [
                        MicrosoftWin32Primitives,
                        mscorlib,
                        netstandard,
                        SystemAppContext,
                        SystemCollectionsConcurrent,
                        SystemCollections,
                        SystemCollectionsNonGeneric,
                        SystemCollectionsSpecialized,
                        SystemComponentModelComposition,
                        SystemComponentModel,
                        SystemComponentModelEventBasedAsync,
                        SystemComponentModelPrimitives,
                        SystemComponentModelTypeConverter,
                        SystemConsole,
                        SystemCore,
                        SystemDataCommon,
                        SystemData,
                        SystemDiagnosticsContracts,
                        SystemDiagnosticsDebug,
                        SystemDiagnosticsFileVersionInfo,
                        SystemDiagnosticsProcess,
                        SystemDiagnosticsStackTrace,
                        SystemDiagnosticsTextWriterTraceListener,
                        SystemDiagnosticsTools,
                        SystemDiagnosticsTraceSource,
                        SystemDiagnosticsTracing,
                        System,
                        SystemDrawing,
                        SystemDrawingPrimitives,
                        SystemDynamicRuntime,
                        SystemGlobalizationCalendars,
                        SystemGlobalization,
                        SystemGlobalizationExtensions,
                        SystemIOCompression,
                        SystemIOCompressionFileSystem,
                        SystemIOCompressionZipFile,
                        SystemIO,
                        SystemIOFileSystem,
                        SystemIOFileSystemDriveInfo,
                        SystemIOFileSystemPrimitives,
                        SystemIOFileSystemWatcher,
                        SystemIOIsolatedStorage,
                        SystemIOMemoryMappedFiles,
                        SystemIOPipes,
                        SystemIOUnmanagedMemoryStream,
                        SystemLinq,
                        SystemLinqExpressions,
                        SystemLinqParallel,
                        SystemLinqQueryable,
                        SystemNet,
                        SystemNetHttp,
                        SystemNetNameResolution,
                        SystemNetNetworkInformation,
                        SystemNetPing,
                        SystemNetPrimitives,
                        SystemNetRequests,
                        SystemNetSecurity,
                        SystemNetSockets,
                        SystemNetWebHeaderCollection,
                        SystemNetWebSocketsClient,
                        SystemNetWebSockets,
                        SystemNumerics,
                        SystemObjectModel,
                        SystemReflection,
                        SystemReflectionExtensions,
                        SystemReflectionPrimitives,
                        SystemResourcesReader,
                        SystemResourcesResourceManager,
                        SystemResourcesWriter,
                        SystemRuntimeCompilerServicesVisualC,
                        SystemRuntime,
                        SystemRuntimeExtensions,
                        SystemRuntimeHandles,
                        SystemRuntimeInteropServices,
                        SystemRuntimeInteropServicesRuntimeInformation,
                        SystemRuntimeNumerics,
                        SystemRuntimeSerialization,
                        SystemRuntimeSerializationFormatters,
                        SystemRuntimeSerializationJson,
                        SystemRuntimeSerializationPrimitives,
                        SystemRuntimeSerializationXml,
                        SystemSecurityClaims,
                        SystemSecurityCryptographyAlgorithms,
                        SystemSecurityCryptographyCsp,
                        SystemSecurityCryptographyEncoding,
                        SystemSecurityCryptographyPrimitives,
                        SystemSecurityCryptographyX509Certificates,
                        SystemSecurityPrincipal,
                        SystemSecuritySecureString,
                        SystemServiceModelWeb,
                        SystemTextEncoding,
                        SystemTextEncodingExtensions,
                        SystemTextRegularExpressions,
                        SystemThreading,
                        SystemThreadingOverlapped,
                        SystemThreadingTasks,
                        SystemThreadingTasksParallel,
                        SystemThreadingThread,
                        SystemThreadingThreadPool,
                        SystemThreadingTimer,
                        SystemTransactions,
                        SystemValueTuple,
                        SystemWeb,
                        SystemWindows,
                        SystemXml,
                        SystemXmlLinq,
                        SystemXmlReaderWriter,
                        SystemXmlSerialization,
                        SystemXmlXDocument,
                        SystemXmlXmlDocument,
                        SystemXmlXmlSerializer,
                        SystemXmlXPath,
                        SystemXmlXPathXDocument,
                    ];
                }
                return _all;
            }
        }

        public static IEnumerable<(string FileName, byte[] ImageBytes, PortableExecutableReference Reference, Guid Mvid)> AllValues => All.Select(x => x.AsTuple());
    }
}

public static partial class NetStandard20
{
    public static class References
    {
        private static PortableExecutableReference? _MicrosoftWin32Primitives;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for Microsoft.Win32.Primitives.dll
        /// </summary>
        public static PortableExecutableReference MicrosoftWin32Primitives
        {
            get
            {
                if (_MicrosoftWin32Primitives is null)
                {
                    _MicrosoftWin32Primitives = AssemblyMetadata.CreateFromImage(Resources.MicrosoftWin32Primitives).GetReference(filePath: "Microsoft.Win32.Primitives.dll", display: "Microsoft.Win32.Primitives (netstandard20)");
                }
                return _MicrosoftWin32Primitives;
            }
        }

        private static PortableExecutableReference? _mscorlib;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for mscorlib.dll
        /// </summary>
        public static PortableExecutableReference mscorlib
        {
            get
            {
                if (_mscorlib is null)
                {
                    _mscorlib = AssemblyMetadata.CreateFromImage(Resources.mscorlib).GetReference(filePath: "mscorlib.dll", display: "mscorlib (netstandard20)");
                }
                return _mscorlib;
            }
        }

        private static PortableExecutableReference? _netstandard;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for netstandard.dll
        /// </summary>
        public static PortableExecutableReference netstandard
        {
            get
            {
                if (_netstandard is null)
                {
                    _netstandard = AssemblyMetadata.CreateFromImage(Resources.netstandard).GetReference(filePath: "netstandard.dll", display: "netstandard (netstandard20)");
                }
                return _netstandard;
            }
        }

        private static PortableExecutableReference? _SystemAppContext;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.AppContext.dll
        /// </summary>
        public static PortableExecutableReference SystemAppContext
        {
            get
            {
                if (_SystemAppContext is null)
                {
                    _SystemAppContext = AssemblyMetadata.CreateFromImage(Resources.SystemAppContext).GetReference(filePath: "System.AppContext.dll", display: "System.AppContext (netstandard20)");
                }
                return _SystemAppContext;
            }
        }

        private static PortableExecutableReference? _SystemCollectionsConcurrent;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Collections.Concurrent.dll
        /// </summary>
        public static PortableExecutableReference SystemCollectionsConcurrent
        {
            get
            {
                if (_SystemCollectionsConcurrent is null)
                {
                    _SystemCollectionsConcurrent = AssemblyMetadata.CreateFromImage(Resources.SystemCollectionsConcurrent).GetReference(filePath: "System.Collections.Concurrent.dll", display: "System.Collections.Concurrent (netstandard20)");
                }
                return _SystemCollectionsConcurrent;
            }
        }

        private static PortableExecutableReference? _SystemCollections;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Collections.dll
        /// </summary>
        public static PortableExecutableReference SystemCollections
        {
            get
            {
                if (_SystemCollections is null)
                {
                    _SystemCollections = AssemblyMetadata.CreateFromImage(Resources.SystemCollections).GetReference(filePath: "System.Collections.dll", display: "System.Collections (netstandard20)");
                }
                return _SystemCollections;
            }
        }

        private static PortableExecutableReference? _SystemCollectionsNonGeneric;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Collections.NonGeneric.dll
        /// </summary>
        public static PortableExecutableReference SystemCollectionsNonGeneric
        {
            get
            {
                if (_SystemCollectionsNonGeneric is null)
                {
                    _SystemCollectionsNonGeneric = AssemblyMetadata.CreateFromImage(Resources.SystemCollectionsNonGeneric).GetReference(filePath: "System.Collections.NonGeneric.dll", display: "System.Collections.NonGeneric (netstandard20)");
                }
                return _SystemCollectionsNonGeneric;
            }
        }

        private static PortableExecutableReference? _SystemCollectionsSpecialized;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Collections.Specialized.dll
        /// </summary>
        public static PortableExecutableReference SystemCollectionsSpecialized
        {
            get
            {
                if (_SystemCollectionsSpecialized is null)
                {
                    _SystemCollectionsSpecialized = AssemblyMetadata.CreateFromImage(Resources.SystemCollectionsSpecialized).GetReference(filePath: "System.Collections.Specialized.dll", display: "System.Collections.Specialized (netstandard20)");
                }
                return _SystemCollectionsSpecialized;
            }
        }

        private static PortableExecutableReference? _SystemComponentModelComposition;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.ComponentModel.Composition.dll
        /// </summary>
        public static PortableExecutableReference SystemComponentModelComposition
        {
            get
            {
                if (_SystemComponentModelComposition is null)
                {
                    _SystemComponentModelComposition = AssemblyMetadata.CreateFromImage(Resources.SystemComponentModelComposition).GetReference(filePath: "System.ComponentModel.Composition.dll", display: "System.ComponentModel.Composition (netstandard20)");
                }
                return _SystemComponentModelComposition;
            }
        }

        private static PortableExecutableReference? _SystemComponentModel;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.ComponentModel.dll
        /// </summary>
        public static PortableExecutableReference SystemComponentModel
        {
            get
            {
                if (_SystemComponentModel is null)
                {
                    _SystemComponentModel = AssemblyMetadata.CreateFromImage(Resources.SystemComponentModel).GetReference(filePath: "System.ComponentModel.dll", display: "System.ComponentModel (netstandard20)");
                }
                return _SystemComponentModel;
            }
        }

        private static PortableExecutableReference? _SystemComponentModelEventBasedAsync;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.ComponentModel.EventBasedAsync.dll
        /// </summary>
        public static PortableExecutableReference SystemComponentModelEventBasedAsync
        {
            get
            {
                if (_SystemComponentModelEventBasedAsync is null)
                {
                    _SystemComponentModelEventBasedAsync = AssemblyMetadata.CreateFromImage(Resources.SystemComponentModelEventBasedAsync).GetReference(filePath: "System.ComponentModel.EventBasedAsync.dll", display: "System.ComponentModel.EventBasedAsync (netstandard20)");
                }
                return _SystemComponentModelEventBasedAsync;
            }
        }

        private static PortableExecutableReference? _SystemComponentModelPrimitives;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.ComponentModel.Primitives.dll
        /// </summary>
        public static PortableExecutableReference SystemComponentModelPrimitives
        {
            get
            {
                if (_SystemComponentModelPrimitives is null)
                {
                    _SystemComponentModelPrimitives = AssemblyMetadata.CreateFromImage(Resources.SystemComponentModelPrimitives).GetReference(filePath: "System.ComponentModel.Primitives.dll", display: "System.ComponentModel.Primitives (netstandard20)");
                }
                return _SystemComponentModelPrimitives;
            }
        }

        private static PortableExecutableReference? _SystemComponentModelTypeConverter;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.ComponentModel.TypeConverter.dll
        /// </summary>
        public static PortableExecutableReference SystemComponentModelTypeConverter
        {
            get
            {
                if (_SystemComponentModelTypeConverter is null)
                {
                    _SystemComponentModelTypeConverter = AssemblyMetadata.CreateFromImage(Resources.SystemComponentModelTypeConverter).GetReference(filePath: "System.ComponentModel.TypeConverter.dll", display: "System.ComponentModel.TypeConverter (netstandard20)");
                }
                return _SystemComponentModelTypeConverter;
            }
        }

        private static PortableExecutableReference? _SystemConsole;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Console.dll
        /// </summary>
        public static PortableExecutableReference SystemConsole
        {
            get
            {
                if (_SystemConsole is null)
                {
                    _SystemConsole = AssemblyMetadata.CreateFromImage(Resources.SystemConsole).GetReference(filePath: "System.Console.dll", display: "System.Console (netstandard20)");
                }
                return _SystemConsole;
            }
        }

        private static PortableExecutableReference? _SystemCore;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Core.dll
        /// </summary>
        public static PortableExecutableReference SystemCore
        {
            get
            {
                if (_SystemCore is null)
                {
                    _SystemCore = AssemblyMetadata.CreateFromImage(Resources.SystemCore).GetReference(filePath: "System.Core.dll", display: "System.Core (netstandard20)");
                }
                return _SystemCore;
            }
        }

        private static PortableExecutableReference? _SystemDataCommon;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Data.Common.dll
        /// </summary>
        public static PortableExecutableReference SystemDataCommon
        {
            get
            {
                if (_SystemDataCommon is null)
                {
                    _SystemDataCommon = AssemblyMetadata.CreateFromImage(Resources.SystemDataCommon).GetReference(filePath: "System.Data.Common.dll", display: "System.Data.Common (netstandard20)");
                }
                return _SystemDataCommon;
            }
        }

        private static PortableExecutableReference? _SystemData;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Data.dll
        /// </summary>
        public static PortableExecutableReference SystemData
        {
            get
            {
                if (_SystemData is null)
                {
                    _SystemData = AssemblyMetadata.CreateFromImage(Resources.SystemData).GetReference(filePath: "System.Data.dll", display: "System.Data (netstandard20)");
                }
                return _SystemData;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsContracts;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.Contracts.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsContracts
        {
            get
            {
                if (_SystemDiagnosticsContracts is null)
                {
                    _SystemDiagnosticsContracts = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsContracts).GetReference(filePath: "System.Diagnostics.Contracts.dll", display: "System.Diagnostics.Contracts (netstandard20)");
                }
                return _SystemDiagnosticsContracts;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsDebug;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.Debug.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsDebug
        {
            get
            {
                if (_SystemDiagnosticsDebug is null)
                {
                    _SystemDiagnosticsDebug = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsDebug).GetReference(filePath: "System.Diagnostics.Debug.dll", display: "System.Diagnostics.Debug (netstandard20)");
                }
                return _SystemDiagnosticsDebug;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsFileVersionInfo;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.FileVersionInfo.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsFileVersionInfo
        {
            get
            {
                if (_SystemDiagnosticsFileVersionInfo is null)
                {
                    _SystemDiagnosticsFileVersionInfo = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsFileVersionInfo).GetReference(filePath: "System.Diagnostics.FileVersionInfo.dll", display: "System.Diagnostics.FileVersionInfo (netstandard20)");
                }
                return _SystemDiagnosticsFileVersionInfo;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsProcess;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.Process.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsProcess
        {
            get
            {
                if (_SystemDiagnosticsProcess is null)
                {
                    _SystemDiagnosticsProcess = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsProcess).GetReference(filePath: "System.Diagnostics.Process.dll", display: "System.Diagnostics.Process (netstandard20)");
                }
                return _SystemDiagnosticsProcess;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsStackTrace;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.StackTrace.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsStackTrace
        {
            get
            {
                if (_SystemDiagnosticsStackTrace is null)
                {
                    _SystemDiagnosticsStackTrace = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsStackTrace).GetReference(filePath: "System.Diagnostics.StackTrace.dll", display: "System.Diagnostics.StackTrace (netstandard20)");
                }
                return _SystemDiagnosticsStackTrace;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsTextWriterTraceListener;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.TextWriterTraceListener.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsTextWriterTraceListener
        {
            get
            {
                if (_SystemDiagnosticsTextWriterTraceListener is null)
                {
                    _SystemDiagnosticsTextWriterTraceListener = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsTextWriterTraceListener).GetReference(filePath: "System.Diagnostics.TextWriterTraceListener.dll", display: "System.Diagnostics.TextWriterTraceListener (netstandard20)");
                }
                return _SystemDiagnosticsTextWriterTraceListener;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsTools;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.Tools.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsTools
        {
            get
            {
                if (_SystemDiagnosticsTools is null)
                {
                    _SystemDiagnosticsTools = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsTools).GetReference(filePath: "System.Diagnostics.Tools.dll", display: "System.Diagnostics.Tools (netstandard20)");
                }
                return _SystemDiagnosticsTools;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsTraceSource;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.TraceSource.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsTraceSource
        {
            get
            {
                if (_SystemDiagnosticsTraceSource is null)
                {
                    _SystemDiagnosticsTraceSource = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsTraceSource).GetReference(filePath: "System.Diagnostics.TraceSource.dll", display: "System.Diagnostics.TraceSource (netstandard20)");
                }
                return _SystemDiagnosticsTraceSource;
            }
        }

        private static PortableExecutableReference? _SystemDiagnosticsTracing;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Diagnostics.Tracing.dll
        /// </summary>
        public static PortableExecutableReference SystemDiagnosticsTracing
        {
            get
            {
                if (_SystemDiagnosticsTracing is null)
                {
                    _SystemDiagnosticsTracing = AssemblyMetadata.CreateFromImage(Resources.SystemDiagnosticsTracing).GetReference(filePath: "System.Diagnostics.Tracing.dll", display: "System.Diagnostics.Tracing (netstandard20)");
                }
                return _SystemDiagnosticsTracing;
            }
        }

        private static PortableExecutableReference? _System;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.dll
        /// </summary>
        public static PortableExecutableReference System
        {
            get
            {
                if (_System is null)
                {
                    _System = AssemblyMetadata.CreateFromImage(Resources.System).GetReference(filePath: "System.dll", display: "System (netstandard20)");
                }
                return _System;
            }
        }

        private static PortableExecutableReference? _SystemDrawing;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Drawing.dll
        /// </summary>
        public static PortableExecutableReference SystemDrawing
        {
            get
            {
                if (_SystemDrawing is null)
                {
                    _SystemDrawing = AssemblyMetadata.CreateFromImage(Resources.SystemDrawing).GetReference(filePath: "System.Drawing.dll", display: "System.Drawing (netstandard20)");
                }
                return _SystemDrawing;
            }
        }

        private static PortableExecutableReference? _SystemDrawingPrimitives;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Drawing.Primitives.dll
        /// </summary>
        public static PortableExecutableReference SystemDrawingPrimitives
        {
            get
            {
                if (_SystemDrawingPrimitives is null)
                {
                    _SystemDrawingPrimitives = AssemblyMetadata.CreateFromImage(Resources.SystemDrawingPrimitives).GetReference(filePath: "System.Drawing.Primitives.dll", display: "System.Drawing.Primitives (netstandard20)");
                }
                return _SystemDrawingPrimitives;
            }
        }

        private static PortableExecutableReference? _SystemDynamicRuntime;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Dynamic.Runtime.dll
        /// </summary>
        public static PortableExecutableReference SystemDynamicRuntime
        {
            get
            {
                if (_SystemDynamicRuntime is null)
                {
                    _SystemDynamicRuntime = AssemblyMetadata.CreateFromImage(Resources.SystemDynamicRuntime).GetReference(filePath: "System.Dynamic.Runtime.dll", display: "System.Dynamic.Runtime (netstandard20)");
                }
                return _SystemDynamicRuntime;
            }
        }

        private static PortableExecutableReference? _SystemGlobalizationCalendars;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Globalization.Calendars.dll
        /// </summary>
        public static PortableExecutableReference SystemGlobalizationCalendars
        {
            get
            {
                if (_SystemGlobalizationCalendars is null)
                {
                    _SystemGlobalizationCalendars = AssemblyMetadata.CreateFromImage(Resources.SystemGlobalizationCalendars).GetReference(filePath: "System.Globalization.Calendars.dll", display: "System.Globalization.Calendars (netstandard20)");
                }
                return _SystemGlobalizationCalendars;
            }
        }

        private static PortableExecutableReference? _SystemGlobalization;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Globalization.dll
        /// </summary>
        public static PortableExecutableReference SystemGlobalization
        {
            get
            {
                if (_SystemGlobalization is null)
                {
                    _SystemGlobalization = AssemblyMetadata.CreateFromImage(Resources.SystemGlobalization).GetReference(filePath: "System.Globalization.dll", display: "System.Globalization (netstandard20)");
                }
                return _SystemGlobalization;
            }
        }

        private static PortableExecutableReference? _SystemGlobalizationExtensions;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Globalization.Extensions.dll
        /// </summary>
        public static PortableExecutableReference SystemGlobalizationExtensions
        {
            get
            {
                if (_SystemGlobalizationExtensions is null)
                {
                    _SystemGlobalizationExtensions = AssemblyMetadata.CreateFromImage(Resources.SystemGlobalizationExtensions).GetReference(filePath: "System.Globalization.Extensions.dll", display: "System.Globalization.Extensions (netstandard20)");
                }
                return _SystemGlobalizationExtensions;
            }
        }

        private static PortableExecutableReference? _SystemIOCompression;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.Compression.dll
        /// </summary>
        public static PortableExecutableReference SystemIOCompression
        {
            get
            {
                if (_SystemIOCompression is null)
                {
                    _SystemIOCompression = AssemblyMetadata.CreateFromImage(Resources.SystemIOCompression).GetReference(filePath: "System.IO.Compression.dll", display: "System.IO.Compression (netstandard20)");
                }
                return _SystemIOCompression;
            }
        }

        private static PortableExecutableReference? _SystemIOCompressionFileSystem;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.Compression.FileSystem.dll
        /// </summary>
        public static PortableExecutableReference SystemIOCompressionFileSystem
        {
            get
            {
                if (_SystemIOCompressionFileSystem is null)
                {
                    _SystemIOCompressionFileSystem = AssemblyMetadata.CreateFromImage(Resources.SystemIOCompressionFileSystem).GetReference(filePath: "System.IO.Compression.FileSystem.dll", display: "System.IO.Compression.FileSystem (netstandard20)");
                }
                return _SystemIOCompressionFileSystem;
            }
        }

        private static PortableExecutableReference? _SystemIOCompressionZipFile;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.Compression.ZipFile.dll
        /// </summary>
        public static PortableExecutableReference SystemIOCompressionZipFile
        {
            get
            {
                if (_SystemIOCompressionZipFile is null)
                {
                    _SystemIOCompressionZipFile = AssemblyMetadata.CreateFromImage(Resources.SystemIOCompressionZipFile).GetReference(filePath: "System.IO.Compression.ZipFile.dll", display: "System.IO.Compression.ZipFile (netstandard20)");
                }
                return _SystemIOCompressionZipFile;
            }
        }

        private static PortableExecutableReference? _SystemIO;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.dll
        /// </summary>
        public static PortableExecutableReference SystemIO
        {
            get
            {
                if (_SystemIO is null)
                {
                    _SystemIO = AssemblyMetadata.CreateFromImage(Resources.SystemIO).GetReference(filePath: "System.IO.dll", display: "System.IO (netstandard20)");
                }
                return _SystemIO;
            }
        }

        private static PortableExecutableReference? _SystemIOFileSystem;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.FileSystem.dll
        /// </summary>
        public static PortableExecutableReference SystemIOFileSystem
        {
            get
            {
                if (_SystemIOFileSystem is null)
                {
                    _SystemIOFileSystem = AssemblyMetadata.CreateFromImage(Resources.SystemIOFileSystem).GetReference(filePath: "System.IO.FileSystem.dll", display: "System.IO.FileSystem (netstandard20)");
                }
                return _SystemIOFileSystem;
            }
        }

        private static PortableExecutableReference? _SystemIOFileSystemDriveInfo;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.FileSystem.DriveInfo.dll
        /// </summary>
        public static PortableExecutableReference SystemIOFileSystemDriveInfo
        {
            get
            {
                if (_SystemIOFileSystemDriveInfo is null)
                {
                    _SystemIOFileSystemDriveInfo = AssemblyMetadata.CreateFromImage(Resources.SystemIOFileSystemDriveInfo).GetReference(filePath: "System.IO.FileSystem.DriveInfo.dll", display: "System.IO.FileSystem.DriveInfo (netstandard20)");
                }
                return _SystemIOFileSystemDriveInfo;
            }
        }

        private static PortableExecutableReference? _SystemIOFileSystemPrimitives;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.FileSystem.Primitives.dll
        /// </summary>
        public static PortableExecutableReference SystemIOFileSystemPrimitives
        {
            get
            {
                if (_SystemIOFileSystemPrimitives is null)
                {
                    _SystemIOFileSystemPrimitives = AssemblyMetadata.CreateFromImage(Resources.SystemIOFileSystemPrimitives).GetReference(filePath: "System.IO.FileSystem.Primitives.dll", display: "System.IO.FileSystem.Primitives (netstandard20)");
                }
                return _SystemIOFileSystemPrimitives;
            }
        }

        private static PortableExecutableReference? _SystemIOFileSystemWatcher;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.FileSystem.Watcher.dll
        /// </summary>
        public static PortableExecutableReference SystemIOFileSystemWatcher
        {
            get
            {
                if (_SystemIOFileSystemWatcher is null)
                {
                    _SystemIOFileSystemWatcher = AssemblyMetadata.CreateFromImage(Resources.SystemIOFileSystemWatcher).GetReference(filePath: "System.IO.FileSystem.Watcher.dll", display: "System.IO.FileSystem.Watcher (netstandard20)");
                }
                return _SystemIOFileSystemWatcher;
            }
        }

        private static PortableExecutableReference? _SystemIOIsolatedStorage;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.IsolatedStorage.dll
        /// </summary>
        public static PortableExecutableReference SystemIOIsolatedStorage
        {
            get
            {
                if (_SystemIOIsolatedStorage is null)
                {
                    _SystemIOIsolatedStorage = AssemblyMetadata.CreateFromImage(Resources.SystemIOIsolatedStorage).GetReference(filePath: "System.IO.IsolatedStorage.dll", display: "System.IO.IsolatedStorage (netstandard20)");
                }
                return _SystemIOIsolatedStorage;
            }
        }

        private static PortableExecutableReference? _SystemIOMemoryMappedFiles;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.MemoryMappedFiles.dll
        /// </summary>
        public static PortableExecutableReference SystemIOMemoryMappedFiles
        {
            get
            {
                if (_SystemIOMemoryMappedFiles is null)
                {
                    _SystemIOMemoryMappedFiles = AssemblyMetadata.CreateFromImage(Resources.SystemIOMemoryMappedFiles).GetReference(filePath: "System.IO.MemoryMappedFiles.dll", display: "System.IO.MemoryMappedFiles (netstandard20)");
                }
                return _SystemIOMemoryMappedFiles;
            }
        }

        private static PortableExecutableReference? _SystemIOPipes;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.Pipes.dll
        /// </summary>
        public static PortableExecutableReference SystemIOPipes
        {
            get
            {
                if (_SystemIOPipes is null)
                {
                    _SystemIOPipes = AssemblyMetadata.CreateFromImage(Resources.SystemIOPipes).GetReference(filePath: "System.IO.Pipes.dll", display: "System.IO.Pipes (netstandard20)");
                }
                return _SystemIOPipes;
            }
        }

        private static PortableExecutableReference? _SystemIOUnmanagedMemoryStream;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.IO.UnmanagedMemoryStream.dll
        /// </summary>
        public static PortableExecutableReference SystemIOUnmanagedMemoryStream
        {
            get
            {
                if (_SystemIOUnmanagedMemoryStream is null)
                {
                    _SystemIOUnmanagedMemoryStream = AssemblyMetadata.CreateFromImage(Resources.SystemIOUnmanagedMemoryStream).GetReference(filePath: "System.IO.UnmanagedMemoryStream.dll", display: "System.IO.UnmanagedMemoryStream (netstandard20)");
                }
                return _SystemIOUnmanagedMemoryStream;
            }
        }

        private static PortableExecutableReference? _SystemLinq;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Linq.dll
        /// </summary>
        public static PortableExecutableReference SystemLinq
        {
            get
            {
                if (_SystemLinq is null)
                {
                    _SystemLinq = AssemblyMetadata.CreateFromImage(Resources.SystemLinq).GetReference(filePath: "System.Linq.dll", display: "System.Linq (netstandard20)");
                }
                return _SystemLinq;
            }
        }

        private static PortableExecutableReference? _SystemLinqExpressions;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Linq.Expressions.dll
        /// </summary>
        public static PortableExecutableReference SystemLinqExpressions
        {
            get
            {
                if (_SystemLinqExpressions is null)
                {
                    _SystemLinqExpressions = AssemblyMetadata.CreateFromImage(Resources.SystemLinqExpressions).GetReference(filePath: "System.Linq.Expressions.dll", display: "System.Linq.Expressions (netstandard20)");
                }
                return _SystemLinqExpressions;
            }
        }

        private static PortableExecutableReference? _SystemLinqParallel;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Linq.Parallel.dll
        /// </summary>
        public static PortableExecutableReference SystemLinqParallel
        {
            get
            {
                if (_SystemLinqParallel is null)
                {
                    _SystemLinqParallel = AssemblyMetadata.CreateFromImage(Resources.SystemLinqParallel).GetReference(filePath: "System.Linq.Parallel.dll", display: "System.Linq.Parallel (netstandard20)");
                }
                return _SystemLinqParallel;
            }
        }

        private static PortableExecutableReference? _SystemLinqQueryable;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Linq.Queryable.dll
        /// </summary>
        public static PortableExecutableReference SystemLinqQueryable
        {
            get
            {
                if (_SystemLinqQueryable is null)
                {
                    _SystemLinqQueryable = AssemblyMetadata.CreateFromImage(Resources.SystemLinqQueryable).GetReference(filePath: "System.Linq.Queryable.dll", display: "System.Linq.Queryable (netstandard20)");
                }
                return _SystemLinqQueryable;
            }
        }

        private static PortableExecutableReference? _SystemNet;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.dll
        /// </summary>
        public static PortableExecutableReference SystemNet
        {
            get
            {
                if (_SystemNet is null)
                {
                    _SystemNet = AssemblyMetadata.CreateFromImage(Resources.SystemNet).GetReference(filePath: "System.Net.dll", display: "System.Net (netstandard20)");
                }
                return _SystemNet;
            }
        }

        private static PortableExecutableReference? _SystemNetHttp;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.Http.dll
        /// </summary>
        public static PortableExecutableReference SystemNetHttp
        {
            get
            {
                if (_SystemNetHttp is null)
                {
                    _SystemNetHttp = AssemblyMetadata.CreateFromImage(Resources.SystemNetHttp).GetReference(filePath: "System.Net.Http.dll", display: "System.Net.Http (netstandard20)");
                }
                return _SystemNetHttp;
            }
        }

        private static PortableExecutableReference? _SystemNetNameResolution;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.NameResolution.dll
        /// </summary>
        public static PortableExecutableReference SystemNetNameResolution
        {
            get
            {
                if (_SystemNetNameResolution is null)
                {
                    _SystemNetNameResolution = AssemblyMetadata.CreateFromImage(Resources.SystemNetNameResolution).GetReference(filePath: "System.Net.NameResolution.dll", display: "System.Net.NameResolution (netstandard20)");
                }
                return _SystemNetNameResolution;
            }
        }

        private static PortableExecutableReference? _SystemNetNetworkInformation;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.NetworkInformation.dll
        /// </summary>
        public static PortableExecutableReference SystemNetNetworkInformation
        {
            get
            {
                if (_SystemNetNetworkInformation is null)
                {
                    _SystemNetNetworkInformation = AssemblyMetadata.CreateFromImage(Resources.SystemNetNetworkInformation).GetReference(filePath: "System.Net.NetworkInformation.dll", display: "System.Net.NetworkInformation (netstandard20)");
                }
                return _SystemNetNetworkInformation;
            }
        }

        private static PortableExecutableReference? _SystemNetPing;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.Ping.dll
        /// </summary>
        public static PortableExecutableReference SystemNetPing
        {
            get
            {
                if (_SystemNetPing is null)
                {
                    _SystemNetPing = AssemblyMetadata.CreateFromImage(Resources.SystemNetPing).GetReference(filePath: "System.Net.Ping.dll", display: "System.Net.Ping (netstandard20)");
                }
                return _SystemNetPing;
            }
        }

        private static PortableExecutableReference? _SystemNetPrimitives;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.Primitives.dll
        /// </summary>
        public static PortableExecutableReference SystemNetPrimitives
        {
            get
            {
                if (_SystemNetPrimitives is null)
                {
                    _SystemNetPrimitives = AssemblyMetadata.CreateFromImage(Resources.SystemNetPrimitives).GetReference(filePath: "System.Net.Primitives.dll", display: "System.Net.Primitives (netstandard20)");
                }
                return _SystemNetPrimitives;
            }
        }

        private static PortableExecutableReference? _SystemNetRequests;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.Requests.dll
        /// </summary>
        public static PortableExecutableReference SystemNetRequests
        {
            get
            {
                if (_SystemNetRequests is null)
                {
                    _SystemNetRequests = AssemblyMetadata.CreateFromImage(Resources.SystemNetRequests).GetReference(filePath: "System.Net.Requests.dll", display: "System.Net.Requests (netstandard20)");
                }
                return _SystemNetRequests;
            }
        }

        private static PortableExecutableReference? _SystemNetSecurity;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.Security.dll
        /// </summary>
        public static PortableExecutableReference SystemNetSecurity
        {
            get
            {
                if (_SystemNetSecurity is null)
                {
                    _SystemNetSecurity = AssemblyMetadata.CreateFromImage(Resources.SystemNetSecurity).GetReference(filePath: "System.Net.Security.dll", display: "System.Net.Security (netstandard20)");
                }
                return _SystemNetSecurity;
            }
        }

        private static PortableExecutableReference? _SystemNetSockets;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.Sockets.dll
        /// </summary>
        public static PortableExecutableReference SystemNetSockets
        {
            get
            {
                if (_SystemNetSockets is null)
                {
                    _SystemNetSockets = AssemblyMetadata.CreateFromImage(Resources.SystemNetSockets).GetReference(filePath: "System.Net.Sockets.dll", display: "System.Net.Sockets (netstandard20)");
                }
                return _SystemNetSockets;
            }
        }

        private static PortableExecutableReference? _SystemNetWebHeaderCollection;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.WebHeaderCollection.dll
        /// </summary>
        public static PortableExecutableReference SystemNetWebHeaderCollection
        {
            get
            {
                if (_SystemNetWebHeaderCollection is null)
                {
                    _SystemNetWebHeaderCollection = AssemblyMetadata.CreateFromImage(Resources.SystemNetWebHeaderCollection).GetReference(filePath: "System.Net.WebHeaderCollection.dll", display: "System.Net.WebHeaderCollection (netstandard20)");
                }
                return _SystemNetWebHeaderCollection;
            }
        }

        private static PortableExecutableReference? _SystemNetWebSocketsClient;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.WebSockets.Client.dll
        /// </summary>
        public static PortableExecutableReference SystemNetWebSocketsClient
        {
            get
            {
                if (_SystemNetWebSocketsClient is null)
                {
                    _SystemNetWebSocketsClient = AssemblyMetadata.CreateFromImage(Resources.SystemNetWebSocketsClient).GetReference(filePath: "System.Net.WebSockets.Client.dll", display: "System.Net.WebSockets.Client (netstandard20)");
                }
                return _SystemNetWebSocketsClient;
            }
        }

        private static PortableExecutableReference? _SystemNetWebSockets;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Net.WebSockets.dll
        /// </summary>
        public static PortableExecutableReference SystemNetWebSockets
        {
            get
            {
                if (_SystemNetWebSockets is null)
                {
                    _SystemNetWebSockets = AssemblyMetadata.CreateFromImage(Resources.SystemNetWebSockets).GetReference(filePath: "System.Net.WebSockets.dll", display: "System.Net.WebSockets (netstandard20)");
                }
                return _SystemNetWebSockets;
            }
        }

        private static PortableExecutableReference? _SystemNumerics;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Numerics.dll
        /// </summary>
        public static PortableExecutableReference SystemNumerics
        {
            get
            {
                if (_SystemNumerics is null)
                {
                    _SystemNumerics = AssemblyMetadata.CreateFromImage(Resources.SystemNumerics).GetReference(filePath: "System.Numerics.dll", display: "System.Numerics (netstandard20)");
                }
                return _SystemNumerics;
            }
        }

        private static PortableExecutableReference? _SystemObjectModel;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.ObjectModel.dll
        /// </summary>
        public static PortableExecutableReference SystemObjectModel
        {
            get
            {
                if (_SystemObjectModel is null)
                {
                    _SystemObjectModel = AssemblyMetadata.CreateFromImage(Resources.SystemObjectModel).GetReference(filePath: "System.ObjectModel.dll", display: "System.ObjectModel (netstandard20)");
                }
                return _SystemObjectModel;
            }
        }

        private static PortableExecutableReference? _SystemReflection;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Reflection.dll
        /// </summary>
        public static PortableExecutableReference SystemReflection
        {
            get
            {
                if (_SystemReflection is null)
                {
                    _SystemReflection = AssemblyMetadata.CreateFromImage(Resources.SystemReflection).GetReference(filePath: "System.Reflection.dll", display: "System.Reflection (netstandard20)");
                }
                return _SystemReflection;
            }
        }

        private static PortableExecutableReference? _SystemReflectionExtensions;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Reflection.Extensions.dll
        /// </summary>
        public static PortableExecutableReference SystemReflectionExtensions
        {
            get
            {
                if (_SystemReflectionExtensions is null)
                {
                    _SystemReflectionExtensions = AssemblyMetadata.CreateFromImage(Resources.SystemReflectionExtensions).GetReference(filePath: "System.Reflection.Extensions.dll", display: "System.Reflection.Extensions (netstandard20)");
                }
                return _SystemReflectionExtensions;
            }
        }

        private static PortableExecutableReference? _SystemReflectionPrimitives;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Reflection.Primitives.dll
        /// </summary>
        public static PortableExecutableReference SystemReflectionPrimitives
        {
            get
            {
                if (_SystemReflectionPrimitives is null)
                {
                    _SystemReflectionPrimitives = AssemblyMetadata.CreateFromImage(Resources.SystemReflectionPrimitives).GetReference(filePath: "System.Reflection.Primitives.dll", display: "System.Reflection.Primitives (netstandard20)");
                }
                return _SystemReflectionPrimitives;
            }
        }

        private static PortableExecutableReference? _SystemResourcesReader;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Resources.Reader.dll
        /// </summary>
        public static PortableExecutableReference SystemResourcesReader
        {
            get
            {
                if (_SystemResourcesReader is null)
                {
                    _SystemResourcesReader = AssemblyMetadata.CreateFromImage(Resources.SystemResourcesReader).GetReference(filePath: "System.Resources.Reader.dll", display: "System.Resources.Reader (netstandard20)");
                }
                return _SystemResourcesReader;
            }
        }

        private static PortableExecutableReference? _SystemResourcesResourceManager;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Resources.ResourceManager.dll
        /// </summary>
        public static PortableExecutableReference SystemResourcesResourceManager
        {
            get
            {
                if (_SystemResourcesResourceManager is null)
                {
                    _SystemResourcesResourceManager = AssemblyMetadata.CreateFromImage(Resources.SystemResourcesResourceManager).GetReference(filePath: "System.Resources.ResourceManager.dll", display: "System.Resources.ResourceManager (netstandard20)");
                }
                return _SystemResourcesResourceManager;
            }
        }

        private static PortableExecutableReference? _SystemResourcesWriter;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Resources.Writer.dll
        /// </summary>
        public static PortableExecutableReference SystemResourcesWriter
        {
            get
            {
                if (_SystemResourcesWriter is null)
                {
                    _SystemResourcesWriter = AssemblyMetadata.CreateFromImage(Resources.SystemResourcesWriter).GetReference(filePath: "System.Resources.Writer.dll", display: "System.Resources.Writer (netstandard20)");
                }
                return _SystemResourcesWriter;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeCompilerServicesVisualC;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.CompilerServices.VisualC.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeCompilerServicesVisualC
        {
            get
            {
                if (_SystemRuntimeCompilerServicesVisualC is null)
                {
                    _SystemRuntimeCompilerServicesVisualC = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeCompilerServicesVisualC).GetReference(filePath: "System.Runtime.CompilerServices.VisualC.dll", display: "System.Runtime.CompilerServices.VisualC (netstandard20)");
                }
                return _SystemRuntimeCompilerServicesVisualC;
            }
        }

        private static PortableExecutableReference? _SystemRuntime;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntime
        {
            get
            {
                if (_SystemRuntime is null)
                {
                    _SystemRuntime = AssemblyMetadata.CreateFromImage(Resources.SystemRuntime).GetReference(filePath: "System.Runtime.dll", display: "System.Runtime (netstandard20)");
                }
                return _SystemRuntime;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeExtensions;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.Extensions.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeExtensions
        {
            get
            {
                if (_SystemRuntimeExtensions is null)
                {
                    _SystemRuntimeExtensions = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeExtensions).GetReference(filePath: "System.Runtime.Extensions.dll", display: "System.Runtime.Extensions (netstandard20)");
                }
                return _SystemRuntimeExtensions;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeHandles;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.Handles.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeHandles
        {
            get
            {
                if (_SystemRuntimeHandles is null)
                {
                    _SystemRuntimeHandles = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeHandles).GetReference(filePath: "System.Runtime.Handles.dll", display: "System.Runtime.Handles (netstandard20)");
                }
                return _SystemRuntimeHandles;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeInteropServices;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.InteropServices.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeInteropServices
        {
            get
            {
                if (_SystemRuntimeInteropServices is null)
                {
                    _SystemRuntimeInteropServices = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeInteropServices).GetReference(filePath: "System.Runtime.InteropServices.dll", display: "System.Runtime.InteropServices (netstandard20)");
                }
                return _SystemRuntimeInteropServices;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeInteropServicesRuntimeInformation;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.InteropServices.RuntimeInformation.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeInteropServicesRuntimeInformation
        {
            get
            {
                if (_SystemRuntimeInteropServicesRuntimeInformation is null)
                {
                    _SystemRuntimeInteropServicesRuntimeInformation = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeInteropServicesRuntimeInformation).GetReference(filePath: "System.Runtime.InteropServices.RuntimeInformation.dll", display: "System.Runtime.InteropServices.RuntimeInformation (netstandard20)");
                }
                return _SystemRuntimeInteropServicesRuntimeInformation;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeNumerics;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.Numerics.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeNumerics
        {
            get
            {
                if (_SystemRuntimeNumerics is null)
                {
                    _SystemRuntimeNumerics = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeNumerics).GetReference(filePath: "System.Runtime.Numerics.dll", display: "System.Runtime.Numerics (netstandard20)");
                }
                return _SystemRuntimeNumerics;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeSerialization;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.Serialization.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeSerialization
        {
            get
            {
                if (_SystemRuntimeSerialization is null)
                {
                    _SystemRuntimeSerialization = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeSerialization).GetReference(filePath: "System.Runtime.Serialization.dll", display: "System.Runtime.Serialization (netstandard20)");
                }
                return _SystemRuntimeSerialization;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeSerializationFormatters;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.Serialization.Formatters.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeSerializationFormatters
        {
            get
            {
                if (_SystemRuntimeSerializationFormatters is null)
                {
                    _SystemRuntimeSerializationFormatters = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeSerializationFormatters).GetReference(filePath: "System.Runtime.Serialization.Formatters.dll", display: "System.Runtime.Serialization.Formatters (netstandard20)");
                }
                return _SystemRuntimeSerializationFormatters;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeSerializationJson;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.Serialization.Json.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeSerializationJson
        {
            get
            {
                if (_SystemRuntimeSerializationJson is null)
                {
                    _SystemRuntimeSerializationJson = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeSerializationJson).GetReference(filePath: "System.Runtime.Serialization.Json.dll", display: "System.Runtime.Serialization.Json (netstandard20)");
                }
                return _SystemRuntimeSerializationJson;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeSerializationPrimitives;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.Serialization.Primitives.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeSerializationPrimitives
        {
            get
            {
                if (_SystemRuntimeSerializationPrimitives is null)
                {
                    _SystemRuntimeSerializationPrimitives = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeSerializationPrimitives).GetReference(filePath: "System.Runtime.Serialization.Primitives.dll", display: "System.Runtime.Serialization.Primitives (netstandard20)");
                }
                return _SystemRuntimeSerializationPrimitives;
            }
        }

        private static PortableExecutableReference? _SystemRuntimeSerializationXml;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Runtime.Serialization.Xml.dll
        /// </summary>
        public static PortableExecutableReference SystemRuntimeSerializationXml
        {
            get
            {
                if (_SystemRuntimeSerializationXml is null)
                {
                    _SystemRuntimeSerializationXml = AssemblyMetadata.CreateFromImage(Resources.SystemRuntimeSerializationXml).GetReference(filePath: "System.Runtime.Serialization.Xml.dll", display: "System.Runtime.Serialization.Xml (netstandard20)");
                }
                return _SystemRuntimeSerializationXml;
            }
        }

        private static PortableExecutableReference? _SystemSecurityClaims;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Security.Claims.dll
        /// </summary>
        public static PortableExecutableReference SystemSecurityClaims
        {
            get
            {
                if (_SystemSecurityClaims is null)
                {
                    _SystemSecurityClaims = AssemblyMetadata.CreateFromImage(Resources.SystemSecurityClaims).GetReference(filePath: "System.Security.Claims.dll", display: "System.Security.Claims (netstandard20)");
                }
                return _SystemSecurityClaims;
            }
        }

        private static PortableExecutableReference? _SystemSecurityCryptographyAlgorithms;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Security.Cryptography.Algorithms.dll
        /// </summary>
        public static PortableExecutableReference SystemSecurityCryptographyAlgorithms
        {
            get
            {
                if (_SystemSecurityCryptographyAlgorithms is null)
                {
                    _SystemSecurityCryptographyAlgorithms = AssemblyMetadata.CreateFromImage(Resources.SystemSecurityCryptographyAlgorithms).GetReference(filePath: "System.Security.Cryptography.Algorithms.dll", display: "System.Security.Cryptography.Algorithms (netstandard20)");
                }
                return _SystemSecurityCryptographyAlgorithms;
            }
        }

        private static PortableExecutableReference? _SystemSecurityCryptographyCsp;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Security.Cryptography.Csp.dll
        /// </summary>
        public static PortableExecutableReference SystemSecurityCryptographyCsp
        {
            get
            {
                if (_SystemSecurityCryptographyCsp is null)
                {
                    _SystemSecurityCryptographyCsp = AssemblyMetadata.CreateFromImage(Resources.SystemSecurityCryptographyCsp).GetReference(filePath: "System.Security.Cryptography.Csp.dll", display: "System.Security.Cryptography.Csp (netstandard20)");
                }
                return _SystemSecurityCryptographyCsp;
            }
        }

        private static PortableExecutableReference? _SystemSecurityCryptographyEncoding;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Security.Cryptography.Encoding.dll
        /// </summary>
        public static PortableExecutableReference SystemSecurityCryptographyEncoding
        {
            get
            {
                if (_SystemSecurityCryptographyEncoding is null)
                {
                    _SystemSecurityCryptographyEncoding = AssemblyMetadata.CreateFromImage(Resources.SystemSecurityCryptographyEncoding).GetReference(filePath: "System.Security.Cryptography.Encoding.dll", display: "System.Security.Cryptography.Encoding (netstandard20)");
                }
                return _SystemSecurityCryptographyEncoding;
            }
        }

        private static PortableExecutableReference? _SystemSecurityCryptographyPrimitives;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Security.Cryptography.Primitives.dll
        /// </summary>
        public static PortableExecutableReference SystemSecurityCryptographyPrimitives
        {
            get
            {
                if (_SystemSecurityCryptographyPrimitives is null)
                {
                    _SystemSecurityCryptographyPrimitives = AssemblyMetadata.CreateFromImage(Resources.SystemSecurityCryptographyPrimitives).GetReference(filePath: "System.Security.Cryptography.Primitives.dll", display: "System.Security.Cryptography.Primitives (netstandard20)");
                }
                return _SystemSecurityCryptographyPrimitives;
            }
        }

        private static PortableExecutableReference? _SystemSecurityCryptographyX509Certificates;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Security.Cryptography.X509Certificates.dll
        /// </summary>
        public static PortableExecutableReference SystemSecurityCryptographyX509Certificates
        {
            get
            {
                if (_SystemSecurityCryptographyX509Certificates is null)
                {
                    _SystemSecurityCryptographyX509Certificates = AssemblyMetadata.CreateFromImage(Resources.SystemSecurityCryptographyX509Certificates).GetReference(filePath: "System.Security.Cryptography.X509Certificates.dll", display: "System.Security.Cryptography.X509Certificates (netstandard20)");
                }
                return _SystemSecurityCryptographyX509Certificates;
            }
        }

        private static PortableExecutableReference? _SystemSecurityPrincipal;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Security.Principal.dll
        /// </summary>
        public static PortableExecutableReference SystemSecurityPrincipal
        {
            get
            {
                if (_SystemSecurityPrincipal is null)
                {
                    _SystemSecurityPrincipal = AssemblyMetadata.CreateFromImage(Resources.SystemSecurityPrincipal).GetReference(filePath: "System.Security.Principal.dll", display: "System.Security.Principal (netstandard20)");
                }
                return _SystemSecurityPrincipal;
            }
        }

        private static PortableExecutableReference? _SystemSecuritySecureString;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Security.SecureString.dll
        /// </summary>
        public static PortableExecutableReference SystemSecuritySecureString
        {
            get
            {
                if (_SystemSecuritySecureString is null)
                {
                    _SystemSecuritySecureString = AssemblyMetadata.CreateFromImage(Resources.SystemSecuritySecureString).GetReference(filePath: "System.Security.SecureString.dll", display: "System.Security.SecureString (netstandard20)");
                }
                return _SystemSecuritySecureString;
            }
        }

        private static PortableExecutableReference? _SystemServiceModelWeb;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.ServiceModel.Web.dll
        /// </summary>
        public static PortableExecutableReference SystemServiceModelWeb
        {
            get
            {
                if (_SystemServiceModelWeb is null)
                {
                    _SystemServiceModelWeb = AssemblyMetadata.CreateFromImage(Resources.SystemServiceModelWeb).GetReference(filePath: "System.ServiceModel.Web.dll", display: "System.ServiceModel.Web (netstandard20)");
                }
                return _SystemServiceModelWeb;
            }
        }

        private static PortableExecutableReference? _SystemTextEncoding;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Text.Encoding.dll
        /// </summary>
        public static PortableExecutableReference SystemTextEncoding
        {
            get
            {
                if (_SystemTextEncoding is null)
                {
                    _SystemTextEncoding = AssemblyMetadata.CreateFromImage(Resources.SystemTextEncoding).GetReference(filePath: "System.Text.Encoding.dll", display: "System.Text.Encoding (netstandard20)");
                }
                return _SystemTextEncoding;
            }
        }

        private static PortableExecutableReference? _SystemTextEncodingExtensions;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Text.Encoding.Extensions.dll
        /// </summary>
        public static PortableExecutableReference SystemTextEncodingExtensions
        {
            get
            {
                if (_SystemTextEncodingExtensions is null)
                {
                    _SystemTextEncodingExtensions = AssemblyMetadata.CreateFromImage(Resources.SystemTextEncodingExtensions).GetReference(filePath: "System.Text.Encoding.Extensions.dll", display: "System.Text.Encoding.Extensions (netstandard20)");
                }
                return _SystemTextEncodingExtensions;
            }
        }

        private static PortableExecutableReference? _SystemTextRegularExpressions;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Text.RegularExpressions.dll
        /// </summary>
        public static PortableExecutableReference SystemTextRegularExpressions
        {
            get
            {
                if (_SystemTextRegularExpressions is null)
                {
                    _SystemTextRegularExpressions = AssemblyMetadata.CreateFromImage(Resources.SystemTextRegularExpressions).GetReference(filePath: "System.Text.RegularExpressions.dll", display: "System.Text.RegularExpressions (netstandard20)");
                }
                return _SystemTextRegularExpressions;
            }
        }

        private static PortableExecutableReference? _SystemThreading;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Threading.dll
        /// </summary>
        public static PortableExecutableReference SystemThreading
        {
            get
            {
                if (_SystemThreading is null)
                {
                    _SystemThreading = AssemblyMetadata.CreateFromImage(Resources.SystemThreading).GetReference(filePath: "System.Threading.dll", display: "System.Threading (netstandard20)");
                }
                return _SystemThreading;
            }
        }

        private static PortableExecutableReference? _SystemThreadingOverlapped;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Threading.Overlapped.dll
        /// </summary>
        public static PortableExecutableReference SystemThreadingOverlapped
        {
            get
            {
                if (_SystemThreadingOverlapped is null)
                {
                    _SystemThreadingOverlapped = AssemblyMetadata.CreateFromImage(Resources.SystemThreadingOverlapped).GetReference(filePath: "System.Threading.Overlapped.dll", display: "System.Threading.Overlapped (netstandard20)");
                }
                return _SystemThreadingOverlapped;
            }
        }

        private static PortableExecutableReference? _SystemThreadingTasks;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Threading.Tasks.dll
        /// </summary>
        public static PortableExecutableReference SystemThreadingTasks
        {
            get
            {
                if (_SystemThreadingTasks is null)
                {
                    _SystemThreadingTasks = AssemblyMetadata.CreateFromImage(Resources.SystemThreadingTasks).GetReference(filePath: "System.Threading.Tasks.dll", display: "System.Threading.Tasks (netstandard20)");
                }
                return _SystemThreadingTasks;
            }
        }

        private static PortableExecutableReference? _SystemThreadingTasksParallel;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Threading.Tasks.Parallel.dll
        /// </summary>
        public static PortableExecutableReference SystemThreadingTasksParallel
        {
            get
            {
                if (_SystemThreadingTasksParallel is null)
                {
                    _SystemThreadingTasksParallel = AssemblyMetadata.CreateFromImage(Resources.SystemThreadingTasksParallel).GetReference(filePath: "System.Threading.Tasks.Parallel.dll", display: "System.Threading.Tasks.Parallel (netstandard20)");
                }
                return _SystemThreadingTasksParallel;
            }
        }

        private static PortableExecutableReference? _SystemThreadingThread;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Threading.Thread.dll
        /// </summary>
        public static PortableExecutableReference SystemThreadingThread
        {
            get
            {
                if (_SystemThreadingThread is null)
                {
                    _SystemThreadingThread = AssemblyMetadata.CreateFromImage(Resources.SystemThreadingThread).GetReference(filePath: "System.Threading.Thread.dll", display: "System.Threading.Thread (netstandard20)");
                }
                return _SystemThreadingThread;
            }
        }

        private static PortableExecutableReference? _SystemThreadingThreadPool;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Threading.ThreadPool.dll
        /// </summary>
        public static PortableExecutableReference SystemThreadingThreadPool
        {
            get
            {
                if (_SystemThreadingThreadPool is null)
                {
                    _SystemThreadingThreadPool = AssemblyMetadata.CreateFromImage(Resources.SystemThreadingThreadPool).GetReference(filePath: "System.Threading.ThreadPool.dll", display: "System.Threading.ThreadPool (netstandard20)");
                }
                return _SystemThreadingThreadPool;
            }
        }

        private static PortableExecutableReference? _SystemThreadingTimer;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Threading.Timer.dll
        /// </summary>
        public static PortableExecutableReference SystemThreadingTimer
        {
            get
            {
                if (_SystemThreadingTimer is null)
                {
                    _SystemThreadingTimer = AssemblyMetadata.CreateFromImage(Resources.SystemThreadingTimer).GetReference(filePath: "System.Threading.Timer.dll", display: "System.Threading.Timer (netstandard20)");
                }
                return _SystemThreadingTimer;
            }
        }

        private static PortableExecutableReference? _SystemTransactions;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Transactions.dll
        /// </summary>
        public static PortableExecutableReference SystemTransactions
        {
            get
            {
                if (_SystemTransactions is null)
                {
                    _SystemTransactions = AssemblyMetadata.CreateFromImage(Resources.SystemTransactions).GetReference(filePath: "System.Transactions.dll", display: "System.Transactions (netstandard20)");
                }
                return _SystemTransactions;
            }
        }

        private static PortableExecutableReference? _SystemValueTuple;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.ValueTuple.dll
        /// </summary>
        public static PortableExecutableReference SystemValueTuple
        {
            get
            {
                if (_SystemValueTuple is null)
                {
                    _SystemValueTuple = AssemblyMetadata.CreateFromImage(Resources.SystemValueTuple).GetReference(filePath: "System.ValueTuple.dll", display: "System.ValueTuple (netstandard20)");
                }
                return _SystemValueTuple;
            }
        }

        private static PortableExecutableReference? _SystemWeb;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Web.dll
        /// </summary>
        public static PortableExecutableReference SystemWeb
        {
            get
            {
                if (_SystemWeb is null)
                {
                    _SystemWeb = AssemblyMetadata.CreateFromImage(Resources.SystemWeb).GetReference(filePath: "System.Web.dll", display: "System.Web (netstandard20)");
                }
                return _SystemWeb;
            }
        }

        private static PortableExecutableReference? _SystemWindows;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Windows.dll
        /// </summary>
        public static PortableExecutableReference SystemWindows
        {
            get
            {
                if (_SystemWindows is null)
                {
                    _SystemWindows = AssemblyMetadata.CreateFromImage(Resources.SystemWindows).GetReference(filePath: "System.Windows.dll", display: "System.Windows (netstandard20)");
                }
                return _SystemWindows;
            }
        }

        private static PortableExecutableReference? _SystemXml;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.dll
        /// </summary>
        public static PortableExecutableReference SystemXml
        {
            get
            {
                if (_SystemXml is null)
                {
                    _SystemXml = AssemblyMetadata.CreateFromImage(Resources.SystemXml).GetReference(filePath: "System.Xml.dll", display: "System.Xml (netstandard20)");
                }
                return _SystemXml;
            }
        }

        private static PortableExecutableReference? _SystemXmlLinq;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.Linq.dll
        /// </summary>
        public static PortableExecutableReference SystemXmlLinq
        {
            get
            {
                if (_SystemXmlLinq is null)
                {
                    _SystemXmlLinq = AssemblyMetadata.CreateFromImage(Resources.SystemXmlLinq).GetReference(filePath: "System.Xml.Linq.dll", display: "System.Xml.Linq (netstandard20)");
                }
                return _SystemXmlLinq;
            }
        }

        private static PortableExecutableReference? _SystemXmlReaderWriter;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.ReaderWriter.dll
        /// </summary>
        public static PortableExecutableReference SystemXmlReaderWriter
        {
            get
            {
                if (_SystemXmlReaderWriter is null)
                {
                    _SystemXmlReaderWriter = AssemblyMetadata.CreateFromImage(Resources.SystemXmlReaderWriter).GetReference(filePath: "System.Xml.ReaderWriter.dll", display: "System.Xml.ReaderWriter (netstandard20)");
                }
                return _SystemXmlReaderWriter;
            }
        }

        private static PortableExecutableReference? _SystemXmlSerialization;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.Serialization.dll
        /// </summary>
        public static PortableExecutableReference SystemXmlSerialization
        {
            get
            {
                if (_SystemXmlSerialization is null)
                {
                    _SystemXmlSerialization = AssemblyMetadata.CreateFromImage(Resources.SystemXmlSerialization).GetReference(filePath: "System.Xml.Serialization.dll", display: "System.Xml.Serialization (netstandard20)");
                }
                return _SystemXmlSerialization;
            }
        }

        private static PortableExecutableReference? _SystemXmlXDocument;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.XDocument.dll
        /// </summary>
        public static PortableExecutableReference SystemXmlXDocument
        {
            get
            {
                if (_SystemXmlXDocument is null)
                {
                    _SystemXmlXDocument = AssemblyMetadata.CreateFromImage(Resources.SystemXmlXDocument).GetReference(filePath: "System.Xml.XDocument.dll", display: "System.Xml.XDocument (netstandard20)");
                }
                return _SystemXmlXDocument;
            }
        }

        private static PortableExecutableReference? _SystemXmlXmlDocument;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.XmlDocument.dll
        /// </summary>
        public static PortableExecutableReference SystemXmlXmlDocument
        {
            get
            {
                if (_SystemXmlXmlDocument is null)
                {
                    _SystemXmlXmlDocument = AssemblyMetadata.CreateFromImage(Resources.SystemXmlXmlDocument).GetReference(filePath: "System.Xml.XmlDocument.dll", display: "System.Xml.XmlDocument (netstandard20)");
                }
                return _SystemXmlXmlDocument;
            }
        }

        private static PortableExecutableReference? _SystemXmlXmlSerializer;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.XmlSerializer.dll
        /// </summary>
        public static PortableExecutableReference SystemXmlXmlSerializer
        {
            get
            {
                if (_SystemXmlXmlSerializer is null)
                {
                    _SystemXmlXmlSerializer = AssemblyMetadata.CreateFromImage(Resources.SystemXmlXmlSerializer).GetReference(filePath: "System.Xml.XmlSerializer.dll", display: "System.Xml.XmlSerializer (netstandard20)");
                }
                return _SystemXmlXmlSerializer;
            }
        }

        private static PortableExecutableReference? _SystemXmlXPath;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.XPath.dll
        /// </summary>
        public static PortableExecutableReference SystemXmlXPath
        {
            get
            {
                if (_SystemXmlXPath is null)
                {
                    _SystemXmlXPath = AssemblyMetadata.CreateFromImage(Resources.SystemXmlXPath).GetReference(filePath: "System.Xml.XPath.dll", display: "System.Xml.XPath (netstandard20)");
                }
                return _SystemXmlXPath;
            }
        }

        private static PortableExecutableReference? _SystemXmlXPathXDocument;

        /// <summary>
        /// The <see cref="PortableExecutableReference"/> for System.Xml.XPath.XDocument.dll
        /// </summary>
        public static PortableExecutableReference SystemXmlXPathXDocument
        {
            get
            {
                if (_SystemXmlXPathXDocument is null)
                {
                    _SystemXmlXPathXDocument = AssemblyMetadata.CreateFromImage(Resources.SystemXmlXPathXDocument).GetReference(filePath: "System.Xml.XPath.XDocument.dll", display: "System.Xml.XPath.XDocument (netstandard20)");
                }
                return _SystemXmlXPathXDocument;
            }
        }

        private static ImmutableArray<PortableExecutableReference> _all;
        public static ImmutableArray<PortableExecutableReference> All
        {
            get
            {
                if (_all.IsDefault)
                {
                    _all =
                    [
                        MicrosoftWin32Primitives,
                        mscorlib,
                        netstandard,
                        SystemAppContext,
                        SystemCollectionsConcurrent,
                        SystemCollections,
                        SystemCollectionsNonGeneric,
                        SystemCollectionsSpecialized,
                        SystemComponentModelComposition,
                        SystemComponentModel,
                        SystemComponentModelEventBasedAsync,
                        SystemComponentModelPrimitives,
                        SystemComponentModelTypeConverter,
                        SystemConsole,
                        SystemCore,
                        SystemDataCommon,
                        SystemData,
                        SystemDiagnosticsContracts,
                        SystemDiagnosticsDebug,
                        SystemDiagnosticsFileVersionInfo,
                        SystemDiagnosticsProcess,
                        SystemDiagnosticsStackTrace,
                        SystemDiagnosticsTextWriterTraceListener,
                        SystemDiagnosticsTools,
                        SystemDiagnosticsTraceSource,
                        SystemDiagnosticsTracing,
                        System,
                        SystemDrawing,
                        SystemDrawingPrimitives,
                        SystemDynamicRuntime,
                        SystemGlobalizationCalendars,
                        SystemGlobalization,
                        SystemGlobalizationExtensions,
                        SystemIOCompression,
                        SystemIOCompressionFileSystem,
                        SystemIOCompressionZipFile,
                        SystemIO,
                        SystemIOFileSystem,
                        SystemIOFileSystemDriveInfo,
                        SystemIOFileSystemPrimitives,
                        SystemIOFileSystemWatcher,
                        SystemIOIsolatedStorage,
                        SystemIOMemoryMappedFiles,
                        SystemIOPipes,
                        SystemIOUnmanagedMemoryStream,
                        SystemLinq,
                        SystemLinqExpressions,
                        SystemLinqParallel,
                        SystemLinqQueryable,
                        SystemNet,
                        SystemNetHttp,
                        SystemNetNameResolution,
                        SystemNetNetworkInformation,
                        SystemNetPing,
                        SystemNetPrimitives,
                        SystemNetRequests,
                        SystemNetSecurity,
                        SystemNetSockets,
                        SystemNetWebHeaderCollection,
                        SystemNetWebSocketsClient,
                        SystemNetWebSockets,
                        SystemNumerics,
                        SystemObjectModel,
                        SystemReflection,
                        SystemReflectionExtensions,
                        SystemReflectionPrimitives,
                        SystemResourcesReader,
                        SystemResourcesResourceManager,
                        SystemResourcesWriter,
                        SystemRuntimeCompilerServicesVisualC,
                        SystemRuntime,
                        SystemRuntimeExtensions,
                        SystemRuntimeHandles,
                        SystemRuntimeInteropServices,
                        SystemRuntimeInteropServicesRuntimeInformation,
                        SystemRuntimeNumerics,
                        SystemRuntimeSerialization,
                        SystemRuntimeSerializationFormatters,
                        SystemRuntimeSerializationJson,
                        SystemRuntimeSerializationPrimitives,
                        SystemRuntimeSerializationXml,
                        SystemSecurityClaims,
                        SystemSecurityCryptographyAlgorithms,
                        SystemSecurityCryptographyCsp,
                        SystemSecurityCryptographyEncoding,
                        SystemSecurityCryptographyPrimitives,
                        SystemSecurityCryptographyX509Certificates,
                        SystemSecurityPrincipal,
                        SystemSecuritySecureString,
                        SystemServiceModelWeb,
                        SystemTextEncoding,
                        SystemTextEncodingExtensions,
                        SystemTextRegularExpressions,
                        SystemThreading,
                        SystemThreadingOverlapped,
                        SystemThreadingTasks,
                        SystemThreadingTasksParallel,
                        SystemThreadingThread,
                        SystemThreadingThreadPool,
                        SystemThreadingTimer,
                        SystemTransactions,
                        SystemValueTuple,
                        SystemWeb,
                        SystemWindows,
                        SystemXml,
                        SystemXmlLinq,
                        SystemXmlReaderWriter,
                        SystemXmlSerialization,
                        SystemXmlXDocument,
                        SystemXmlXmlDocument,
                        SystemXmlXmlSerializer,
                        SystemXmlXPath,
                        SystemXmlXPathXDocument,
                    ];
                }
                return _all;
            }
        }
    }
}

#if !BASIC_REFERENCE_ASSEMBLIES_COMBINED
    public static partial class NetStandard20
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
#endif
