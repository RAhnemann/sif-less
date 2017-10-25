
Set-StrictMode -Version 2.0

Function Invoke-RemoveWebsiteTask {
    [CmdletBinding(SupportsShouldProcess=$true)]
    param(
        [Parameter(Mandatory=$true)]
        [string]$Name
    )

    Write-TaskInfo "Removing Website $name" -Tag 'RemoveWebsite'

    Remove-Website -Name $name 
}
Register-SitecoreInstallExtension -Command Invoke-RemoveWebsiteTask -As RemoveWebsite -Type Task