using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIMigration.Models;

namespace WebAPIMigration.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1
            },
            new Product
            {
                Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M
            },
            new Product
            {
                Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M
            }
        };

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetProduct(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);
            return Created("", product);
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            if (products.FirstOrDefault(x => x.Id == product.Id) != null)
            {
                products.Remove(product);
                products.Add(product);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
            return NotFound();
        }
    }
}
