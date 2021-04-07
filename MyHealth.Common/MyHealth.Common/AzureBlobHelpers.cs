using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public class AzureBlobHelpers : IAzureBlobHelpers
    {
        public BlobContainerClient ConnectToBlobClient(string connectionString, string containerName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);

            return containerClient;
        }

        public async Task<Stream> DownloadBlobAsStreamAsync(BlobContainerClient containerClient, string blobName)
        {
            BlobClient blobClient = containerClient.GetBlobClient(blobName);

            var stream = new MemoryStream();

            await blobClient.DownloadToAsync(stream);

            return stream;
        }

        public async Task UploadBlobAsync(BlobContainerClient containerClient, string blobName, string fileName)
        {
            BlobClient blobClient = containerClient.GetBlobClient(blobName);

            await blobClient.UploadAsync(fileName);
        }
    }
}
