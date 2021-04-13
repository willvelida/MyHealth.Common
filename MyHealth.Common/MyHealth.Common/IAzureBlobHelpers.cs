using System.IO;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public interface IAzureBlobHelpers
    {
        /// <summary>
        /// Uploads a blob to Azure Storage
        /// </summary>
        /// <param name="blobName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        Task UploadBlobAsync(string blobName, string fileName);

        /// <summary>
        /// Downloads the content of a specified blob to a stream
        /// </summary>
        /// <param name="blobName"></param>
        /// <returns></returns>
        Task<Stream> DownloadBlobAsStreamAsync(string blobName);
    }
}
