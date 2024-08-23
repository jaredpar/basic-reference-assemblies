Net Standard 1.3
===

The majority of target frameworks have a NuPkg file that contains all of the ref
assemblies. The exception is `netstandard1.3` which is just a collection of individual
references that make up a reference set. For example here is the output of a 
`netstandard1.3` build on my local machine

```
.nuget\packages\microsoft.win32.primitives\4.3.0\ref\netstandard1.3\Microsoft.Win32.Primitives.dll
.nuget\packages\system.appcontext\4.3.0\ref\netstandard1.3\System.AppContext.dll
.nuget\packages\system.collections.concurrent\4.3.0\ref\netstandard1.3\System.Collections.Concurrent.dll
.nuget\packages\system.collections\4.3.0\ref\netstandard1.3\System.Collections.dll
.nuget\packages\system.console\4.3.0\ref\netstandard1.3\System.Console.dll
.nuget\packages\system.diagnostics.debug\4.3.0\ref\netstandard1.3\System.Diagnostics.Debug.dll
.nuget\packages\system.diagnostics.fileversioninfo\4.3.0\ref\netstandard1.3\System.Diagnostics.FileVersionInfo.dll
.nuget\packages\system.diagnostics.process\4.3.0\ref\netstandard1.3\System.Diagnostics.Process.dll
.nuget\packages\system.diagnostics.tools\4.3.0\ref\netstandard1.0\System.Diagnostics.Tools.dll
.nuget\packages\system.diagnostics.tracing\4.3.0\ref\netstandard1.3\System.Diagnostics.Tracing.dll
.nuget\packages\system.globalization.calendars\4.3.0\ref\netstandard1.3\System.Globalization.Calendars.dll
.nuget\packages\system.globalization\4.3.0\ref\netstandard1.3\System.Globalization.dll
.nuget\packages\system.io.compression\4.3.0\ref\netstandard1.3\System.IO.Compression.dll
.nuget\packages\system.io.compression.zipfile\4.3.0\ref\netstandard1.3\System.IO.Compression.ZipFile.dll
.nuget\packages\system.io\4.3.0\ref\netstandard1.3\System.IO.dll
.nuget\packages\system.io.filesystem\4.3.0\ref\netstandard1.3\System.IO.FileSystem.dll
.nuget\packages\system.io.filesystem.primitives\4.3.0\ref\netstandard1.3\System.IO.FileSystem.Primitives.dll
.nuget\packages\system.linq\4.3.0\ref\netstandard1.0\System.Linq.dll
.nuget\packages\system.linq.expressions\4.3.0\ref\netstandard1.3\System.Linq.Expressions.dll
.nuget\packages\system.net.http\4.3.0\ref\netstandard1.3\System.Net.Http.dll
.nuget\packages\system.net.primitives\4.3.0\ref\netstandard1.3\System.Net.Primitives.dll
.nuget\packages\system.net.security\4.3.0\ref\netstandard1.3\System.Net.Security.dll
.nuget\packages\system.net.sockets\4.3.0\ref\netstandard1.3\System.Net.Sockets.dll
.nuget\packages\system.objectmodel\4.3.0\ref\netstandard1.3\System.ObjectModel.dll
.nuget\packages\system.reflection\4.3.0\ref\netstandard1.3\System.Reflection.dll
.nuget\packages\system.reflection.extensions\4.3.0\ref\netstandard1.0\System.Reflection.Extensions.dll
.nuget\packages\system.reflection.primitives\4.3.0\ref\netstandard1.0\System.Reflection.Primitives.dll
.nuget\packages\system.resources.resourcemanager\4.3.0\ref\netstandard1.0\System.Resources.ResourceManager.dll
.nuget\packages\system.runtime\4.3.0\ref\netstandard1.3\System.Runtime.dll
.nuget\packages\system.runtime.extensions\4.3.0\ref\netstandard1.3\System.Runtime.Extensions.dll
.nuget\packages\system.runtime.handles\4.3.0\ref\netstandard1.3\System.Runtime.Handles.dll
.nuget\packages\system.runtime.interopservices\4.3.0\ref\netstandard1.3\System.Runtime.InteropServices.dll
.nuget\packages\system.runtime.interopservices.runtimeinformation\4.3.0\ref\netstandard1.1\System.Runtime.InteropServices.RuntimeInformation.dll
.nuget\packages\system.runtime.numerics\4.3.0\ref\netstandard1.1\System.Runtime.Numerics.dll
.nuget\packages\system.runtime.serialization.primitives\4.3.0\ref\netstandard1.3\System.Runtime.Serialization.Primitives.dll
.nuget\packages\system.security.accesscontrol\4.3.0\ref\netstandard1.3\System.Security.AccessControl.dll
.nuget\packages\system.security.claims\4.3.0\ref\netstandard1.3\System.Security.Claims.dll
.nuget\packages\system.security.cryptography.algorithms\4.3.0\ref\netstandard1.3\System.Security.Cryptography.Algorithms.dll
.nuget\packages\system.security.cryptography.csp\4.3.0\ref\netstandard1.3\System.Security.Cryptography.Csp.dll
.nuget\packages\system.security.cryptography.encoding\4.3.0\ref\netstandard1.3\System.Security.Cryptography.Encoding.dll
.nuget\packages\system.security.cryptography.primitives\4.3.0\ref\netstandard1.3\System.Security.Cryptography.Primitives.dll
.nuget\packages\system.security.cryptography.x509certificates\4.3.0\ref\netstandard1.3\System.Security.Cryptography.X509Certificates.dll
.nuget\packages\system.security.principal\4.3.0\ref\netstandard1.0\System.Security.Principal.dll
.nuget\packages\system.security.principal.windows\4.3.0\ref\netstandard1.3\System.Security.Principal.Windows.dll
.nuget\packages\system.text.encoding.codepages\4.3.0\ref\netstandard1.3\System.Text.Encoding.CodePages.dll
.nuget\packages\system.text.encoding\4.3.0\ref\netstandard1.3\System.Text.Encoding.dll
.nuget\packages\system.text.encoding.extensions\4.3.0\ref\netstandard1.3\System.Text.Encoding.Extensions.dll
.nuget\packages\system.text.regularexpressions\4.3.0\ref\netstandard1.3\System.Text.RegularExpressions.dll
.nuget\packages\system.threading\4.3.0\ref\netstandard1.3\System.Threading.dll
.nuget\packages\system.threading.tasks\4.3.0\ref\netstandard1.3\System.Threading.Tasks.dll
.nuget\packages\system.threading.tasks.extensions\4.3.0\lib\netstandard1.0\System.Threading.Tasks.Extensions.dll
.nuget\packages\system.threading.timer\4.3.0\ref\netstandard1.2\System.Threading.Timer.dll
.nuget\packages\system.valuetuple\4.5.0\lib\netstandard1.0\System.ValueTuple.dll
.nuget\packages\system.xml.readerwriter\4.3.0\ref\netstandard1.3\System.Xml.ReaderWriter.dll
.nuget\packages\system.xml.xdocument\4.3.0\ref\netstandard1.3\System.Xml.XDocument.dll
.nuget\packages\system.xml.xmldocument\4.3.0\ref\netstandard1.3\System.Xml.XmlDocument.dll
.nuget\packages\system.xml.xpath\4.3.0\ref\netstandard1.3\System.Xml.XPath.dll
.nuget\packages\system.xml.xpath.xdocument\4.3.0\ref\netstandard1.3\System.Xml.XPath.XDocument.dll

```

