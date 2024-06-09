namespace UI.UserControls
{
    partial class CourseTypeCard
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
            this.pbCourse = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.btnAddItemToCart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCourse
            // 
            this.pbCourse.Image = global::UI.Properties.Resources._1565838_e54e_16;
            this.pbCourse.Location = new System.Drawing.Point(10, 7);
            this.pbCourse.Name = "pbCourse";
            this.pbCourse.Size = new System.Drawing.Size(243, 144);
            this.pbCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCourse.TabIndex = 0;
            this.pbCourse.TabStop = false;
            this.pbCourse.Click += new System.EventHandler(this.pbCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoEllipsis = true;
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourseName.ForeColor = System.Drawing.Color.Black;
            this.lblCourseName.Location = new System.Drawing.Point(12, 156);
            this.lblCourseName.MaximumSize = new System.Drawing.Size(243, 50);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(197, 42);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "The complete 2023 Web development bootstrap";
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLecturerName.ForeColor = System.Drawing.Color.DimGray;
            this.lblLecturerName.Location = new System.Drawing.Point(17, 202);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Size = new System.Drawing.Size(80, 15);
            this.lblLecturerName.TabIndex = 3;
            this.lblLecturerName.Text = "Dr. Angela Yu";
            this.lblLecturerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRating.ForeColor = System.Drawing.Color.Black;
            this.lblRating.Location = new System.Drawing.Point(17, 226);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(32, 21);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "4.7";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(154, 229);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(60, 15);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "(330,730)";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellingPrice.ForeColor = System.Drawing.Color.Black;
            this.lblSellingPrice.Location = new System.Drawing.Point(32, 254);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(83, 25);
            this.lblSellingPrice.TabIndex = 6;
            this.lblSellingPrice.Text = "349,000";
            this.lblSellingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "đ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(120, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "đ";
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.lblOriginalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblOriginalPrice.Location = new System.Drawing.Point(135, 255);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(67, 21);
            this.lblOriginalPrice.TabIndex = 8;
            this.lblOriginalPrice.Text = "349,000";
            this.lblOriginalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddItemToCart
            // 
            this.btnAddItemToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(158)))));
            this.btnAddItemToCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(158)))));
            this.btnAddItemToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItemToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddItemToCart.Location = new System.Drawing.Point(16, 284);
            this.btnAddItemToCart.Name = "btnAddItemToCart";
            this.btnAddItemToCart.Size = new System.Drawing.Size(129, 31);
            this.btnAddItemToCart.TabIndex = 10;
            this.btnAddItemToCart.Text = "Add to cart";
            this.btnAddItemToCart.UseVisualStyleBackColor = false;
            this.btnAddItemToCart.Click += new System.EventHandler(this.btnAddItemToCart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.star;
            this.pictureBox2.Location = new System.Drawing.Point(49, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.star;
            this.pictureBox3.Location = new System.Drawing.Point(70, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UI.Properties.Resources.star;
            this.pictureBox4.Location = new System.Drawing.Point(91, 229);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UI.Properties.Resources.star;
            this.pictureBox5.Location = new System.Drawing.Point(133, 229);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UI.Properties.Resources.star;
            this.pictureBox6.Location = new System.Drawing.Point(112, 229);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.pnlContainer.BorderRadius = 3;
            this.pnlContainer.BorderThickness = 1;
            this.pnlContainer.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(264, 330);
            this.pnlContainer.TabIndex = 16;
            this.pnlContainer.Click += new System.EventHandler(this.pnlContainer_Click);
            // 
            // CourseTypeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAddItemToCart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOriginalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblLecturerName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCourse);
            this.Controls.Add(this.pnlContainer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CourseTypeCard";
            this.Size = new System.Drawing.Size(264, 330);
            this.Load += new System.EventHandler(this.Course_Load);
            this.Click += new System.EventHandler(this.CourseTypeCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbCourse;
        private Label label1;
        private Label lblCourseName;
        private Label lblLecturerName;
        private Label lblRating;
        private Label lblQuantity;
        private Label lblSellingPrice;
        private Label label6;
        private Label label7;
        private Label lblOriginalPrice;
        private Button btnAddItemToCart;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlContainer;
    }
}
