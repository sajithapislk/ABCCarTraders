using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    public class VehicleService
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
            if (name == null || number == null || type == 0 || brand == 0 || color == null || year == null || price == 0 || engine == null || engineCode == null || torque == null || afc == null || power == null || qty == 0) return false;
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
        public bool UpdateVehicle(int id, string name, string number, int type, int brand, string color, string year, double price, string engine, string engineCode, string torque, string afc, string power,int qty)
        {
            if (name == null || number == null || type == 0 || brand == 0 || color == null || year == null || price == 0 || engine == null || engineCode == null || torque == null || afc == null || power == null || qty == 0) return false;
            var vehicle = new VehicleModel
            {
                Id=id,
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
            return _vehicleRepository.Update(vehicle);
        }
        public bool DeleteVehicle(int id)
        {
            return _vehicleRepository.Delete(id);
        }

        public VehicleModel FindById(int id)
        {
            return _vehicleRepository.FindById(id);
        }
    }
}
