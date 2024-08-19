using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
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

        public User Login(string username, string password)
        {
            return _userRepository.GetUser(username, password);
        }
        public bool RegisterCustomer(string username, string password, string name, string email, string tp)
        {
            var customer = new Customer
            {
                Username = username,
                Password = password,
                Name = name,
                Email = email,
                Tp = tp
            };
            return _userRepository.AddUser(customer);
        }
    }
}
