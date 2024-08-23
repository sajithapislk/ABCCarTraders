using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Models
{
    class VehicleModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int? Type { get; set; }
        public int? Brand { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public double Price { get; set; }
        public string Engine { get; set; }
        public string EngineCode { get; set; }
        public string Torque { get; set; }
        public string AFC { get; set; }
        public string Power { get; set; }
    }
}
