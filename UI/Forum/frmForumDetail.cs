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
using UI.Lecturer.Forum;
using UI.UserControls;

namespace UI.Lecturer
{
    public partial class frmForumDetail : Form
    {
        BLL.Models.Forum CurrentForum;
        public frmForumDetail(BLL.Models.Forum forum)
        {
            InitializeComponent();
            CurrentForum = forum;
            LoadData();
        }

        private void frm_Forum_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }
        public static int parentX, parentY;
        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using(frmCreatePost modal = new frmCreatePost(CurrentForum.Id))
            {
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }    
            
        }

        private void LoadData()
        {
            this.lblForumName.Text = CurrentForum.Name;
            this.lblForumDecs.Name = CurrentForum.Description;

            this.fpnlPosts.Controls.Clear();
            List<BLL.Models.Post> lst = PostBLL.Instance.getPostsOfForum(CurrentForum.Id);
            foreach(var a in lst)
            {
                this.fpnlPosts.Controls.Add(new Post(a.PostId));
            }
        }
    }
}
