using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories
{
    public interface IRepository<T> where T : class
    {
        public bool Create(T entity);
        public bool Update(T entity);
        public T Get(int id);
        public IEnumerable<T> GetAll();
        public bool Delete(int id);
    }
}
