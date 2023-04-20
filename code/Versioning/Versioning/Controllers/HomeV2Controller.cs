using Microsoft.AspNetCore.Mvc;

namespace Versioning.Controllers
{
    //[Route("api/{v:apiVersion}/Home")]
    [Route("api/Home")]
    [ApiController]
    [ApiVersion("2.0")]
    public class HomeV2Controller : ControllerBase
    {

        [HttpGet]
        public string GetController()
        {
            return "Get Version 2.0";
        }
    }
}
