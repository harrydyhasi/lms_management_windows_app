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
using UI.Forum;
using UI.UserControls;

namespace UI.Course
{
    public partial class frmCourseDetail : Form
    {
        public static int parentX, parentY;
        public string CourseId { get; set; }
        public string LearnerId { get; set; }

        private BLL.Models.Course CurCourse;

        public frmCourseDetail(string courseId)
        {
            InitializeComponent();
            CourseId = courseId;
            CurCourse = CourseBLL.Instance.getById(courseId);
            LearnerId = frmLogin.CurAcc.Username;
            lblCourseName.Text = CurCourse.CourseName;
        }

        private void siticoneButton_Content_Click(object sender, EventArgs e)
        {
            this.siticonePanel_Body.Controls.Clear();
            CourseContent course_Content = new CourseContent(CourseId,LearnerId);
            this.siticonePanel_Body.Controls.Add(course_Content);
        }
        private void siticoneButton_Forum_Click(object sender, EventArgs e)
        {
            this.siticonePanel_Body.Controls.Clear();
            frmForum F = new frmForum(CourseId);
            F.Dock = DockStyle.Fill;
            this.siticonePanel_Body.Controls.Add(F);
        }

    }
}
