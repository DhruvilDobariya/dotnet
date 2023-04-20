using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Versioning.Controllers
{
    // using URI 
    //[Route("api/{v:apiVersion}/Home")]
    [Route("api/Home")]
    [ApiController]
    [ApiVersion("1.0")]
    public class HomeV1Controller : ControllerBase
    {
        [HttpGet]
        public string GetController()
        {
            return "Get Version 1.0";
        }
    }
}
