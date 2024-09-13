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
        public void Logout()
        {
            SessionManager.Logout();
        }
    }
}
