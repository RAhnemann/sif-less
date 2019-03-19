param (
	[Parameter(HelpMessage="Run the script in Uninstall Mode. May be run multiple times.")]
    [switch]$Uninstall,
	[Parameter(HelpMessage="Enforce the Prereq check. Can take some time!")]
	[switch]$ForcePreReqCheck,
	[Parameter(HelpMessage="Bypass all valiation checks. May lead to failed installs. You've been warned!")]
	[switch]$SkipValidation,
	[Parameter(HelpMessage="Only perform validation. Useful for a sanity check.")]
	[switch]$ValidateOnly
);


$start = Get-Date

#Requires -Version 5.1
#Requires -RunAsAdministrator


if($SkipValidation -and $ValidateOnly){
	Write-Error "What?"
	Exit
}
#Let's check if we have SIF installed...might be an older version..might not be.
if (Get-Module -Name SitecoreInstallFramework) {
  Write-Information "Removing SIF" 
  Remove-Module SitecoreInstallFramework
}

Write-Information "Loading SIF 2.0"
Import-Module SitecoreInstallFramework -RequiredVersion 2.0.0

[GLOBAL]

if($uninstall)
{
	function RemoveService([string]$serviceName){
    $service = Get-Service $serviceName -ErrorAction SilentlyContinue
    
    if($service){
      Write-Information "Removing Service '$serviceName'"
      if($service.Status -ne "Stopped"){
        Write-Information "Stopping Service '$serviceName'"
          Stop-Service $serviceName
      }
    
      sc.exe delete $serviceName #in Powershell 6, this will be nicer...
      Write-Information "Removed Service '$serviceName'"
    }
    else {
      Write-Information "Service not found '$serviceName'"
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
        Write-Information "Deleting Core: '$core'"
        $client.DownloadString($url)
        if ($?) {$success++}
        else{ $error++}
      }
    }
    Write-Information "Deleted $success cores.  Had $error errors."
  }

  function RemoveDatabase([string]$dbName){
    Write-Information "Removing Database '$dbName'"
    Invoke-SQLCmd -ServerInstance $SqlServer -U $SqlAdminUser -P $SqlAdminPassword -Query "IF EXISTS(SELECT * FROM sys.databases WHERe NAME = '${prefix}_$dbName') BEGIN ALTER DATABASE [${prefix}_$dbName] SET SINGLE_USER WITH ROllBACK IMMEDIATE; DROP DATABASE [${prefix}_$dbName];END"
  }

  function RemoveWebsite([string]$site){
    Write-Information "Removing Site '$site'"
    $webSite = Get-Website -Name $site -ErrorAction SilentlyContinue
    $sitePath = $webSite.PhysicalPath
    if($webSite){
      Stop-Website -Name $site
     
      Remove-Website -Name $site

      Write-Information "Removing Application Pool '$site'"
      Remove-WebAppPool -Name $site 
    }
    else {
      Write-Information "Site not found '$site'"
    }
  }

	
  function RemoveFolder([string]$path){
	  if(Test-Path -Path $path){
		   Write-Information "Removing Folder '$path'"
			&cmd.exe /c rd /s /q $path
	  }
	  else{
		  Write-Information "Folder not found: '$path'"
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
		Write-Information "Validation Complete! Yay!" -ForegroundColor Green
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

Write-Information ("SIF-less completed in {0:HH:mm:ss}" -f ([datetime]$timeSpan.Ticks))