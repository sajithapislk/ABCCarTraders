﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Models
{
    public class VehicleOrderModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public string Address { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
    }
}
