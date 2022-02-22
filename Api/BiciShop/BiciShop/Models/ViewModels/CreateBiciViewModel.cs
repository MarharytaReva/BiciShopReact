using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiciShop.Models.ViewModels
{
    public class CreateBiciViewModel
    {
        public Bicicleta Bicicleta { get; set; } = new Bicicleta();
        public SelectList BiciTypes { get; set; }
        public IFormFile File { get; set; }
    }
}
