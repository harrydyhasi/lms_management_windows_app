using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Admin
    {
        public string Username { get; set; }
        public string AvatarPath { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string PhoneNumb { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public Admin() { }

        public Admin(string username, string avatarPath, string fName, string mName, string lName, string email, string phoneNumb, DateTime dateOfBirth, string address)
        {
            Username = username;
            AvatarPath = avatarPath;
            FName = fName;
            MName = mName;
            LName = lName;
            Email = email;
            PhoneNumb = phoneNumb;
            DateOfBirth = dateOfBirth;
            Address = address;
        }

        public Admin(DataRow row)
        {
            Username = row["username"].ToString();
            AvatarPath = row["avatar_path"].ToString();
            FName = row["f_name"].ToString();
            MName = row["m_name"].ToString();
            LName = row["l_name"].ToString();
            Email = row["email"].ToString();
            PhoneNumb = row["phone"].ToString();
            DateOfBirth = Convert.ToDateTime(row["date_of_birth"].ToString());
            Address = row["address"].ToString();
        }

    }
}
