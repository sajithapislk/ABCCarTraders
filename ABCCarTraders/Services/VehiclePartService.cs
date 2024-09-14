using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using ABCCarTraders.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool RegisterVehiclePart(int? vehicleId, int? categoryId, string name, string partNumber, string brand, double price, int qty, string description, string fileName)
        {
            if (Validation.IsEmpty(name, partNumber, brand,  description, fileName) || vehicleId == null || categoryId == null)
            {
                MessageBox.Show("Validation failed: Some fields are empty or invalid.");
                return false;
            }
            var vehiclePart = new VehiclePartModel
            {
                VehicleId = vehicleId.Value,
                CategoryId = categoryId.Value,
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
        public bool UpdateVehiclePart(int? id, int? vehicleId, int? categoryId, string name, string partNumber, string brand, double price, int qty, string description)
        {
            if (Validation.IsEmpty(name, partNumber, brand, description) || vehicleId == null || categoryId == null)
            {
                MessageBox.Show("Validation failed: Some fields are empty or invalid.");
                return false;
            }
            var vehiclePart = new VehiclePartModel
            {
                Id = id.Value,
                VehicleId = vehicleId.Value,
                CategoryId = categoryId.Value,
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
        public VehiclePartModel FindById(int id)
        {
            return _vehiclePartRepository.FindById(id);
        }

    }
}
