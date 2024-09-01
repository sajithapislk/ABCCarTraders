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
    class VehiclePartCategoryRepository
    {
        private readonly DatabaseService _dbService;

        public VehiclePartCategoryRepository()
        {
            _dbService = new DatabaseService();
        }

        public List<VehiclePartCategoryModel> All()
        {
            string query = $"SELECT * FROM vehicle_part_categories";
            DataTable result = _dbService.ExecuteQuery(query);
            List<VehiclePartCategoryModel> categories = new List<VehiclePartCategoryModel>();

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    VehiclePartCategoryModel category = new VehiclePartCategoryModel
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["name"].ToString()
                    };

                    categories.Add(category);
                }

                return categories;
            }
            return null;
        }
        public bool AddCategory(string category)
        {
            string query = $"INSERT INTO vehicle_part_categories (name) VALUES ('{category}')";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            string query = $"UPDATE vehicle_part_categories SET name='{name}' WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
        public bool DeleteCategory(int id)
        {
            string query = $"DELETE FROM vehicle_part_categories WHERE id={id}";

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
    }
}
