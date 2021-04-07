using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public interface IAzureBlobHelpers
    {
        /// <summary>
        /// Connects to a BlobClient in Azure Blob Storage
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="containerName"></param>
        /// <returns></returns>
        BlobContainerClient ConnectToBlobClient(string connectionString, string containerName);

        /// <summary>
        /// Uploads a blob to Azure Storage
        /// </summary>
        /// <param name="containerClient"></param>
        /// <param name="blobName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        Task UploadBlobAsync(BlobContainerClient containerClient, string blobName, string fileName);

        /// <summary>
        /// Downloads the content of a specified blob to a stream
        /// </summary>
        /// <param name="containerClient"></param>
        /// <param name="blobName"></param>
        /// <returns></returns>
        Task<Stream> DownloadBlobAsStreamAsync(BlobContainerClient containerClient, string blobName);
    }
}
