using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Models;
using DAL;

namespace UI.UserControls
{
    public partial class ItemInCart : UserControl
    {
        public string CourseId;
        string err;
        public static bool IsRemove = false;
        public static string CurrentID;

        public ItemInCart()
        {
            InitializeComponent();
        }

        public ItemInCart(string courseId)
        {
            InitializeComponent();
            CourseId = courseId;
            BLL.Models.Course A = CourseBLL.Instance.getById(courseId);
            this.lblCourseName.Text = A.CourseName;
            this.lblLecturerName.Text = A.LecturerId; //******
            this.lblAvgRating.Text = A.AvgRating.ToString();
            this.lblOriginalPrice.Text = A.OriginalPrice.ToString();
            this.lblSelingPrice.Text = A.SellingPrice.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            IsRemove = true;
            CurrentID = CourseId;
        }
    }
}
