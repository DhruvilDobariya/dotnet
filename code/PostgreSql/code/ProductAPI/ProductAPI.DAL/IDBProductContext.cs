using ProductAPI.Models;

namespace ProductAPI.DAL
{
    public interface IDbProductContext
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        int AddProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(int id);
    }
}