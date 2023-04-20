using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeaderLearn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            HttpContext.Response.Headers.Add("Name", "Dhruvil Dobariya");
            HttpContext.Response.Headers.Add("Company-Name", HttpContext.Request.Headers["company-name"]);
            return "Header Learn";
        }
    }
}
