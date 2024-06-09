namespace UI.Lecturer
{
    partial class frmViewProfile
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
            btnHire = new Button();
            txbPassword = new TextBox();
            txbUsername = new TextBox();
            groupBox1 = new GroupBox();
            label14 = new Label();
            dtimeDateOfBirth = new DateTimePicker();
            btncancel = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            txbaddress = new TextBox();
            txbemail = new TextBox();
            txbPhone = new TextBox();
            txblname = new TextBox();
            txbmname = new TextBox();
            txbfname = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            avatar1 = new UserControls.Avatar();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar1).BeginInit();
            SuspendLayout();
            // 
            // btnHire
            // 
            btnHire.Location = new Point(194, 356);
            btnHire.Margin = new Padding(3, 4, 3, 4);
            btnHire.Name = "btnHire";
            btnHire.Size = new Size(98, 31);
            btnHire.TabIndex = 31;
            btnHire.Text = "Show/Hide";
            btnHire.UseVisualStyleBackColor = true;
            btnHire.Click += btnHire_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(148, 317);
            txbPassword.Margin = new Padding(3, 4, 3, 4);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(143, 27);
            txbPassword.TabIndex = 30;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(148, 270);
            txbUsername.Margin = new Padding(3, 4, 3, 4);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(143, 27);
            txbUsername.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(dtimeDateOfBirth);
            groupBox1.Controls.Add(btncancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txbaddress);
            groupBox1.Controls.Add(txbemail);
            groupBox1.Controls.Add(txbPhone);
            groupBox1.Controls.Add(txblname);
            groupBox1.Controls.Add(txbmname);
            groupBox1.Controls.Add(txbfname);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(324, 206);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(722, 321);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 277);
            label14.Name = "label14";
            label14.Size = new Size(94, 20);
            label14.TabIndex = 16;
            label14.Text = "Date of Birth";
            // 
            // dtimeDateOfBirth
            // 
            dtimeDateOfBirth.Location = new Point(136, 268);
            dtimeDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtimeDateOfBirth.Name = "dtimeDateOfBirth";
            dtimeDateOfBirth.Size = new Size(228, 27);
            dtimeDateOfBirth.TabIndex = 15;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(424, 283);
            btncancel.Margin = new Padding(3, 4, 3, 4);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(93, 31);
            btncancel.TabIndex = 14;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(523, 283);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 31);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gainsboro;
            btnUpdate.Location = new Point(623, 283);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 31);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Edit profile";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txbaddress
            // 
            txbaddress.Location = new Point(138, 141);
            txbaddress.Margin = new Padding(3, 4, 3, 4);
            txbaddress.Name = "txbaddress";
            txbaddress.Size = new Size(188, 27);
            txbaddress.TabIndex = 11;
            // 
            // txbemail
            // 
            txbemail.Location = new Point(138, 217);
            txbemail.Margin = new Padding(3, 4, 3, 4);
            txbemail.Name = "txbemail";
            txbemail.Size = new Size(188, 27);
            txbemail.TabIndex = 10;
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(138, 180);
            txbPhone.Margin = new Padding(3, 4, 3, 4);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(188, 27);
            txbPhone.TabIndex = 9;
            // 
            // txblname
            // 
            txblname.Location = new Point(138, 103);
            txblname.Margin = new Padding(3, 4, 3, 4);
            txblname.Name = "txblname";
            txblname.Size = new Size(188, 27);
            txblname.TabIndex = 8;
            // 
            // txbmname
            // 
            txbmname.Location = new Point(138, 64);
            txbmname.Margin = new Padding(3, 4, 3, 4);
            txbmname.Name = "txbmname";
            txbmname.Size = new Size(188, 27);
            txbmname.TabIndex = 7;
            // 
            // txbfname
            // 
            txbfname.Location = new Point(138, 20);
            txbfname.Margin = new Padding(3, 4, 3, 4);
            txbfname.Name = "txbfname";
            txbfname.Size = new Size(188, 27);
            txbfname.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 229);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 5;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 185);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 4;
            label8.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 146);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 3;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 108);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 2;
            label6.Text = "Last name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 69);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 1;
            label5.Text = "Mid name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 25);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "First name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 230);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 27;
            label1.Text = "Administrator";
            // 
            // avatar1
            // 
            avatar1.Image = Properties.Resources.user;
            avatar1.Location = new Point(148, 150);
            avatar1.Margin = new Padding(3, 4, 3, 4);
            avatar1.Name = "avatar1";
            avatar1.Size = new Size(51, 60);
            avatar1.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar1.TabIndex = 26;
            avatar1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 328);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 25;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.Location = new Point(73, 274);
            label2.Name = "label2";
            label2.Size = new Size(80, 31);
            label2.TabIndex = 24;
            label2.Text = "Username:";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(61, 230);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(241, 172);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            // 
            // frmViewProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnHire);
            Controls.Add(txbPassword);
            Controls.Add(txbUsername);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(avatar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmViewProfile";
            Size = new Size(1107, 796);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHire;
        private TextBox txbPassword;
        private TextBox txbUsername;
        private GroupBox groupBox1;
        private Label label14;
        private DateTimePicker dtimeDateOfBirth;
        private Button btncancel;
        private Button btnSave;
        private Button btnUpdate;
        private TextBox txbaddress;
        private TextBox txbemail;
        private TextBox txbPhone;
        private TextBox txblname;
        private TextBox txbmname;
        private TextBox txbfname;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private UserControls.Avatar avatar1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
    }
}
