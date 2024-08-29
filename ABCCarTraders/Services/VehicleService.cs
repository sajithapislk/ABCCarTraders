using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    class VehicleService
    {
        private readonly VehicleRepository _vehicleRepository;

        public VehicleService()
        {
            _vehicleRepository = new VehicleRepository();
        }

        public List<VehicleModel> List()
        {
            return _vehicleRepository.All();
        }

        public bool RegisterVehicle(string name, string number, int type, int brand, string color, string year, double price, string engine, string engineCode, string torque, string afc, string power,int qty)
        {
            var vehicle = new VehicleModel
            {
                Name = name,
                Number = number,
                Type = type,
                Brand = brand,
                Color = color,
                Year = year,
                Price = price,
                Engine = engine,
                EngineCode = engineCode,
                Torque = torque,
                AFC = afc,
                Power = power,
                Qty= qty
            };
            return _vehicleRepository.Add(vehicle);
        }
    }
}
