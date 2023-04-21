using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace UsingMiddleware.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("{gender}")]
        public string Route([FromRoute] string gender)
        {
            return JsonSerializer.Serialize(new
            {
                gender = gender
            });
        }

        [HttpGet]
        public string Query([FromQuery] string gender)
        {
            return JsonSerializer.Serialize(new
            {
                gender = gender
            });
        }

        [HttpPost]
        public string Body([FromBody] string gender)
        {
            return JsonSerializer.Serialize(new
            {
                gender = gender
            });
        }

        [HttpPost]
        public string Form([FromForm] string gender)
        {
            return JsonSerializer.Serialize(new
            {
                gender = gender
            });
        }

        [HttpGet]
        public string Header([FromHeader] string gender)
        {
            return JsonSerializer.Serialize(new
            {
                gender = gender
            });
        }
    }
}
