using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public DateTime Delete_at { get; set; }

        public Account()
        {

        }

        public Account(string username, string password, string type, DateTime delete_at )
        {           
            Username = username;
            Password = password;
            Delete_at = delete_at;
            Type = type;
        }
        public Account(string username, string password, string type)
        {

            Username = username;
            Password = password;
            Type = type;
        }
        public Account(DataRow row)
        {
            Username = row["username"].ToString();
            Type = row["type"].ToString();
            Password = row["password"].ToString();
            if (row["deleted_at"].ToString() != "")
            Delete_at = Convert.ToDateTime(row["deleted_at"].ToString());
        }

    }
}
