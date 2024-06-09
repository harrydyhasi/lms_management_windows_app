using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;
namespace UI.Course
{
    public partial class frmAssignmentDetail : Form
    {
        private string SectionId;
        public frmAssignmentDetail(Assignment assignmentInfo, string sectionId)
        {
            InitializeComponent();
            this.SectionId = sectionId;
            this.labelTitle.Text = this.labelTitle.Text + " " + assignmentInfo.Title;
            this.labelDesc.Text = this.labelDesc.Text + " " + assignmentInfo.Desc;
            this.labelOpenDate.Text = this.labelOpenDate.Text + " " + assignmentInfo.OpenDate;
            this.labelDueDate.Text = this.labelDueDate.Text + " " + assignmentInfo.DueDate;
        }

        private void siticoneButton_AddSubmit_Click(object sender, EventArgs e)
        {
            frmUploadFile frm_UploadFile = new frmUploadFile(SectionId);
            frm_UploadFile.Show();
        }
        int i;
        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .04;
            }

            int y = frmCourseDetail.parentY += 3;
            this.Location = new Point(frmCourseDetail.parentX + 100, y);
            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }
    }
}
