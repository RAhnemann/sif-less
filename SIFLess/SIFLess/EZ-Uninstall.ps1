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
Path = "$PSScriptRoot\remove-xconnect-solr.json"
SolrUrl = $SolrUrl
SolrRoot = $SolrRoot
CorePrefix = $prefix
}
Install-SitecoreConfiguration @solrParams

#deploy xconnect instance
$xconnectParams = @{
Path = "$PSScriptRoot\remove-xconnect-xp0.json"
SiteName = $XConnectCollectionService
SqlDbPrefix = $prefix
SqlServer = $SqlServer
SqlAdminUser = $SqlAdminUser
SqlAdminPassword = $SqlAdminPassword
}
Install-SitecoreConfiguration @xconnectParams
#install solr cores for sitecore
$solrParams = @{
Path = "$PSScriptRoot\remove-sitecore-solr.json"
SolrUrl = $SolrUrl
SolrRoot = $SolrRoot
CorePrefix = $prefix
}
Install-SitecoreConfiguration @solrParams
#install sitecore instance
$sitecoreParams = @{
Path = "$PSScriptRoot\remove-sitecore-xp0.json"
SqlDbPrefix = $prefix
SqlServer = $SqlServer
SqlAdminUser = $SqlAdminUser
SqlAdminPassword = $SqlAdminPassword
SiteName = $SitecoreSiteName
}
Install-SitecoreConfiguration @sitecoreParams