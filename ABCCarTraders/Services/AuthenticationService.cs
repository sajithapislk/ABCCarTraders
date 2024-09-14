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
    class AuthenticationService
    {
        private readonly UserRepository _userRepository;

        public AuthenticationService()
        {
            _userRepository = new UserRepository();
        }

        public UserModel Login(string username, string password)
        {
            if (Validation.IsEmpty(username, password))
            {
                MessageBox.Show("Validation failed: Some fields are empty or invalid.");
                return null;
            }
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
