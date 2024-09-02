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
    public class TempCartToPermentService
    {
        private readonly OrderRepository _vehicleOrderRepository;
        private readonly VehicleOrderInfoRepository _vehicleOrderInfoRepository;
        private readonly VehiclePartOrderInfoRepository _vehiclePartOrderInfoRepository;
        private readonly TempOrderInfoService _tempOrderInfoService;

        private Dictionary<string, IEnumerable<object>> _tempList;

        public TempCartToPermentService()
        {
            _vehicleOrderRepository = new OrderRepository();
            _vehicleOrderInfoRepository = new VehicleOrderInfoRepository();
            _vehiclePartOrderInfoRepository = new VehiclePartOrderInfoRepository();
            _tempOrderInfoService = new TempOrderInfoService();

            _tempList = _tempOrderInfoService.List();
        }
        public bool ConvertList(string address)
        {
            try
            {
                SessionManager.LoadSession();
                int userId = SessionManager.CurrentUser.Id;

                var order = new OrderModel
                {
                    CustomerId=userId,
                    Address=address,
                    Amount=0,
                    Status="Pending"
                };
                int orderId = _vehicleOrderRepository.Add(order);

                foreach (var row in _tempList["VehicleOrders"] as List<VehicleOrderInfoModel>)
                {
                    row.OrderId = orderId;
                    _vehicleOrderInfoRepository.Save(row);
                }

                foreach (var row in _tempList["VehiclePartOrders"] as List<VehiclePartOrderInfoModel>)
                {
                    row.OrderId = orderId;
                    _vehiclePartOrderInfoRepository.Save(row);
                }
                _tempOrderInfoService.clearTempData();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
