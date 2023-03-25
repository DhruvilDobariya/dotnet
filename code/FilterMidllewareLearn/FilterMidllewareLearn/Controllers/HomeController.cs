using Microsoft.AspNetCore.Mvc;

namespace FilterLearn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Division([FromQuery] int a, [FromQuery] int b)
        {
            return Ok(a / b);
        }
    }
}
