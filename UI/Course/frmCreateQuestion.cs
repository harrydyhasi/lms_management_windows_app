using BLL;
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
    public partial class frmCreateQuestion : Form
    {
        private string TestId;
        public bool isLoad;
        public frmCreateQuestion(string testId,ref bool isLoad)
        {
            InitializeComponent();
            TestId = testId;
            this.isLoad = isLoad;
        }

        private void ComboBoxNumOfChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelContainer.Controls.Clear();
            int y = 0;
            for(int i=0;i < int.Parse(this.ComboBoxNumOfChoices.SelectedItem.ToString()); i++)
            {
                SiticoneTextBox textBox = new SiticoneTextBox();
                textBox.Size = new Size(590, 30);
                textBox.Location = new Point(0, y);
                this.PanelContainer.Controls.Add(textBox);
                y += 40;
            }
        }

        private void ButtonAddQuestion_Click(object sender, EventArgs e)
        {
            BLL.Models.Question question = new BLL.Models.Question();
            question.Text = this.TextBoxTextOfQuestion.Text;
            question.TestId = TestId;
            if(ComboBoxType.Text == "Checkboxes")
            {
                question.Type = false;
            }
            else
            {
                question.Type = true;
            }
            question.Point = float.Parse(TextBoxPoint.Text);
            question.CorrectAnswer = this.TextBoxCorrectAnwser.Text;
            string choices = "";
            foreach (SiticoneTextBox choice in PanelContainer.Controls)
            {
                if(choices == "")
                {
                    choices += choice.Text;
                }
                else
                {
                    choices += "-" + choice.Text;
                }
            }
            question.Choices = choices;
            string err = string.Empty;
            if (QuestionBLL.Instance.add(question,ref err) == 0)
            {
                MessageBox.Show(err);
            }
            else
            {
                isLoad = true;
                this.Close();
            }
        }
    }
}
