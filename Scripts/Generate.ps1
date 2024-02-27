function Get-GeneratedContentCore($name, $realPackagePath, $realPackagePrefix, $targetsPrefix, [string]$excludePattern)
{
  $targetsContent = @"
<Project>
    <ItemGroup>

"@;

  $codeContent = @"
// This is a generated file, please edit Generate.ps1 to change the contents

using System;
using System.Collections.Generic;
using System.Linq;
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
        public static class References
        {

"@

  $refInfoContent = @"
    public static partial class $name
    {
        public static class ReferenceInfos
        {

"@

  $lowerName = $name.ToLower()
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

    $mvid = Get-Mvid $dllPath
    $dll = $dllName.Substring(0, $dllName.Length - 4)
    $logicalName = "$($lowerName).$($dll)";
    $dllPath = $dllPath.Substring($realPackagePrefix.Length)
    $dllPath = $targetsPrefix + $dllPath

    $targetsContent += @"
        <EmbeddedResource Include="$dllPath" WithCulture="false">
          <LogicalName>$logicalName</LogicalName>
          <Link>Resources\$lowerName\$dllName</Link>
        </EmbeddedResource>

"@

    $propName = $dll.Replace(".", "");
    $allPropNames += $propName
    $fieldName = "_" + $propName
    $codeContent += @"
            private static byte[]? $fieldName;
            public static byte[] $propName => ResourceLoader.GetOrCreateResource(ref $fieldName, "$logicalName");

"@

    $refInfoContent += @"
            public static ReferenceInfo $propName => new ReferenceInfo("$dllName", Resources.$($propName), $name.References.$propName, global::System.Guid.Parse("$mvid"));

"@

    $metadataContent += @"
            private static PortableExecutableReference? $fieldName;
            public static PortableExecutableReference $propName
            {
                get
                {
                    if ($fieldName == null)
                    {
                        $fieldName = AssemblyMetadata.CreateFromImage(Resources.$($propName)).GetReference(filePath: "$dllName", display: "$dll ($lowerName)");
                    }
                    return $fieldName;
                }
            }


"@

  }

  $refInfoContent += @"
            private static ReferenceInfo[]? _all;
            public static IEnumerable<ReferenceInfo> All
            {
                get
                {
                    if (_all == null)
                    {
                        _all = new[]
                        {

"@

  $metadataContent += @"
            private static PortableExecutableReference[]? _all;
            public static IEnumerable<PortableExecutableReference> All
            {
                get
                {
                    if (_all == null)
                    {
                        _all = new PortableExecutableReference[]
                        {

"@;
    foreach ($propName in $allPropNames)
    {
      $refInfoContent += @"
                            $propName,

"@

      $metadataContent += @"
                            $propName,

"@
    }

    $metadataContent += @"
                        };
                    }
                    return _all;
                }
            }
        }
    }
"@
    $refInfoContent += @"
                        };
                    }
                    return _all;
                }
            }

            public static IEnumerable<(string FileName, byte[] ImageBytes, PortableExecutableReference Reference, Guid Mvid)> AllValues => All.Select(x => x.AsTuple());
        }
    }

"@
    $codeContent += @"

        }
    }

"@
    $codeContent += $refInfoContent;
    $codeContent += $metadataContent;
    $codeContent += (Get-ReferenceInfo $name)

  $targetsContent += @"
    </ItemGroup>
  </Project>
"@;

  $codeContent += @"

}
"@

  return @{ CodeContent = $codeContent; TargetsContent = $targetsContent}
}

function Get-ReferenceInfo($containingType)
{
  function Get-CodeLines($containingType)
  {
    $lines = Get-Content (Join-Path $combinedDir "ReferenceInfo.cs")
    $i = 0;
    $state = 0;

    Write-Output "#if !BASIC_REFERENCE_ASSEMBLIES_COMBINED"
    while ($i -lt $lines.Length)
    {
      $current = $lines[$i]
      if ($state -eq 0)
      {
        if ($current.StartsWith("namespace"))
        {
          Write-Output "    public static partial class $containingType"
          Write-Output "    {"
          $state = 1
          $i += 1
        }
      }
      elseif ($state -eq 1)
      {
        Write-Output "    $current"
        if ($current -eq "}")
        {
          $state = 2
        }
      }

      $i += 1
    }

    Write-Output "#endif"
  }

  $lines = Get-CodeLines $containingType
  return "`r`n" + ($lines -join "`r`n")
}

