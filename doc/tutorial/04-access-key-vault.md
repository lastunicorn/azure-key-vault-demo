# Access Key Vault from a Console Application

## Step 1 - Include NuGet Packages

```cmd
Install-Package Azure.Identity
Install-Package Azure.Security.KeyVault.Secrets
```

## Step 2 - Instantiate `SecretClient`

```C#
string keyVaultName = "key-vault-20251023-kv"
Uri kvUri = new($"https://{keyVaultName}.vault.azure.net");

SecretClient client = new(kvUri, new DefaultAzureCredential());
```

## Step 3 - Access a Secret

```c#
string secretName = "password";

// Create a secret
string secretValue = "This is secret";
await client.SetSecretAsync(secretName, secretValue);

// Retrieve a secret
Response<KeyVaultSecret> secret = await client.GetSecretAsync(secretName);
string secretValue = secret.Value.Value;
```

