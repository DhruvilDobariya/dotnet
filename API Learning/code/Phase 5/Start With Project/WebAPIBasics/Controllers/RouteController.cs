using Microsoft.AspNetCore.Mvc;

namespace WebAPIBasics.Controllers
{
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    [Route("api/Route2")]
    public class RouteController : Controller
    {
        [HttpGet("First")]
        //[HttpGet]
        //[Route("First")]
        public ActionResult<int> Index()
        {
            return 0;
        }

        [HttpGet]
        [Route("Seconde/{id:int:min(1)}")]
        public ActionResult<int> Method2(int id)
        {
            return id;
        }

        [HttpGet("Route1")]
        [HttpPost("Route2")]
        public ActionResult<int> Method3()
        {
            return 0;
        }
    }
}
