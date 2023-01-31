using Dapper;
using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class ProductDAL
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; Database = ProductDB; Uid = root; Pwd=Admin;");

        #region GetProducts
        public List<Product> GetProducts()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                List<Product> products = connection.Query<Product>("Select * From Product").ToList();

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        #endregion

        #region GetProductById
        public Product GetProductById(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                Product product = connection.QuerySingleOrDefault<Product>("Select * From Product Where Id = " + id);
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        #endregion

        #region AddProduct
        public int AddProduct(Product product)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                int result = connection.Execute("Insert into Product (Name, Quantity, Price) values (@Name, @Quantity, @Price)", product);

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        #endregion

        #region UpdateProduct
        public int UpdateProduct(Product product)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                int result = connection.Execute("Update Product set Name = @Name, Quantity = @Quantity, Price = @Price Where Id = @Id", product);

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        #endregion

        #region DeleteProduct
        public int DeleteProduct(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                int result = connection.Execute("Delete From Product Where Id = " + id);

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }
        #endregion
    }
}
