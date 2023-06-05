using ProductAPI.Models;

namespace ProductAPI.BAL
{
    public interface IBLProductHandler
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}