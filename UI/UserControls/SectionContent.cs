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
using UI.Course;
using static System.Net.Mime.MediaTypeNames;

namespace UI.UserControls
{
    public partial class s : UserControl
    {
        public bool isCompleted = false;
        private bool isMaterialOpen = true;
        private bool isMaterialDone = false;
        private bool isAssignmentOpen = true;
        private bool isAssignmentDone = false;
        private bool isTestOpen = true;
        private bool isTestDone = false;
        private string LearnerId;
        private string SectionId;
        private string PathVideo;
        private string Type;
        public s(string learnerId, string sectionId)
        {
            InitializeComponent();
            this.Location = new Point(0, 10);
            LearnerId = learnerId;
            SectionId = sectionId;
            PathVideo = VideoBLL.Instance.getPathBySectionId(SectionId);
            Init();
            Type = frmLogin.CurAcc.Type;
            if(Type == "2")
            {
                this.ButtonAddVideo.Hide();
            }
        }
        private void Init()
        {
            if (PathVideo == "")
            {
                return;
            }
            Video.Navigate(PathVideo);
        }
        private void ButtonMaterial_Click(object sender, EventArgs e)
        {
            IsCompleted();
            this.isMaterialDone = true;
            if (isMaterialDone)
            {
                this.ButtonMaterial.CustomImages.Image = Properties.Resources.checked1;
            }
            DataTable materials = FileBLL.Instance.getAllFileOfSection(SectionId);
            if (this.isMaterialOpen)
            {
                this.ButtonMaterial.Image = Properties.Resources.down_arrow;
                int y = 20;
                for (int i = 0; i < materials.Rows.Count; i++)
                {
                    File file = new File();
                    file.fileName = (string)materials.Rows[i][1];
                    string type = (string)materials.Rows[i][2];
                    file.url = (string)materials.Rows[i][3];
                    switch (type)
                    {
                        case ".pdf":
                            file.image = Properties.Resources.pdf;
                            break;
                        case ".docx":
                            file.image = Properties.Resources.docx;
                            break;
                        case ".txt":
                            file.image = Properties.Resources.txt;
                            break;
                        default:
                            break;
                    }
                    y += 75;
                    file.Location = new Point(30, y);
                    this.PanelMaterials.Controls.Add(file);
                }
                if (Type == "1")
                {
                    Create_Add_Button("Add File", new Point(85, y + 85));
                }
                this.PanelAssignments.Location = new Point(
                    this.PanelMaterials.Location.X, this.PanelMaterials.Location.Y + this.PanelMaterials.Height);
                this.PanelTests.Location = new Point(
                    this.PanelAssignments.Location.X, this.PanelAssignments.Location.Y + this.PanelAssignments.Height);
                this.isMaterialOpen = false;
            }
            else
            {
                this.ButtonMaterial.Image = Properties.Resources.right_arrow;
                while (this.PanelMaterials.Controls.Count > 1)
                {
                    this.PanelMaterials.Controls.Remove(this.PanelMaterials.Controls[1]);
                }
                this.PanelMaterials.Width = 680;
                this.PanelMaterials.Height = 77;
                this.PanelAssignments.Location = new Point(
                        this.PanelMaterials.Location.X, this.PanelMaterials.Location.Y + this.PanelMaterials.Height);
                this.PanelTests.Location = new Point(
                        this.PanelAssignments.Location.X, this.PanelAssignments.Location.Y + this.PanelAssignments.Height);
                this.isMaterialOpen = true;
            }
        }
        private void ButtonAssignment_Click(object sender, EventArgs e)
        {
            IsCompleted();
            this.isAssignmentDone = true;
            if (isAssignmentDone)
            {
                this.ButtonAssignment.CustomImages.Image = Properties.Resources.checked1;
            }
            DataTable assignments = AssignmentBLL.Instance.getAllAssignmentOfSection(SectionId);
            if (this.isAssignmentOpen)
            {
                this.ButtonAssignment.Image = Properties.Resources.down_arrow;
                int y = 20;
                for (int i = 0; i < assignments.Rows.Count; i++)
                {
                    BLL.Models.Assignment assignmentInfo = new BLL.Models.Assignment();
                    assignmentInfo.AssignmentId = (string)assignments.Rows[i][0];
                    assignmentInfo.Title = (string)assignments.Rows[i][2];
                    assignmentInfo.Desc = (string)assignments.Rows[i][3];
                    assignmentInfo.OpenDate = (DateTime)assignments.Rows[i][4];
                    assignmentInfo.DueDate = (DateTime)assignments.Rows[i][5];
                    Assignment assignment = new Assignment(assignmentInfo);
                    assignment.titleAssignment = (string)assignments.Rows[i][2];
                    y += 85;
                    assignment.Location = new Point(30, y);
                    this.PanelAssignments.Controls.Add(assignment);
                }
                if (Type == "1")
                {
                    Create_Add_Button("Add Assignment", new Point(85, y + 110));
                }
                this.PanelTests.Location = new Point(
                    this.PanelAssignments.Location.X, this.PanelAssignments.Location.Y + this.PanelAssignments.Height);
                this.isAssignmentOpen = false;
            }
            else
            {
                this.ButtonAssignment.Image = Properties.Resources.right_arrow;
                while (this.PanelAssignments.Controls.Count > 1)
                {
                    this.PanelAssignments.Controls.Remove(this.PanelAssignments.Controls[1]);
                }
                this.PanelAssignments.Width = 680;
                this.PanelAssignments.Height = 77;
                this.PanelTests.Location = new Point(
                    this.PanelAssignments.Location.X, this.PanelAssignments.Location.Y + this.PanelAssignments.Height);
                this.isAssignmentOpen = true;
            }
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            IsCompleted();
            this.isTestDone = true;
            if (isTestDone)
            {
                this.ButtonTest.CustomImages.Image = Properties.Resources.checked1;
            }
            DataTable tests = TestBLL.Instance.getAllTestOfSection(SectionId);

            if (this.isTestOpen)
            {
                this.ButtonTest.Image = Properties.Resources.down_arrow;
                int y = 20;
                for (int i = 0; i < tests.Rows.Count; i++)
                {
                    
                    Test test = new Test((string)tests.Rows[i][0], LearnerId, (int)tests.Rows[i][2], (string)tests.Rows[i][1]);
                    test.TestName = (string)tests.Rows[i][1];
                    this.PanelTests.Controls.Add(test);
                    y += 85;
                    test.Location = new Point(30, y);
                    int isTakedTest = TakeTestBLL.Instance.isExist((string)tests.Rows[i][0], LearnerId);
                    if (Type == "1" || isTakedTest!=0)
                    {
                        test.ButtonStartTest.Hide();
                    }
                    this.PanelTests.Controls.Add(test);
                    if(isTakedTest != 0)
                    {
                        SiticoneHtmlLabel score = new SiticoneHtmlLabel();
                        score.Text = (TakeTestBLL.Instance.GetScoreByTakeTestID((string)tests.Rows[i][0], LearnerId)).ToString();
                        this.Location=new Point(543, 23); 
                    }
                }
                if (Type != "2")
                {
                    Create_Add_Button("Add Test", new Point(85, y + 110));
                }
                
                this.isTestOpen = false;
            }
            else
            {
                this.ButtonTest.Image = Properties.Resources.right_arrow;
                while (this.PanelTests.Controls.Count > 1)
                {
                    this.PanelTests.Controls.Remove(this.PanelTests.Controls[1]);
                }
                this.PanelTests.Width = 680;
                this.PanelTests.Height = 77;
                this.isTestOpen = true;
            }
        }
        private void Create_Add_Button(string text, Point location)
        {
            SiticoneButton button = new SiticoneButton();
            button.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            button.BorderRadius = 10;
            button.BorderThickness = 1;
            button.Cursor = Cursors.Hand;
            button.DisabledState.BorderColor = Color.DarkGray;
            button.DisabledState.CustomBorderColor = Color.DarkGray;
            button.DisabledState.FillColor = Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            button.DisabledState.ForeColor = Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            button.FillColor = Color.White;
            button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            button.Image = global::UI.Properties.Resources.add11;
            button.ImageAlign = HorizontalAlignment.Left;
            button.ImageOffset = new Point(10, 0);
            button.ImageSize = new Size(15, 15);
            button.Padding = new Padding(5);
            button.Location = location;
            button.Name = "ButtonAdd";
            button.Size = new Size(180, 47);
            button.AutoSize = true;
            button.TabIndex = 2;
            button.Text = text;
            button.TextOffset = new Point(15, 0);
            switch (text)
            {
                case "Add File":
                    this.PanelMaterials.Controls.Add(button);
                    break;
                case "Add Assignment":
                    this.PanelAssignments.Controls.Add(button);
                    break;
                case "Add Test":
                    this.PanelTests.Controls.Add(button);
                    break;
            }
            button.Click += (sender, e) => Add_Button_Click(sender, e, text); ;
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Hide();

        }
        private void Add_Button_Click(object sender, EventArgs e, string type)
        {
            switch (type)
            {
                case "Add File":
                    frmUploadFile frmUpload = new frmUploadFile(SectionId);
                    frmUpload.Show();
                    break;
                case "Add Assignment":
                    frmCreateAssignment frmCreateAssignment = new frmCreateAssignment(SectionId);
                    frmCreateAssignment.Show();
                    break;
                case "Add Test":
                    frmCreateTest frmCreateTest = new frmCreateTest(SectionId);
                    frmCreateTest.Show();
                    break;
            }
        }

        private void ButtonAddVideo_Click(object sender, EventArgs e)
        {
            frmAddVideo f = new frmAddVideo(SectionId);
            f.Show();
        }
        private void IsCompleted()
        {
            if (isMaterialDone && isAssignmentDone && isTestDone)
            {
                isCompleted = true;
                string err = string.Empty;
                SectionBLL.Instance.SetCompletion(SectionId, ref err);
            }
        }
    }
}