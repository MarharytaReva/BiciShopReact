using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiciShop.Models
{
    public class Cart
    {
        private List<CartLine> cartLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get => cartLines;
            set
            {
                cartLines = value;
            }
        }

        public void Add(Bicicleta bicicleta, int count)
        {
            CartLine cartLine = cartLines.Where(x => x.Bicicleta.BicicletaId == bicicleta.BicicletaId)
                                         .FirstOrDefault();
            if(cartLine is null)
            {
                CartLine newItem = new CartLine()
                {
                    Count = count,
                    Bicicleta = bicicleta
                };
                cartLines.Add(newItem);
            }
            else
            {
                cartLine.Count += count;
            }
        }
        public void Remove(Bicicleta bicicleta)
        {
            cartLines.RemoveAll(x => x.Bicicleta.BicicletaId == bicicleta.BicicletaId);
        }
        public void Clear()
        {
            cartLines.Clear();
        }
        public double GetTotalValue()
        {
            return cartLines.Sum(x => x.Bicicleta.Price);
        }
    }
}
