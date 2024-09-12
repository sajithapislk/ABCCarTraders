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
                        Price = Convert.ToDouble(row["price"]),
                        Qty = Convert.ToInt32(row["qty"]),
                        Description = row["description"].ToString(),
                        Img = row["img"].ToString()
                    };

                    vehicleParts.Add(vehicle);
                }

                return vehicleParts;
            }
            return null;
        }
        public bool Add(VehiclePartModel vehiclePart)
        {
            string query = @"INSERT INTO vehicle_parts (vehicle_id, category_id, name, part_number, brand, price, qty, description, created_at, updated_at, img) VALUES (@vehicleId, @categoryId, @name, @partNumber, @brand, @price, @qty, @description, @createdAt, @updatedAt, @img)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@vehicleId", SqlDbType.Int) { Value = vehiclePart.VehicleId },
                new SqlParameter("@categoryId", SqlDbType.Int) { Value = vehiclePart.CategoryId },
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = vehiclePart.Name },
                new SqlParameter("@partNumber", SqlDbType.NVarChar) { Value = vehiclePart.PartNumber },
                new SqlParameter("@brand", SqlDbType.NVarChar) { Value = vehiclePart.Brand },
                new SqlParameter("@price", SqlDbType.Decimal) { Value = vehiclePart.Price },
                new SqlParameter("@qty", SqlDbType.Int) { Value = vehiclePart.Qty },
                new SqlParameter("@description", SqlDbType.NVarChar) { Value = vehiclePart.Description },
                new SqlParameter("@createdAt", SqlDbType.DateTime) { Value = DateTime.Now },
                new SqlParameter("@updatedAt", SqlDbType.DateTime) { Value = DateTime.Now },
                new SqlParameter("@img", SqlDbType.NVarChar) { Value = vehiclePart.Img },
            };

            int rowsAffected = _dbService.ExecuteNonQueryWithParameters(query, parameters);
            return rowsAffected > 0;
        }

        public bool Update(VehiclePartModel vehiclePart)
        {
            string query = @"UPDATE vehicle_parts 
                    SET vehicle_id = @vehicleId, 
                        category_id = @categoryId, 
                        name = @name, 
                        part_number = @partNumber, 
                        brand = @brand, 
                        price = @price, 
                        qty = @qty, 
                        description = @description, 
                        updated_at = @updatedAt
                    WHERE id = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = vehiclePart.Id },
                new SqlParameter("@vehicleId", SqlDbType.Int) { Value = vehiclePart.VehicleId },
                new SqlParameter("@categoryId", SqlDbType.Int) { Value = vehiclePart.CategoryId },
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = vehiclePart.Name },
                new SqlParameter("@partNumber", SqlDbType.NVarChar) { Value = vehiclePart.PartNumber },
                new SqlParameter("@brand", SqlDbType.NVarChar) { Value = vehiclePart.Brand },
                new SqlParameter("@price", SqlDbType.Decimal) { Value = vehiclePart.Price },
                new SqlParameter("@qty", SqlDbType.Int) { Value = vehiclePart.Qty },
                new SqlParameter("@description", SqlDbType.NVarChar) { Value = vehiclePart.Description },
                new SqlParameter("@updatedAt", SqlDbType.DateTime) { Value = DateTime.Now }
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

        public VehiclePartModel FindById(int id)
        {
            string query = $"SELECT * FROM vehicle_parts WHERE id={id}";
            DataTable result = _dbService.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                VehiclePartModel vehiclePart = new VehiclePartModel
                {
                    Id = Convert.ToInt32(row["id"]),
                    VehicleId = Convert.ToInt32(row["vehicle_id"]),
                    CategoryId = Convert.ToInt32(row["category_id"]),
                    Name = row["name"].ToString(),
                    PartNumber = row["part_number"].ToString(),
                    Brand = row["brand"].ToString(),
                    Price = Convert.ToDouble(row["price"]),
                    Qty = Convert.ToInt32(row["qty"]),
                    Description = row["description"].ToString(),
                    Img = row["img"].ToString()
                };

                return vehiclePart;
            }
            return null;
        }
    }
}
