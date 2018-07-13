param (
    [switch]$uninstall
);


$start = Get-Date

#Requires -Version 5.1
#Requires -RunAsAdministrator
#Requires -Modules SitecoreInstallFramework
#Requires -Modules SitecoreFundamentals


Import-Module SitecoreInstallFramework
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
    [xml]$coresXML = $client.DownloadString("$SolrUrl/admin/cores")
    $cores = $coresXML.response.lst[2].lst | % {$_.name}
    $success = 0
    $error = 0
    
    foreach ($core in $cores) {
      if ($core.StartsWith($prefix)) {
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
	[INSTALL]
}


$timeSpan = New-TimeSpan -Start $start -End (Get-Date)

Write-Host ("SIF-less completed in {0:HH:mm:ss}" -f ([datetime]$timeSpan.Ticks))