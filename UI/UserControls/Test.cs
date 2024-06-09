using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace UI.UserControls
{
    public partial class Test : UserControl
    {
        
        public string TestName
        {
            get { return siticoneButton_Test.Text; }
            set { siticoneButton_Test.Text = value; }
        }
        public string LearnerId { get; set; }
        public string TestId { get; set; }
        public int Time { get; set; }
        public string Name { get; set; }
        
        public Test(string testId,string learnerId,int time,string name)
        {
            InitializeComponent();
            TestId = testId;
            LearnerId = learnerId;
            Time = time;
            Name = name;

        }
        
        private void siticoneButton_StartTest_Click(object sender, EventArgs e)
        {
            Form frmTest = new frmTest(TestId,LearnerId,Time,Name);
            frmTest.Show();
            frmTest.BringToFront();
        }

        
        
    }
}
