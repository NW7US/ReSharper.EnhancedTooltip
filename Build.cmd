del /Q Deploy
del /Q bin
"%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" Build.targets
mkdir Deploy\9.1
packages\NuGet.CommandLine.2.8.6\tools\NuGet.exe pack GammaJul.ReSharper.EnhancedTooltip\GammaJul.ReSharper.EnhancedTooltip.9.1.nuspec -NoPackageAnalysis -OutputDirectory Deploy\9.1
