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
    class UserRepository
    {
        private readonly DatabaseService _dbService;

        public UserRepository()
        {
            _dbService = new DatabaseService();
        }

        public User GetUser(string username, string password)
        {
            string query = $"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'";
            DataTable result = _dbService.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                if (Convert.ToBoolean(row["is_admin"]))
                {
                    return new Admin
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Username = row["username"].ToString(),
                        Password = row["password"].ToString()
                    };
                }
            }
            return null;
        }
    }
}
