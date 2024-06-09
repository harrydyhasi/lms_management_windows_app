namespace UI.Course
{
    partial class frmCreateSection
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
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.LabelSectionName = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.TextBoxSectionName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ButtonCreate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.siticoneHtmlLabel1);
            this.siticonePanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(480, 60);
            this.siticonePanel2.TabIndex = 1;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(182, 11);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(140, 30);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "Create Section";
            // 
            // LabelSectionName
            // 
            this.LabelSectionName.BackColor = System.Drawing.Color.Transparent;
            this.LabelSectionName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelSectionName.Location = new System.Drawing.Point(23, 107);
            this.LabelSectionName.Name = "LabelSectionName";
            this.LabelSectionName.Size = new System.Drawing.Size(105, 23);
            this.LabelSectionName.TabIndex = 2;
            this.LabelSectionName.Text = "Section Name";
            // 
            // TextBoxSectionName
            // 
            this.TextBoxSectionName.DefaultText = "";
            this.TextBoxSectionName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSectionName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSectionName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSectionName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSectionName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSectionName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSectionName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSectionName.Location = new System.Drawing.Point(188, 107);
            this.TextBoxSectionName.Name = "TextBoxSectionName";
            this.TextBoxSectionName.PasswordChar = '\0';
            this.TextBoxSectionName.PlaceholderText = "";
            this.TextBoxSectionName.SelectedText = "";
            this.TextBoxSectionName.Size = new System.Drawing.Size(267, 36);
            this.TextBoxSectionName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(134, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "*";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonCancel.BorderRadius = 5;
            this.ButtonCancel.BorderThickness = 1;
            this.ButtonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCancel.FillColor = System.Drawing.Color.White;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonCancel.Location = new System.Drawing.Point(212, 179);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(110, 38);
            this.ButtonCancel.TabIndex = 58;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BorderRadius = 5;
            this.ButtonCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreate.ForeColor = System.Drawing.Color.White;
            this.ButtonCreate.Location = new System.Drawing.Point(345, 179);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(110, 38);
            this.ButtonCreate.TabIndex = 57;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // frmCreateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 238);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxSectionName);
            this.Controls.Add(this.LabelSectionName);
            this.Controls.Add(this.siticonePanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateSection";
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelSectionName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxSectionName;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonCancel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonCreate;
    }
}