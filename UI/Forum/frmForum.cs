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
    public partial class frmForum : UserControl
    {
        private string CourseId;
        private string LearnerId;
        public frmForum(string courseId)
        {
            InitializeComponent();
            CourseId = courseId;
            if(frmLogin.CurAcc.Type == "1")
            {
                this.btnAdd.Show();
            }
            else
            {
                this.btnAdd.Hide();
            }
            this.btnAllTab.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCreateForum frm = new frmCreateForum(CourseId);
            frm.ShowDialog();
        }

        private void btnAllTab_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlContainer.Controls.Clear();
            AllForumsTab A = new AllForumsTab(CourseId);
            A.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(A);
        }
    }
}
