using Dapper;
using DapperLearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DapperLearn.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly string _connectionString;
        public ProductController(IConfiguration configuration) 
        {
            _connectionString = configuration.GetConnectionString("DefauultConnection");
        }

        [HttpGet]
        public IActionResult BufferedLearn()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "Select * from Product";
                connection.Open();

                IEnumerable<Product> products = connection.Query<Product>(query, buffered: true);

                connection.Close();

                return Ok(products);
            }
        }

        [HttpGet]
        public IActionResult UnbufferedLearn()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "Select * from Product";
                connection.Open();

                IEnumerable<Product> products = connection.Query<Product>(query, buffered: false);

                connection.Close();

                return Ok(products);
            }
        }
    }
}
