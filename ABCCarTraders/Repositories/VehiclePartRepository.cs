using ABCCarTraders.Models;
using ABCCarTraders.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Repositories
{
    class VehiclePartRepository
    {
        private readonly DatabaseService _dbService;

        public VehiclePartRepository()
        {
            _dbService = new DatabaseService();
        }

        public List<VehiclePartModel> All()
        {
            string query = $"SELECT * FROM vehicle_parts";
            DataTable result = _dbService.ExecuteQuery(query);
            List<VehiclePartModel> vehicleParts = new List<VehiclePartModel>();

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    VehiclePartModel vehicle = new VehiclePartModel
                    {
                        Id = Convert.ToInt32(row["id"]),
                        VehicleId = Convert.ToInt32(row["vehicle_id"]),
                        CategoryId = Convert.ToInt32(row["category_id"]),
                        Name = row["name"].ToString(),
                        PartNumber = row["part_number"].ToString(),
                        Brand = row["brand"].ToString(),
                        Price = Convert.ToDecimal(row["price"]),
                        Qty = Convert.ToInt32(row["qty"]),
                        Description = row["description"].ToString()
                    };

                    vehicleParts.Add(vehicle);
                }

                return vehicleParts;
            }
            return null;
        }
        public bool Add(VehiclePartModel vehiclePart)
        {
            string query = @"INSERT INTO vehicle_parts (vehicle_id, category_id, name, part_number, brand, price, qty, description, created_at, updated_at) VALUES (@vehicleId, @categoryId, @name, @partNumber, @brand, @price, @qty, @description, @createdAt, @updatedAt)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@vehicleId", vehiclePart.VehicleId ?? (object)DBNull.Value),
                new SqlParameter("@categoryId", vehiclePart.CategoryId),
                new SqlParameter("@name", vehiclePart.Name),
                new SqlParameter("@partNumber", vehiclePart.PartNumber),
                new SqlParameter("@brand", vehiclePart.Brand),
                new SqlParameter("@price", vehiclePart.Price),
                new SqlParameter("@qty", vehiclePart.Qty),
                new SqlParameter("@description", vehiclePart.Description),
                new SqlParameter("@createdAt", DateTime.Now),
                new SqlParameter("@updatedAt", DateTime.Now)
            };

            int rowsAffected = _dbService.ExecuteNonQueryWithParameters(query, parameters);
            return rowsAffected > 0;
        }
        public bool Delete(int id)
        {
            string query = $"DELETE FROM vehicle_parts WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
    }
}
