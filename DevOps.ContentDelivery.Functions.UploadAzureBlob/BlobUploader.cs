using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;
using static System.IO.File;

namespace DevOps.ContentDelivery.Functions.UploadAzureBlob
{
    public static class BlobUploader
    {
        public static async Task Upload(CloudBlobContainer container, string name, string path)
        {
            var blob = container.GetBlockBlobReference(name);
            using (var stream = OpenRead(path))
                await blob.UploadFromStreamAsync(stream);
        }
    }
}
