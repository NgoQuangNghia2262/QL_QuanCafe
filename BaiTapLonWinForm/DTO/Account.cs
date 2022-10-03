using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string _username;
        private string _password;
        private string _category;
        public Account()
        {

        }
        public Account(string username, string password, string category)
        {
            Username = username;
            Password = password;
            Category = category;
        }
        public Account(DataRow row)
        {
            Username = row["USERNAME"].ToString();
            Password = row["PASS"].ToString();
            Category = row["CATEGORY"].ToString();
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Category { get => _category; set => _category = value; }
    }
}
