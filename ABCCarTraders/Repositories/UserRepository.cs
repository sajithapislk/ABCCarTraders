using ABCCarTraders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Repositories
{
    class UserRepository
    {
        private List<User> _users;

        public UserRepository()
        {
            _users = new List<User>
            {
                new Admin { Id = 1, Username = "admin", Password = "admin123" },
            };
        }

        public User GetUser(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
