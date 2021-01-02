# WPNinjas Dsregcmd and Azure AD Join information


I developed this helper library because I need often information like Azure AD Device ID when working localy on a device. But I was never happy with parsing the registry or the command line output from dsregcmd. With this small library you get the possibility to get all this information directly from netapi32 in managed code like .NET or PowerShell as a simple object in the following structure: 

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
The package is available on [Nuget](https://www.nuget.org/packages/WPNinjas.Dsregcmd/1.0.0). Simply install it by searching for 'WPNinjas.Dsregcmd'. You can the retrieve the dsregcmd data by using:

```c#

using System;
using WPNinjas.Dsregcmd;

namespace WPNinjas.Dsregcmd.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DsregcmdResult dsreg = Dsregcmd.GetInfo();
                Console.WriteLine("Successfully retrieved information.");
            } catch (Exception ex)
            {
                Console.WriteLine("Error occured.");
                Console.WriteLine(ex.Message);

            }

        }
    }
}

```

## PowerShell Module
For your convinience the module is published to the [Powershell Gallery](https://www.powershellgallery.com/packages/WPNinjas.Dsregcmd/).

```powershell
Install-Module -Name WPNinjas.Dsregcmd

# Request information
$result = Get-Dsregcmd 

# Output information to console
$result | Format-List *
```

