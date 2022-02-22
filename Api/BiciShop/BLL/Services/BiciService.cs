using BiciShop.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BiciService : ServiceBase<Bicicleta>
    {
        public string DefaultStr => "all";
        public BiciService(IRepository<Bicicleta> repository) : base(repository)
        {

        }
        public Task<Bicicleta> CreateAsync(Bicicleta bicicleta)
        {
            Task<Bicicleta> task = new Task<Bicicleta>(() =>
            {
                repository.Create(bicicleta);
                repository.Save();
                return bicicleta;
            });
            task.Start();
            return task;
        }
        public Task<Bicicleta> UpdateAsync(Bicicleta bicicleta)
        {
            Task<Bicicleta> task = new Task<Bicicleta>(() =>
            {
                repository.Update(bicicleta);
                repository.Save();
                return bicicleta;
            });
            task.Start();
            return task;
        }
        public Task<Bicicleta> DeleteAsync(Bicicleta bicicleta)
        {
            Task<Bicicleta> task = new Task<Bicicleta>(() =>
            {
                repository.Delete(bicicleta);
                repository.Save();
                return bicicleta;
            });
            task.Start();
            return task;
        }
        public Task<IEnumerable<Bicicleta>> GetAllAsync()
        {
            Task<IEnumerable<Bicicleta>> task = new Task<IEnumerable<Bicicleta>>(() =>
            {
                return repository.GetAll();
            });
            task.Start();
            return task;
        }
        public Task<Bicicleta> GetItemAsync(int id)
        {
            Task<Bicicleta> task = new Task<Bicicleta>(() =>
            {
                return repository.GetItem(id);
            });
            task.Start();
            return task;
        }
        public IEnumerable<Bicicleta> Filter(string color, string type, IEnumerable<Bicicleta> bicicletas)
        {
            if (color != DefaultStr)
                bicicletas = bicicletas.Where(x => x.Color.ToLower() == color.ToLower() || x.Color.ToLower().Contains(color.ToLower())).ToList();
            if (type != DefaultStr)
                bicicletas = bicicletas.Where(x => x.BiciType.BiciTypeName.ToLower() == type.ToLower()).ToList();
            return bicicletas;
        }
        public IEnumerable<Bicicleta> Search(string searchText)
        {
            var bicicletas = repository.GetAll().ToList();
            if (!string.IsNullOrEmpty(searchText))
                bicicletas = bicicletas.Where(x => x.Title.ToLower().Contains(searchText.ToLower())).ToList();

            return bicicletas;
        }
        public void CreateOrUpdate(Bicicleta bicicleta)
        {
            if (bicicleta.BicicletaId == 0)
            {
                bicicleta.BiciTypeId = 1;
                repository.Create(bicicleta);
            }
            else
            {
                ((BiciRepo)repository).Update(bicicleta);
            }
            repository.Save();
        }
    }
}
