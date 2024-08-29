using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Models
{
    public class VehiclePartOrderInfoModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PartId { get; set; }
        public int Qty { get; set; }
    }
}
