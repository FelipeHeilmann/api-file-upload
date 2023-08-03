using FileApi.Models;
using FileApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FileApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class FileController : ControllerBase
    {
        public readonly IFileService _fileServices;

        public FileController(IFileService fileService)
        {
            _fileServices = fileService;
        }

        [HttpPost]
        [Route("file")]
        public async Task<IActionResult> Uplaod([FromForm] FileModels file)
        {
            var fileUpload = await _fileServices.Upload(file);
            return Ok(fileUpload);
        }

        [HttpGet]
        [Route("file")]
        public async Task<IActionResult> Get(string name)
        {
            var image = await _fileServices.Get(name);
            string fileType = "jpg";

            if (fileType.Contains("png"))
            {
                fileType = "png";
            }

            return File(image, $"image/{fileType}");
        }
    }

}