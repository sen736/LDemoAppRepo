#
# Script1.ps1
#
$proj = “.\LDemoApp.csproj”

$azure = “.\Properties\PublishProfiles\LDemoApp - Web Deploy.pubxml”

$pwd = iPTBcTgvqbfwYz6vcbS1w6d8psd3KWftrEDRJegR2lY9P138u4e1R7nkd0RW”

C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe $proj /p:DeployOnBuild=true /p:PublishProfile=$azure /p:VisualStudioVersion=11.0 /p:Password=$pwd /p:AllowUntrustedCertificate=true