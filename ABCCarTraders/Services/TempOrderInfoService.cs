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
    class TempOrderInfoService
    {
        private Dictionary<string, IEnumerable<object>> list;
        public TempOrderInfoService()
        {
            TempVehicleOrderManager.LoadSession();
            TempVehiclePartOrderManager.LoadSession();
        }
        public Dictionary<string, IEnumerable<object>> List()
        {
            list = new Dictionary<string, IEnumerable<object>>
            {
                { "VehicleOrders", TempVehicleOrderManager.list },
                { "VehiclePartOrders", TempVehiclePartOrderManager.list }
            };
            return list;
        }
        public void saveVehicle(int vehicleId, int qty)
        {
            if (vehicleId == 0 || qty == 0) return;
            VehicleOrderInfoModel vehicleOrder = new VehicleOrderInfoModel
            {
                VehicleId = vehicleId,
                Qty = qty
            };

            TempVehicleOrderManager.SaveSession(vehicleOrder);
        }

        public void saveVehiclePart(int partId, int qty)
        {
            VehiclePartOrderInfoModel vehiclePartOrder = new VehiclePartOrderInfoModel
            {
                PartId = partId,
                Qty = qty
            };
            TempVehiclePartOrderManager.SaveSession(vehiclePartOrder);
        }
        public void clearTempData()
        {
            TempVehicleOrderManager.Clear();
            TempVehiclePartOrderManager.Clear();
            list.Clear();
        }
        public void DeleteIndex(string type, int index)
        {
            if (type == "Vehicle")
            {
                TempVehicleOrderManager.RemoveIndex(index);
            }
            else
            {
                TempVehiclePartOrderManager.RemoveIndex(index);
            }
        }

    }
}
