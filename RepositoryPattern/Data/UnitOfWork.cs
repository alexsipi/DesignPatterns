using RepositoryPattern.Core;
using RepositoryPattern.Repositories;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly string connectionString;
        private DataContext context;
        private IProductRepository productRepository;

        public UnitOfWork(IProductRepository productRepository, DataContext context) {
            this.productRepository = productRepository;
            this.context = context;
        }

        public void insertProduct(Product product) {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void removeProduct(int id) {
            Product product = context.Products.Find(id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public IEnumerable<Product> getProducts() {
            throw new NotImplementedException();
        }

        public void Commit() {
            foreach (var product in context.Products)
            {

            }
        }
    }
}
