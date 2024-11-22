using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBAPI.UI.Services
{
    public class UserService
    {
        private bool _isAuthenticated = false;

        public bool IsAuthenticated => _isAuthenticated;

        public void Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                _isAuthenticated = true;
            }
        }

        public void Logout()
        {
            _isAuthenticated = false;
        }
    }
}
