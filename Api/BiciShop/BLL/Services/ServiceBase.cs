using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ServiceBase<T> : IService<T> where T : class
    {
        protected IRepository<T> repository;
        public ServiceBase(IRepository<T> repository)
        {
            this.repository = repository;
        }
        public T Create(T item)
        {
            T result = repository.Create(item);
            repository.Save();
            return result;
        }

        public T Delete(T item)
        {
            T result = repository.Delete(item);
            repository.Save();
            return result;
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public T GetItem(int id)
        {
            return repository.GetItem(id);
        }

        public T Update(T item)
        {
            return repository.Update(item);
        }
    }
}
