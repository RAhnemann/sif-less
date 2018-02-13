Import-Module SitecoreInstallFramework
$prefix = "[SC_PREFIX]"
$PSScriptRoot = "[SCRIPT_ROOT]"
$XConnectCollectionService = "[XCONNECT_NAME]"
$SitecoreSiteName = "[SITE_NAME]"
$SolrUrl = "[SOLR_URL]"
$SolrRoot = "[SOLR_FOLDER]"
$SqlServer = "[SQL_SERVER]"
$SqlAdminUser = "[SQL_USER]"
$SqlAdminPassword="[SQL_PASSWORD]"

#install client certificate for xconnect
#$certParams = @{
#Path = "$PSScriptRoot\xconnect-createcert.json"
#CertificateName = "$prefix.xconnect_client"
#}
#Install-SitecoreConfiguration @certParams -Verbose
#install solr cores for xdb

$solrParams = @{
Path = "$PSScriptRoot\remove-xconnect-solr-cores.json"
SolrUrl = $SolrUrl
SolrRoot = $SolrRoot
CorePrefix = $prefix
}
try{
	Install-SitecoreConfiguration @solrParams
}
catch{
	$error = $_.Exception
	
	#If we are failing because it has already been unloaded, then we can proceed
	if($error.Message.Contains("Cannot unload non-existent core")){
		Write-Warning -Message ("Core is not found. May have already been uninstalled. Proceeding to folders." | Out-String)
	}
	else{
		throw $error;
	}
}

$solrParams = @{
Path = "$PSScriptRoot\remove-xconnect-solr-folders.json"
SolrUrl = $SolrUrl
SolrRoot = $SolrRoot
CorePrefix = $prefix
}
Install-SitecoreConfiguration @solrParams

#remove xconnect instance
$xconnectParams = @{
Path = "$PSScriptRoot\remove-xconnect-xp0.json"
SiteName = $XConnectCollectionService
SqlDbPrefix = $prefix
SqlServer = $SqlServer
SqlAdminUser = $SqlAdminUser
SqlAdminPassword = $SqlAdminPassword
}

Install-SitecoreConfiguration @xconnectParams

#remove solr cores for sitecore
$solrParams = @{
Path = "$PSScriptRoot\remove-sitecore-solr-cores.json"
SolrUrl = $SolrUrl
SolrRoot = $SolrRoot
CorePrefix = $prefix
}
try{
	Install-SitecoreConfiguration @solrParams
}
catch{
	$error = $_.Exception
	
	#If we are failing because it has already been unloaded, then we can proceed
	if($error.Message.Contains("Cannot unload non-existent core")){
		Write-Warning -Message ("Core is not found. May have already been uninstalled. Proceeding to folders." | Out-String)
	}
	else{
		throw $error;
	}
}
#remove Sitecore Solr folders
$solrParams = @{
Path = "$PSScriptRoot\remove-sitecore-solr-folders.json"
SolrUrl = $SolrUrl
SolrRoot = $SolrRoot
CorePrefix = $prefix
}
Install-SitecoreConfiguration @solrParams

#remove sitecore instance
$sitecoreParams = @{
Path = "$PSScriptRoot\remove-sitecore-xp0.json"
SqlDbPrefix = $prefix
SqlServer = $SqlServer
SqlAdminUser = $SqlAdminUser
SqlAdminPassword = $SqlAdminPassword
SiteName = $SitecoreSiteName
}
Install-SitecoreConfiguration @sitecoreParams