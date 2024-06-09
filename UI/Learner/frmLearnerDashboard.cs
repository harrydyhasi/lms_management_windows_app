using BLL;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UserControls;

namespace UI
{
    public partial class frmLearnerDashboard : Form
    {
        frmLearnerHome home;
        frmMyLearning myLearning;
        public string LearnerId;
        BLL.Models.Cart C;

        public frmLearnerDashboard(string learnerId)
        {
            InitializeComponent();
            this.LearnerId = learnerId;
            C = CartBLL.Instance.getById(LearnerId);
            timer1.Start();
            LoadData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.btnHome.Checked = true;
            this.btnMyLearning.Checked = false;
            ActivateFormHome();
        }

        private void ActivateFormHome()
        {
            if (home == null)
            {
                home = new frmLearnerHome(LearnerId);
                home.FormClosed += frmHome_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }
        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }


        private void btnMyLearning_Click(object sender, EventArgs e)
        {
            this.btnHome.Checked = false;
            this.btnMyLearning.Checked = true;
            ActivateMyLearning();
        }

        private void ActivateMyLearning()
        {
            if (myLearning == null)
            {
                myLearning = new frmMyLearning(LearnerId);
                myLearning.FormClosed += frmMyLearning_FormClosed;
                myLearning.MdiParent = this;
                myLearning.Dock = DockStyle.Fill;
                myLearning.Show();
            }
            else
            {
                myLearning.Activate();
            }
        }

        private void frmMyLearning_FormClosed(object sender, FormClosedEventArgs e)
        {
            myLearning = null;
        }


        private void frm_Home_Load(object sender, EventArgs e)
        {
            btnHome.Checked = true;
            ActivateFormHome();
        }
        
        private void btnCart_Click(object sender, EventArgs e)
        {

            frmCart f = new frmCart(C.CartId);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {
            C = CartBLL.Instance.getById(LearnerId);
            this.lblQuantity.Text = CartBLL.Instance.GetQuantity(C.CartId).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (frmLearnerHome.isLoadQuantity)
            {
                this.lblQuantity.Text = CartBLL.Instance.GetQuantity(C.CartId).ToString();
                frmLearnerHome.isLoadQuantity = false;
            }
        }
    }
}
