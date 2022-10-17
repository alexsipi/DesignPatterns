using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Core;

namespace RepositoryPattern.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public int GetStock(Product product);
    }
}
