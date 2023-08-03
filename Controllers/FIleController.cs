using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FileApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class FIleController : ControllerBase
    {
        [HttpPost("file")]
        public ActionResult<String> UploadImage([FromForm] IFormFile file)
        {
            try
            {
                // getting file original name
                string FileName = file.FileName;

                // combining GUID to create unique name before saving in wwwroot
                string uniqueFileName = Guid.NewGuid().ToString() + "-" + FileName;

                // getting full path inside wwwroot/images
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", uniqueFileName);

                // copying file
                file.CopyTo(new FileStream(imagePath, FileMode.Create));

                return "File Uploaded Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}