using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    class VehicleTypeService
    {
        private readonly VehicleTypeRepository _vehicleTypeRepository;

        public VehicleTypeService()
        {
            _vehicleTypeRepository = new VehicleTypeRepository();
        }

        public List<VehicleTypeModel> List()
        {
            return _vehicleTypeRepository.GetTypes();
        }
    }
}
