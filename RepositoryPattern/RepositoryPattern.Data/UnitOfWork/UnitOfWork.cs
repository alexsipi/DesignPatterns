using RepositoryPattern.Core;
using RepositoryPattern.RepositoryPattern.Data.Repositories;
using RepositoryPattern.RepositoryPattern.Domain.Core.Repositories;
using RepositoryPattern.RepositoryPattern.Domain.Core.UnitOfWork;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.RepositoryPattern.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private MyDbContext context;
        private IProductRepository productRepository;

        public IProductRepository ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new ProductRepository(this.context);
                }
                return productRepository;
            }
        }

        public UnitOfWork(MyDbContext context) {
            this.context = context;
        }

        public IEnumerable<Product> getProducts() {
            throw new NotImplementedException();
        }

        public void Save() {
            context.SaveChanges();
        }

        public void Dispose() {
            context.Dispose();
        }
    }
}
