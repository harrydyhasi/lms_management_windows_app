namespace UI.Course
{
    partial class frmCourseDetail
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
            this.siticonePanel_Body = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.ButtonHome = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ButtonForum = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ButtonContent = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PanelContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblCourseName = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel3.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel_Body
            // 
            this.siticonePanel_Body.Location = new System.Drawing.Point(250, 0);
            this.siticonePanel_Body.Name = "siticonePanel_Body";
            this.siticonePanel_Body.Size = new System.Drawing.Size(950, 600);
            this.siticonePanel_Body.TabIndex = 1;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.BackColor = System.Drawing.Color.White;
            this.siticonePanel3.BorderThickness = 1;
            this.siticonePanel3.Controls.Add(this.ButtonHome);
            this.siticonePanel3.Controls.Add(this.ButtonForum);
            this.siticonePanel3.Controls.Add(this.ButtonContent);
            this.siticonePanel3.Location = new System.Drawing.Point(-1, 0);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(250, 600);
            this.siticonePanel3.TabIndex = 0;
            // 
            // ButtonHome
            // 
            this.ButtonHome.BorderColor = System.Drawing.Color.White;
            this.ButtonHome.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonHome.Checked = true;
            this.ButtonHome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonHome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonHome.CheckedState.FillColor = System.Drawing.Color.White;
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonHome.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHome.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.ButtonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonHome.FillColor = System.Drawing.Color.White;
            this.ButtonHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonHome.ForeColor = System.Drawing.Color.Black;
            this.ButtonHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHome.ImageOffset = new System.Drawing.Point(15, 0);
            this.ButtonHome.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonHome.Location = new System.Drawing.Point(0, 149);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(250, 50);
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHome.TextOffset = new System.Drawing.Point(25, 0);
            this.ButtonHome.Click += new System.EventHandler(this.siticoneButton_Content_Click);
            // 
            // ButtonForum
            // 
            this.ButtonForum.BorderColor = System.Drawing.Color.White;
            this.ButtonForum.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonForum.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonForum.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonForum.CheckedState.FillColor = System.Drawing.Color.White;
            this.ButtonForum.CheckedState.Image = global::UI.Properties.Resources.forum21;
            this.ButtonForum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonForum.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonForum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonForum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonForum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonForum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonForum.FillColor = System.Drawing.Color.White;
            this.ButtonForum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonForum.ForeColor = System.Drawing.Color.Black;
            this.ButtonForum.Image = global::UI.Properties.Resources.forum1;
            this.ButtonForum.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonForum.ImageOffset = new System.Drawing.Point(15, 0);
            this.ButtonForum.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonForum.Location = new System.Drawing.Point(0, 249);
            this.ButtonForum.Name = "ButtonForum";
            this.ButtonForum.Size = new System.Drawing.Size(250, 50);
            this.ButtonForum.TabIndex = 4;
            this.ButtonForum.Text = "Forum";
            this.ButtonForum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonForum.TextOffset = new System.Drawing.Point(25, 0);
            this.ButtonForum.Click += new System.EventHandler(this.siticoneButton_Forum_Click);
            // 
            // ButtonContent
            // 
            this.ButtonContent.BorderColor = System.Drawing.Color.White;
            this.ButtonContent.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonContent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonContent.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonContent.CheckedState.FillColor = System.Drawing.Color.White;
            this.ButtonContent.CheckedState.Image = global::UI.Properties.Resources.content2;
            this.ButtonContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonContent.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonContent.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonContent.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.ButtonContent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonContent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonContent.FillColor = System.Drawing.Color.White;
            this.ButtonContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonContent.ForeColor = System.Drawing.Color.Black;
            this.ButtonContent.Image = global::UI.Properties.Resources.content1;
            this.ButtonContent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonContent.ImageOffset = new System.Drawing.Point(15, 0);
            this.ButtonContent.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonContent.Location = new System.Drawing.Point(0, 196);
            this.ButtonContent.Name = "ButtonContent";
            this.ButtonContent.Size = new System.Drawing.Size(250, 50);
            this.ButtonContent.TabIndex = 0;
            this.ButtonContent.Text = "Content";
            this.ButtonContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonContent.TextOffset = new System.Drawing.Point(25, 0);
            this.ButtonContent.Click += new System.EventHandler(this.siticoneButton_Content_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Controls.Add(this.siticonePanel3);
            this.PanelContainer.Controls.Add(this.siticonePanel_Body);
            this.PanelContainer.Location = new System.Drawing.Point(0, 100);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1200, 600);
            this.PanelContainer.TabIndex = 5;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1155, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedColor = System.Drawing.Color.IndianRed;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 30);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1110, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 30);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Controls.Add(this.lblCourseName);
            this.siticonePanel1.CustomBorderColor = System.Drawing.Color.DimGray;
            this.siticonePanel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1200, 100);
            this.siticonePanel1.TabIndex = 4;
            // 
            // lblCourseName
            // 
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblCourseName.Location = new System.Drawing.Point(32, 25);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(203, 47);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name";
            // 
            // frmCourseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCourseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Course";
            this.siticonePanel3.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel_Body;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonForum;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonContent;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCourseName;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonHome;
    }
}