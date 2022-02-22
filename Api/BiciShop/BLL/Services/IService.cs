using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IService<T> where T : class 
    {
        T Create(T item);
        T Delete(T item);
        IEnumerable<T> GetAll();
        T GetItem(int id);
       
    }
}
