namespace UI.Course
{
    partial class CourseByLecturer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseByLecturer));
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnGoToCourse = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblLecName = new System.Windows.Forms.Label();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.siticonePanel1.BorderRadius = 3;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.btnGoToCourse);
            this.siticonePanel1.Controls.Add(this.lblCourseName);
            this.siticonePanel1.Controls.Add(this.lblLecName);
            this.siticonePanel1.Controls.Add(this.siticonePictureBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Depth = 0;
            this.siticonePanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.siticonePanel1.Size = new System.Drawing.Size(950, 142);
            this.siticonePanel1.TabIndex = 1;
            // 
            // btnGoToCourse
            // 
            this.btnGoToCourse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnGoToCourse.BorderRadius = 3;
            this.btnGoToCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGoToCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGoToCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGoToCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGoToCourse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnGoToCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToCourse.ForeColor = System.Drawing.Color.White;
            this.btnGoToCourse.Image = global::UI.Properties.Resources.right_arrow;
            this.btnGoToCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGoToCourse.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnGoToCourse.Location = new System.Drawing.Point(730, 49);
            this.btnGoToCourse.Name = "btnGoToCourse";
            this.btnGoToCourse.Size = new System.Drawing.Size(180, 45);
            this.btnGoToCourse.TabIndex = 4;
            this.btnGoToCourse.Text = "Go to Course";
            this.btnGoToCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGoToCourse.TextOffset = new System.Drawing.Point(15, 0);
            this.btnGoToCourse.Click += new System.EventHandler(this.btnGoToCourse_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblCourseName.Location = new System.Drawing.Point(186, 56);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(471, 30);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "HTML, CSS, and Javascript for Web Developers";
            // 
            // lblLecName
            // 
            this.lblLecName.AutoSize = true;
            this.lblLecName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLecName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblLecName.Location = new System.Drawing.Point(192, 32);
            this.lblLecName.Name = "lblLecName";
            this.lblLecName.Size = new System.Drawing.Size(161, 17);
            this.lblLecName.TabIndex = 2;
            this.lblLecName.Text = "Johns Hopkins University";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BorderRadius = 10;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(14, 20);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(158, 98);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 1;
            this.siticonePictureBox1.TabStop = false;
            // 
            // CourseByLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticonePanel1);
            this.Name = "CourseByLecturer";
            this.Size = new System.Drawing.Size(950, 142);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnGoToCourse;
        private Label lblCourseName;
        private Label lblLecName;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}
