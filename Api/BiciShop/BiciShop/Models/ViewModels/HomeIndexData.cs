using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiciShop.Models
{
    public class HomeIndexData
    {
        public string SearchText { get; set; }
        public IEnumerable<Bicicleta> Bicicletas { get; set; }
        public int PageNumber { get; set; }
        public int PageCount { get; set; }
        public SelectList Colors { get; set; }
        public SelectList BiciTypes { get; set; }
        public string Color { get; set; }
        public string BiciType { get; set; }
        public string Text { get; set; }
        public SortType SortType { get; set; }
        public HomeIndexData()
        {
            string defaultSelect = "all";
            PageNumber = 1;
            Color = defaultSelect;
            BiciType = defaultSelect;
            SortType = SortType.None;
        }
    }
}
