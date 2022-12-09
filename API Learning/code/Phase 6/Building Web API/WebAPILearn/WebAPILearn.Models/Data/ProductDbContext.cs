using Microsoft.EntityFrameworkCore;

namespace WebAPILearn.Models.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Product { get; set; }
    }
}
