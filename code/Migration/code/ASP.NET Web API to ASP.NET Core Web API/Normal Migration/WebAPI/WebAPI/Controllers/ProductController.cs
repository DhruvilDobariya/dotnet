using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductController : ApiController
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
        public IHttpActionResult GetProducts()
        {
            return Ok(products);
        }

        [HttpGet]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            if(product != null)
            {
                return Ok(product);
            }
            return NotFound();
            
        }

        [HttpPost]
        public IHttpActionResult AddProduct(Product product)
        {
            products.Add(product);
            return Created("", product);
        }

        [HttpDelete]
        public IHttpActionResult UpdateProduct(Product product)
        {
            if (products.FirstOrDefault(x => x.Id == product.Id) != null)
            {
                products.Remove(product);
                products.Add(product);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
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
