namespace UI.UserControls
{
    partial class Test
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
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton_Test = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ButtonStartTest = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(46, 11);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(194, 27);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "Section 1: Title Section";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(92, 40);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(49, 23);
            this.siticoneHtmlLabel2.TabIndex = 3;
            this.siticoneHtmlLabel2.Text = "mm:ss";
            // 
            // siticoneButton_Test
            // 
            this.siticoneButton_Test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton_Test.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_Test.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_Test.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_Test.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_Test.FillColor = System.Drawing.Color.White;
            this.siticoneButton_Test.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton_Test.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton_Test.Location = new System.Drawing.Point(0, 0);
            this.siticoneButton_Test.Name = "siticoneButton_Test";
            this.siticoneButton_Test.Size = new System.Drawing.Size(680, 75);
            this.siticoneButton_Test.TabIndex = 0;
            this.siticoneButton_Test.Text = "Test 1";
            this.siticoneButton_Test.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton_Test.TextOffset = new System.Drawing.Point(46, 0);
            // 
            // ButtonStartTest
            // 
            this.ButtonStartTest.BorderRadius = 5;
            this.ButtonStartTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStartTest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStartTest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStartTest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStartTest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonStartTest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonStartTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonStartTest.ForeColor = System.Drawing.Color.White;
            this.ButtonStartTest.Location = new System.Drawing.Point(543, 23);
            this.ButtonStartTest.Name = "ButtonStartTest";
            this.ButtonStartTest.Size = new System.Drawing.Size(86, 30);
            this.ButtonStartTest.TabIndex = 1;
            this.ButtonStartTest.Text = "Start test";
            this.ButtonStartTest.Click += new System.EventHandler(this.siticoneButton_StartTest_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonStartTest);
            this.Controls.Add(this.siticoneButton_Test);
            this.Name = "Test";
            this.Size = new System.Drawing.Size(680, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_Test;
        public Siticone.Desktop.UI.WinForms.SiticoneButton ButtonStartTest;
    }
}
