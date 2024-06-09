using BLL.Models;
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

namespace UI.Learner
{
    public partial class frmCompleted : UserControl
    {
        private string LearnerId;
        
        public frmCompleted(string learnerId)
        { 
            InitializeComponent();
            LearnerId = learnerId;
            LoadData();
        }

        private void LoadData()
        {
            this.fpnlContainer.Controls.Clear();
            List<BLL.Models.Course> result = CourseBLL.Instance.getLearnerCourseCompleted(LearnerId);
            foreach (var a in result)
            {
                this.fpnlContainer.Controls.Add(new CourseTypeList(a.CourseId, LearnerId, true));
            }
        }
    }
}
