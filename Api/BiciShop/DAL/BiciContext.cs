using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiciShop.Models
{
    public class BiciContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Bicicleta> Bicicletas { get; set; }
        public DbSet<BiciType> BiciTypes { get; set; }
        public BiciContext(DbContextOptions<BiciContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
       
    }
}
