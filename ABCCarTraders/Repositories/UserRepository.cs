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
    class UserRepository
    {
        private readonly DatabaseService _dbService;

        public UserRepository()
        {
            _dbService = new DatabaseService();
        }

        public UserModel GetUser(string username, string password)
        {
            string query = $"SELECT * FROM users WHERE username = @username AND password = @password";
            DataTable result = _dbService.ExecuteQueryWithParameters(query, new SqlParameter("@username", username), new SqlParameter("@password", password));
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                if (Convert.ToBoolean(row["is_admin"]))
                {
                    return new AdminModel
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Username = row["username"].ToString(),
                        Password = row["password"].ToString()
                    };
                }
            }
            return null;
        }
        public bool AddUser(UserModel user)
        {
            string query;
            if (user is CustomerModel)
            {
                CustomerModel customer = user as CustomerModel;
                query = $"INSERT INTO users (username, password, name, email, tp, is_admin) VALUES ('{customer.Username}', '{customer.Password}', '{customer.Name}', '{customer.Email}', '{customer.Tp}', 0)";
            }
            else
            {
                query = $"INSERT INTO Users (Username, Password, IsAdmin) VALUES ('{user.Username}', '{user.Password}', 1)";
            }

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
    }
}
