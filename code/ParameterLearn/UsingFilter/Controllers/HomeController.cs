using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using UsingFilter.Filters;

namespace UsingFilter.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [ParameterFilter1]
        [HttpGet("{name}")]
        public string RouteQuery([FromQuery] string gender, [FromRoute] string name)
        {
            return JsonSerializer.Serialize(new
            {
                gender = gender,
                name = name
            });
        }

        [ParameterFilter2]
        [HttpPost]
        public string Body([FromBody] string gender)
        {
            return JsonSerializer.Serialize(new
            {
                gender = gender
            });
        }

        [ParameterFilter2]
        [HttpPost]
        public string Form([FromForm] string gender)
        {
            return JsonSerializer.Serialize(new
            {
                gender = gender
            });
        }

        [ParameterFilter2]
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
