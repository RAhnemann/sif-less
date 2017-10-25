
Set-StrictMode -Version 2.0

Function Invoke-RemoveFolderTask {
    [CmdletBinding(SupportsShouldProcess=$true)]
    param(
        [Parameter(Mandatory=$true)]
        [string]$Name
    )

	if(Test-Path $name) {
    Write-TaskInfo "Removing Folder $name" -Tag 'RemoveFolder'

    Remove-Item -path $name -recurse
	}
	else
	{
	Write-TaskInfo "Folder doesn't exist {$name}" -Tag 'RemoveFolder'
	}
}
Register-SitecoreInstallExtension -Command Invoke-RemoveFolderTask -As RemoveFolder -Type Task