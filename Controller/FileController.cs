using Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicApiProject.Controller
{
    [ApiController]
    [Route("file")]
    public class FileController : ControllerBase
    {
        [HttpGet]
        [Route("GetFile")]
        public IActionResult GetFile(int fileId)
        {
            try
            {
                if (fileId > 0)
                {
                    return Ok(fileId);
                }
                return BadRequest("file id must be greater then 0");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("GetAllFiles"), HttpGet]
        public ActionResult<FileContent> GetAll() 
        {
            try 
            {
                var file=new FileContent();
                file.ID = 5;
                file.UserName = "admin";
                file.Name = "BasicFile";
                file.CreatedOn= DateTime.Now.AddHours(-5);
                file.DateOfBirth = DateTime.Now;
                if (file!=null)
                {
                    return Ok(file);
                }
                else 
                {
                    return BadRequest("File not found");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }

    }
}
