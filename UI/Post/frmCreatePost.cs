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

namespace UI.Lecturer.Forum
{
    public partial class frmCreatePost : Form
    {
        private string ForumId;
        string err;
        public frmCreatePost(string forumId)
        {
            InitializeComponent();
            ForumId = forumId;
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
        int i;
        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .04;
            }

            int y = frmForumDetail.parentY += 3;
            this.Location = new Point(frmForumDetail.parentX + 220, y);
            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }

        private void frm_CreatePost_Load(object sender, EventArgs e)
        {
            i = frmForumDetail.parentY + 150;
            this.Location = new Point(frmForumDetail.parentX + 220, frmForumDetail.parentY + 150);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string title = this.txbTitle.Text;
            string body = this.txbBody.Text;
            BLL.Models.Post A = new BLL.Models.Post();
            A.Title = title;
            A.Content = body;
            A.ForumId = ForumId;
            A.Author = frmLogin.CurAcc.Username;
            if (title == "" || body == "")
            {
                MessageBox.Show("Provide full information about the Post, please!");
            }
            else
            {
                PostBLL.Instance.add(A, ref err);
                this.Close();
                MessageBox.Show("Posted successfully");
            }
        }
    }
}
