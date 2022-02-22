﻿using BiciShop.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BiciTypeService : ServiceBase<BiciType>
    {
        public BiciTypeService(IRepository<BiciType> repository) : base(repository)
        {

        }
    }
}
