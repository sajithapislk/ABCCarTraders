using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    class VehiclePartCategoryService
    {
        private readonly VehiclePartCategoryRepository _vehiclePartCategoryRepository;

        public VehiclePartCategoryService()
        {
            _vehiclePartCategoryRepository = new VehiclePartCategoryRepository();
        }

        public List<VehiclePartCategoryModel> List()
        {
            return _vehiclePartCategoryRepository.GetCategories();
        }
    }
}
