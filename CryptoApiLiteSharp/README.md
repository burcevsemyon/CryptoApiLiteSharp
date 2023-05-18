# CryptoApiLiteSharp

Сигнатуры методов для C# P/Invoke КРИПТО-ПРО CAPILite для Linux
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
