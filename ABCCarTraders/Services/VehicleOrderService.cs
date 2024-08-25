using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using ABCCarTraders.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    class VehicleOrderService
    {
        private readonly VehicleOrderRepository _vehicleOrderRepository;

        public VehicleOrderService()
        {
            _vehicleOrderRepository = new VehicleOrderRepository();
        }

        public List<VehicleOrderModel> List()
        {
            return _vehicleOrderRepository.All();
        }

        public bool MakeOrder(string address)
        {
            if (!SessionManager.IsLoggedIn()) return false;

            VehicleOrderModel order = new VehicleOrderModel
            {
                CustomerId = SessionManager.CurrentUser.Id,
                Address= address,
                Amount = 0,
                Status="Pending"
            };

            return _vehicleOrderRepository.Add(order);
        }
    }
}
