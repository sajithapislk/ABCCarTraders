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
    class VehicleBrandRepository
    {
        private readonly DatabaseService _dbService;

        public VehicleBrandRepository()
        {
            _dbService = new DatabaseService();
        }

        public List<VehicleBrandModel> GetBrands()
        {
            string query = $"SELECT * FROM vehicle_brands WHERE deleted_at IS NULL";
            DataTable result = _dbService.ExecuteQuery(query);
            List<VehicleBrandModel> carTypes = new List<VehicleBrandModel>();

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    VehicleBrandModel carType = new VehicleBrandModel
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
        public bool AddBrand(string carType)
        {
            string query = $"INSERT INTO vehicle_brands (name) VALUES ('{carType}')";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
        public bool UpdateBrand(int id, string name)
        {
            string query = $"UPDATE vehicle_brands SET name='{name}' WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
        public bool DeleteBrand(int id)
        {
            try
            {
                string query = $"DELETE FROM vehicle_brands WHERE id={id}";
                int rowsAffected = _dbService.ExecuteNonQuery(query);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                string query = $"UPDATE vehicle_brands SET deleted_at=GETDATE() WHERE id={id}";
                int rowsAffected = _dbService.ExecuteNonQuery(query);
                return rowsAffected > 0;
            }
        }
    }
}
