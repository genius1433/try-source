using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPF_bigprodject
{
    class DataBase
    {
        private string login;
        private string password;
        private string role;
        public string Login
        {
            set
            {
                this.login = value;
            }
            get
            {
                return login;
            }
        }
        public string Password
        {
            set
            {
                this.password = value;
            }
            get
            {
                return password;
            }
        }
        public string Role
        {
            set
            {
                this.role = value;
            }
            get
            {
                return role;
            }
        }
        public DataBase()
        {
            this.Login = "";
            this.Password = "";
            this.Role = "";
        }
        public DataBase(string login, string password, string role)
        {
            this.Login = login;
            this.Password = password;
            this.Role = role;
        }
        public override string ToString()
        {
            return Login + ", " + Password + ", " + Role;
        }
    }
}
