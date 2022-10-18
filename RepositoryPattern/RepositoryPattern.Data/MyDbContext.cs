using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core;

namespace RepositoryPattern.RepositoryPattern.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products;

        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasKey(Product => Product.Id);
        }
    }
}
