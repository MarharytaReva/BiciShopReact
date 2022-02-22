using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiciShop.Models
{
    public class CartLine
    {
        public Bicicleta Bicicleta { get; set; }
        public int Count { get; set; }
    }
}
