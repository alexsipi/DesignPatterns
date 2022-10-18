using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core;
using RepositoryPattern.RepositoryPattern.Domain.Core.Repositories;

namespace RepositoryPattern.RepositoryPattern.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private MyDbContext context;
        private DbSet<Product> products;

        public ProductRepository(MyDbContext context) {
            this.context = context;
            this.products = context.Set<Product>();
        }

        public bool Create(Product entity) {
            products.Add(entity);
            return true;
        }

        public bool Delete(int id) {
            Product product = products.Find(id);
            if (product != null)
            {
                products.Remove(product);
            }
            return true;
        }

        public Product Get(int id) {
            Product product = products.FirstOrDefault(e => e.Id == id);
            return product;
        }

        public IEnumerable<Product> GetAll() {
            return products;
        }

        public int GetNumProdcuts() {
            return products.Count(); ;
        }

        public bool Update(Product entity) {
            products.Update(entity);
            return true;
        }
    }
}
