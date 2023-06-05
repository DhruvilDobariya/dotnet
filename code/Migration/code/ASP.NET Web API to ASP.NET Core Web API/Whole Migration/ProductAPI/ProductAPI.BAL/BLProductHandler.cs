using ProductAPI.DAL;
using ProductAPI.Domain;
using System.Collections.Generic;

namespace ProductAPI.BAL
{
    public class BLProductHandler
    {
        #region GetProducts

        public List<Product> GetProducts()
        {
            try
            {
                return new DBProductContext().GetProducts();
            }
            catch
            {
                throw;
            }
        }

        #endregion GetProducts

        #region GetProductById

        public Product GetProductById(int id)
        {
            try
            {
                return new DBProductContext().GetProductById(id);
            }
            catch { throw; }
        }

        #endregion GetProductById

        #region AddProduct

        public bool AddProduct(Product product)
        {
            try
            {
                int result = new DBProductContext().AddProduct(product);

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch { throw; }
        }

        #endregion AddProduct

        #region UpdateProduct

        public bool UpdateProduct(Product product)
        {
            try
            {
                int result = new DBProductContext().UpdateProduct(product);

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch { throw; }
        }

        #endregion UpdateProduct

        #region DeleteProduct

        public bool DeleteProduct(int id)
        {
            try
            {
                int result = new DBProductContext().DeleteProduct(id);

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch { throw; }
        }

        #endregion DeleteProduct
    }
}