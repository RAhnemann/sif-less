
Set-StrictMode -Version 2.0

Function Invoke-RemoveAppPoolTask {
    [CmdletBinding(SupportsShouldProcess=$true)]
    param(
        [Parameter(Mandatory=$true)]
        [string]$Name
    )

    Write-TaskInfo "Removing Application Pool $name" -Tag 'RemoveAppPool'

    Remove-WebAppPool -Name $name 
}
Register-SitecoreInstallExtension -Command Invoke-RemoveAppPoolTask -As RemoveAppPool -Type Task