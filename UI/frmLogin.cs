using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Lecturer.Forum;
using BLL;
using UI;
using UI.Lecturer;

namespace UI
{
    public partial class frmLogin : Form
    {
        public static BLL.Models.Account CurAcc;
        public static BLL.Models.AccountInfor CurAccInfo;
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.Red;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            frmForgotPassword f = new frmForgotPassword();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp f = new frmSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ReturnFormByRole(string role,string username)
        {
            Form f;
            switch (role)
            {
                case "0":
                    f = new UI.Admin.frmAdminDashboard(username); 
                    break;
                case "1":
                    f = new frmLecturerDashBoard(username);
                    break;
                default:
                    f = new frmLearnerDashboard(username);
                    break;
            }
            
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txbUsername.Text;
            if (AccountBLL.Instance.isLogin(username, this.txbPassword.Text))
            {
                CurAcc = AccountBLL.Instance.getById(username);
                //CurAccInfo = AccountBLL.Instance.GetAccountInfor(username);
                //string role = AccountBLL.Instance.GetTypeByUsername(username);
                ReturnFormByRole(CurAcc.Type,username);
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }
    }
}
