using Dapper;
using MySql.Data.MySqlClient;
using ProductAPI.Models;

namespace ProductAPI.DAL.Services
{
    public class DBProductContext : IDbProductContext
    {
        private readonly string _connectionString = "Server = localhost; Database = ProductDB; Username = Admin; Password=gs@123;";

        #region GetProducts

        public List<Product> GetProducts()
        {
            try
            {
                List<Product> products = new List<Product>();
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    products = connection.Query<Product>("Select * From Product").ToList();
                }
                return products;
            }
            catch { throw; }
        }

        #endregion GetProducts

        #region GetProductById

        public Product GetProductById(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    Product product = connection.QuerySingleOrDefault<Product>("Select * From Product Where Id = " + id);
                    return product;
                }

            }
            catch { throw; }
        }

        #endregion GetProductById

        #region AddProduct

        public int AddProduct(Product product)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    int result = connection.Execute("Insert into Product (Name, Quantity, Price) values (@Name, @Quantity, @Price)", product);
                    return result;
                }
            }
            catch { throw; }
        }

        #endregion AddProduct

        #region UpdateProduct

        public int UpdateProduct(Product product)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    int result = connection.Execute("Update Product set Name = @Name, Quantity = @Quantity, Price = @Price Where Id = @Id", product);
                    return result;
                }

            }
            catch { throw; }
        }

        #endregion UpdateProduct

        #region DeleteProduct

        public int DeleteProduct(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    int result = connection.Execute("Delete From Product Where Id = " + id);
                    return result;
                }
            }
            catch { throw; }
        }

        #endregion DeleteProduct
    }
}
