namespace UI.Admin
{
    partial class frmAdminCourseSection
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
            this.dtgvCourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbcourseid = new System.Windows.Forms.TextBox();
            this.txblecturerid = new System.Windows.Forms.TextBox();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txboprice = new System.Windows.Forms.TextBox();
            this.txbdiscount = new System.Windows.Forms.TextBox();
            this.txbsprice = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCheck = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCourse
            // 
            this.dtgvCourse.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCourse.Location = new System.Drawing.Point(27, 82);
            this.dtgvCourse.Name = "dtgvCourse";
            this.dtgvCourse.ReadOnly = true;
            this.dtgvCourse.RowHeadersWidth = 10;
            this.dtgvCourse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvCourse.RowTemplate.Height = 25;
            this.dtgvCourse.Size = new System.Drawing.Size(640, 384);
            this.dtgvCourse.TabIndex = 0;
            this.dtgvCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCourse_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(678, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detail Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lecturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Original price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Selling price";
            // 
            // txbcourseid
            // 
            this.txbcourseid.Location = new System.Drawing.Point(763, 86);
            this.txbcourseid.Name = "txbcourseid";
            this.txbcourseid.Size = new System.Drawing.Size(175, 23);
            this.txbcourseid.TabIndex = 9;
            // 
            // txblecturerid
            // 
            this.txblecturerid.Location = new System.Drawing.Point(763, 115);
            this.txblecturerid.Name = "txblecturerid";
            this.txblecturerid.Size = new System.Drawing.Size(175, 23);
            this.txblecturerid.TabIndex = 10;
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(763, 148);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(175, 23);
            this.txbname.TabIndex = 11;
            // 
            // txboprice
            // 
            this.txboprice.Location = new System.Drawing.Point(762, 182);
            this.txboprice.Name = "txboprice";
            this.txboprice.Size = new System.Drawing.Size(176, 23);
            this.txboprice.TabIndex = 12;
            // 
            // txbdiscount
            // 
            this.txbdiscount.Location = new System.Drawing.Point(763, 214);
            this.txbdiscount.Name = "txbdiscount";
            this.txbdiscount.Size = new System.Drawing.Size(175, 23);
            this.txbdiscount.TabIndex = 13;
            // 
            // txbsprice
            // 
            this.txbsprice.Location = new System.Drawing.Point(763, 243);
            this.txbsprice.Name = "txbsprice";
            this.txbsprice.Size = new System.Drawing.Size(175, 23);
            this.txbsprice.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(684, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 31);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Modify";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(876, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(780, 369);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 31);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create new";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(684, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 41);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(849, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 41);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(678, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Number leaner";
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(770, 304);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(168, 23);
            this.txbNumber.TabIndex = 21;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(944, 304);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(64, 23);
            this.btnDetail.TabIndex = 22;
            this.btnDetail.Text = "Detail list";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(27, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "Admin > Manager Course";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(27, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Number:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(108, 475);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 15);
            this.lblNumber.TabIndex = 35;
            this.lblNumber.Text = "0";
            // 
            // txbSearch
            // 
            this.txbSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearch.Location = new System.Drawing.Point(263, 53);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(228, 23);
            this.txbSearch.TabIndex = 36;
            this.txbSearch.Text = "Input search";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(592, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCheck
            // 
            this.cbCheck.FormattingEnabled = true;
            this.cbCheck.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cbCheck.Location = new System.Drawing.Point(497, 53);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(89, 23);
            this.cbCheck.TabIndex = 38;
            this.cbCheck.Text = "ID";
            // 
            // frmAdminCourseSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1015, 542);
            this.Controls.Add(this.cbCheck);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbsprice);
            this.Controls.Add(this.txbdiscount);
            this.Controls.Add(this.txboprice);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.txblecturerid);
            this.Controls.Add(this.txbcourseid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminCourseSection";
            this.Text = "frmAdminCourse";
            this.Load += new System.EventHandler(this.frmAdminCourseSection_Load);
            this.Click += new System.EventHandler(this.frmAdminCourseSection_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvCourse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txbcourseid;
        private TextBox txblecturerid;
        private TextBox txbname;
        private TextBox txboprice;
        private TextBox txbdiscount;
        private TextBox txbsprice;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private Button btnCancel;
        private Button btnSave;
        private Label label8;
        private TextBox txbNumber;
        private Button btnDetail;
        private Label label12;
        private Label label9;
        private Label lblNumber;
        private TextBox txbSearch;
        private Button btnSearch;
        private ComboBox cbCheck;
    }
}