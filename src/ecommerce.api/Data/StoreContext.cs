using ecommerce.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.api.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
