using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YtMovieApis.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class AdminController : ControllerBase
    {
        public IActionResult GetData()
        {
            return Ok("Data from admin controller");
        }
    }
}
