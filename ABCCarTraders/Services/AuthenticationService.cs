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
            if (username == null || password == null) return null;
            UserModel user = _userRepository.GetUserForLogin(username, password);
            if (user!=null) SessionManager.Login(user);
            return user;
        }
        public bool RegisterCustomer(string username, string password, string name, string email, string tp)
        {
            if (username == null || password == null || name == null || email == null || tp == null) return false;
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
