using FileApi.Models;

namespace FileApi.Services
{
    public interface IFileService
    {
        Task<String> Upload(FileModels fileModel);
        Task<Stream> Get(string name);
    }
}