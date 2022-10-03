function Get-ContentCore($name, $realPackagePath, $realPackagePrefix, $targetsPrefix, [string]$excludePattern)
{
  $targetsContent = @"
<Project>
    <ItemGroup>

"@;

  $codeContent = @"
// This is a generated file, please edit Generate.ps1 to change the contents

using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Basic.Reference.Assemblies
{

"@;

  $codeContent += @"
    public static partial class $name
    {
        public static class Resources
        {

"@;

  $metadataContent = @"
    public static partial class $name
    {

"@

  $refContent = @"
    public static partial class $name
    {
        public readonly struct ReferenceInfo
        {
            public string FileName { get; }
            public byte[] ImageBytes { get; }
            public ReferenceInfo(string fileName, byte[] imageBytes)
            {
                FileName = fileName;
                ImageBytes = imageBytes;
            }
        }

        public static class References
        {

"@

  $name = $name.ToLower()
  $list = @(Get-ChildItem -filter *.dll $realPackagePath | %{ $_.FullName })
  $facadesPath = Join-Path $realPackagePath "Facades"
  if (Test-Path $facadesPath) {
    $list += @(Get-ChildItem -filter *.dll $facadesPath | %{ $_.FullName })
  }

  $allPropNames = @()
  foreach ($dllPath in $list)
  {
    $dllName= Split-Path -Leaf $dllPath
    if ($excludePattern -ne "" -and $dllName -match $excludePattern)
    {
      continue
    }

    $dll = $dllName.Substring(0, $dllName.Length - 4)
    $logicalName = "$($name).$($dll)";
    $dllPath = $dllPath.Substring($realPackagePrefix.Length)
    $dllPath = $targetsPrefix + $dllPath

    $targetsContent += @"
        <EmbeddedResource Include="$dllPath">
          <LogicalName>$logicalName</LogicalName>
          <Link>Resources\$name\$dllName</Link>
        </EmbeddedResource>

"@

    $propName = $dll.Replace(".", "");
    $allPropNames += $propName
    $fieldName = "_" + $propName
    $codeContent += @"
            private static byte[]? $fieldName;
            public static byte[] $propName => ResourceLoader.GetOrCreateResource(ref $fieldName, "$logicalName");

"@

    $refContent += @"
            public static ReferenceInfo $propName => new ReferenceInfo("$dllName", Resources.$($propName));

"@

    $metadataContent += @"
        public static PortableExecutableReference $propName { get; } = AssemblyMetadata.CreateFromImage(Resources.$($propName)).GetReference(filePath: "$dllName", display: "$dll ($name)");

"@

  }

  $refContent += @"
            public static IEnumerable<ReferenceInfo> All { get; }= new []
            {

"@

  $metadataContent += @"
        public static IEnumerable<PortableExecutableReference> All { get; }= new PortableExecutableReference[]
        {

"@;
    foreach ($propName in $allPropNames)
    {
      $refContent += @"
                $propName,

"@

      $metadataContent += @"
            $propName,

"@
    }

    $metadataContent += @"
        };
    }

"@
    $refContent += @"
            };
        }
    }

"@

    $codeContent += @"
        }
    }

"@
    $codeContent += $refContent;
    $codeContent += $metadataContent;

  $targetsContent += @"
    </ItemGroup>
  </Project>
"@;

  $codeContent += @"
}
"@

  return @{ CodeContent = $codeContent; TargetsContent = $targetsContent}
}

function Get-Content($name, $packagePath, [string]$excludePattern)
{
  [string]$nugetPackageRoot = $env:NUGET_PACKAGES
  if ($nugetPackageRoot -eq "")
  {
    $nugetPackageRoot = Join-Path $env:USERPROFILE ".nuget\packages"
  }

  $realPackagePath = Join-Path $nugetPackageRoot $packagePath 
  return Get-ContentCore $name $realPackagePath $nugetPackageRoot '$(NuGetPackageRoot)' $excludePattern
}

function Get-ResourceContent($name, $resourcePath)
{
  $realPackagePrefix = Split-Path -Parent $PSScriptRoot
  $realPackagePath = Join-Path $realPackagePrefix $resourcePath
  return Get-ContentCore $name $realPackagePath $realPackagePrefix '$(MSBuildThisFileDirectory)..\' 
}

$combinedDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies"

# NetCoreApp31 
$map = Get-Content "NetCoreApp31" 'microsoft.netcore.app.ref\3.1.0\ref\netcoreapp3.1' 
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.NetCoreApp31"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.NetCoreApp31.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.NetCoreApp31.targets") -Encoding Utf8

# Net50
$map = Get-Content "Net50" 'microsoft.netcore.app.ref\5.0.0\ref\net5.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net50"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.Net50.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.Net50.targets") -Encoding Utf8

# Net60
$map = Get-Content "Net60" 'microsoft.netcore.app.ref\6.0.9\ref\net6.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net60"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.Net60.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.Net60.targets") -Encoding Utf8

# Net70
$map = Get-Content "Net70" 'microsoft.netcore.app.ref\7.0.0-rc.2.22469.6\ref\net7.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net70"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.Net70.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.Net70.targets") -Encoding Utf8

# NetStandardl.3
$map = Get-ResourceContent "NetStandard13" "Resources\netstandard1.3"
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.NetStandard13"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.NetStandard13.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.NetStandard13.targets") -Encoding Utf8

# NetStandard2.0
$map = Get-Content "NetStandard20" 'netstandard.library\2.0.3\build\netstandard2.0\ref'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.NetStandard20"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.NetStandard20.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.NetStandard20.targets") -Encoding Utf8

# Net461
$map = Get-Content "Net461" 'microsoft.netframework.referenceassemblies.net461\1.0.2\build\.NETFramework\v4.6.1' 'System\.Enterprise.*'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net461"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.Net461.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.Net461.targets") -Encoding Utf8

# Net472
$map = Get-Content "Net472" 'microsoft.netframework.referenceassemblies.net472\1.0.0\build\.NETFramework\v4.7.2' 'System\.Enterprise.*'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net472"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.Net472.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.Net472.targets") -Encoding Utf8
