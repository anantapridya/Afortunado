using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantMonet
{
    public class Admin
    {
        private string _username;
        private string _password;
        public string Username { get { return _username; } set {_username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public bool login(string username, string password)
        {
            //username sementara: Admin dan password sementara: TenantMoney
            if (username == "Admin" && password == "TenantMoney")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
