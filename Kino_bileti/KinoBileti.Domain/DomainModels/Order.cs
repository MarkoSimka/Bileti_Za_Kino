﻿using KinoBileti.Domain.DomainModels;
using KinoBileti.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoBileti.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public BiletiUserApplication User { get; set; }

        public IEnumerable<ProductInOrder> ProductInOrders { get; set; }
    }
}