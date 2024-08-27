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
        public void saveVehicle(int vehicleId, int qty)
        {
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

    }
}
