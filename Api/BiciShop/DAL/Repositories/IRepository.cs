using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Create(T item);
        void Save();
        T Delete(T item);
        IEnumerable<T> GetAll();
        T GetItem(int id);
        T Update(T item);
    }
}
