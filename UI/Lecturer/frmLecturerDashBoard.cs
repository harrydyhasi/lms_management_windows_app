using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Lecturer
{
    public partial class frmLecturerDashBoard : Form
    {

        private string LecturerId;
        public frmLecturerDashBoard(string lecturerId)
        {
            InitializeComponent();
            LecturerId = lecturerId;
            this.btnCourseOverview.Checked = true;
        }

        private void frmLecturerDashBoard_Load(object sender, EventArgs e)
        {
            this.ShadowForm.SetShadowForm(this);
        }

        private void btnCourseOverview_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlContainer.Controls.Clear();
            frmLecCourseOverView A = new frmLecCourseOverView(LecturerId);
            A.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(A);

        }

        private void btnViewProfile_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlContainer.Controls.Clear();
            frmViewProfile A = new frmViewProfile(LecturerId);
            A.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(A);
        }
    }
}
