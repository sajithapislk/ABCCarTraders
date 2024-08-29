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
    class VehiclePartOrderInfoRepository
    {
        private readonly DatabaseService _dbService;

        public VehiclePartOrderInfoRepository()
        {
            _dbService = new DatabaseService();
        }

        public bool Save(VehiclePartOrderInfoModel order)
        {
            string query = $"INSERT INTO vehicle_part_order_info (order_id,part_id,qty) VALUES (@orderId, @partId, @qty)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@orderId", order.OrderId),
                new SqlParameter("@partId", order.PartId),
                new SqlParameter("@qty", order.Qty)
            };

            int rowsAffected = _dbService.ExecuteNonQueryWithParameters(query, parameters);

            if (rowsAffected > 0)
            {
                string updateQuery = $"UPDATE vehicle_parts SET qty = qty - @qty WHERE id = @partId";
                SqlParameter[] updateParameters = new SqlParameter[]
                {
                    new SqlParameter("@partId", order.PartId),
                    new SqlParameter("@qty", order.Qty)
                };
                _dbService.ExecuteNonQueryWithParameters(updateQuery, updateParameters);
            }


            return rowsAffected > 0;
        }
    }
}
