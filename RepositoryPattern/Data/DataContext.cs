using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core;
using System;

namespace RepositoryPattern.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products;
        private Func<object, object> value;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=.;Database=test;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
