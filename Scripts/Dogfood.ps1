Push-Location (Join-Path $PSScriptRoot "..")
try {

  & dotnet pack /p:Version=0.1.0-dogfood
  Create-Directory Dogfood
  Get-ChildItem -Re -In *.nupkg Basic.* | %{ Copy-Item -Force $_ Dogfood }
}
finally {
  Pop-Location
}
