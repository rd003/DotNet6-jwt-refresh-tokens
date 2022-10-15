using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YtMovieApis.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    [Authorize]
    public class ProtectedController : ControllerBase
    {
        public IActionResult GetData()
        {
            return Ok("Data from protected controller");
        }
    }
}
