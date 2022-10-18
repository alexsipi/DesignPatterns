using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core;
using RepositoryPattern.RepositoryPattern.Data;
using RepositoryPattern.RepositoryPattern.Data.UnitOfWork;
using System;

namespace RepositoryPattern
{
    public class Program
    {
        static void Main(string[] args) {

            // In Memory DbContext
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName: "testDb")
                .Options;
            var databaseContext = new MyDbContext(options);
            databaseContext.Database.EnsureCreated();

            // SQL DbContext
            //var contextOptions = new DbContextOptionsBuilder<MyDbContext>()
            //.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test")
            //.Options

            //Unit Of Work
            UnitOfWork uow = new UnitOfWork(databaseContext);

            // Fill In Database
            if (uow.ProductRepository.GetNumProdcuts() <= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    uow.ProductRepository.Create(new Product()
                    {
                        Id = i,
                        Name = $"product{i}",
                        Price = 15.20
                    });
                }
                uow.Save();
            }

            var products = uow.ProductRepository.GetAll();

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
