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

        public UserModel GetUserForLogin(string username, string password)
        {
            string query = $"SELECT * FROM users WHERE username = @username AND password = @password AND deleted_at IS NULL";
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
                }else
                {
                    return new CustomerModel
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Username = row["username"].ToString(),
                        Password = row["password"].ToString(),
                        Email = row["email"].ToString(),
                        Tp = row["tp"].ToString(),
                        Name = row["name"].ToString(),
                    };
                }
            }
            return null;
        }
        public List<CustomerModel> GetCustomers()
        {
            string query = $"SELECT * FROM users WHERE is_admin=0";
            DataTable result = _dbService.ExecuteQuery(query);
            List<CustomerModel> _customers = new List<CustomerModel>();

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    CustomerModel _customer = new CustomerModel
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["name"].ToString(),
                        Email = row["email"].ToString(),
                        Tp = row["tp"].ToString(),
                        Username = row["username"].ToString(),
                    };

                    _customers.Add(_customer);
                }

                return _customers;
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

        public bool UpdateUser(UserModel user)
        {
            string query;

            if (user is CustomerModel)
            {
                CustomerModel customer = user as CustomerModel;

                query = $"UPDATE users SET " +
                        $"username = '{customer.Username}', " +
                        $"name = '{customer.Name}', " +
                        $"email = '{customer.Email}', " +
                        $"tp = '{customer.Tp}', " +
                        $"is_admin = 0 " +
                        $"WHERE id = {customer.Id}";
            }
            else
            {
                query = $"UPDATE users SET " +
                        $"username = '{user.Username}', " +
                        $"is_admin = 1 " +
                        $"WHERE id = {user.Id}";
            }

            int rowsAffected = _dbService.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
        public bool Delete(int id)
        {
            try
            {
                string query = $"DELETE FROM users WHERE id={id}";
                int rowsAffected = _dbService.ExecuteNonQuery(query);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                string query = $"UPDATE users SET deleted_at=GETDATE() WHERE id={id}";
                int rowsAffected = _dbService.ExecuteNonQuery(query);
                return rowsAffected > 0;
            }
        }
    }
}
