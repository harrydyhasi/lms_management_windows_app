namespace UI.UserControls
{
    partial class Assignment
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton_Assignment = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.siticoneButton_Assignment);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(680, 75);
            this.siticonePanel1.TabIndex = 0;
            // 
            // siticoneButton_Assignment
            // 
            this.siticoneButton_Assignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton_Assignment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_Assignment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_Assignment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_Assignment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_Assignment.FillColor = System.Drawing.Color.White;
            this.siticoneButton_Assignment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton_Assignment.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton_Assignment.Image = global::UI.Properties.Resources.upload;
            this.siticoneButton_Assignment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.siticoneButton_Assignment.ImageOffset = new System.Drawing.Point(80, 0);
            this.siticoneButton_Assignment.Location = new System.Drawing.Point(0, 0);
            this.siticoneButton_Assignment.Name = "siticoneButton_Assignment";
            this.siticoneButton_Assignment.Size = new System.Drawing.Size(680, 75);
            this.siticoneButton_Assignment.TabIndex = 3;
            this.siticoneButton_Assignment.Text = "Assignment 1";
            this.siticoneButton_Assignment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton_Assignment.TextOffset = new System.Drawing.Point(50, 0);
            this.siticoneButton_Assignment.Click += new System.EventHandler(this.siticoneButton_Assignment_Click);
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel1);
            this.Name = "Assignment";
            this.Size = new System.Drawing.Size(680, 75);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_Assignment;
    }
}
