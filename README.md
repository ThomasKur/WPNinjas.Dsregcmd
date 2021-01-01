# WPNinjas Dsregcmd and Azure AD Join information
This repo provides options to use dsregcmd information in managed code and powershell not by parsing the dsregcmd.exe commandline output. Therefore, direct calls to netapi32 will be used.

I personally developed these helper library because I need often information like Azure AD Device ID when workjing localy on a device, but I'm not happy with parsing the registry or the command line output from dsregcmd. With this small library you get the possibility to get all this information in managed code like .NETc# or PowerShell as a simple object in the following structure: 

```C#
public class DsregcmdResult
{
    public JoinType JoinType { get; set; }
    public Guid DeviceId { get; set; }
    public string IdpDomain { get; set; }
    public Guid TenantId { get; set; }
    public string JoinUserEmail { get; set; }

    public string TenantDisplayName { get; set; }

    public string MdmEnrollmentUrl { get; set; }
    public string MdmTermsOfUseUrl { get; set; }
    public string MdmComplianceUrl { get; set; }
    public string UserSettingSyncUrl { get; set; }

    public UserResult UserInfo { get; set; }
    public List<X509Certificate2> CertInfo { get; set; }
}

public class UserResult
{
    public string UserEmail { get; set; }
    public Guid UserKeyId { get; set; }
    public string UserKeyname { get; set; }
}
```

## Nuget package for .NET projects

## PowerShell Module


