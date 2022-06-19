using System;
using System.Text;
using System.Runtime.InteropServices;

namespace CryptoApiLiteSharp
{
    public static class CApiLiteNative
    {
        static CApiLiteNative()
        {
            CryptAcquireContext = CApiLiteNativeLinux.CryptAcquireContext;
            CryptReleaseContext = CApiLiteNativeLinux.CryptReleaseContext;

            PFXImportCertStore = CApiLiteNativeLinux.PFXImportCertStore;
            CertFindCertificateInStore = CApiLiteNativeLinux.CertFindCertificateInStore;
            CertCloseStore = CApiLiteNativeLinux.CertCloseStore;
            CertFreeCertificateContext = CApiLiteNativeLinux.CertFreeCertificateContext;
            CryptAcquireCertificatePrivateKey = CApiLiteNativeLinux.CryptAcquireCertificatePrivateKey;

            CryptCreateHash = CApiLiteNativeLinux.CryptCreateHash;
            CryptDestroyHash = CApiLiteNativeLinux.CryptDestroyHash;
            CryptHashData = CApiLiteNativeLinux.CryptHashData;
            CryptGetHashParam = CApiLiteNativeLinux.CryptGetHashParam;
            CryptSetHashParam = CApiLiteNativeLinux.CryptSetHashParam;
            CryptSignHash = CApiLiteNativeLinux.CryptSignHash;

            GetLastError = CApiLiteNativeLinux.GetLastError;
            FormatMessage = CApiLiteNativeLinux.FormatMessage;
        }

        #region CryptAcquireContext

        public delegate 
        bool CryptAcquireContextHandler(
            out CspSafeHandle phProv,
            string pszContainer,
            string pszProvider,
            uint dwProvType,
            uint dwFlags);

        public static CryptAcquireContextHandler CryptAcquireContext { get; }

        #endregion

        #region CryptReleaseContext

        public delegate 
        bool CryptReleaseContextHandler(
            IntPtr hProv,
            uint dwFlags);

        public static CryptReleaseContextHandler CryptReleaseContext { get; }

        #endregion

        #region PFXImportCertStore

        public delegate 
        CertStoreSafeHandle PFXImportCertStoreHandler(
            ref CRYPT_DATA_BLOB pPfx,
            IntPtr szPassword,
            uint dwFlags);

        public static PFXImportCertStoreHandler PFXImportCertStore { get; }

        #endregion

        #region CertFindCertificateInStore

        public delegate 
        CertContextSafeHandle CertFindCertificateInStoreHandler(
            CertStoreSafeHandle hCertStore,
            uint dwCertEncodingType,
            uint dwFindFlags,
            uint dwFindType,
            IntPtr pvFindPara,
            IntPtr pPrevCertContext);

        public static CertFindCertificateInStoreHandler CertFindCertificateInStore { get; }

        #endregion

        #region CertCloseStore

        public delegate
        bool CertCloseStoreHandler(
          IntPtr hCertStore,
          uint dwFlags
        );

        public static CertCloseStoreHandler CertCloseStore { get; }

        #endregion

        #region CertFreeCertificateContext

        public delegate
        bool CertFreeCertificateContextHandler(
          IntPtr pCertContext
        );

        public static CertFreeCertificateContextHandler CertFreeCertificateContext { get; }

        #endregion

        #region CryptAcquireCertificatePrivateKey

        public delegate 
        bool CryptAcquireCertificatePrivateKeyHandler(
            CertContextSafeHandle pCert,
            uint dwFlags,
            IntPtr pvReserved,
            out CspSafeHandle phCryptProv,
            ref uint pdwKeySpec,
            ref bool pfCallerFreeProv);

        public static CryptAcquireCertificatePrivateKeyHandler CryptAcquireCertificatePrivateKey { get; }

        #endregion

        #region CryptCreateHash

        public delegate
        bool CryptCreateHashHandler(
          CspSafeHandle hProv,
          uint algid,
          IntPtr hKey,
          int dwFlags,
          out HashSafeHandle phHash
        );

        public static CryptCreateHashHandler CryptCreateHash { get; }

        #endregion

        #region CryptDestroyHash

        public delegate
        bool CryptDestroyHashHandler(
          IntPtr hHash
        );

        public static CryptDestroyHashHandler CryptDestroyHash{ get; }

        #endregion

        #region CryptHashData

        public delegate
        bool CryptHashDataHandler(
           HashSafeHandle hHash,
           IntPtr pbData,
           int dataLen,
           int flags
        );

        public static CryptHashDataHandler CryptHashData { get; }

        #endregion

        #region CryptGetHashParam

        public delegate
        bool CryptGetHashParamHandler(
            HashSafeHandle hHash,
            uint dwParam,
            IntPtr pbData,
            ref int pdwDataLen,
            int dwFlags);

        public static CryptGetHashParamHandler CryptGetHashParam { get; }

        #endregion

        #region CryptSetHashParam

        public delegate
        bool CryptSetHashParamHandler(
             HashSafeHandle hHash,
             uint dwParam,
             IntPtr pbData,
             int dwFlags);

        public static CryptSetHashParamHandler CryptSetHashParam { get; }

        #endregion

        #region CryptSignHash

        public delegate
        bool CryptSignHashHandler(
             HashSafeHandle hHash,
             uint keySpec,
             IntPtr description,
             uint flags,
             IntPtr signature,
             ref int signatureLen);

        public static CryptSignHashHandler CryptSignHash { get; }

        #endregion

        #region GetLastError

        public delegate 
        int GetLastErrorHandler();

        public static GetLastErrorHandler GetLastError { get; }

        #endregion

        #region FormatMessage

        public delegate 
        int FormatMessageHandler(
            uint dwFlags,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            int nSize,
            IntPtr vaListArguments);

        public static FormatMessageHandler FormatMessage { get; }

        #endregion
    }
}
