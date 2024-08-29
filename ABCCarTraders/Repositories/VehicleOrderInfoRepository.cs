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
    class VehicleOrderInfoRepository
    {
        private readonly DatabaseService _dbService;

        public VehicleOrderInfoRepository()
        {
            _dbService = new DatabaseService();
        }

        public bool Save(VehicleOrderInfoModel order)
        {
            string query = $"INSERT INTO vehicle_order_info (order_id,vehicle_id,qty) VALUES (@orderId, @vehicleId, @qty)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@orderId", order.OrderId),
                new SqlParameter("@vehicleId", order.VehicleId),
                new SqlParameter("@qty", order.Qty)
            };

            int rowsAffected = _dbService.ExecuteNonQueryWithParameters(query, parameters);

            if (rowsAffected > 0)
            {
                string updateQuery = $"UPDATE vehicles SET qty = qty - @qty WHERE id = @vehicleId";
                SqlParameter[] updateParameters = new SqlParameter[]
                {
                    new SqlParameter("@vehicleId", order.VehicleId),
                    new SqlParameter("@qty", order.Qty)
                };
                _dbService.ExecuteNonQueryWithParameters(updateQuery, updateParameters);
            }

            return rowsAffected > 0;
        }
    }
}
