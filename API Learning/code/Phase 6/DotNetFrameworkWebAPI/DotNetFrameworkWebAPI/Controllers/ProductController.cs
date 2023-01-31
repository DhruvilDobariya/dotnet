using BAL;
using Entity;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Http;

namespace DotNetFrameworkWebAPI.Controllers
{
    public class ProductController : ApiController
    {

        //GET: Product
        [HttpGet]
        [Route("api/Products")]
        public IHttpActionResult GetProducts()
        {
            ProductBAL productBAL = new ProductBAL();
            List<Product> products = productBAL.GetProducts();

            if (products == null)
            {
                return BadRequest(productBAL.Message);
            }

            return Ok(new { Value = products, Count = products.Count });
        }

        [HttpGet]
        [Route(("api/Products/{id:int}"))]
        public IHttpActionResult GetProductById([FromUri] int id)
        {
            ProductBAL productBAL = new ProductBAL();
            Product product = productBAL.GetProductById(id);

            if (product == null)
            {
                return BadRequest(productBAL.Message);
            }

            return Ok(new { product });
        }

        [HttpPost]
        [Route("api/Products")]
        public IHttpActionResult AddProduct([FromBody] Product product)
        {
            ProductBAL productBAL = new ProductBAL();

            if (!productBAL.AddProduct(product))
            {
                return BadRequest(productBAL.Message);
            }

            return Ok(productBAL.Message);
        }

        [HttpPut]
        [Route("api/Products")]
        public IHttpActionResult UpdateProduct([FromBody] Product product)
        {
            ProductBAL productBAL = new ProductBAL();

            if (!productBAL.UpdateProduct(product))
            {
                return BadRequest(productBAL.Message);
            }

            return Ok(productBAL.Message);
        }

        [HttpDelete]
        [Route(("api/Products/{id:int}"))]
        public IHttpActionResult DeleteProduct([FromUri] int id)
        {
            ProductBAL productBAL = new ProductBAL();

            if (!productBAL.DeleteProduct(id))
            {
                return BadRequest(productBAL.Message);
            }

            return Ok(productBAL.Message);
        }
    }
}