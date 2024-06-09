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

namespace UI.UserControls
{
    public partial class CourseTypeCard : UserControl
    {
        public static bool isAddItemToCart = false;
        public static string CurrentCourseID;
        public string CourseId;
        public CourseTypeCard(string courseId)
        {
            InitializeComponent();
            CourseId = courseId;
            BLL.Models.Course A = CourseBLL.Instance.getById(courseId);
            this.lblCourseName.Text = A.CourseName;
            this.lblCourseName.Text = A.CourseName;
            this.lblLecturerName.Text = A.LecturerId; //******
            this.lblRating.Text = A.AvgRating.ToString();
            this.lblOriginalPrice.Text = A.OriginalPrice.ToString();
            this.lblSellingPrice.Text = A.SellingPrice.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItemToCart_Click(object sender, EventArgs e)
        {
            isAddItemToCart = true;
            CurrentCourseID = CourseId;
        }

        private void CourseTypeCard_Click(object sender, EventArgs e)
        {
            /*frmCourseDetail f = new frmCourseDetail(CourseId);
            f.ShowDialog();*/
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            /*frmCourseDetail f = new frmCourseDetail(CourseId);
            f.ShowDialog();*/
        }

        private void pbCourse_Click(object sender, EventArgs e)
        {
            /*frmCourseDetail f = new frmCourseDetail(CourseId);
            f.ShowDialog();*/
        }
    }
}
