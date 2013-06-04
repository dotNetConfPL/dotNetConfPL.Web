Set-ExecutionPolicy Bypass
Import-Module .\Scripts\psake.psm1
Invoke-psake .\deploy.ps1 -parameters @{"userName"="$($args[0])";"password"="$($args[1])";"ftpAddress"="$($args[2])"}