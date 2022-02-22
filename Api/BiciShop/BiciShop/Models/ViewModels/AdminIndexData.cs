using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiciShop.Models
{
    public class AdminIndexData
    {
        public IEnumerable<Bicicleta> Bicicletas { get; set; }
        public int PageCount { get; set; }
    }
}
