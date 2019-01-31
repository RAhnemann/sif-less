param (
    [switch]$Uninstall,
	[switch]$ForcePreReqCheck,
	[switch]$SkipValidation,
	[switch]$ValidateOnly
);


$start = Get-Date

#Requires -Version 5.1
#Requires -RunAsAdministrator


if($SkipValidation -and $ValidateOnly){
	Write-Host "What?"
	Exit
}
#Let's check if we have SIF installed...might be an older version..might not be.
if (Get-Module -Name SitecoreInstallFramework) {
  Write-Host "Removing SIF" 
  Remove-Module SitecoreInstallFramework
}

Write-Host "Loading SIF 2.0"
Import-Module SitecoreInstallFramework -RequiredVersion 2.0.0

[GLOBAL]

if($uninstall)
{
	function RemoveService([string]$serviceName){
    $service = Get-Service $serviceName -ErrorAction SilentlyContinue
    
    if($service){
      Write-Host "Removing Service '$serviceName'"
      if($service.Status -ne "Stopped"){
        Write-Host "Stopping Service '$serviceName'"
          Stop-Service $serviceName
      }
    
      sc.exe delete $serviceName #in Powershell 6, this will be nicer...
      Write-Host "Removed Service '$serviceName'"
    }
    else {
      Write-Host "Service not found '$serviceName'"
    } 
  }

  function RemoveSolrCores(){
    $client = (New-Object System.Net.WebClient)
    $cores = $client.DownloadString("$SolrUrl/admin/cores") | ConvertFrom-Json | Select -expand Status | foreach{ $_.psobject.properties.name}
    $success = 0
    $error = 0
    
    foreach ($core in $cores) {
      if ($core.StartsWith("${prefix}_")) {
        $url = "$SolrUrl/admin/cores?action=UNLOAD&deleteIndex=true&deleteInstanceDir=true&core=$core"
        Write-Host "Deleting Core: '$core'"
        $client.DownloadString($url)
        if ($?) {$success++}
        else{ $error++}
      }
    }
    write-host "Deleted $success cores.  Had $error errors."
  }

  function RemoveDatabase([string]$dbName){
    Write-Host "Removing Database '$dbName'"
    Invoke-SQLCmd -ServerInstance $SqlServer -U $SqlAdminUser -P $SqlAdminPassword -Query "IF EXISTS(SELECT * FROM sys.databases WHERe NAME = '${prefix}_$dbName') BEGIN ALTER DATABASE [${prefix}_$dbName] SET SINGLE_USER WITH ROllBACK IMMEDIATE; DROP DATABASE [${prefix}_$dbName];END"
  }

  function RemoveWebsite([string]$site){
    Write-Host "Removing Site '$site'"
    $webSite = Get-Website -Name $site -ErrorAction SilentlyContinue
    $sitePath = $webSite.PhysicalPath
    if($webSite){
      Stop-Website -Name $site
     
      Remove-Website -Name $site

      Write-Host "Removing Application Pool '$site'"
      Remove-WebAppPool -Name $site 
    }
    else {
      Write-Host "Site not found '$site'"
    }
  }

	
  function RemoveFolder([string]$path){
	  if(Test-Path -Path $path){
		   Write-Host "Removing Folder '$path'"
			&cmd.exe /c rd /s /q $path
	  }
	  else{
		  Write-Host "Folder not found: '$path'"
	  }
   

    if(Test-Path -Path $path)      {
      Write-Error "Failed to delete site folder '$path'"
  }

  }


	[UNINSTALL]
}
else
{
	function ValidateSystem()
	{
		[VALIDATE]
		Write-Host "Validation Complete! Yay!" -ForegroundColor Green
	}

	if($ForcePreReqCheck){
		Install-SitecoreConfiguration -Path "$SCInstallRoot\Prerequisites.json"
	}

	if(!$SkipValidation){
		ValidateSystem
	}
	if(!$Validateonly){
		[INSTALL]
	}
}


$timeSpan = New-TimeSpan -Start $start -End (Get-Date)

Write-Host ("SIF-less completed in {0:HH:mm:ss}" -f ([datetime]$timeSpan.Ticks))