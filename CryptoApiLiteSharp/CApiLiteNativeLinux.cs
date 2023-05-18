using System;
using System.Text;
using System.Runtime.InteropServices;

namespace CryptoApiLiteSharp
{
    internal static class CApiLiteNativeLinux
    {
        private const string LIB_NAME = "capi20";

        [DllImport(LIB_NAME, CharSet = CharSet.Ansi, SetLastError = true, EntryPoint = "CryptAcquireContextA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptAcquireContext(
            [Out] out CspSafeHandle phProv,
            [In] string pszContainer,
            [In] string pszProvider,
            [In] uint dwProvType,
            [In] uint dwFlags);

        [DllImport(LIB_NAME, CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptReleaseContext(
            [In] IntPtr hProv,
            [In] uint dwFlags);

        [DllImport(LIB_NAME)]
        public static extern
        int GetLastError();

        [DllImport(LIB_NAME, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern
        int FormatMessage(
            [In] uint dwFlags,
            [In] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out] StringBuilder lpBuffer,
            [In] int nSize,
            [In] IntPtr vaListArguments);

        [DllImport(LIB_NAME, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern
            CertStoreSafeHandle PFXImportCertStore(
            [In] ref CRYPT_DATA_BLOB pPfx,
            [In] IntPtr szPassword,
            [In] uint dwFlags);

        [DllImport(LIB_NAME, SetLastError = true)]
        public static extern
            CertContextSafeHandle CertFindCertificateInStore(
            [In] CertStoreSafeHandle hCertStore,
            [In] uint dwCertEncodingType,
            [In] uint dwFindFlags,
            [In] uint dwFindType,
            [In] IntPtr pvFindPara,
            [In] IntPtr pPrevCertContext);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CertCloseStore(
            [In] IntPtr hCertStore,
            [In] uint dwFlags);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CertFreeCertificateContext(
            [In] IntPtr pCertContext);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptAcquireCertificatePrivateKey(
            [In] CertContextSafeHandle pCert,
            [In] uint dwFlags,
            [In] IntPtr pvReserved,
            [Out] out CspSafeHandle phCryptProv,
            [In, Out] ref uint pdwKeySpec,
            [In, Out] ref bool pfCallerFreeProv);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptCreateHash(
            [In] CspSafeHandle hProv,
            [In] uint algid,
            [In] IntPtr hKey,
            [In] int dwFlags,
            [Out] out HashSafeHandle phHash);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptDestroyHash(
          [In] IntPtr hHash
        );


        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptHashData(
            [In] HashSafeHandle hHash,
            [In] IntPtr pbData,
            [In] int dataLen,
            [In] int flags);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptGetHashParam(
            [In] HashSafeHandle hHash,
            [In] uint dwParam,
            [In, Out] IntPtr pbData,
            [In, Out] ref int pdwDataLen,
            [In] int dwFlags);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptSetHashParam(
            [In] HashSafeHandle hHash,
            [In] uint dwParam,
            [In] IntPtr pbData,
            [In] int dwFlags);

        [DllImport(LIB_NAME, SetLastError = true, CharSet = CharSet.Ansi, EntryPoint = "CryptSignHashA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern
        bool CryptSignHash(
            [In] HashSafeHandle hHash,
            [In] uint keySpec,
            [In] IntPtr description,
            [In] uint flags,
            [Out] IntPtr signature,
            [In, Out] ref int signatureLen);
    }
}
