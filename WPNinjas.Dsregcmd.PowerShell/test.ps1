$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
import-module "$scriptPath\WPNinjas.Dsregcmd\WPNinjas.Dsregcmd.psm1" -force
Get-Dsregcmd | Format-List *
