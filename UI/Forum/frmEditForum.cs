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

namespace UI.Forum
{
    public partial class frmEditForum : Form
    {
        BLL.Models.Forum CurrentForum;
        private string err;
        public static bool isUpdate = false;
        public static bool isDelete = false;
        public frmEditForum(BLL.Models.Forum A)
        {
            InitializeComponent();
            CurrentForum = A;
            LoadData();
        }

        private void LoadData()
        {
            this.txbName.Text = CurrentForum.Name;
            this.txbDesc.Text = CurrentForum.Description;
            if (CurrentForum.Visibility)
            {
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = true;
            }
            
            else
            {
                this.radioButton2.Checked = false;
                this.radioButton1.Checked = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentForum.Name = this.txbName.Text;
            CurrentForum.Description = this.txbDesc.Text;
            CurrentForum.Visibility = this.radioButton1.Checked == true ? false : true;
            if (ForumBLL.Instance.update(CurrentForum, ref err)==1)
            {
                MessageBox.Show("Saved Successfully!");
                isUpdate = true;
                this.Close();
            }
            else
                MessageBox.Show(err);
        }

        private void frmEditForum_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ForumBLL.Instance.delete(CurrentForum, ref err)==1)
            {
                MessageBox.Show("Deleted Successful!");
                isDelete = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(err);
            }
        }
    }
}
