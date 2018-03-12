param (
    [switch]$uninstall
);
Import-Module SitecoreInstallFramework
[GLOBAL]

if($uninstall)
{
	[UNINSTALL]
}
else
{
	[INSTALL]
}