using RepositoryPattern.Core;
using System.Collections.Generic;

namespace RepositoryPattern.Data
{
    public interface IUnitOfWork
    {
        void insertProduct(Product product);
        void removeProduct(int id);
        IEnumerable<Product> getProducts();
        void Commit();
    }
}
