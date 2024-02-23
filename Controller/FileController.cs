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
                if(fileId > 0) 
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
    }
}
