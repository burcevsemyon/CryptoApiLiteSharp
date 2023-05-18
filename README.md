# CryptoApiLiteSharp

Сигнатуры методов для C# P/Invoke КРИПТО-ПРО CryptoAPI Lite (CAPILite) v5 для Linux
- **Функции работы с провайдером**	
	CryptAcquireContext  
	CryptReleaseContext  
- **Функции работы с PFX (PKCS#12) файлами**	
 
    PFXImportCertStore  
- **Функции обработки сертификатов**

	CertFindCertificateInStore  
    CertFreeCertificateContext 
- **Функции работы c хранилищем сертификатов**

	CertCloseStore  
- **Функции генерации и обмена ключа**  

    CryptAcquireCertificatePrivateKey  
- **Функции обработки хэша и цифровой подписи**  

    CryptCreateHash  
	CryptDestroyHash  
    CryptHashData  
	CryptGetHashParam  
    CryptSetHashParam  
	CryptSignHash


Описание методов и параметров можно узнать на справочной [странице](https://cpdn.cryptopro.ru/default.asp?url=content/cades/indexpage.html) КРИПТО-ПРО или [MSDN](https://learn.microsoft.com/en-us/windows/win32/seccrypto/cryptography-functions)