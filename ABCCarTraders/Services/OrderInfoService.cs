using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    public class OrderInfoService
    {
        private readonly VehicleOrderInfoRepository _vehicleOrderInfoRepository;
        private readonly VehiclePartOrderInfoRepository _vehiclePartOrderInfoRepository;
        public OrderInfoService()
        {
            _vehicleOrderInfoRepository = new VehicleOrderInfoRepository();
            _vehiclePartOrderInfoRepository = new VehiclePartOrderInfoRepository();
        }
        public Dictionary<string, IEnumerable<object>> FindByOrderId(int id)
        {
            List<VehicleOrderInfoModel> vehicleOrderList = _vehicleOrderInfoRepository.FilterByOrderId(id);
            List<VehiclePartOrderInfoModel> vehiclePartOrderList = _vehiclePartOrderInfoRepository.FilterByOrderId(id);

            return new Dictionary<string, IEnumerable<object>>
            {
                { "VehicleOrderList", vehicleOrderList },
                { "VehiclePartOrderList", vehiclePartOrderList }
            };
        }
    }
}
