using RepositoryPattern.Core;
using System;

namespace RepositoryPattern.RepositoryPattern.Domain.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public int GetNumProdcuts();
    }
}
