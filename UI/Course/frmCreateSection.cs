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

namespace UI.Course
{
    public partial class frmCreateSection : Form
    {
        private string CourseId;
        public frmCreateSection(string courseId)
        {
            InitializeComponent();
            CourseId = courseId;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            SectionBLL sectionBLL = new SectionBLL();
            Section section = new Section(this.TextBoxSectionName.Text,CourseId);
            string err = string.Empty;
            if (sectionBLL.add(section, ref err) == 0)
            {
                MessageBox.Show(err);
            }
        }
    }
}