The project file used to generate this list is the following:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netstandard1.3</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="System.Runtime.Serialization.Primitives" Version="4.3.0" />
    <PackageReference Include="System.Text.Encoding.CodePages" Version="4.3.0" />
    <PackageReference Include="System.Xml.XPath" Version="4.3.0" />
    <PackageReference Include="System.Xml.XmlDocument" Version="4.3.0" />
    <PackageReference Include="System.Xml.XPath.XDocument" Version="4.3.0" />
    <PackageReference Include="System.Xml.ReaderWriter" Version="4.3.0" />
    <PackageReference Include="System.Security.AccessControl" Version="4.3.0" />
    <PackageReference Include="System.ValueTuple" Version="4.5.0" />
    <PackageReference Include="System.Diagnostics.FileVersionInfo" Version="4.3.0" />
    <PackageReference Include="System.Diagnostics.Process" Version="4.3.0" />
    <PackageReference Include="System.Security.Cryptography.Csp" Version="4.3.0" />
    <PackageReference Include="System.Threading.Tasks.Extensions" Version="4.3.0" />
    <PackageReference Include="System.Net.Security" Version="4.3.0" />
  </ItemGroup>

</Project>
```

To make `netstandard1.3` better fit in with the infrastructure in this repository
I just copied the above set into flat list here and that will be used in our 
generation scripts
