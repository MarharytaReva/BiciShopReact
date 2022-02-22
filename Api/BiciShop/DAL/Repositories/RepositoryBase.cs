using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected DbContext context;
        protected DbSet<T> table;
        public RepositoryBase(DbContext context)
        {
            this.context = context;
            table = context.Set<T>();
        }
        public T Create(T item)
        {
            table.Add(item);
           

            return item;
        }

        public T Delete(T item)
        {
            table.Remove(item);
            
            return item;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return table;
        }

        public virtual T GetItem(int id)
        {
            return table.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public virtual T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
