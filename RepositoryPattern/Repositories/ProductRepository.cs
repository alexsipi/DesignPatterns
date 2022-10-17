using System;
using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.Core;

namespace RepositoryPattern.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> products { get; set; }

        public bool Create(Product entity) {
            products.Add(entity);
            return true;
        }

        public bool Delete(int id) {
            Product product = products.FirstOrDefault(e => e.Id == id);
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

        public int GetStock(Product product) {
            return products.Count(); ;
        }

        public bool Update(Product entity) {
            var index = products.FindIndex(e => e.Id == entity.Id);
            if (index > -1)
            {
                products[index] = entity;
            }
            return true;
        }
    }
}
