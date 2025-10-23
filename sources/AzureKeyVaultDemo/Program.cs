namespace DustInTheWind.AzureKeyVaultDemo;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        Secret keyVaultSecret = new("key-vault-20251023-kv", "Test");

        await keyVaultSecret.Create("My really secret value");
        await keyVaultSecret.Retrieve();
        await keyVaultSecret.Delete();
        await keyVaultSecret.PurgeSecret();
    }
}