using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = this.txbUsername.Text;
            string passwword = this.txbPass.Text;
            string email = this.txbEmail.Text;
            string phone = this.txbPhone.Text;
            string address = this.txbAddress.Text;
            DateTime dateOfBirth = this.dtimeDateOfBirth.Value;

            if (AccountBLL.Instance.SignUp(username, passwword, "huynh", "Dong", "Hen",phone, email, address, dateOfBirth))
            {
                Form f = new frmLearnerDashboard(username);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                this.txbUsername.ResetText();
                MessageBox.Show("Username is used!!!");
            }
        }
    }
}
