﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Models
{
    public class VehicleOrderInfoModel
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int OrderId { get; set; }
        public int Qty { get; set; }

    }
}
