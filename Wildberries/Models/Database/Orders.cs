﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildberries.Models.Database
{
    internal class Orders
    {
        public string Id { get; set; }
        public PickupPoints FK_PickupPoint { get; set; }
        public Clients FK_Client { get; set; }
    }
}
