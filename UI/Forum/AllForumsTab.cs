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
    public partial class AllForumsTab : UserControl
    {
        private string CourseId;
        public AllForumsTab(string courseId)
        {
            InitializeComponent();
            CourseId = courseId;
            LoadData();
        }

        private void LoadData()
        {
            this.fpnlContainer.Controls.Clear();

            List<BLL.Models.Forum> lst = ForumBLL.Instance.getForumsByCourseId(CourseId);
            foreach(var a in lst)
            {
                this.fpnlContainer.Controls.Add(new ForumItem(a));
            }
        }
    }
}
