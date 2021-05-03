using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public class KeyVaultHelper : IKeyVaultHelper
    {
        private readonly SecretClient _secretClient;

        public KeyVaultHelper(string keyVaultName)
        {
            var keyVaultUri = "https://" + keyVaultName + ".vault.azure.net";
            _secretClient = new SecretClient(new Uri(keyVaultUri), new DefaultAzureCredential());
        }

        public KeyVaultHelper(string keyVaultName, string tenantId, string clientId, string clientSecret)
        {
            var keyVaultUri = "https://" + keyVaultName + ".vault.azure.net";
            ClientSecretCredential clientSecretCredential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            _secretClient = new SecretClient(new Uri(keyVaultUri), clientSecretCredential);
        }

        public async Task RetrieveSecretFromKeyVaultAsync(string secret)
        {
            await _secretClient.GetSecretAsync(secret);
        }

        public async Task SaveSecretToKeyVaultAsync(string secretName, string secretValue)
        {
            await _secretClient.SetSecretAsync(secretName, secretValue);
        }
    }
}
