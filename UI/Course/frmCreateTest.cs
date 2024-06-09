using BLL;
using BLL.Models;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UserControls;

namespace UI.Course
{
    public partial class frmCreateTest : Form
    {
        private string TestId;
        private string SectionId;
        public bool isLoad = false;
        public frmCreateTest(string sectionId)
        {
            InitializeComponent();
            SectionId = sectionId;
        }

        private void siticoneButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonAddQuestion_Click(object sender, EventArgs e)
        {
            BLL.Models.Test test = new BLL.Models.Test();
            test.SectionId = SectionId;
            test.Name = this.TextBoxNameOfTest.Text;
            test.Time = int.Parse(this.TextBoxTime.Text);
            string err = string.Empty;
            if(TestBLL.Instance.add(test,ref err) == 0)
            {
                MessageBox.Show(err);
            }
            else
            {
                TestId = TestBLL.Instance.GetLastestAddedTest();
                frmCreateQuestion frmCreateQuestion = new frmCreateQuestion(TestId,ref isLoad);
                frmCreateQuestion.Show();
            }
        }

        private void frmCreateTest_Load(object sender, EventArgs e)
        {
            this.siticoneShadowForm1.SetShadowForm(this);
        }
    }
}
