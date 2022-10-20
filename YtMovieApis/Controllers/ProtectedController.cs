using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YtMovieApis.Models.DTO;

namespace YtMovieApis.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    [Authorize]
    public class ProtectedController : ControllerBase
    {
        public IActionResult GetData()
        {
            var status = new Status();
            status.StatusCode = 1;
            status.Message = "Data from protected controller";
            return Ok(status);
        }
    }
}
