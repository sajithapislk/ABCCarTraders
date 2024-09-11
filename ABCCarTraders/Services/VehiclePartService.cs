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

        public bool RegisterVehiclePart(int? vehicleId, int categoryId, string name, string partNumber, string brand, double price, int qty, string description, string fileName)
        {
            if (vehicleId == null || categoryId == null || name == null || partNumber == null || brand == null || price == 0 || qty == 0 || description == null || fileName == null) return false;
            var vehiclePart = new VehiclePartModel
            {
                VehicleId = vehicleId ?? 0,
                CategoryId = categoryId,
                Name = name,
                PartNumber = partNumber,
                Brand = brand,
                Price = price,
                Qty = qty,
                Description = description,
                Img = fileName
            };

            return _vehiclePartRepository.Add(vehiclePart);
        }
        public bool UpdateVehiclePart(int id, int? vehicleId, int categoryId, string name, string partNumber, string brand, double price, int qty, string description)
        {
            if (id == null || vehicleId == null || categoryId == null || name == null || partNumber == null || brand == null || price == null || qty == null || description == null) return false;
            var vehiclePart = new VehiclePartModel
            {
                Id = id,
                VehicleId = vehicleId ?? 0,
                CategoryId = categoryId,
                Name = name,
                PartNumber = partNumber,
                Brand = brand,
                Price = price,
                Qty = qty,
                Description = description
            };

            return _vehiclePartRepository.Update(vehiclePart);
        }
        public bool DeleteVehiclePart(int id)
        {
            return _vehiclePartRepository.Delete(id);
        }
    }
}
