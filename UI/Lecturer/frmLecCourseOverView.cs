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
using UI.Course;

namespace UI.Lecturer
{
    public partial class frmLecCourseOverView : UserControl
    {
        private string LecturerId;
        public frmLecCourseOverView(string lecturerId)
        {
            InitializeComponent();
            LecturerId = lecturerId;
            LoadData();
        }

        private void frmLecCourseOverView_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void LoadData()
        {
            this.fpnlContainer.Controls.Clear();
            List<BLL.Models.Course> list = CourseBLL.Instance.getCourseByLecturerId(LecturerId);
            foreach (var c in list)
            {
                this.fpnlContainer.Controls.Add(new CourseByLecturer(c.CourseId));
            }
        }
    }
}
