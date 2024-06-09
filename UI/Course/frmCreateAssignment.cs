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
using UI.Lecturer;
using UI.UserControls;

namespace UI.Course
{
    public partial class frmCreateAssignment : Form
    {
        private string SectionId;

        public frmCreateAssignment()
        {

        }
        public frmCreateAssignment(string sectionId)
        {
            InitializeComponent();
            SectionId = sectionId;
        }

        int i;
        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
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

        private void frm_CreateAssignment_Load(object sender, EventArgs e)
        {
            
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            AssignmentBLL assignmentBLL = new AssignmentBLL();
            BLL.Models.Assignment assignment = new BLL.Models.Assignment();
            assignment.SectionId = SectionId;
            assignment.Title = this.TextBoxTitle.Text;
            assignment.Desc = this.TextBoxDesc.Text;
            assignment.OpenDate = this.OpenDate.Value;
            assignment.DueDate = this.DueDate.Value;
            string err = string.Empty;
            if(assignmentBLL.add(assignment, ref err) == 0)
            {
                MessageBox.Show(err);
            }
            else
            {
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
