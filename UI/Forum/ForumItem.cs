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
using UI.Lecturer;

namespace UI.Forum
{
    public partial class ForumItem : UserControl
    {
        BLL.Models.Forum CurrentForum;
        public ForumItem(BLL.Models.Forum A)
        {
            InitializeComponent();
            CurrentForum = A;
            LoadData();
        }

        private void LoadData()
        {
            if (frmLogin.CurAcc.Type == "1")
            {
                this.btnEdit.Show();
            }
            else
            {
                this.btnEdit.Hide();
            }
            this.lblName.Text = CurrentForum.Name;
            this.lblDesc.Text = CurrentForum.Description;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditForum f = new frmEditForum(CurrentForum);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ForumItem_Click(object sender, EventArgs e)
        {
            frmForumDetail f = new frmForumDetail(CurrentForum);
            f.ShowDialog();
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            frmForumDetail f = new frmForumDetail(CurrentForum);
            f.ShowDialog();
        }
    }
}
