using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WPNinjas.Dsregcmd
{
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
    
}
