# Cryptography

* Encrypt and decrypt text files
* Unity minimum version: **2019.3**
* Current version: **0.1.0**
* License: **MIT**

## How To Use

You can only to encrypt or decrypt strings using AES algorithm.

```csharp
using UnityEngine;
using ActionCode.Cryptography;

public class Test : MonoBehaviour
{
    public TextAsset json;

    [ContextMenu("Run Test")]
    async void RunTest()
    {
        // You can create a security key at https://randomkeygen.com/
        var superSecurityKey = "IspwttyeNSQ9qWLouOoG6y1GnozZ9uEn";
        var cryptographer = CryptographerFactory.Create(CryptographerType.AES, superSecurityKey);
        var encrypted = await cryptographer.Encrypt(json.text);
        var decrypted = await cryptographer.Decrypt(encrypted);

        print(encrypted);
        print(decrypted);
    }
}
```

## Installation

### Using the Package Registry Server

Follow the instructions inside [here](https://cutt.ly/ukvj1c8) and the package **ActionCode-Cryptography** 
will be available for you to install using the **Package Manager** windows.

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set. 

- Use the **Package Manager** "Add package from git URL..." feature and paste this URL: `https://github.com/HyagoOliveira/Cryptography.git`

- You can also manually modify you `Packages/manifest.json` file and add this line inside `dependencies` attribute: 

```json
"com.actioncode.cryptography":"https://github.com/HyagoOliveira/Cryptography.git"
```

---

**Hyago Oliveira**

[GitHub](https://github.com/HyagoOliveira) -
[BitBucket](https://bitbucket.org/HyagoGow/) -
[LinkedIn](https://www.linkedin.com/in/hyago-oliveira/) -
<hyagogow@gmail.com>