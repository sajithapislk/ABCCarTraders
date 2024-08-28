﻿using ABCCarTraders.Models;
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
        public TempOrderInfoService()
        {
            TempVehicleOrderManager.LoadSession();
            TempVehiclePartOrderManager.LoadSession();
        }
        public Dictionary<string, IEnumerable<object>> List()
        {
            return new Dictionary<string, IEnumerable<object>>
            {
                { "VehicleOrders", TempVehicleOrderManager.list },
                { "VehiclePartOrders", TempVehiclePartOrderManager.list }
            };
        }
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
