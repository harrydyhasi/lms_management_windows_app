namespace UI.Course
{
    partial class frmCreateAssignment
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
            this.ButtonCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ButtonCreate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DueDate = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.OpenDate = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.TextBoxDesc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.TextBoxTitle = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.ButtonCancel);
            this.siticonePanel1.Controls.Add(this.ButtonCreate);
            this.siticonePanel1.Controls.Add(this.DueDate);
            this.siticonePanel1.Controls.Add(this.OpenDate);
            this.siticonePanel1.Controls.Add(this.label4);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel6);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel5);
            this.siticonePanel1.Controls.Add(this.TextBoxDesc);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel4);
            this.siticonePanel1.Controls.Add(this.TextBoxTitle);
            this.siticonePanel1.Controls.Add(this.label5);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel2);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(561, 400);
            this.siticonePanel1.TabIndex = 0;
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
            this.ButtonCancel.Location = new System.Drawing.Point(278, 351);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(110, 38);
            this.ButtonCancel.TabIndex = 56;
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
            this.ButtonCreate.Location = new System.Drawing.Point(409, 351);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(110, 38);
            this.ButtonCreate.TabIndex = 55;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // DueDate
            // 
            this.DueDate.Checked = true;
            this.DueDate.FillColor = System.Drawing.Color.White;
            this.DueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DueDate.Location = new System.Drawing.Point(211, 288);
            this.DueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(308, 34);
            this.DueDate.TabIndex = 54;
            this.DueDate.Value = new System.DateTime(2023, 10, 27, 9, 44, 39, 336);
            // 
            // OpenDate
            // 
            this.OpenDate.Checked = true;
            this.OpenDate.FillColor = System.Drawing.Color.White;
            this.OpenDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.OpenDate.Location = new System.Drawing.Point(211, 233);
            this.OpenDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.OpenDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.OpenDate.Name = "OpenDate";
            this.OpenDate.Size = new System.Drawing.Size(308, 34);
            this.OpenDate.TabIndex = 53;
            this.OpenDate.Value = new System.DateTime(2023, 10, 27, 9, 44, 39, 336);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(112, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(123, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "*";
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(36, 300);
            this.siticoneHtmlLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(69, 23);
            this.siticoneHtmlLabel6.TabIndex = 50;
            this.siticoneHtmlLabel6.Text = "Due date";
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(36, 244);
            this.siticoneHtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(80, 23);
            this.siticoneHtmlLabel5.TabIndex = 49;
            this.siticoneHtmlLabel5.Text = "Open date";
            // 
            // TextBoxDesc
            // 
            this.TextBoxDesc.DefaultText = "";
            this.TextBoxDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDesc.Location = new System.Drawing.Point(211, 136);
            this.TextBoxDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxDesc.Name = "TextBoxDesc";
            this.TextBoxDesc.PasswordChar = '\0';
            this.TextBoxDesc.PlaceholderText = "";
            this.TextBoxDesc.SelectedText = "";
            this.TextBoxDesc.Size = new System.Drawing.Size(308, 74);
            this.TextBoxDesc.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(130, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "*";
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(36, 140);
            this.siticoneHtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(87, 23);
            this.siticoneHtmlLabel4.TabIndex = 46;
            this.siticoneHtmlLabel4.Text = "Description";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.DefaultText = "";
            this.TextBoxTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTitle.Location = new System.Drawing.Point(211, 78);
            this.TextBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.PasswordChar = '\0';
            this.TextBoxTitle.PlaceholderText = "";
            this.TextBoxTitle.SelectedText = "";
            this.TextBoxTitle.Size = new System.Drawing.Size(308, 27);
            this.TextBoxTitle.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(74, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "*";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(36, 82);
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
            this.siticonePanel2.Size = new System.Drawing.Size(561, 60);
            this.siticonePanel2.TabIndex = 0;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(192, 14);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(181, 30);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "Create Assignment";
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // frmCreateAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 400);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateAssignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_CreateAssignment_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxDesc;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxTitle;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Label label4;
        private Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker DueDate;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker OpenDate;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonCreate;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonCancel;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}