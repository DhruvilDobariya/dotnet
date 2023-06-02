using Entity;
using ProductAPI.DAL;
using System;
using System.Collections.Generic;

namespace ProductAPI.BAL
{
    public class BLProduct
    {
        public string Message { get; set; } = string.Empty;

        #region GetProducts

        public List<Product> GetProducts()
        {
            try
            {
                DBProductContext productDAL = new DBProductContext();
                List<Product> products = productDAL.GetProducts();

                return products;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return null;
            }
        }

        #endregion GetProducts

        #region GetProductById

        public Product GetProductById(int id)
        {
            try
            {
                DBProductContext productDAL = new DBProductContext();
                Product product = productDAL.GetProductById(id);

                if (product == null)
                {
                    Message = "Product not found.";
                }
                return product;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return null;
            }
        }

        #endregion GetProductById

        #region AddProduct

        public bool AddProduct(Product product)
        {
            try
            {
                DBProductContext productDAL = new DBProductContext();
                int result = productDAL.AddProduct(product);

                if (result > 0)
                {
                    Message = "Product added successfullly.";
                    return true;
                }

                Message = "Product does not added successfully";
                return false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        #endregion AddProduct

        #region UpdateProduct

        public bool UpdateProduct(Product product)
        {
            try
            {
                DBProductContext productDAL = new DBProductContext();
                int result = productDAL.UpdateProduct(product);

                if (result > 0)
                {
                    Message = "Product updated successfullly.";
                    return true;
                }

                Message = "Product does not updated successfully";
                return false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        #endregion UpdateProduct

        #region DeleteProduct

        public bool DeleteProduct(int id)
        {
            try
            {
                DBProductContext productDAL = new DBProductContext();
                int result = productDAL.DeleteProduct(id);

                if (result > 0)
                {
                    Message = "Product deleted successfullly.";
                    return true;
                }

                Message = "Product not found.";
                return false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        #endregion DeleteProduct
    }
}