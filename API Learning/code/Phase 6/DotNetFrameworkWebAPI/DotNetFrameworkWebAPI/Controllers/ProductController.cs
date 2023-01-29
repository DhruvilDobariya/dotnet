using Dapper;
using DotNetFrameworkWebAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
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
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                List<Product> products = connection.Query<Product>("Select * From Product").ToList();

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                return Ok(new { Value = products, Count = products.Count });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        [HttpGet]
        [Route(("api/Products/{id:int}"))]
        public IHttpActionResult GetProductById([FromUri] int id)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                Product product = connection.QuerySingleOrDefault<Product>("Select * From Product Where Id = " + id);
                if (product == null)
                {
                    return NotFound();
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                return Ok(new {product});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        [HttpPost]
        [Route("api/Products")]
        public IHttpActionResult AddProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                int result = connection.Execute("Insert into Product (Name, Quantity, Price) values (@Name, @Quantity, @Price)", product);

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                if (result == 0)
                {
                    return BadRequest("Product not inserted.");
                }


                return Ok("Product added successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        [HttpPut]
        [Route("api/Products")]
        public IHttpActionResult UpdateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                int result = connection.Execute("Update Product set Name = @Name, Quantity = @Quantity, Price = @Price Where Id = @Id", product);

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                if (result == 0)
                {
                    return BadRequest("Product not updated.");
                }


                return Ok("Product updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        [HttpDelete]
        [Route(("api/Products/{id:int}"))]
        public IHttpActionResult DeleteProduct([FromUri] int id)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                int result = connection.Execute("Delete From Product Where Id = " + id);

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                if (result == 0)
                {
                    return BadRequest("Product not deleted");
                }


                return Ok("Product deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}