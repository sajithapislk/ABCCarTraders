using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using ABCCarTraders.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.Services
{
    class CustomerService
    {
        private readonly UserRepository _userRepository;

        public CustomerService()
        {
            _userRepository = new UserRepository();
        }

        public List<CustomerModel> List()
        {
            return _userRepository.GetCustomers();
        }
        public bool RegisterCustomer(string username, string password, string name, string email, string tp, bool is_admin)
        {
            if (Validation.IsEmpty(username, password, name, email, tp) || !Validation.IsValidEmail(email))
            {
                MessageBox.Show("Validation failed: Some fields are empty or invalid.");
                return false;
            }

            var user = new CustomerModel
            {
                Username = username,
                Password = password,
                Name = name,
                Email = email,
                Tp = tp
            };
            
            return _userRepository.AddUser(user);
        }
        public bool UpdateCustomer(int id, string username, string name, string email, string tp)
        {
            if (Validation.IsEmpty(username, name, email, tp) || !Validation.IsValidEmail(email))
            {
                MessageBox.Show("Validation failed: Some fields are empty or invalid.");
                return false;
            }

            var user = new CustomerModel
            {
                Id = id,
                Username = username,
                Name = name,
                Email = email,
                Tp = tp
            };

            return _userRepository.UpdateUser(user);
        }
    }
}
