using ABCCarTraders.Models;
using ABCCarTraders.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Repositories
{
    class VehicleTypeRepository
    {
        private readonly DatabaseService _dbService;

        public VehicleTypeRepository()
        {
            _dbService = new DatabaseService();
        }

        public List<VehicleTypeModel> GetTypes()
        {
            string query = $"SELECT * FROM vehicle_types";
            DataTable result = _dbService.ExecuteQuery(query);
            List<VehicleTypeModel> carTypes = new List<VehicleTypeModel>();

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    VehicleTypeModel carType = new VehicleTypeModel
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["name"].ToString()
                    };

                    carTypes.Add(carType);
                }

                return carTypes;
            }
            return null;
        }
        public bool AddType(string carType)
        {
            string query = $"INSERT INTO vehicle_types (name) VALUES ('{carType}')";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
        public bool DeleteCarType(int id)
        {
            string query = $"DELETE FROM vehicle_types WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
    }
}
