using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiciShop.Models.Services
{
    public static class Paginator
    {
        private static int paginationSize = 10;
        public static int PaginationSize
        {
            get => paginationSize;
        }
        public static int GetPageCount(int itemCount)
        {
            int pageCount = itemCount / paginationSize;
            if (itemCount % paginationSize != 0)
                pageCount++;
            return pageCount;
        }
        public static IList<T> GetPageItems<T>(IList<T> list, int pageNumber)
        {
            return list.Skip((pageNumber - 1) * paginationSize).Take(paginationSize).ToList();
        }
    }
}
