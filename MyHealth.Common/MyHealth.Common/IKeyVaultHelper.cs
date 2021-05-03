using System.Threading.Tasks;

namespace MyHealth.Common
{
    public interface IKeyVaultHelper
    {
        Task SaveSecretToKeyVaultAsync(string secretName, string secretValue);
        Task RetrieveSecretFromKeyVaultAsync(string secret);
    }
}
