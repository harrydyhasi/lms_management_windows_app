using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class Certificate : UserControl
    {
        private string Learner;
        private string Course;

        public Certificate(string username, string course)
        {
            InitializeComponent();
            Learner = username;
            Course = course;
            Init();
        }
        private void Init()
        {
            //this.panel1.Controls.Add(pictureBox1);
            this.panel1.Controls.Add(pictureBox2);
            //pictureBox1.SendToBack();
            panel1.BackgroundImage = UI.Properties.Resources.Certificate;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

            this.panel1.Controls.Add(lblNameLearner);
            this.panel1.Controls.Add(lblCourse);
            lblNameLearner.BringToFront();
            lblCourse.BringToFront();

            lbltime.Hide();
            AccountInfor t = AccountBLL.Instance.GetAccountInfor(Learner);
            string name = String.Format("{0} {1} {2}", t.FName, t.MName, t.LName);
            lblNameLearner.Text = name;
            lblNameLearner.Location = new Point(330 - (int)(name.Length / 2), 251);
            BLL.Models.Course c = CourseBLL.Instance.getById(Course);
            lblCourse.Text = c.CourseName;
            lblCourse.Location = new Point(390 - (int)(c.CourseName.Length / 2), 327);
            this.panel1.Controls.Remove(lbltime);

        }
        public void Print()
        {
            this.panel1.Controls.Add(lbltime);
            lbltime.Text = DateTime.Now.ToString();
        }

        
    }
}
