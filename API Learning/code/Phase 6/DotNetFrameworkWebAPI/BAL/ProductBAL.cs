using DAL;
using Entity;
using System;
using System.Collections.Generic;

namespace BAL
{
    public class ProductBAL
    {
        public string Message { get; set; } = string.Empty;

        #region GetProducts
        public List<Product> GetProducts()
        {
            try
            {
                ProductDAL productDAL = new ProductDAL();
                List<Product> products = productDAL.GetProducts();

                return products;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return null;
            }
        }
        #endregion

        #region GetProductById
        public Product GetProductById(int id)
        {
            try
            {
                ProductDAL productDAL = new ProductDAL();
                Product product = productDAL.GetProductById(id);

                if(product == null)
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
        #endregion

        #region AddProduct
        public bool AddProduct(Product product)
        {
            try
            {
                ProductDAL productDAL = new ProductDAL();
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
        #endregion

        #region UpdateProduct
        public bool UpdateProduct(Product product)
        {
            try
            {
                ProductDAL productDAL = new ProductDAL();
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
        #endregion

        #region DeleteProduct
        public bool DeleteProduct(int id)
        {
            try
            {
                ProductDAL productDAL = new ProductDAL();
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
        #endregion
    }
}
