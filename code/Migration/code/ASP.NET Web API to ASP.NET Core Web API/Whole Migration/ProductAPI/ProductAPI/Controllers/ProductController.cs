using ProductAPI.BAL;
using ProductAPI.Domain;
using System.Web.Http;

namespace ProductAPI.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            return Ok(new BLProductHandler().GetProducts());
        }

        [HttpGet]
        public IHttpActionResult GetUser(int id)
        {
            return Ok(new BLProductHandler().GetProductById(id));
        }

        [HttpPost]
        public IHttpActionResult AddProduct(Product product)
        {
            if(new BLProductHandler().AddProduct(product))
            {
                return Created("", "Product added successfully");
            }
            return BadRequest();
        }

        [HttpPut]
        public IHttpActionResult Update(Product product)
        {
            if (new BLProductHandler().UpdateProduct(product))
            {
                return Ok("Product updated successfully");
            }
            return BadRequest();
        }

        [HttpDelete]
        public IHttpActionResult AddProduct(int id)
        {
            if (new BLProductHandler().DeleteProduct(id))
            {
                return Ok("Product deleted successfully");
            }
            return NotFound();
        }
    }
}
