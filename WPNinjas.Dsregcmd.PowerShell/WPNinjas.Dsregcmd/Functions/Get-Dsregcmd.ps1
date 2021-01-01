Function Get-Dsregcmd(){
    <#
    .DESCRIPTION
    This method will provide information normally returned by dsregcmd in form of a managed object. 

    .EXAMPLE
    $d = Get-Dsregcmd
    $d | fl

    JoinType           : DSREG_DEVICE_JOIN
    DeviceId           : e023667e-01ea-4ede-8751-fd3b6c402c7e
    IdpDomain          : login.windows.net
    TenantId           : 971d7678-7ef2-4d6b-b297-e62aaa6941f0
    JoinUserEmail      : thomas.kurth@wpninjas.ch
    TenantDisplayName  : WPNinjas
    MdmEnrollmentUrl   : https://enrollment.manage.microsoft.com/enrollmentserver/discovery.svc
    MdmTermsOfUseUrl   : https://portal.manage.microsoft.com/TermsofUse.aspx
    MdmComplianceUrl   : thomas.kurth@wpninjas.ch
    UserSettingSyncUrl : {"Uris":["https://kailani6.one.microsoft.com/","https://kailani7.one.microsoft.com/"]}
    UserInfo           :
    CertInfo           : {[Subject]
                        CN=e023667e-01ea-4ede-8751-fd3b6c402c7e

                        [Issuer]
                        DC=net + DC=windows + CN=MS-Organization-Access + OU=82dbaca4-3e81-46ca-9c73-0950c1eaca97

                        [Serial Number]
                        465FCD1F737DFCA440046DAEB36B2B88

                        [Not Before]
                        07.06.2020 15:34:06

                        [Not After]
                        07.06.2030 16:04:06

                        [Thumbprint]
                        85813B7F36A52BBFF941D33609B6FAA64735DAB7
                        }

    .NOTES
    Author: Thomas Kurth/baseVISION
    Date:   1.1.2021

    History
        See Release Notes in Github.

    #>
    [CmdletBinding()]
    [OutputType([WPNinjas.Dsregcmd.DsregcmdResult])]
    Param(
    )
      

    #region Initialization
    ########################################################
    Write-Log "Start Script $Scriptname"
    #endregion

    #region Main Script
    ########################################################
    
    [WPNinjas.Dsregcmd.Dsregcmd]::GetInfo()

    #endregion
    #region Finishing
    ########################################################

    Write-Log "End Script $Scriptname"
    #endregion
}