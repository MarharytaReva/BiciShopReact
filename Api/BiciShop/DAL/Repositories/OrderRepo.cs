using BiciShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderRepo : RepositoryBase<Order>
    {
        public OrderRepo(BiciContext context) : base(context)
        {

        }
    }
}
