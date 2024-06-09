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
using UI.Forum;

namespace UI.UserControls
{
    public partial class Post : UserControl
    {
        BLL.Models.Post post;
        private bool IsAuthor;
        string err;
        bool isClick;
        public static bool isLoad = false;
        
        public Post(string postId)
        {
            InitializeComponent();
            post = PostBLL.Instance.getById(postId);
            LoadData();
        }


        private void LoadData()
        {
            this.lblTitle.Text = post.Title;
            this.txbContent.Text = post.Content;
            this.lblLike.Text = "Like " + post.Likes;
            this.lblReply.Text = "Reply " + post.Replys;
            this.lblAuthorName.Text = post.Author;
            this.btnEdit.Hide();
            this.btnSave.Hide();
            if (PostBLL.Instance.isLike(post.PostId, frmLogin.CurAcc.Username, ref err))
            {
                this.btnLike.Checked = true;
                isClick = true;
            }
            else
            {
                this.btnLike.Checked = false;
                isClick = false;
            }

            if (post.Author == frmLogin.CurAcc.Username)
            {
                this.btnEdit.Show();
            }
            
        }


        private void Post_Load(object sender, EventArgs e)
        {

        }

        private void btnLike_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if(isClick)
            {
                if (PostBLL.Instance.UnLike(post.PostId, frmLogin.CurAcc.Username, ref err))
                {
                    isClick = false;
                    this.btnLike.Checked = false;
                    this.lblLike.Text = "Like " + (post.Likes - 1);

                }

            }
            else
            {
                if (PostBLL.Instance.Like(post.PostId, frmLogin.CurAcc.Username, ref err))
                {
                    isClick = true;
                    this.btnLike.Checked = true;
                    this.lblLike.Text = "Like " + (post.Likes);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txbContent.Enabled = true;
            this.btnSave.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            post.Content = this.txbContent.Text;
            if (PostBLL.Instance.update(post, ref err) != 0)
            {
                MessageBox.Show("Saved!");
                this.btnSave.Hide();
                this.txbContent.Enabled = false;
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            frmPostDetail f = new frmPostDetail(post.PostId);
            f.ShowDialog();
        }
    }
}
