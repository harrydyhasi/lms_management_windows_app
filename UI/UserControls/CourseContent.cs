using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Models;
using Siticone.Desktop.UI.WinForms;
using UI.Course;
using static System.Collections.Specialized.BitVector32;

namespace UI.UserControls
{
    public partial class CourseContent : UserControl
    {
        private string CourseId;
        private string AccountId;
        public CourseContent(string courseId, string accountId)
        {
            InitializeComponent();
            CourseId = courseId;
            AccountId = accountId;
        }

        private void Course_content_Load(object sender, EventArgs e)
        {
            DataTable sections = SectionBLL.Instance.getAllSectionOfCourse(CourseId);
            
            for (int i=0; i<sections.Rows.Count; i++)
            {
                AddSectionItems(sections, i);
            }
            Create_Add_Button();
            

        }

        private void AddSectionItems(DataTable sections, int count)
        {
            SiticoneButton section = new SiticoneButton();
            section.DisabledState.BorderColor = Color.DarkGray;
            section.DisabledState.CustomBorderColor = Color.DarkGray;
            section.DisabledState.FillColor = Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            section.DisabledState.ForeColor = Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            section.FillColor = Color.White;
            section.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            section.ForeColor = Color.Black;
            //section.Image = global::UI.Properties.Resources._checked;
            section.ImageAlign = HorizontalAlignment.Right;
            section.ImageOffset = new Point(50, 0);
            section.ImageSize = new Size(30, 30);
            section.Location = new Point(0, 0);
            section.Size = new Size(680, 75);
            section.TabIndex = 4;
            section.TextAlign = HorizontalAlignment.Left;
            section.TextOffset = new Point(50, 0);
            section.Click += (sender, e) => Section_Click(sender, e, (string)sections.Rows[count][0]); ;
            section.Text = "Section " + (count+1) + ": " + (string)sections.Rows[count][1];
            this.PanelContainer.Controls.Add(section);
        }

        private void Section_Click(object sender, EventArgs e,string sectionId)
        {
            s sectionContent = new s(AccountId,sectionId);
            sectionContent.Location = new Point(95, 150);
            this.Controls.Add(sectionContent);
            this.PanelContainer.SendToBack();

        }
        private void Create_Add_Button()
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
            button.Location = new Point(0,0);
            button.Margin = new Padding(50,10,0,0);
            button.Name = "ButtonAdd";
            button.Size = new Size(180, 47);
            button.AutoSize = true;
            button.TabIndex = 2;
            button.Text = "Add Section";
            button.TextOffset = new Point(15, 0);
            button.Click += (sender, e) => Add_Button_Click(sender, e); ;
            this.PanelContainer.Controls.Add(button);  
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            frmCreateSection frmCreateSection = new frmCreateSection(CourseId);
            frmCreateSection.Show();
        }
    }
}
