using Azure.Security.KeyVault.Secrets;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public interface IKeyVaultHelper
    {
        Task SaveSecretToKeyVaultAsync(string secretName, string secretValue);
        Task<KeyVaultSecret> RetrieveSecretFromKeyVaultAsync(string secret);
    }
}
