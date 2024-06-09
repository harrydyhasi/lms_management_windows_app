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

namespace UI.Forum
{
    public partial class frmCreateForum : Form
    {
        private bool selected;
        private string err;
        private string CourseId;
        public frmCreateForum(string courseId)
        {
            InitializeComponent();
            this.siticoneShadowForm1.SetShadowForm(this);
            CourseId = courseId;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SiticoneRadioButton rb = sender as SiticoneRadioButton;

            if (rb == null)
            {
                return;
            }

            if (rb.Checked)
            {
                if (rb.Text == "Private")
                    selected = false;
                else
                    selected = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ForumBLL.Instance.add(new BLL.Models.Forum(CourseId, txbName.Text, txbDesc.Text, selected), ref err) == 1)
            {
                MessageBox.Show("Added successfully!");
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateForum_Load(object sender, EventArgs e)
        {

        }
    }
}
