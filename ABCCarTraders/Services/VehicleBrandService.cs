using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    class VehicleBrandService
    {
        private readonly VehicleBrandRepository _vehicleBrandRepository;

        public VehicleBrandService()
        {
            _vehicleBrandRepository = new VehicleBrandRepository();
        }

        public List<VehicleBrandModel> List()
        {
            return _vehicleBrandRepository.GetBrands();
        }
        public bool Add(string name)
        {
            return _vehicleBrandRepository.AddBrand(name);
        }
    }
}
