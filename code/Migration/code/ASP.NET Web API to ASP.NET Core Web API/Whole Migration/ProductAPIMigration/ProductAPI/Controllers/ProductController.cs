using Microsoft.AspNetCore.Mvc;
using ProductAPI.BAL;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class ProductController : ControllerBase
    {
        private readonly IBLProductHandler _bLProductHandler;

        public ProductController(IBLProductHandler bLProductHandler)
        {
            _bLProductHandler = bLProductHandler;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_bLProductHandler.GetProducts());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUser(int id)
        {
            return Ok(_bLProductHandler.GetProductById(id));
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (_bLProductHandler.AddProduct(product))
            {
                return Created("", "Product added successfully");
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            if (_bLProductHandler.UpdateProduct(product))
            {
                return Ok("Product updated successfully");
            }
            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public IActionResult AddProduct(int id)
        {
            if (_bLProductHandler.DeleteProduct(id))
            {
                return Ok("Product deleted successfully");
            }
            return NotFound();
        }
    }
}
