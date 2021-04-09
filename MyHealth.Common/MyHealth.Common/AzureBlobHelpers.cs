using Azure.Storage.Blobs;
using System.IO;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public class AzureBlobHelpers : IAzureBlobHelpers
    {
        private readonly BlobContainerClient _blobContainerClient;

        public AzureBlobHelpers(string connectionString, string containerName)
        {
            _blobContainerClient = new BlobContainerClient(connectionString, containerName);
        }

        public async Task<Stream> DownloadBlobAsStreamAsync(string blobName)
        {
            BlobClient blobClient = _blobContainerClient.GetBlobClient(blobName);

            var stream = new MemoryStream();

            await blobClient.DownloadToAsync(stream);

            return stream;
        }

        public async Task UploadBlobAsync(string blobName, string fileName)
        {
            BlobClient blobClient = _blobContainerClient.GetBlobClient(blobName);

            await blobClient.UploadAsync(fileName);
        }
    }
}
