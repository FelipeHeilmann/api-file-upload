using FileApi.Models;

namespace FileApi.Services
{
    public interface IFileService
    {
        Task Upload(FileModels fileModel);
        Task<Stream> Get(string name);
    }
}