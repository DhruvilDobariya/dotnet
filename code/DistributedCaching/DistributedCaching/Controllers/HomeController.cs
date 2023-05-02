using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace DistributedCaching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IDistributedCache _cache;
        public HomeController(IDistributedCache cache)
        {
            _cache = cache;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string token = string.Empty;
            try
            {
                token = await _cache.GetStringAsync("token");
                //Or
                //token = Encoding.UTF8.GetString(await _cache.GetAsync("token"));
            }
            catch { }

            if (!string.IsNullOrEmpty(token))
            {
                return Ok(token);

            }

            token = GetTocken();
            DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(40),
                // Or
                //AbsoluteExpiration = DateTime.UtcNow.AddSeconds(40)
            };
            await _cache.SetStringAsync("token", token, options);
            // Or
            //byte[] tokenBytes = Encoding.UTF8.GetBytes(token);
            //await _cache.SetStringAsync("token", tokenBytes, options);

            return Ok(token);
        }

        private static string GetTocken()
        {
            string token = "Dhruvil";

            Thread.Sleep(7000);

            return token;
        }
    }
}
