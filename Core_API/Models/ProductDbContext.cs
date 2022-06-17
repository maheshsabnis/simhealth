using Microsoft.EntityFrameworkCore;

namespace Core_API.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<ProductInfo> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
