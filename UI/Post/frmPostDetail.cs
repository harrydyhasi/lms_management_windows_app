using BLL;
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
using UI.UserControls;

namespace UI.Forum
{
    public partial class frmPostDetail : Form
    {
        BLL.Models.Post post;
        public frmPostDetail(string postId)
        {
            InitializeComponent();
            post = BLL.PostBLL.Instance.getById(postId);
            LoadData();
        }
        bool isExpand = false;
        private void btnReply_Click(object sender, EventArgs e)
        {
            /*if (isExpand == false)
            {
                this.plReply.Visible = false;
                isExpand = true;
                this.plComment.Location = this.plReply.Location;
            }
            else
            {
                this.plReply.Visible = true;
                isExpand = false;
                this.plComment.Location = new Point(17, 322);
            }*/
        }

        private void frm_PostDetail_Load(object sender, EventArgs e)
        {
            //LoadData();
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void btnLike_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            this.lblContent.Text = post.Content;
            this.lblAuthorName.Text = post.Author;
            this.lblLike.Text = "Like " + post.Likes;
            this.lblReply.Text = "Reply " + post.Replys;

            //isExpand = false;
            //this.plComment.Location = this.plReply.Location;

            this.plReply.Controls.Clear();
            List<BLL.Models.Reply> replyList = ReplyBLL.Instance.getReplysOfPost(post.PostId);
            foreach (var a in replyList)
            {
                plComment.Controls.Add(new ReplyUC(a));
            }
        }
    }
}
