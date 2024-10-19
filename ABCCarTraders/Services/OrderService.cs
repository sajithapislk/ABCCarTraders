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
    class OrderService
    {
        private readonly OrderRepository _vehicleOrderRepository;

        public OrderService()
        {
            _vehicleOrderRepository = new OrderRepository();
        }
        public OrderModel FindById(int id)
        {
            return _vehicleOrderRepository.FindById(id);
        }
        public List<OrderModel> List()
        {
            return _vehicleOrderRepository.All();
        }
        public List<OrderModel> AllByCustomer()
        {
            return _vehicleOrderRepository.AllByCustomer();
        }

        public bool MakeOrder(string address)
        {
            if (address == null) return false;
            if (!SessionManager.IsLoggedIn()) return false;

            OrderModel order = new OrderModel
            {
                CustomerId = SessionManager.CurrentUser.Id,
                Address= address,
                Amount = 0,
                Status="Pending"
            };

            return 0 >_vehicleOrderRepository.Add(order);
        }
        public bool UpdateStatus(int id,string status)
        {
            return _vehicleOrderRepository.UpdateStatus(id,status);
        }
        public bool Delete(int id)
        {
            return _vehicleOrderRepository.Delete(id);
        }
    }
}
