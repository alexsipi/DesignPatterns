using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core;
using System;
using System.Threading.Tasks;

namespace RepositoryPattern.RepositoryPattern.Data
{
    public static class InMemoryDbContext
    {
        public static async Task<MyDbContext> GetDatabaseContext() {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new MyDbContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.Products.CountAsync() <= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    databaseContext.Products.Add(new Product()
                    {
                        Id = i,
                        Name = $"product{i}",
                        Price = 15.20
                    });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }
    }
}
