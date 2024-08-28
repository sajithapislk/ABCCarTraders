using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using ABCCarTraders.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Services
{
    class AuthenticationService
    {
        private readonly UserRepository _userRepository;

        public AuthenticationService()
        {
            _userRepository = new UserRepository();
        }

        public UserModel Login(string username, string password)
        {
            UserModel user = _userRepository.GetUserForLogin(username, password);
            SessionManager.Login(user);
            return user;
        }
        public bool RegisterCustomer(string username, string password, string name, string email, string tp)
        {
            var customer = new CustomerModel
            {
                Username = username,
                Password = password,
                Name = name,
                Email = email,
                Tp = tp
            };
            return _userRepository.AddUser(customer);
        }
        public void Logout()
        {
            SessionManager.Logout();
        }
    }
}
