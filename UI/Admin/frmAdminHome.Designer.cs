namespace UI.Admin
{
    partial class frmAdminHome
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avatar1 = new UI.UserControls.Avatar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtimeDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbaddress = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txblname = new System.Windows.Forms.TextBox();
            this.txbmname = new System.Windows.Forms.TextBox();
            this.txbfname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnHire = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(55, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // avatar1
            // 
            this.avatar1.Image = global::UI.Properties.Resources.user;
            this.avatar1.Location = new System.Drawing.Point(121, 70);
            this.avatar1.Name = "avatar1";
            this.avatar1.Size = new System.Drawing.Size(45, 45);
            this.avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar1.TabIndex = 14;
            this.avatar1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Administrator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtimeDateOfBirth);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txbaddress);
            this.groupBox1.Controls.Add(this.txbemail);
            this.groupBox1.Controls.Add(this.txbPhone);
            this.groupBox1.Controls.Add(this.txblname);
            this.groupBox1.Controls.Add(this.txbmname);
            this.groupBox1.Controls.Add(this.txbfname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(275, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 241);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Date of Birth";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dtimeDateOfBirth
            // 
            this.dtimeDateOfBirth.Location = new System.Drawing.Point(119, 201);
            this.dtimeDateOfBirth.Name = "dtimeDateOfBirth";
            this.dtimeDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtimeDateOfBirth.TabIndex = 15;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(371, 212);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 23);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(458, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Location = new System.Drawing.Point(545, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Edit profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbaddress
            // 
            this.txbaddress.Location = new System.Drawing.Point(121, 106);
            this.txbaddress.Name = "txbaddress";
            this.txbaddress.Size = new System.Drawing.Size(165, 23);
            this.txbaddress.TabIndex = 11;
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(121, 163);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(165, 23);
            this.txbemail.TabIndex = 10;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(121, 135);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(165, 23);
            this.txbPhone.TabIndex = 9;
            // 
            // txblname
            // 
            this.txblname.Location = new System.Drawing.Point(121, 77);
            this.txblname.Name = "txblname";
            this.txblname.Size = new System.Drawing.Size(165, 23);
            this.txblname.TabIndex = 8;
            // 
            // txbmname
            // 
            this.txbmname.Location = new System.Drawing.Point(121, 48);
            this.txbmname.Name = "txbmname";
            this.txbmname.Size = new System.Drawing.Size(165, 23);
            this.txbmname.TabIndex = 7;
            // 
            // txbfname
            // 
            this.txbfname.Location = new System.Drawing.Point(121, 15);
            this.txbfname.Name = "txbfname";
            this.txbfname.Size = new System.Drawing.Size(165, 23);
            this.txbfname.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mid name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(275, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 171);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authority";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Coupon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Account: Admin, Lecturer, Learner";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(121, 160);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(126, 23);
            this.txbUsername.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(121, 195);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(126, 23);
            this.txbPassword.TabIndex = 21;
            // 
            // btnHire
            // 
            this.btnHire.Location = new System.Drawing.Point(161, 224);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(86, 23);
            this.btnHire.TabIndex = 22;
            this.btnHire.Text = "Show/Hide";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(45, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 129);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 542);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avatar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminHome";
            this.Text = "frmAdminHome";
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private UserControls.Avatar avatar1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox2;
        private TextBox txbfname;
        private TextBox txbmname;
        private TextBox txblname;
        private TextBox txbPhone;
        private TextBox txbemail;
        private TextBox txbaddress;
        private Label label10;
        private Label label11;
        private Label label13;
        private TextBox txbUsername;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txbPassword;
        private Button btnUpdate;
        private Button btnSave;
        private Button btncancel;
        private Button btnHire;
        private GroupBox groupBox3;
        private DateTimePicker dtimeDateOfBirth;
        private Label label14;
    }
}