using Azure.Storage.Blobs;
using FileApi.Models;

namespace FileApi.Services
{
    public class FileService : IFileService
    {
        public readonly BlobServiceClient _blobServiceClient;

        public FileService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task Upload(FileModels fileModel)
        {
            string originalFileName = Path.GetFileName(fileModel.ImageFile.FileName);

            string uniqueFileName = Guid.NewGuid().ToString() + "-" + originalFileName;

            var containerInstance = _blobServiceClient.GetBlobContainerClient("rootcontainer");

            var blobInstance = containerInstance.GetBlobClient(uniqueFileName);

            await blobInstance.UploadAsync(fileModel.ImageFile.OpenReadStream());
        }

        public async Task<Stream> Get(string name)
        {
            var containerInstance = _blobServiceClient.GetBlobContainerClient("rootcontainer");

            var blobInstance = containerInstance.GetBlobClient(name);

            var downloadContent = await blobInstance.DownloadAsync();

            return downloadContent.Value.Content;
        }
    }
}