function Get-Mvid($dllPath)
{
  $stream = [IO.File]::OpenRead($dllPath)
  $peReader = New-Object -Type System.Reflection.PortableExecutable.PEReader -ArgumentList $stream
  $metadataReader = [Reflection.Metadata.PEReaderExtensions]::GetMetadataReader($peReader)
  $mvidHandle = $metadataReader.GetModuleDefinition().Mvid;
  $mvid = $metadataReader.GetGuid($mvidHandle)
  return $mvid.ToString()
}

function Get-GeneratedContent($name, $packagePath, [string]$excludePattern)
{
  [string]$nugetPackageRoot = $env:NUGET_PACKAGES
  if ($nugetPackageRoot -eq "")
  {
    $nugetPackageRoot = Join-Path $env:USERPROFILE ".nuget\packages"
  }

  $realPackagePath = Join-Path $nugetPackageRoot $packagePath
  return Get-GeneratedContentCore $name $realPackagePath $nugetPackageRoot '$(NuGetPackageRoot)' $excludePattern
}

function Get-ResourceContent($name, $resourcePath)
{
  $realPackagePrefix = Split-Path -Parent $PSScriptRoot
  $realPackagePath = Join-Path $realPackagePrefix $resourcePath
  return Get-GeneratedContentCore $name $realPackagePath $realPackagePrefix '$(MSBuildThisFileDirectory)..\'
}

$combinedDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies"

# NetCoreApp31
$map = Get-GeneratedContent "NetCoreApp31" 'microsoft.netcore.app.ref\3.1.0\ref\netcoreapp3.1'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.NetCoreApp31"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8

# Net50
$map = Get-GeneratedContent "Net50" 'microsoft.netcore.app.ref\5.0.0\ref\net5.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net50"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8

# Net60
$map = Get-GeneratedContent "Net60" 'microsoft.netcore.app.ref\6.0.9\ref\net6.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net60"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8

# Net60Windows
$map = Get-GeneratedContent "Net60Windows" 'microsoft.windowsdesktop.app.ref\6.0.9\ref\net6.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net60Windows"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8

# Net70
$map = Get-GeneratedContent "Net70" 'microsoft.netcore.app.ref\7.0.0-rc.1.22426.10\ref\net7.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net70"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8

# Net80
$map = Get-GeneratedContent "Net80" 'microsoft.netcore.app.ref\8.0.2\ref\net8.0'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net80"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.Net80.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.Net80.targets") -Encoding Utf8

# NetStandard1.3
$map = Get-ResourceContent "NetStandard13" "Resources\netstandard1.3"
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.NetStandard13"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8

# NetStandard2.0
$map = Get-GeneratedContent "NetStandard20" 'netstandard.library\2.0.3\build\netstandard2.0\ref'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.NetStandard20"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.NetStandard20.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.NetStandard20.targets") -Encoding Utf8

# Net461
$map = Get-GeneratedContent "Net461" 'microsoft.netframework.referenceassemblies.net461\1.0.2\build\.NETFramework\v4.6.1' 'System\.Enterprise.*'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net461"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8

# Net472
$map = Get-GeneratedContent "Net472" 'microsoft.netframework.referenceassemblies.net472\1.0.0\build\.NETFramework\v4.7.2' 'System\.Enterprise.*'
$targetDir = Join-Path $PSScriptRoot "..\Basic.Reference.Assemblies.Net472"
$map.CodeContent | Out-File (Join-Path $targetDir "Generated.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $targetDir "Generated.targets") -Encoding Utf8
$map.CodeContent | Out-File (Join-Path $combinedDir "Generated.Net472.cs") -Encoding Utf8
$map.TargetsContent | Out-File (Join-Path $combinedDir "Generated.Net472.targets") -Encoding Utf8
