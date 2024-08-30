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

        public List<OrderModel> All()
        {
            string query = $"SELECT * FROM orders";
            DataTable result = _dbService.ExecuteQuery(query);
            List<OrderModel> vehicle_orders = new List<OrderModel>();

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    OrderModel order = new OrderModel
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
        public int Add(OrderModel order)
        {
            string query = $"INSERT INTO orders(customer_id, address, amount, status) VALUES(@customerId, @address, @amount, @status); SELECT SCOPE_IDENTITY(); ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerId", order.CustomerId),
                new SqlParameter("@address", order.Address),
                new SqlParameter("@amount", order.Amount),
                new SqlParameter("@status", order.Status),
            };

            return _dbService.ExecuteNonQueryWithParametersAndResult(query, parameters);
        }
        public bool Delete(int id)
        {
            string query = $"DELETE FROM orders WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }

        public bool UpdateStatus(int id,string status)
        {
            string query = $"UPDATE orders SET status='{status}' WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }

    }
}
