namespace UI.UserControls
{
    partial class Coupon
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
            this.lblCoupon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDrop = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoupon
            // 
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCoupon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblCoupon.Location = new System.Drawing.Point(6, 2);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Size = new System.Drawing.Size(124, 21);
            this.lblCoupon.TabIndex = 0;
            this.lblCoupon.Text = "ST16MT102523";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCoupon);
            this.panel1.Location = new System.Drawing.Point(31, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 28);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(129, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "is applied";
            // 
            // btnDrop
            // 
            this.btnDrop.AutoSize = true;
            this.btnDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDrop.Location = new System.Drawing.Point(6, 10);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(20, 21);
            this.btnDrop.TabIndex = 3;
            this.btnDrop.Text = "X";
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.panel1);
            this.Name = "Coupon";
            this.Size = new System.Drawing.Size(253, 40);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCoupon;
        private Panel panel1;
        private Label label2;
        private Label btnDrop;
    }
}
