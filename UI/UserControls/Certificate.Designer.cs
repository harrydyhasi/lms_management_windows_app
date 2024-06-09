namespace UI.UserControls
{
    partial class Certificate
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
            lblNameLearner = new Label();
            lblCourse = new Label();
            lbltime = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblNameLearner
            // 
            lblNameLearner.AutoSize = true;
            lblNameLearner.BackColor = Color.FromArgb(255, 249, 243);
            lblNameLearner.Font = new Font("Vladimir Script", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameLearner.Location = new Point(343, 251);
            lblNameLearner.Name = "lblNameLearner";
            lblNameLearner.Size = new Size(150, 36);
            lblNameLearner.TabIndex = 2;
            lblNameLearner.Text = "Name learner";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.BackColor = Color.FromArgb(255, 249, 243);
            lblCourse.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCourse.Location = new Point(355, 324);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(121, 25);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Name course";
            // 
            // lbltime
            // 
            lbltime.AutoSize = true;
            lbltime.BackColor = Color.FromArgb(255, 249, 243);
            lbltime.Location = new Point(529, 450);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(42, 20);
            lbltime.TabIndex = 4;
            lbltime.Text = "Time";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 249, 243);
            pictureBox2.Image = Properties.Resources.owl;
            pictureBox2.Location = new Point(102, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 539);
            panel1.TabIndex = 6;
            // 
            // Certificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(lblCourse);
            Controls.Add(lbltime);
            Controls.Add(lblNameLearner);
            Controls.Add(panel1);
            Name = "Certificate";
            Size = new Size(841, 539);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNameLearner;
        private Label lblCourse;
        private Label lbltime;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}
