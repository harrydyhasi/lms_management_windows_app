
using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace UI.Admin
{
    public partial class frmAdminAccount : Form
    {
        public string Username;
        bool isCreate;
        bool isUpdate;
        string err;

        public frmAdminAccount(string username)
        {
            InitializeComponent();
            this.Username = username;
            LoadData();
            Init(false);
            this.cbSearch.SelectedIndex = 0;
            this.cblst.SelectedIndex = 3;
            this.dtgvLstAccount.ReadOnly = true;
        }
        private void Init(bool check)
        {
            this.isCreate = false;
            this.isUpdate = false;
            this.txbUsername.Enabled = check;
            this.txbPassword.Enabled = check;
            this.cbRole.Enabled = check;
            this.txbfname.Enabled = check;
            this.txbmname.Enabled = check;
            this.txblname.Enabled = check;
            this.txbEmail.Enabled = check;
            this.txbPhone.Enabled = check;
            this.txbaddress.Enabled = check;
            this.dtimeDateOfBirth.Enabled = check;
            this.btncancel.Enabled = check;
            this.btnsave.Enabled = check;
        }
        private void InitNull()
        {
            this.txbUsername.Text = "";
            this.txbPassword.Text = "";
            this.cbRole.SelectedIndex = 0;
            this.txbfname.Text = "";
            this.txbmname.Text = "";
            this.txblname.Text = "";
            this.txbEmail.Text = "";
            this.txbPhone.Text = "";
            this.txbaddress.Text = "";
            this.dtimeDateOfBirth.Value = DateTime.Today;
        }
        private void LoadData()
        {
            dtgvLstAccount.DataSource = AccountBLL.Instance.getTable();
            this.lblNumber.Text = AccountBLL.Instance.CountAccout();
        }
        private void dtgvLstAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvLstAccount.CurrentCell.RowIndex;
            if (r < 0 || r > dtgvLstAccount.RowCount - 2)
                return;

            string username = dtgvLstAccount.Rows[r].Cells[0].Value.ToString();

            BLL.Models.AccountInfor t = BLL.AccountBLL.Instance.GetAccountInfor(username);
            string passwword = dtgvLstAccount.Rows[r].Cells[1].Value.ToString();

            this.txbUsername.Text = username;
            this.txbPassword.Text = passwword;

            this.cbRole.SelectedIndex = Int32.Parse(dtgvLstAccount.Rows[r].Cells[4].Value.ToString());
            this.txbfname.Text = t.FName;
            this.txbmname.Text = t.MName;
            this.txblname.Text=t.LName;
            this.txbEmail.Text = t.Email;
            this.txbPhone.Text = t.PhoneNumb;
            this.txbaddress.Text = t.Address;
            this.dtimeDateOfBirth.Value = t.DateOfBirth;
            Init(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Init(true);
            this.txbUsername.Enabled = false;
            this.cbRole.Enabled = false;
            this.isUpdate = true;
            this.isCreate = false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Init(true);
            InitNull();
            this.isCreate = true;
            this.isUpdate = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Init(false);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string username = this.txbUsername.Text;
            string password = this.txbPassword.Text;
            string lname = this.txblname.Text;
            string mname = this.txbmname.Text;
            string fname = this.txbfname.Text;
            string email = this.txbEmail.Text;
            string address = this.txbaddress.Text;
            string phone = this.txbPhone.Text;
            string avatarPath = "NULL";
            DateTime dateOfBirth = this.dtimeDateOfBirth.Value.Date;
            string type = cbRole.SelectedIndex.ToString();

            if (isUpdate)
            {
                Account account = new Account(username, password, type);
                AccountInfor accountInfor = new AccountInfor(username, avatarPath, fname, mname, lname, email, phone, dateOfBirth, address);
                int check = BLL.AccountBLL.Instance.UpdateAccountInfor(account, accountInfor, ref err);
                LoadData();
                Init(false);
                if (check < 1)
                    MessageBox.Show(err);
                isUpdate = false;
                isCreate = false;
            }
            if (isCreate)
            {
                Account account = new Account(username, password, type);
                AccountInfor accountInfor = new AccountInfor(username, avatarPath, fname, mname, lname, email, phone, dateOfBirth, address);
                int check = BLL.AccountBLL.Instance.AddAccount(account, accountInfor, ref err);
                LoadData();
                Init(false);

                if (check < 1)
                    MessageBox.Show(err);
                isUpdate = false;
                isCreate = false;
            }
            Init(false);
            LoadData();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text;
            string type = cblst.SelectedIndex.ToString();

            if (cbSearch.SelectedIndex == 0)
            {
                dtgvLstAccount.DataSource = AccountBLL.Instance.SearchAccountByUsername(input, type);
            }
            else
            {
                dtgvLstAccount.DataSource = AccountBLL.Instance.SearchAccountByName(input, type);
            }
            int len = dtgvLstAccount.RowCount - 1;
            this.lblNumber.Text = len.ToString();
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            this.tbSearch.SelectAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = this.txbUsername.Text;
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int check = AccountBLL.Instance.deleteAccount(username, ref err);
                if (check == 0)
                {
                    MessageBox.Show(err);
                }
                else
                {
                    LoadData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.dtimeDateOfBirth.Value.Date.ToString("dd,MM,yyyy"));
        }
    }
}
