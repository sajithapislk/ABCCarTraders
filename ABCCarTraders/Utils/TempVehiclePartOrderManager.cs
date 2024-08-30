using ABCCarTraders.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Utils
{
    class TempVehiclePartOrderManager
    {
        private const string SESSION_FILE = "temp_vehicle_part_order.json";
        public static List<VehiclePartOrderInfoModel> list { get; private set; }

        public static void LoadSession()
        {
            if (File.Exists(SESSION_FILE))
            {
                string json = File.ReadAllText(SESSION_FILE);
                list = JsonConvert.DeserializeObject<List<VehiclePartOrderInfoModel>>(json);
            }
            else
            {
                list = new List<VehiclePartOrderInfoModel>();
            }
        }

        public static void SaveSession(VehiclePartOrderInfoModel vehicleOrder)
        {
            LoadSession();
            list.Add(vehicleOrder);
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(SESSION_FILE, json);
        }
        public static void Clear()
        {
            File.Delete(SESSION_FILE);
        }
        public static void RemoveIndex(int index)
        {
            LoadSession();
            list.RemoveAt(index);
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(SESSION_FILE, json);
        }
    }
}
