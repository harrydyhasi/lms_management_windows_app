namespace UI.Course
{
    partial class frmUploadFile
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
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.ButtonCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ButtonUpload = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TextboxFileName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.TypesOfFile = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneButton_Browse = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TextboxFilePath = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.ButtonCancel.Location = new System.Drawing.Point(276, 288);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(110, 38);
            this.ButtonCancel.TabIndex = 56;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonUpload
            // 
            this.ButtonUpload.BorderRadius = 5;
            this.ButtonUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonUpload.ForeColor = System.Drawing.Color.White;
            this.ButtonUpload.Location = new System.Drawing.Point(403, 288);
            this.ButtonUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonUpload.Name = "ButtonUpload";
            this.ButtonUpload.Size = new System.Drawing.Size(110, 38);
            this.ButtonUpload.TabIndex = 55;
            this.ButtonUpload.Text = "Upload";
            this.ButtonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // TextboxFileName
            // 
            this.TextboxFileName.DefaultText = "";
            this.TextboxFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextboxFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextboxFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextboxFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxFileName.Location = new System.Drawing.Point(152, 91);
            this.TextboxFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxFileName.Name = "TextboxFileName";
            this.TextboxFileName.PasswordChar = '\0';
            this.TextboxFileName.PlaceholderText = "";
            this.TextboxFileName.SelectedText = "";
            this.TextboxFileName.Size = new System.Drawing.Size(361, 36);
            this.TextboxFileName.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(72, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "*";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(36, 95);
            this.siticoneHtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(35, 23);
            this.siticoneHtmlLabel2.TabIndex = 1;
            this.siticoneHtmlLabel2.Text = "Title";
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
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(221, 16);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(107, 30);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "Upload file";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.TypesOfFile);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel4);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.siticoneButton_Browse);
            this.siticonePanel1.Controls.Add(this.TextboxFilePath);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel3);
            this.siticonePanel1.Controls.Add(this.ButtonCancel);
            this.siticonePanel1.Controls.Add(this.ButtonUpload);
            this.siticonePanel1.Controls.Add(this.TextboxFileName);
            this.siticonePanel1.Controls.Add(this.label5);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel2);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(560, 350);
            this.siticonePanel1.TabIndex = 1;
            // 
            // TypesOfFile
            // 
            this.TypesOfFile.BackColor = System.Drawing.Color.Transparent;
            this.TypesOfFile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypesOfFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypesOfFile.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypesOfFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypesOfFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypesOfFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TypesOfFile.ItemHeight = 30;
            this.TypesOfFile.Items.AddRange(new object[] {
            ".pdf",
            ".docx",
            ".txt"});
            this.TypesOfFile.Location = new System.Drawing.Point(152, 142);
            this.TypesOfFile.Name = "TypesOfFile";
            this.TypesOfFile.Size = new System.Drawing.Size(140, 36);
            this.TypesOfFile.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(74, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "*";
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(36, 155);
            this.siticoneHtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(39, 23);
            this.siticoneHtmlLabel4.TabIndex = 61;
            this.siticoneHtmlLabel4.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(117, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "*";
            // 
            // siticoneButton_Browse
            // 
            this.siticoneButton_Browse.BorderRadius = 5;
            this.siticoneButton_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton_Browse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_Browse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_Browse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_Browse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_Browse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.siticoneButton_Browse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton_Browse.ForeColor = System.Drawing.Color.White;
            this.siticoneButton_Browse.Location = new System.Drawing.Point(152, 249);
            this.siticoneButton_Browse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneButton_Browse.Name = "siticoneButton_Browse";
            this.siticoneButton_Browse.Size = new System.Drawing.Size(88, 26);
            this.siticoneButton_Browse.TabIndex = 59;
            this.siticoneButton_Browse.Text = "Browse";
            this.siticoneButton_Browse.Click += new System.EventHandler(this.siticoneButton_Browse_Click);
            // 
            // TextboxFilePath
            // 
            this.TextboxFilePath.DefaultText = "";
            this.TextboxFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextboxFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextboxFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxFilePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextboxFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxFilePath.Location = new System.Drawing.Point(152, 194);
            this.TextboxFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxFilePath.Name = "TextboxFilePath";
            this.TextboxFilePath.PasswordChar = '\0';
            this.TextboxFilePath.PlaceholderText = "";
            this.TextboxFilePath.SelectedText = "";
            this.TextboxFilePath.Size = new System.Drawing.Size(361, 37);
            this.TextboxFilePath.TabIndex = 58;
            this.TextboxFilePath.TextChanged += new System.EventHandler(this.siticoneTextBox_FileName_TextChanged);
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(36, 208);
            this.siticoneHtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(79, 23);
            this.siticoneHtmlLabel3.TabIndex = 57;
            this.siticoneHtmlLabel3.Text = "Link of file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 350);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUploadFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_UploadFile";
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer modalEffect_Timer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonCancel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonUpload;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextboxFileName;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private OpenFileDialog openFileDialog1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextboxFilePath;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_Browse;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox TypesOfFile;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
    }
}