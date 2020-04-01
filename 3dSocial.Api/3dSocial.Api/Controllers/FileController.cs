using System;
using System.IO;
using System.Threading.Tasks;
using _3dSocial.Application.Interfaces;
using _3dSocial.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3dSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileFacade facade;

        public FileController(IFileFacade facade)
        {
            this.facade = facade;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var file = facade.Get(id);
                Stream stream = new MemoryStream(file.Content);

                if (stream == null)
                    return NotFound(); 
                
                return File(stream, "application/octet-stream", file.Name); // returns a FileStreamResult
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(IFormFile formFile)
        {
            try
            {
                Domain.Entities.File file = new Domain.Entities.File();

                using (var memoryStream = new MemoryStream())
                {
                    await formFile.CopyToAsync(memoryStream);

                    // Upload the file if less than 5 MB
                    int sizeLimitInMB = 5;
                    if (memoryStream.Length < sizeLimitInMB * 1024 * 1024 && formFile.FileName.ToLower().EndsWith(".zip"))
                    {
                        file = new Domain.Entities.File(){
                            Content = memoryStream.ToArray(),
                            Name = formFile.FileName
                        };

                        facade.Insert(file);
                    }
                    else{
                        ModelState.AddModelError("File", "The file is too large.");
                    }
                }

                return new ObjectResult(file.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                facade.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}