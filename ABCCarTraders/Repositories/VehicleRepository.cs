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
    class VehicleRepository
    {
        private readonly DatabaseService _dbService;

        public VehicleRepository()
        {
            _dbService = new DatabaseService();
        }

        public List<VehicleModel> All()
        {
            string query = $"SELECT * FROM vehicles";
            DataTable result = _dbService.ExecuteQuery(query);
            List<VehicleModel> vehicles = new List<VehicleModel>();

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    VehicleModel vehicle = new VehicleModel
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["name"].ToString(),
                        Number = row["number"].ToString(),
                        Type = Convert.ToInt32(row["type_id"]),
                        Brand = Convert.ToInt32(row["brand_id"]),
                        Color = row["color"].ToString(),
                        Year = row["year"].ToString(),
                        Price = Convert.ToDouble(row["price"]),
                        Engine = row["engine"].ToString(),
                        EngineCode = row["engine_code"].ToString(),
                        Torque = row["torque"].ToString(),
                        AFC = row["afc"].ToString(),
                        Power = row["power"].ToString()
                    };

                    vehicles.Add(vehicle);
                }

                return vehicles;
            }
            return null;
        }
        public bool Add(VehicleModel vehicle)
        {
            string query = $"INSERT INTO vehicles (name, number, type_id, brand_id, color, year, price, engine, engine_code, torque, afc, power, qty) VALUES (@name, @number, @type, @brand, @color, @year, @price, @engine, @engine_code, @torque, @afc, @power, @qty)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", vehicle.Name),
                new SqlParameter("@number", vehicle.Number),
                new SqlParameter("@type", vehicle.Type),
                new SqlParameter("@brand", vehicle.Brand),
                new SqlParameter("@color", vehicle.Color),
                new SqlParameter("@year", vehicle.Year),
                new SqlParameter("@price", vehicle.Price),
                new SqlParameter("@engine", vehicle.Engine),
                new SqlParameter("@engine_code", vehicle.EngineCode),
                new SqlParameter("@torque", vehicle.Torque),
                new SqlParameter("@afc", vehicle.AFC),
                new SqlParameter("@power", vehicle.Power),
                new SqlParameter("@qty", vehicle.Qty)
            };

            int rowsAffected = _dbService.ExecuteNonQueryWithParameters(query, parameters);
            return rowsAffected > 0;
        }
        public bool Delete(int id)
        {
            string query = $"DELETE FROM vehicles WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
    }
}
