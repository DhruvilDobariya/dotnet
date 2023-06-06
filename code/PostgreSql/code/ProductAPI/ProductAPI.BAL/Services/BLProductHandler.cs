using ProductAPI.DAL;
using ProductAPI.Models;

namespace ProductAPI.BAL.Services
{
    public class BLProductHandler : IBLProductHandler
    {
        private readonly IDbProductContext _context;

        public BLProductHandler(IDbProductContext context)
        {
            _context = context;
        }

        #region GetProducts

        public List<Product> GetProducts()
        {
            try
            {
                return _context.GetProducts();
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
                return _context.GetProductById(id);
            }
            catch { throw; }
        }

        #endregion GetProductById

        #region AddProduct

        public bool AddProduct(Product product)
        {
            try
            {
                int result = _context.AddProduct(product);

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
                int result = _context.UpdateProduct(product);

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
                int result = _context.DeleteProduct(id);

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
