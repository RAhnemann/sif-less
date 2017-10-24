Import-Module SitecoreInstallFramework
$prefix = "[SC_PREFIX]"
$PSScriptRoot = "[SCRIPT_ROOT]"
$XConnectCollectionService = "[XCONNECT_NAME]"
$sitecoreSiteName = "[SITE_NAME]"
$SolrUrl = "[SOLR_URL]"
$SolrRoot = "[SOLR_FOLDER]"
$SolrService = "[SOLR_SERVICE]"
$SqlServer = "[SQL_SERVER]"
$SqlAdminUser = "[SQL_USER]"
$SqlAdminPassword="[SQL_PASSWORD]"

#install client certificate for xconnect
$certParams = @{
Path = "$PSScriptRoot\xconnect-createcert.json"
CertificateName = "$prefix.xconnect_client"
}
Install-SitecoreConfiguration @certParams -Verbose
#install solr cores for xdb
$solrParams = @{
Path = "$PSScriptRoot\xconnect-solr.json"
SolrUrl = $SolrUrl
SolrRoot = $SolrRoot
SolrService = $SolrService
CorePrefix = $prefix
}
Install-SitecoreConfiguration @solrParams
#deploy xconnect instance
$xconnectParams = @{
Path = "$PSScriptRoot\xconnect-xp0.json"
Package = "[XCONNECT_PACKAGE]"
LicenseFile = "[LICENSE_XML]"
Sitename = $XConnectCollectionService
XConnectCert = $certParams.CertificateName
SqlDbPrefix = $prefix
SqlServer = $SqlServer
SqlAdminUser = $SqlAdminUser
SqlAdminPassword = $SqlAdminPassword
SolrCorePrefix = $prefix
SolrURL = $SolrUrl
}
Install-SitecoreConfiguration @xconnectParams
#install solr cores for sitecore
$solrParams = @{
Path = "$PSScriptRoot\sitecore-solr.json"
SolrUrl = $SolrUrl
SolrRoot = $SolrRoot
SolrService = $SolrService
CorePrefix = $prefix
}
Install-SitecoreConfiguration @solrParams
#install sitecore instance
$sitecoreParams = @{
Path = "$PSScriptRoot\sitecore-XP0.json"
Package = "[SITECORE_PACKAGE]"
LicenseFile = "[LICENSE_XML]"
SqlDbPrefix = $prefix
SqlServer = $SqlServer
SqlAdminUser = $SqlAdminUser
SqlAdminPassword = $SqlAdminPassword
SolrCorePrefix = $prefix
SolrUrl = $SolrUrl
XConnectCert = $certParams.CertificateName
Sitename = $sitecoreSiteName
XConnectCollectionService = "https://$XConnectCollectionService"
}
Install-SitecoreConfiguration @sitecoreParams