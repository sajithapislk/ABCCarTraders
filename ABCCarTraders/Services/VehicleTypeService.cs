﻿using ABCCarTraders.Models;
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
        public bool Add(string name)
        {
            if (name == null) return false;
            return _vehicleTypeRepository.AddType(name);
        }
        public bool Update(int id,string name)
        {
            if (name == null) return false;
            return _vehicleTypeRepository.UpdateType(id,name);
        }
        public bool Delete(int id)
        {
            return _vehicleTypeRepository.DeleteCarType(id);
        }
    }
}
