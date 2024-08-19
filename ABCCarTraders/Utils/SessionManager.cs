using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ABCCarTraders.Models;

namespace ABCCarTraders.Utils
{
    class SessionManager
    {
        private const string SESSION_FILE = "session.json";

        public static UserModel CurrentUser { get; private set; }

        public static void Login(UserModel user)
        {
            CurrentUser = user;
            SaveSession();
        }

        public static void Logout()
        {
            CurrentUser = null;
            File.Delete(SESSION_FILE);
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static void LoadSession()
        {
            if (File.Exists(SESSION_FILE))
            {
                string json = File.ReadAllText(SESSION_FILE);
                ConcreteUserModel _concreteUser = JsonConvert.DeserializeObject<ConcreteUserModel>(json);
                if (_concreteUser != null && !string.IsNullOrEmpty(_concreteUser.Username))
                {
                    if (_concreteUser.Type == "Admin") {  
                        CurrentUser = new AdminModel {
                            Id = _concreteUser.Id,
                            Username = _concreteUser.Username,
                        };
                    }
                    else
                    {
                        CurrentUser = new CustomerModel
                        {
                            Id = _concreteUser.Id,
                            Username = _concreteUser.Username,
                        };
                    }
                }
            }
        }

        private static void SaveSession()
        {
            if (CurrentUser != null)
            {
                string _type = CurrentUser is AdminModel ? "Admin" : "Customer" ;

                ConcreteUserModel concreteUser = new ConcreteUserModel
                {
                    Id = CurrentUser.Id,
                    Username = CurrentUser.Username,
                    Type = _type
                };

                string json = JsonConvert.SerializeObject(concreteUser);
                File.WriteAllText(SESSION_FILE, json);
            }
        }
    }
}
