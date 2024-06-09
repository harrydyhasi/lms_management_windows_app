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
using UI.Course;

namespace UI.Lecturer
{
    public partial class CourseTypeList : UserControl
    {
        private bool IsDone;
        BLL.Models.Course CurCourse;
        public CourseTypeList(string courseId, string learnerID, bool isDone)
        {
            InitializeComponent();
            CurCourse = CourseBLL.Instance.getCourseInEntrolls(learnerID, courseId);
            IsDone = isDone;
            LoadData();
        }

        private void LoadData()
        {
            this.lblLecName.Text = CurCourse.LecturerId;
            this.lblCourseName.Text = CurCourse.CourseName;
            this.lblCompletion.Text = CurCourse.Completion.ToString() + "%";
            this.proBar.Value = CurCourse.Completion;

            if (!IsDone)
            {
                this.pnlDone.Hide();
                this.pnlDone.Visible = false;
                this.pnlRating.Hide();
                this.pnlRating.Visible = false;
            }
            else
            {
                this.pnlDone.Show();
                this.pnlDone.Visible = true;
                this.pnlRating.Show();
                this.pnlRating.Visible = true;
            }
        }


        private void btnGoToCourse_Click(object sender, EventArgs e)
        {
            frmCourseDetail f = new frmCourseDetail(CurCourse.CourseId);
            f.ShowDialog();
        }
    }
}
