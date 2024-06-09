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
    public partial class frmAdminDashboard : Form
    {
        frmAdminHome home;
        frmAdminAccount account;
        frmAdminCourseSection course;
        frmAdminCoupon coupon;

        public string Username;
        public frmAdminDashboard(string username)
        {
            InitializeComponent();
            this.Username = username;
        }

        private void ActivateFormHome()
        {
            if (home == null)
            {
                home = new frmAdminHome(Username);
                home.FormClosed += frmAdminHome_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }

        private void ActivateFormAccount()
        {
            if (account == null)
            {
                account = new frmAdminAccount(Username);
                account.TopLevel = false;
                account.FormClosed += frmAdminAccount_FormClosed;
                account.MdiParent = this;
                account.Dock = DockStyle.Fill;
                account.Show();
            }
            else
            {
                account.Activate();
            }
        }

        private void ActivateFormCourse()
        {
            if (course == null)
            {
                course = new frmAdminCourseSection(Username);
                course.FormClosed += frmAdminCourseSection_FormClosed;
                course.MdiParent = this;
                course.Dock = DockStyle.Fill;
                course.Show();
            }
            else
            {
                course.Activate();
            }
        }
        private void ActivateFormCoupon()
        {
            if (coupon == null)
            {
                coupon = new frmAdminCoupon(Username);
                coupon.FormClosed += frmAdminCoupon_FormClosed;
                coupon.MdiParent = this;
                coupon.Dock = DockStyle.Fill;
                coupon.Show();
            }
            else
            {
                coupon.Activate();
            }
        }
        private void frmAdminCoupon_FormClosed(object sender, FormClosedEventArgs e)
        {
            coupon = null;
        }
        private void frmAdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }
        private void frmAdminAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            account = null;
        }
        private void frmAdminCourseSection_FormClosed(object sender, FormClosedEventArgs e)
        {
            course = null;
        }
        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.btnHome.Checked = true;
            this.btnCourse.Checked = false;
            this.btnAccount.Checked = false;
            this.btncoupon.Checked = false;
            ActivateFormHome();
        }

        private void lbAdmin_Click(object sender, EventArgs e)
        {

        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.btnHome.Checked = false;
            this.btnCourse.Checked = true;
            this.btnAccount.Checked = false;
            this.btncoupon.Checked = false;

            ActivateFormCourse();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.btnHome.Checked = false;
            this.btnCourse.Checked = false;
            this.btnAccount.Checked = true;
            this.btncoupon.Checked = false;

            ActivateFormAccount();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            this.btnHome.Checked = true;
            this.btnCourse.Checked = false;
            this.btnAccount.Checked = false;
            this.btncoupon.Checked = false;
            ActivateFormHome();
        }

        private void btncoupon_Click(object sender, EventArgs e)
        {
            this.btnHome.Checked = false;
            this.btnCourse.Checked = false;
            this.btnAccount.Checked = false;
            this.btncoupon.Checked = true;
            ActivateFormCoupon();
        }
    }
}
