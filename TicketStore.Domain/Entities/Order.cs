﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Domain.Entities
{
    public class Order
    {
        public int? OrderId { get; set; }
        public int? VoyageId { get; set; }
        public short? Status { get; set; }
    }
}
