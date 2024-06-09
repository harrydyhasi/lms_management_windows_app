namespace UI.Course
{
    partial class frmAssignmentDetail
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labelDueDate = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.labelOpenDate = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.labelDesc = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton_AddSubmit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.labelTitle = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.labelDueDate);
            this.siticonePanel1.Controls.Add(this.labelOpenDate);
            this.siticonePanel1.Controls.Add(this.labelDesc);
            this.siticonePanel1.Controls.Add(this.siticoneButton_AddSubmit);
            this.siticonePanel1.Controls.Add(this.labelTitle);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(560, 350);
            this.siticonePanel1.TabIndex = 2;
            // 
            // labelDueDate
            // 
            this.labelDueDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDueDate.Location = new System.Drawing.Point(55, 241);
            this.labelDueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(77, 23);
            this.labelDueDate.TabIndex = 61;
            this.labelDueDate.Text = "Due date :";
            // 
            // labelOpenDate
            // 
            this.labelOpenDate.BackColor = System.Drawing.Color.Transparent;
            this.labelOpenDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpenDate.Location = new System.Drawing.Point(55, 191);
            this.labelOpenDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelOpenDate.Name = "labelOpenDate";
            this.labelOpenDate.Size = new System.Drawing.Size(88, 23);
            this.labelOpenDate.TabIndex = 60;
            this.labelOpenDate.Text = "Open date :";
            // 
            // labelDesc
            // 
            this.labelDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDesc.Location = new System.Drawing.Point(55, 115);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(95, 23);
            this.labelDesc.TabIndex = 57;
            this.labelDesc.Text = "Description :";
            // 
            // siticoneButton_AddSubmit
            // 
            this.siticoneButton_AddSubmit.BorderRadius = 5;
            this.siticoneButton_AddSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton_AddSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_AddSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_AddSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_AddSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_AddSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.siticoneButton_AddSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton_AddSubmit.ForeColor = System.Drawing.Color.White;
            this.siticoneButton_AddSubmit.Location = new System.Drawing.Point(208, 299);
            this.siticoneButton_AddSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneButton_AddSubmit.Name = "siticoneButton_AddSubmit";
            this.siticoneButton_AddSubmit.Size = new System.Drawing.Size(150, 38);
            this.siticoneButton_AddSubmit.TabIndex = 55;
            this.siticoneButton_AddSubmit.Text = "Add submit";
            this.siticoneButton_AddSubmit.Click += new System.EventHandler(this.siticoneButton_AddSubmit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(55, 77);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(43, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title :";
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel2.Controls.Add(this.siticoneHtmlLabel1);
            this.siticonePanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(560, 60);
            this.siticonePanel2.TabIndex = 0;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(515, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 30);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(194, 16);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(174, 30);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "Assignment detail";
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAssignmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 350);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAssignmentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAssignmentDetail";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelDesc;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_AddSubmit;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelTitle;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private OpenFileDialog openFileDialog1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelDueDate;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelOpenDate;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}