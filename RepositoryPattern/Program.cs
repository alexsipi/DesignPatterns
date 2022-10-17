using RepositoryPattern.Data;
using RepositoryPattern.Repositories;

namespace RepositoryPattern
{
    internal class Program
    {
        static void Main(string[] args) {
            var context = new DataContext();
            IProductRepository productRepository = new ProductRepository();
            var uow = new UnitOfWork(productRepository, context);
        }
    }
}
