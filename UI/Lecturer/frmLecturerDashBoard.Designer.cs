namespace UI.Lecturer
{
    partial class frmLecturerDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            btnViewProfile = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnCourseOverview = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ShadowForm = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(components);
            siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            pnlContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            siticonePanel1.SuspendLayout();
            siticonePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(btnViewProfile);
            siticonePanel1.Controls.Add(btnCourseOverview);
            siticonePanel1.Location = new Point(0, 71);
            siticonePanel1.Margin = new Padding(3, 4, 3, 4);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.ShadowDecoration.Depth = 5;
            siticonePanel1.ShadowDecoration.Enabled = true;
            siticonePanel1.ShadowDecoration.Shadow = new Padding(3, 3, 5, 3);
            siticonePanel1.Size = new Size(229, 805);
            siticonePanel1.TabIndex = 0;
            // 
            // btnViewProfile
            // 
            btnViewProfile.BackColor = Color.White;
            btnViewProfile.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnViewProfile.CheckedState.CustomBorderColor = Color.FromArgb(0, 65, 158);
            btnViewProfile.CheckedState.FillColor = Color.White;
            btnViewProfile.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnViewProfile.DisabledState.BorderColor = Color.DarkGray;
            btnViewProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnViewProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnViewProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnViewProfile.FillColor = Color.White;
            btnViewProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewProfile.ForeColor = Color.FromArgb(31, 31, 31);
            btnViewProfile.HoverState.BorderColor = Color.White;
            btnViewProfile.HoverState.CustomBorderColor = Color.White;
            btnViewProfile.HoverState.FillColor = Color.White;
            btnViewProfile.HoverState.ForeColor = Color.FromArgb(0, 65, 158);
            btnViewProfile.Location = new Point(0, 69);
            btnViewProfile.Margin = new Padding(3, 4, 3, 4);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.PressedDepth = 0;
            btnViewProfile.Size = new Size(229, 60);
            btnViewProfile.TabIndex = 1;
            btnViewProfile.Text = "View Profile";
            btnViewProfile.TextAlign = HorizontalAlignment.Left;
            btnViewProfile.TextOffset = new Point(15, 0);
            btnViewProfile.CheckedChanged += btnViewProfile_CheckedChanged;
            // 
            // btnCourseOverview
            // 
            btnCourseOverview.BackColor = Color.White;
            btnCourseOverview.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnCourseOverview.CheckedState.CustomBorderColor = Color.FromArgb(0, 65, 158);
            btnCourseOverview.CheckedState.FillColor = Color.White;
            btnCourseOverview.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnCourseOverview.DisabledState.BorderColor = Color.DarkGray;
            btnCourseOverview.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCourseOverview.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCourseOverview.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCourseOverview.FillColor = Color.White;
            btnCourseOverview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourseOverview.ForeColor = Color.FromArgb(31, 31, 31);
            btnCourseOverview.HoverState.BorderColor = Color.White;
            btnCourseOverview.HoverState.CustomBorderColor = Color.White;
            btnCourseOverview.HoverState.FillColor = Color.White;
            btnCourseOverview.HoverState.ForeColor = Color.FromArgb(0, 65, 158);
            btnCourseOverview.Location = new Point(0, 1);
            btnCourseOverview.Margin = new Padding(3, 4, 3, 4);
            btnCourseOverview.Name = "btnCourseOverview";
            btnCourseOverview.PressedDepth = 0;
            btnCourseOverview.Size = new Size(229, 60);
            btnCourseOverview.TabIndex = 0;
            btnCourseOverview.Text = "Course Overview";
            btnCourseOverview.TextAlign = HorizontalAlignment.Left;
            btnCourseOverview.TextOffset = new Point(15, 0);
            btnCourseOverview.CheckedChanged += btnCourseOverview_CheckedChanged;
            // 
            // siticonePanel2
            // 
            siticonePanel2.BackColor = Color.FromArgb(0, 65, 158);
            siticonePanel2.Controls.Add(siticoneControlBox1);
            siticonePanel2.Dock = DockStyle.Top;
            siticonePanel2.Location = new Point(0, 0);
            siticonePanel2.Margin = new Padding(3, 4, 3, 4);
            siticonePanel2.Name = "siticonePanel2";
            siticonePanel2.Size = new Size(1353, 72);
            siticonePanel2.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.FillColor = Color.FromArgb(0, 65, 158);
            siticoneControlBox1.IconColor = Color.White;
            siticoneControlBox1.Location = new Point(1319, 16);
            siticoneControlBox1.Margin = new Padding(3, 4, 3, 4);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.Size = new Size(24, 28);
            siticoneControlBox1.TabIndex = 0;
            // 
            // pnlContainer
            // 
            pnlContainer.Location = new Point(235, 80);
            pnlContainer.Margin = new Padding(3, 4, 3, 4);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1107, 796);
            pnlContainer.TabIndex = 2;
            // 
            // frmLecturerDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1353, 881);
            Controls.Add(pnlContainer);
            Controls.Add(siticonePanel2);
            Controls.Add(siticonePanel1);
            ForeColor = Color.FromArgb(31, 31, 31);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLecturerDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLecturerDashBoard";
            Load += frmLecturerDashBoard_Load;
            siticonePanel1.ResumeLayout(false);
            siticonePanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm ShadowForm;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewProfile;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCourseOverview;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlContainer;
    }
}