using Azure;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace DustInTheWind.AzureKeyVaultDemo;

internal class Secret
{
    private readonly SecretClient client;
    private readonly string keyVaultName;
    private readonly string name;

    public Secret(string keyVaultName, string name)
    {
        this.keyVaultName = keyVaultName;
        this.name = name;

        Uri kvUri = new($"https://{keyVaultName}.vault.azure.net");
        client = new(kvUri, new DefaultAzureCredential());
    }

    public async Task Create(string secretValue)
    {
        Console.Write($"Creating a secret in {keyVaultName} called '{name}' with the value '{secretValue}' ...");
        await client.SetSecretAsync(name, secretValue);
        Console.WriteLine(" done.");
    }

    public async Task<string> Retrieve()
    {
        Console.WriteLine($"Retrieving your secret from {keyVaultName}.");
        Response<KeyVaultSecret> secret = await client.GetSecretAsync(name);
        Console.WriteLine($"Your secret is '{secret.Value.Value}'.");

        return secret.Value.Value;
    }

    public async Task Delete()
    {
        Console.Write($"Deleting your secret from {keyVaultName} ...");
        DeleteSecretOperation operation = await client.StartDeleteSecretAsync(name);
        await operation.WaitForCompletionAsync();
        Console.WriteLine(" done.");
    }

    public async Task PurgeSecret()
    {
        Console.Write($"Purging your secret from {keyVaultName} ...");
        await client.PurgeDeletedSecretAsync(name);
        Console.WriteLine(" done.");
    }
}