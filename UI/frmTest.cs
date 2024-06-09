using Siticone.Desktop.UI.WinForms;
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
using UI.UserControls;
using BLL;
using BLL.Models;

namespace UI
{
    public partial class frmTest : Form
    {
        public string TestId { get; set; }
        public string LearnerId { get; set; }
        public int Time { get; set; }
        public string Name { get; set; }

        public static System.Windows.Forms.Timer Timer;
        public static int remainingTime_Minute;
        public static int remainingTime_Second;
        public DataTable questions;
        public DataTable takeTest;
        string err = string.Empty;

        public frmTest()
        {

        }
        public frmTest(string testId, string learnerId, int time, string name)
        {
            InitializeComponent();
            TestId = testId;
            LearnerId = learnerId;
            Time = time;
            Name = name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime_Minute == 0 && remainingTime_Second == 0)
                Timer.Stop();
            else if (remainingTime_Second == 0)
                {
                    remainingTime_Second = 59;
                    remainingTime_Minute--;
                }
            if(remainingTime_Second < 10)
                this.siticoneHtmlLabel_RemainingTime.Text = remainingTime_Minute.ToString() + ":0" + remainingTime_Second.ToString();
            else
                this.siticoneHtmlLabel_RemainingTime.Text = remainingTime_Minute.ToString() + ":" + remainingTime_Second.ToString();
            remainingTime_Second--;
        }
        
        private void frm_Test_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel_BodyTest.BringToFront();
            questions = QuestionBLL.Instance.getAllQuestionOfTest(TestId);
            int numOfQuestions = questions.Rows.Count;
            this.LabelTestName.Text = Name;
            this.LabelTime.Text = Time.ToString();
            this.LabelNumOfQuestions.Text = numOfQuestions.ToString() + " Questions";
            for (int i = 0; i < questions.Rows.Count; i++)
            {
                UI.UserControls.Question question = new UI.UserControls.Question();
                question.LabelText = "Question " + (i+1) + ": " + (string)questions.Rows[i][1];
                object point = questions.Rows[i][3];
                question.LabelPoint = "Point " + point.ToString();
                question.Type = (bool)questions.Rows[i][2];
                question.QuestionId = (string)questions.Rows[i][0];
                string[] array = ((string)questions.Rows[i][4]).Split("-");
                
                if (question.Type)
                 {
                    int count = 0;
                    foreach (string choiceText in array)
                    {
                        count++;
                        SiticoneRadioButton choice = new SiticoneRadioButton();
                        choice.Text = choiceText;
                        choice.AutoSize = true;
                        choice.Name = "choice" + count;
                        question.PanelChoices.Controls.Add(choice);
                    }            
                    this.flowLayoutPanel_BodyTest.Controls.Add(question);
                }
                else 
                {
                    foreach (string choiceText in array)
                    {
                        SiticoneCheckBox choice = new SiticoneCheckBox();
                        choice.Text = choiceText;
                        choice.AutoSize = true;
                        question.PanelChoices.Controls.Add(choice);
                    }
                    this.flowLayoutPanel_BodyTest.Controls.Add(question);
                }
                QuestionListItem question_List_Item = new QuestionListItem();
                this.flowLayoutPanel_Question_list_item.Controls.Add(question_List_Item);
            }

            takeTest = questions;
            Timer = new System.Windows.Forms.Timer();
            remainingTime_Minute = Time;
            remainingTime_Second = 0;
            Timer.Interval = 1000; // 1 second
            Timer.Start();
            Timer.Tick += new EventHandler(timer1_Tick);
            this.siticoneHtmlLabel_RemainingTime.Text = remainingTime_Minute.ToString() + ":" + remainingTime_Second.ToString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            TakeQuestionBLL takeQuestionBLL = new TakeQuestionBLL();
            foreach (UI.UserControls.Question question in flowLayoutPanel_BodyTest.Controls)
            {
                string answer = "";
                
                foreach(Control option in question.PanelChoices.Controls)
                {
                    if (question.Type)
                    {
                    SiticoneRadioButton op = (SiticoneRadioButton)option;
                        if (op.Checked)
                            answer = option.Text;
                    }
                    else
                    {
                        SiticoneCheckBox op = (SiticoneCheckBox)option;
                        if (op.Checked)
                        {
                            if(answer == "")
                                answer += op.Text;
                            else
                                answer += "-" + option.Text;
                        }
                    }
                }
                answer = (string)answer;
                
                TakeQuestion t = new TakeQuestion();
                t.LearnerId = LearnerId;
                t.QuestionId = question.QuestionId;
                t.AnswerChoice = answer;
                err = string.Empty;
                if (takeQuestionBLL.add(t, ref err) == 0)
                {
                    MessageBox.Show(err);
                }
            }
            TakeTest takeTest = new TakeTest(LearnerId, TestId, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:fff"));
            takeTest.LearnerId = LearnerId;
            takeTest.TestId = TestId;
            err = string.Empty;
            TakeTestBLL takeTestBLL = new TakeTestBLL();
            if (takeTestBLL.add(takeTest, ref err) == 0)
            {
                MessageBox.Show(err);
            }
            Timer.Stop();
            MessageBox.Show("Submittion is successfull.");
            this.Close();
        }
    }
}
