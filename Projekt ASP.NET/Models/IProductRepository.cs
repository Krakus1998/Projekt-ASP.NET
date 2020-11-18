﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_ASP.NET.Models
{
    public interface IProductRepository
    {
        public IQueryable<Product> Products { get; }

    }
}
