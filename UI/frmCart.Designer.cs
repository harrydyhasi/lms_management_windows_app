namespace UI
{
    partial class frmCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCart = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEmptyCart = new System.Windows.Forms.Panel();
            this.btnKeepShopping = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCoupon = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEnterCoupon = new System.Windows.Forms.Panel();
            this.btnAppy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txCoupon = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckout = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerRemoveItem = new System.Windows.Forms.Timer(this.components);
            this.bntClose = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.pnlCart.SuspendLayout();
            this.pnlEmptyCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlEnterCoupon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping Cart";
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.pnlEmptyCart);
            this.pnlCart.Location = new System.Drawing.Point(19, 98);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(684, 582);
            this.pnlCart.TabIndex = 1;
            // 
            // pnlEmptyCart
            // 
            this.pnlEmptyCart.Controls.Add(this.btnKeepShopping);
            this.pnlEmptyCart.Controls.Add(this.label8);
            this.pnlEmptyCart.Controls.Add(this.pictureBox1);
            this.pnlEmptyCart.Location = new System.Drawing.Point(3, 3);
            this.pnlEmptyCart.Name = "pnlEmptyCart";
            this.pnlEmptyCart.Size = new System.Drawing.Size(681, 579);
            this.pnlEmptyCart.TabIndex = 0;
            this.pnlEmptyCart.Visible = false;
            // 
            // btnKeepShopping
            // 
            this.btnKeepShopping.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKeepShopping.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKeepShopping.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKeepShopping.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKeepShopping.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnKeepShopping.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKeepShopping.ForeColor = System.Drawing.Color.White;
            this.btnKeepShopping.Location = new System.Drawing.Point(238, 314);
            this.btnKeepShopping.Name = "btnKeepShopping";
            this.btnKeepShopping.Size = new System.Drawing.Size(180, 45);
            this.btnKeepShopping.TabIndex = 2;
            this.btnKeepShopping.Text = "Keep Shopping";
            this.btnKeepShopping.Click += new System.EventHandler(this.btnKeepShopping_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label8.Location = new System.Drawing.Point(130, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(441, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Your cart is empty. Keep shopping to find a course";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.shopping_cart__1_;
            this.pictureBox1.Location = new System.Drawing.Point(185, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCoupon);
            this.panel1.Controls.Add(this.pnlEnterCoupon);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(731, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 582);
            this.panel1.TabIndex = 4;
            // 
            // pnlCoupon
            // 
            this.pnlCoupon.Location = new System.Drawing.Point(18, 242);
            this.pnlCoupon.Name = "pnlCoupon";
            this.pnlCoupon.Size = new System.Drawing.Size(342, 10);
            this.pnlCoupon.TabIndex = 15;
            // 
            // pnlEnterCoupon
            // 
            this.pnlEnterCoupon.Controls.Add(this.btnAppy);
            this.pnlEnterCoupon.Controls.Add(this.txCoupon);
            this.pnlEnterCoupon.Location = new System.Drawing.Point(13, 267);
            this.pnlEnterCoupon.Name = "pnlEnterCoupon";
            this.pnlEnterCoupon.Size = new System.Drawing.Size(441, 57);
            this.pnlEnterCoupon.TabIndex = 14;
            // 
            // btnAppy
            // 
            this.btnAppy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnAppy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAppy.ForeColor = System.Drawing.Color.White;
            this.btnAppy.Location = new System.Drawing.Point(354, 10);
            this.btnAppy.Name = "btnAppy";
            this.btnAppy.Size = new System.Drawing.Size(80, 36);
            this.btnAppy.TabIndex = 14;
            this.btnAppy.Text = "Apply";
            this.btnAppy.Click += new System.EventHandler(this.btnAppy_Click);
            // 
            // txCoupon
            // 
            this.txCoupon.DefaultText = "";
            this.txCoupon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCoupon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCoupon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCoupon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCoupon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCoupon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txCoupon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txCoupon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCoupon.Location = new System.Drawing.Point(8, 10);
            this.txCoupon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txCoupon.Name = "txCoupon";
            this.txCoupon.PasswordChar = '\0';
            this.txCoupon.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txCoupon.PlaceholderText = "Enter Coupon";
            this.txCoupon.SelectedText = "";
            this.txCoupon.Size = new System.Drawing.Size(339, 36);
            this.txCoupon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label7.Location = new System.Drawing.Point(13, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Promotions:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.panel2.Location = new System.Drawing.Point(13, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 2);
            this.panel2.TabIndex = 9;
            // 
            // btnCheckout
            // 
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(13, 130);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(426, 45);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label5.Location = new System.Drawing.Point(13, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "đ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblTotal.Location = new System.Drawing.Point(39, 35);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(143, 37);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "1,306,000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // timerRemoveItem
            // 
            this.timerRemoveItem.Tick += new System.EventHandler(this.timerRemoveItem_Tick);
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.FillColor = System.Drawing.Color.White;
            this.bntClose.HoverState.FillColor = System.Drawing.Color.White;
            this.bntClose.HoverState.IconColor = System.Drawing.Color.Red;
            this.bntClose.IconColor = System.Drawing.Color.Black;
            this.bntClose.Location = new System.Drawing.Point(1156, 12);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(32, 30);
            this.bntClose.TabIndex = 5;
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCart_FormClosed);
            this.Load += new System.EventHandler(this.frm_Cart_Load);
            this.pnlCart.ResumeLayout(false);
            this.pnlEmptyCart.ResumeLayout(false);
            this.pnlEmptyCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEnterCoupon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private FlowLayoutPanel pnlCart;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCheckout;
        private Label label5;
        private Label lblTotal;
        private Label label3;
        private Panel pnlEnterCoupon;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAppy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txCoupon;
        private FlowLayoutPanel pnlCoupon;
        private Panel pnlEmptyCart;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnKeepShopping;
        private Label label8;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerRemoveItem;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox bntClose;
    }
}