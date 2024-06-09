using BLL;
using DAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Lecturer;
using BLL;

namespace UI
{
    public partial class frmForgotPassword : Form
    {
        string err;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
                string newPassword = AccountBLL.Instance.ResetPassword();
                if (AccountBLL.Instance.changePassword(txbUsername.Text, newPassword, ref err))
                {
                    SendNotificationByEmail.Instance.SendEmail(this.txbEmail.Text, "Reset password", "Your password is: " + newPassword);
                    MessageBox.Show("Check your email!.\nWe've sent reset password to your email!");
                }
                else
                {
                    MessageBox.Show("Send Mail failed to send message. Please check your username and email!");
                }
            
        }
    }
}
