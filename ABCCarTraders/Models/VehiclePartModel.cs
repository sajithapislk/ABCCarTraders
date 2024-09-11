using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Models
{
    public class VehiclePartModel
    {
        public int? Id { get; set; }
        public int VehicleId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Img { get; set; }
    }
}
