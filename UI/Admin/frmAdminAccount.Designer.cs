using UI.UserControls;

namespace UI.Admin
{
    partial class frmAdminAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txblname = new System.Windows.Forms.TextBox();
            this.txbmname = new System.Windows.Forms.TextBox();
            this.txbfname = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbaddress = new System.Windows.Forms.TextBox();
            this.dtimeDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cblst = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgvLstAccount = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLstAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(589, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(671, 79);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(175, 23);
            this.txbUsername.TabIndex = 2;
            this.txbUsername.Text = "username";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(671, 106);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(175, 23);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.Text = "password";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Lecturer",
            "Learner"});
            this.cbRole.Location = new System.Drawing.Point(870, 106);
            this.cbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(133, 23);
            this.cbRole.TabIndex = 4;
            this.cbRole.Text = "Role";
            // 
            // txblname
            // 
            this.txblname.Location = new System.Drawing.Point(669, 149);
            this.txblname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txblname.Name = "txblname";
            this.txblname.Size = new System.Drawing.Size(177, 23);
            this.txblname.TabIndex = 5;
            this.txblname.Text = "lname";
            // 
            // txbmname
            // 
            this.txbmname.Location = new System.Drawing.Point(669, 176);
            this.txbmname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbmname.Name = "txbmname";
            this.txbmname.Size = new System.Drawing.Size(177, 23);
            this.txbmname.TabIndex = 6;
            this.txbmname.Text = "mname";
            // 
            // txbfname
            // 
            this.txbfname.Location = new System.Drawing.Point(669, 209);
            this.txbfname.Name = "txbfname";
            this.txbfname.Size = new System.Drawing.Size(177, 23);
            this.txbfname.TabIndex = 7;
            this.txbfname.Text = "fname";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(671, 262);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(210, 23);
            this.txbPhone.TabIndex = 8;
            this.txbPhone.Text = "phone";
            // 
            // txbaddress
            // 
            this.txbaddress.Location = new System.Drawing.Point(670, 324);
            this.txbaddress.Name = "txbaddress";
            this.txbaddress.Size = new System.Drawing.Size(229, 23);
            this.txbaddress.TabIndex = 9;
            this.txbaddress.Text = "address";
            // 
            // dtimeDateOfBirth
            // 
            this.dtimeDateOfBirth.CustomFormat = "dd-MM-yyyy";
            this.dtimeDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeDateOfBirth.Location = new System.Drawing.Point(679, 362);
            this.dtimeDateOfBirth.Name = "dtimeDateOfBirth";
            this.dtimeDateOfBirth.Size = new System.Drawing.Size(229, 23);
            this.dtimeDateOfBirth.TabIndex = 10;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(670, 295);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(209, 23);
            this.txbEmail.TabIndex = 11;
            this.txbEmail.Text = "email";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(679, 413);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 22);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Modify";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(591, 413);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 22);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create new";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.LightGray;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncancel.Location = new System.Drawing.Point(591, 459);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(210, 47);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Blue;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(804, 459);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(199, 47);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(767, 413);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cblst
            // 
            this.cblst.FormattingEnabled = true;
            this.cblst.Items.AddRange(new object[] {
            "Admin",
            "Lecturer",
            "Learner",
            "All"});
            this.cblst.Location = new System.Drawing.Point(380, 50);
            this.cblst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblst.Name = "cblst";
            this.cblst.Size = new System.Drawing.Size(98, 23);
            this.cblst.TabIndex = 17;
            this.cblst.Text = "List";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Location = new System.Drawing.Point(484, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 26);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mid name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "First name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(870, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(592, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Date of Birth";
            // 
            // tbSearch
            // 
            this.tbSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearch.Location = new System.Drawing.Point(27, 50);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(253, 22);
            this.tbSearch.TabIndex = 18;
            this.tbSearch.Text = "Input search";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Username",
            "Name"});
            this.cbSearch.Location = new System.Drawing.Point(286, 50);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(88, 23);
            this.cbSearch.TabIndex = 30;
            this.cbSearch.Text = "Username ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(101, 511);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 15);
            this.lblNumber.TabIndex = 31;
            this.lblNumber.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(27, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 21);
            this.label12.TabIndex = 32;
            this.label12.Text = "Admin > Manager Accounts";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(23, 508);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Number:";
            // 
            // dtgvLstAccount
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtgvLstAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLstAccount.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvLstAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Null";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLstAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLstAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLstAccount.Location = new System.Drawing.Point(27, 82);
            this.dtgvLstAccount.Name = "dtgvLstAccount";
            this.dtgvLstAccount.ReadOnly = true;
            this.dtgvLstAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "Null";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLstAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvLstAccount.RowHeadersWidth = 10;
            this.dtgvLstAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvLstAccount.RowTemplate.Height = 25;
            this.dtgvLstAccount.Size = new System.Drawing.Size(559, 426);
            this.dtgvLstAccount.TabIndex = 34;
            this.dtgvLstAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLstAccount_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvLstAccount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cblst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.dtimeDateOfBirth);
            this.Controls.Add(this.txbaddress);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbfname);
            this.Controls.Add(this.txbmname);
            this.Controls.Add(this.txblname);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminDashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLstAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox txbUsername;
        private TextBox txbPassword;
        private ComboBox cbRole;
        private TextBox txblname;
        private TextBox txbmname;
        private TextBox txbfname;
        private TextBox txbPhone;
        private TextBox txbaddress;
        private DateTimePicker dtimeDateOfBirth;
        private TextBox txbEmail;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btncancel;
        private Button btnsave;
        private Button btnDelete;
        private ComboBox cblst;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbSearch;
        private ComboBox cbSearch;
        private Label lblNumber;
        private Label label12;
        private Label label13;
        private DataGridView dtgvLstAccount;
        private Button button1;
    }
}