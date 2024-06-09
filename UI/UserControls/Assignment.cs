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
using BLL.Models;

namespace UI.UserControls
{
    public partial class Assignment : UserControl
    {
        

        public string titleAssignment
        {
            get { return siticoneButton_Assignment.Text; }
            set { siticoneButton_Assignment.Text = value; }
        }
        public string AssignmentId { get; set; }
        public string SectionId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime DueDate { get; set; }
        public BLL.Models.Assignment AssignmentInfo { get; set; }
        public Assignment()
        {

        }
        public Assignment(BLL.Models.Assignment assignmentInfo)
        {
            InitializeComponent();
            AssignmentInfo = assignmentInfo;
        }

        private void siticoneButton_Assignment_Click(object sender, EventArgs e)
        {      
            Form modalBackground = new Form();
            using (frmAssignmentDetail modal = new frmAssignmentDetail(AssignmentInfo,SectionId))
            {
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.ParentForm.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                modal.ShowDialog();
                modalBackground.Dispose();
            }

        }
    }
}
