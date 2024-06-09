namespace UI
{
    partial class frmLearnerHome
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
            this.components = new System.ComponentModel.Container();
            this.plCourse = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // plCourse
            // 
            this.plCourse.AutoScroll = true;
            this.plCourse.Location = new System.Drawing.Point(12, 12);
            this.plCourse.Name = "plCourse";
            this.plCourse.Size = new System.Drawing.Size(1176, 556);
            this.plCourse.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 580);
            this.Controls.Add(this.plCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frm_DisplayCourseList";
            this.Load += new System.EventHandler(this.frm_DisplayCourseList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel plCourse;
        private System.Windows.Forms.Timer timer1;
    }
}