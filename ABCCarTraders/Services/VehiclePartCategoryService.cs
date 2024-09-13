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
            return _vehiclePartCategoryRepository.All();
        }

        public bool Add(string name)
        {
            if (name == null) return false;
            return _vehiclePartCategoryRepository.AddCategory(name);
        }
        public bool Update(int id, string name)
        {
            if (name == null) return false;
            return _vehiclePartCategoryRepository.UpdateCategory(id,name);
        }
        public bool Delete(int id)
        {
            return _vehiclePartCategoryRepository.DeleteCategory(id);
        }
    }
}
