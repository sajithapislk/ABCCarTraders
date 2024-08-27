using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    class VehiclePartService
    {
        private readonly VehiclePartRepository _vehiclePartRepository;

        public VehiclePartService()
        {
            _vehiclePartRepository = new VehiclePartRepository();
        }

        public List<VehiclePartModel> List()
        {
            return _vehiclePartRepository.All();
        }

        public bool RegisterVehiclePart(int? vehicleId, int categoryId, string name, string partNumber, string brand, decimal price, int qty, string description)
        {
            var vehiclePart = new VehiclePartModel
            {
                VehicleId = vehicleId ?? 0,
                CategoryId = categoryId,
                Name = name,
                PartNumber = partNumber,
                Brand = brand,
                Price = price,
                Qty = qty,
                Description = description
            };

            return _vehiclePartRepository.Add(vehiclePart);
        }
    }
}
