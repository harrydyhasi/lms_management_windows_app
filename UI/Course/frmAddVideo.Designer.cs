namespace UI.Course
{
    partial class frmAddVideo
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBrowse = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TextboxVideoPath = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.ButtonCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ButtonAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(117, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "*";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.BorderRadius = 5;
            this.ButtonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBrowse.ForeColor = System.Drawing.Color.White;
            this.ButtonBrowse.Location = new System.Drawing.Point(152, 166);
            this.ButtonBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(88, 26);
            this.ButtonBrowse.TabIndex = 59;
            this.ButtonBrowse.Text = "Browse";
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // TextboxVideoPath
            // 
            this.TextboxVideoPath.DefaultText = "";
            this.TextboxVideoPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextboxVideoPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextboxVideoPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxVideoPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxVideoPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxVideoPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextboxVideoPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxVideoPath.Location = new System.Drawing.Point(152, 109);
            this.TextboxVideoPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxVideoPath.Name = "TextboxVideoPath";
            this.TextboxVideoPath.PasswordChar = '\0';
            this.TextboxVideoPath.PlaceholderText = "";
            this.TextboxVideoPath.SelectedText = "";
            this.TextboxVideoPath.Size = new System.Drawing.Size(361, 37);
            this.TextboxVideoPath.TabIndex = 58;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(36, 123);
            this.siticoneHtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(79, 23);
            this.siticoneHtmlLabel3.TabIndex = 57;
            this.siticoneHtmlLabel3.Text = "Link of file";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(233, 11);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(101, 30);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "Add Video";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonCancel.BorderRadius = 5;
            this.ButtonCancel.BorderThickness = 1;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCancel.FillColor = System.Drawing.Color.White;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonCancel.Location = new System.Drawing.Point(276, 216);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(110, 38);
            this.ButtonCancel.TabIndex = 56;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BorderRadius = 5;
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(403, 216);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(110, 38);
            this.ButtonAdd.TabIndex = 55;
            this.ButtonAdd.Text = "Upload";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.siticoneHtmlLabel1);
            this.siticonePanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(560, 60);
            this.siticonePanel2.TabIndex = 0;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.ButtonBrowse);
            this.siticonePanel1.Controls.Add(this.TextboxVideoPath);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel3);
            this.siticonePanel1.Controls.Add(this.ButtonCancel);
            this.siticonePanel1.Controls.Add(this.ButtonAdd);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(560, 300);
            this.siticonePanel1.TabIndex = 2;
            // 
            // siticoneShadowForm1
            // 
            this.siticoneShadowForm1.Load += new System.EventHandler(this.siticoneShadowForm1_Load);
            // 
            // frmAddVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddVideo";
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonBrowse;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextboxVideoPath;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonCancel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonAdd;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
    }
}