using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Admin
{
    public partial class frmAdminHome : Form
    {
        public string Username;
        private bool isUpdate;
        private bool passHide;
        public string err = "";
        public frmAdminHome(string username)
        {
            InitializeComponent();
            this.Username = username;
            LoadData();
            Init(false);
            this.txbUsername.Enabled = false;
            passHide = true;
            
            this.txbPassword.UseSystemPasswordChar = passHide;
            this.btncancel.Hide();
            this.btnSave.Hide();

        }
        private void Init(bool check)
        {
            this.isUpdate = check;
            this.txbPassword.Enabled = check;
            this.txbfname.Enabled = check;
            this.txbmname.Enabled = check;
            this.txblname.Enabled = check;
            this.txbemail.Enabled = check;
            this.txbPhone.Enabled = check;
            this.txbaddress.Enabled = check;
            this.dtimeDateOfBirth.Enabled = check;
            this.btncancel.Enabled = check;
            this.btnSave.Enabled = check;
        }
        private void LoadData()
        {
            Account account = BLL.AccountBLL.Instance.getById(Username);
            BLL.Models.AccountInfor accountInfor = BLL.AccountBLL.Instance.GetAccountInfor(Username);

            this.txbUsername.Text = accountInfor.Username;
            this.txbPassword.Text = account.Password;
            this.txbfname.Text = accountInfor.FName;
            this.txblname.Text = accountInfor.LName;
            this.txbmname.Text = accountInfor.MName;
            this.txbPhone.Text = accountInfor.PhoneNumb;
            this.txbemail.Text = accountInfor.Email;
            this.txbaddress.Text = accountInfor.Address;
            this.dtimeDateOfBirth.Value = Convert.ToDateTime(accountInfor.DateOfBirth);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Init(true);
            this.btncancel.Show();
            this.btnSave.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Init(false);
            LoadData();
            this.btncancel.Hide();
            this.btnSave.Hide();
        }

        private void btnHire_Click(object sender, EventArgs e)
        {     
            passHide = !(passHide);
            this.txbPassword.UseSystemPasswordChar = passHide;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isUpdate)
            {
                string password = this.txbPassword.Text;
                string lname = this.txblname.Text;
                string mname = this.txbmname.Text;
                string fname = this.txbfname.Text;
                string email = this.txbemail.Text;
                string address = this.txbaddress.Text;
                string phone = this.txbPhone.Text;
                string avatarPath = "NULL";
                string type = "0";

                DateTime dateOfBirth = this.dtimeDateOfBirth.Value;
                Account account = new Account(Username, password, type);
                AccountInfor accountInfor = new AccountInfor(Username, avatarPath, fname, mname, lname, email, phone, dateOfBirth, address);

                int check = BLL.AccountBLL.Instance.UpdateAccountInfor(account,accountInfor, ref err);
                LoadData();
                Init(false);
                if (check < 1)
                    MessageBox.Show(err);
                this.btncancel.Hide();
                this.btnSave.Hide();
            }        
        }
    }
}
