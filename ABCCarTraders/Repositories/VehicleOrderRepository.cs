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
    class VehicleOrderRepository
    {
        private readonly DatabaseService _dbService;

        public VehicleOrderRepository()
        {
            _dbService = new DatabaseService();
        }

        public List<VehicleOrderModel> All()
        {
            string query = $"SELECT * FROM vehicle_orders";
            DataTable result = _dbService.ExecuteQuery(query);
            List<VehicleOrderModel> vehicle_orders = new List<VehicleOrderModel>();

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    VehicleOrderModel order = new VehicleOrderModel
                    {
                        Id = Convert.ToInt32(row["id"]),
                        CustomerId = Convert.ToInt32(row["customer_id"]),
                        Address = row["address"].ToString(),
                        Status = row["status"].ToString(),
                    };

                    vehicle_orders.Add(order);
                }

                return vehicle_orders;
            }
            return null;
        }
        public bool Add(VehicleOrderModel order)
        {
            string query = $"INSERT INTO vehicle_orders (customer_id, address, amount, status) VALUES (@customerId, @address, @amount, @status)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerId", order.CustomerId),
                new SqlParameter("@address", order.Address),
                new SqlParameter("@amount", order.Amount),
                new SqlParameter("@status", order.Status),
            };

            int rowsAffected = _dbService.ExecuteNonQueryWithParameters(query, parameters);
            return rowsAffected > 0;
        }
        public bool Delete(int id)
        {
            string query = $"DELETE FROM vehicle_orders WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
    }
}
