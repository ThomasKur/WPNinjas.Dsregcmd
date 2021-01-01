using System;
using System.Runtime.InteropServices;

namespace WPNinjas.Dsregcmd
{
    internal class InternalData
    {


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct DSREG_JOIN_INFO
        {
            public int joinType;
            public IntPtr pJoinCertificate;
            [MarshalAs(UnmanagedType.LPWStr)] public string DeviceId;
            [MarshalAs(UnmanagedType.LPWStr)] public string IdpDomain;
            [MarshalAs(UnmanagedType.LPWStr)] public string TenantId;
            [MarshalAs(UnmanagedType.LPWStr)] public string JoinUserEmail;
            [MarshalAs(UnmanagedType.LPWStr)] public string TenantDisplayName;
            [MarshalAs(UnmanagedType.LPWStr)] public string MdmEnrollmentUrl;
            [MarshalAs(UnmanagedType.LPWStr)] public string MdmTermsOfUseUrl;
            [MarshalAs(UnmanagedType.LPWStr)] public string MdmComplianceUrl;
            [MarshalAs(UnmanagedType.LPWStr)] public string UserSettingSyncUrl;
            public IntPtr pUserInfo;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct DSREG_USER_INFO
        {
            [MarshalAs(UnmanagedType.LPWStr)] public string UserEmail;
            [MarshalAs(UnmanagedType.LPWStr)] public string UserKeyId;
            [MarshalAs(UnmanagedType.LPWStr)] public string UserKeyName;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CERT_PUBLIC_KEY_INFO
        {
            public CRYPT_ALGORITHM_IDENTIFIER Algorithm;
            public CRYPT_BIT_BLOB PublicKey;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CERT_CONTEXT
        {
            public uint dwCertEncodingType;
            public IntPtr pbCertEncoded;
            public uint cbCertEncoded;
            public IntPtr pCertInfo;
            public IntPtr hCertStore;
        }


        [StructLayout(LayoutKind.Sequential)]
        internal struct CRYPTOAPI_BLOB //x86 - 8, x64 - 16
        {
            public Int32 cbData;
            public IntPtr pbData;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct CRYPT_OBJID_BLOB //8
        {
            public Int32 cbData;
            [MarshalAs(UnmanagedType.ByValArray)]
            public byte[] pbData;
        }


        [StructLayout(LayoutKind.Sequential)]
        internal struct CERT_INFO
        {
            public uint dwVersion; //4
            public CRYPTOAPI_BLOB SerialNumber; //8 - 16
            public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm; //12 - 16
            public CRYPTOAPI_BLOB Issuer; //8 - 16
            public System.Runtime.InteropServices.ComTypes.FILETIME NotBefore; //8
            public System.Runtime.InteropServices.ComTypes.FILETIME NotAfter; //8
            public CRYPTOAPI_BLOB Subject; //8 - 16
            public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;//24 - 40
            public CRYPT_BIT_BLOB IssuerUniqueId;//12 - 24
            public CRYPT_BIT_BLOB SubjectUniqueId;//12 - 24
            public uint cExtension;//4
            public IntPtr rgExtension;//4 - 8
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_ALGORITHM_IDENTIFIER //12 - 16
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public String pszObjId; //4
            public CRYPT_OBJID_BLOB Parameters;//8
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_BIT_BLOB //12-24
        {
            public Int32 cbData; //4
            public IntPtr pbData;//4-8
            public Int32 cUnusedBits;//4
        }
    }
}
