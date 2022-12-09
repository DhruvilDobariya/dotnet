using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebAPILearn.Models;
using WebAPILearn.Repositories;

namespace WebAPILearn.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    //[Produces("application/json")]
    [FormatFilter]
    public class ProductController : ControllerBase
    {
        private readonly ICRUDRepository<Product> _curdRepository;
        public ProductController(ICRUDRepository<Product> crudRepository)
        {
            _curdRepository = crudRepository;
        }

        //[HttpGet("{format?}")]
        [HttpGet("")]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            IEnumerable<Product> list = await _curdRepository.GetAllAsync();
            //if (list.IsNullOrEmpty())
            //{
            //    return Ok(_curdRepository.Message);
            //}
            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProductById([FromRoute] int id)
        {
            Product product = await _curdRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound(_curdRepository.Message);
            }
            return Ok(product);
        }

        [HttpPost("")]
        public async Task<ActionResult<Product>> AddProduct([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                bool flag = await _curdRepository.InsertAsync(product);
                if (flag)
                {
                    return Ok(product);
                }
                return BadRequest(_curdRepository.Message);
            }
            return BadRequest(ModelState);
        }

        [HttpPost("AddMultipleProduct")]
        public async Task<ActionResult<List<Product>>> AddMultipleProduct([FromBody] List<Product> products)
        {
            if (ModelState.IsValid)
            {
                bool flag = await _curdRepository.InsertRangeAsync(products);
                if (flag)
                {
                    return Ok(products);
                }
                return BadRequest(_curdRepository.Message);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Product>> AddProduct([FromRoute] int id, [FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                bool flag = await _curdRepository.UpdateAsync(id, product);
                if (flag)
                {
                    return Ok(product);
                }
                return BadRequest(_curdRepository.Message);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<string>> DeleteProduct([FromRoute] int id)
        {
            bool flag = await _curdRepository.DeleteAsync(id);
            if (!flag)
            {
                return BadRequest(_curdRepository.Message);
            }
            return Ok(_curdRepository.Message);
        }
    }
}
