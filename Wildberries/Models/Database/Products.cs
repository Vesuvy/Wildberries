﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildberries.Models.Database
{
    internal class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public PickupPoints FK_PickupPoint { get; set; }
    }
}
