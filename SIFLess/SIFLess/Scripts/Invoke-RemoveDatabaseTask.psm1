
Set-StrictMode -Version 2.0

Function Invoke-RemoveDatabaseTask {
    [CmdletBinding(SupportsShouldProcess=$true)]
    param(
        [Parameter(Mandatory=$true)]
        [string]$DatabaseName,
		[Parameter(Mandatory=$true)]
        [string]$ServerName,
		[Parameter(Mandatory=$true)]
        [string]$Login,
		[Parameter(Mandatory=$true)]
        [string]$Password
    )

    Write-TaskInfo "Removing Database $DatabaseName" -Tag 'RemoveDatabase'
	
    Invoke-SQLCmd -ServerInstance $ServerName -U $Login -P $Password -Query "ALTER DATABASE [$DatabaseName] SET SINGLE_USER WITH ROllBACK IMMEDIATE; DROP DATABASE [$DatabaseName];"
}
Register-SitecoreInstallExtension -Command Invoke-RemoveDatabaseTask -As RemoveDatabase -Type Task