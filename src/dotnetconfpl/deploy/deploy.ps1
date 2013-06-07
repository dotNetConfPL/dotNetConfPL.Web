Properties {
	$build_dir = Split-Path $psake.build_script_file
	$sln_dir =  "$build_dir\..\"
    $build_artifacts_dir = "$sln_dir\DeployPackage\"
    $package_dir = [System.IO.Path]::GetFullPath("$sln_dir\DeployPackage\_PublishedWebsites\dotnetconfpl\")
}

Task Default -depends Deploy

Task Deploy -depends Build { 
    try{
			$ftp = "ftp://$userName"+":"+"$password@$ftpAddress/";
	
            "option batch abort
            option confirm off

            open $ftp           
            synchronize remote $package_dir /dotnetconf.pl/wwwroot/
            exit " | winscp -i
    }
    catch [Exception]{
        Write-Host $_.Exception.ToString()
    }
}

Task Build {
	Write-Host "Building dotnetconf.pl sln" -ForegroundColor Green
	Exec { msbuild "$sln_dir\dotnetconfpl.sln" /t:Build /p:Configuration=Release /v:quiet /p:OutDir=$build_artifacts_dir } 
}