Properties {
	$build_dir = Split-Path $psake.build_script_file
	$sln_dir = "$build_dir\..\"
    $build_artifacts_dir = "$sln_dir\DeployPackage\"
}

Task Default -depends Deploy

Task Deploy -depends Build {
   "Deploy"
}

Task Build {
	Write-Host "Building dotnetconf.pl sln" -ForegroundColor Green
	Exec { msbuild "$sln_dir\dotnetconfpl.sln" /t:Build /p:Configuration=Release /v:quiet /p:OutDir=$build_artifacts_dir } 
}