using ABCCarTraders.Models;
using ABCCarTraders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
