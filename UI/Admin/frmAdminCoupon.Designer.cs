namespace UI.Admin
{
    partial class frmAdminCoupon
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
            this.label12 = new System.Windows.Forms.Label();
            this.dtgvCoupon = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.dtimev = new System.Windows.Forms.DateTimePicker();
            this.dtimee = new System.Windows.Forms.DateTimePicker();
            this.txbvalue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCoupon)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(27, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "Admin > Manager Coupon\r\n";
            // 
            // dtgvCoupon
            // 
            this.dtgvCoupon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCoupon.Location = new System.Drawing.Point(27, 82);
            this.dtgvCoupon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCoupon.Name = "dtgvCoupon";
            this.dtgvCoupon.ReadOnly = true;
            this.dtgvCoupon.RowHeadersWidth = 51;
            this.dtgvCoupon.RowTemplate.Height = 29;
            this.dtgvCoupon.Size = new System.Drawing.Size(574, 381);
            this.dtgvCoupon.TabIndex = 34;
            this.dtgvCoupon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCoupon_CellClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(610, 284);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 22);
            this.btnCreate.TabIndex = 35;
            this.btnCreate.Text = "Add new";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(785, 284);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(82, 22);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(698, 284);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(82, 22);
            this.btnupdate.TabIndex = 37;
            this.btnupdate.Text = "Modify";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(606, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Detail Coupon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Valid date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Expire date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Use value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Course ID";
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(694, 85);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(126, 23);
            this.txbCode.TabIndex = 46;
            // 
            // dtimev
            // 
            this.dtimev.Location = new System.Drawing.Point(694, 118);
            this.dtimev.Name = "dtimev";
            this.dtimev.Size = new System.Drawing.Size(200, 23);
            this.dtimev.TabIndex = 47;
            // 
            // dtimee
            // 
            this.dtimee.Location = new System.Drawing.Point(694, 152);
            this.dtimee.Name = "dtimee";
            this.dtimee.Size = new System.Drawing.Size(200, 23);
            this.dtimee.TabIndex = 48;
            // 
            // txbvalue
            // 
            this.txbvalue.Location = new System.Drawing.Point(694, 182);
            this.txbvalue.Name = "txbvalue";
            this.txbvalue.Size = new System.Drawing.Size(100, 23);
            this.txbvalue.TabIndex = 49;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(617, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 53);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(770, 410);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(124, 53);
            this.btnsave.TabIndex = 52;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cbcourse
            // 
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Location = new System.Drawing.Point(694, 211);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(200, 23);
            this.cbcourse.TabIndex = 50;
            // 
            // frmAdminCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(999, 507);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.txbvalue);
            this.Controls.Add(this.dtimee);
            this.Controls.Add(this.dtimev);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtgvCoupon);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdminCoupon";
            this.Text = "frmAdminCoupon";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCoupon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label12;
        private DataGridView dtgvCoupon;
        private Button btnCreate;
        private Button btndelete;
        private Button btnupdate;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txbCode;
        private DateTimePicker dtimev;
        private DateTimePicker dtimee;
        private TextBox txbvalue;
        private Button btnCancel;
        private Button btnsave;
        private ComboBox cbcourse;
    }
}