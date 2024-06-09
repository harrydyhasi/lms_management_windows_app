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

namespace UI.Course
{
    public partial class CourseByLecturer : UserControl
    {
        BLL.Models.Course CurCourse;
        public CourseByLecturer(string courseId)
        {
            InitializeComponent();
            CurCourse = CourseBLL.Instance.getById(courseId);
            LoadData();
        }

        private void LoadData()
        {
            this.lblLecName.Text = CurCourse.LecturerId;
            this.lblCourseName.Text = CurCourse.CourseName;
        }

        private void btnGoToCourse_Click(object sender, EventArgs e)
        {
            frmCourseDetail f = new frmCourseDetail(CurCourse.CourseId);
            f.ShowDialog();
        }
    }
}
