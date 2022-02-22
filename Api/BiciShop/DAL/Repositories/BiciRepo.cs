using BiciShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BiciRepo : RepositoryBase<Bicicleta>
    {
        public BiciRepo(BiciContext context) : base(context)
        {

        }
        public override Bicicleta GetItem(int id)
        {
            return table.Include(x => x.BiciType).FirstOrDefault(x => x.BicicletaId == id);
        }
        public override IEnumerable<Bicicleta> GetAll()
        {
            return table.Include(x => x.BiciType);
        }
        public override Bicicleta Update(Bicicleta item)
        {
            Bicicleta entity = table.FirstOrDefault(x => x.BicicletaId == item.BicicletaId);
            entity.Color = item.Color;
            entity.IssueYear = item.IssueYear;
            entity.Price = item.Price;
            entity.Title = item.Title;
            entity.Weight = item.Weight;
            entity.WheelDiameter = item.WheelDiameter;
            entity.Photo = item.Photo;

            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return item;
        }
    }
}
