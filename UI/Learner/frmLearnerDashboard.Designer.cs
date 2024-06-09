using UI.UserControls;

namespace UI
{
    partial class frmLearnerDashboard
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
            this.header = new System.Windows.Forms.Panel();
            this.lblQuantity = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnCart = new System.Windows.Forms.PictureBox();
            this.btnMyLearning = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnHome = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.avatar1 = new UI.UserControls.Avatar();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.txbSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.lblQuantity);
            this.header.Controls.Add(this.btnCart);
            this.header.Controls.Add(this.btnMyLearning);
            this.header.Controls.Add(this.btnHome);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.avatar1);
            this.header.Controls.Add(this.siticoneCircleButton1);
            this.header.Controls.Add(this.txbSearch);
            this.header.Controls.Add(this.siticoneComboBox1);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.panel2);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 118);
            this.header.TabIndex = 0;
            // 
            // lblQuantity
            // 
            this.lblQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(1027, 9);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.lblQuantity.Size = new System.Drawing.Size(30, 30);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "4";
            // 
            // btnCart
            // 
            this.btnCart.Image = global::UI.Properties.Resources.shopping_cart;
            this.btnCart.Location = new System.Drawing.Point(1003, 24);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(38, 35);
            this.btnCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCart.TabIndex = 17;
            this.btnCart.TabStop = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnMyLearning
            // 
            this.btnMyLearning.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnMyLearning.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnMyLearning.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMyLearning.CustomBorderColor = System.Drawing.Color.White;
            this.btnMyLearning.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnMyLearning.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyLearning.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyLearning.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyLearning.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyLearning.FillColor = System.Drawing.Color.White;
            this.btnMyLearning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyLearning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnMyLearning.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnMyLearning.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnMyLearning.HoverState.FillColor = System.Drawing.Color.White;
            this.btnMyLearning.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMyLearning.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnMyLearning.Location = new System.Drawing.Point(136, 67);
            this.btnMyLearning.Name = "btnMyLearning";
            this.btnMyLearning.PressedColor = System.Drawing.Color.White;
            this.btnMyLearning.Size = new System.Drawing.Size(129, 45);
            this.btnMyLearning.TabIndex = 16;
            this.btnMyLearning.Text = "My learning";
            this.btnMyLearning.Click += new System.EventHandler(this.btnMyLearning_Click);
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnHome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHome.CustomBorderColor = System.Drawing.Color.White;
            this.btnHome.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnHome.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnHome.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnHome.Location = new System.Drawing.Point(23, 69);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.White;
            this.btnHome.Size = new System.Drawing.Size(78, 45);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.down_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(1134, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // avatar1
            // 
            this.avatar1.Image = global::UI.Properties.Resources.user;
            this.avatar1.Location = new System.Drawing.Point(1077, 12);
            this.avatar1.Name = "avatar1";
            this.avatar1.Size = new System.Drawing.Size(45, 45);
            this.avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar1.TabIndex = 13;
            this.avatar1.TabStop = false;
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.Image = global::UI.Properties.Resources.search;
            this.siticoneCircleButton1.Location = new System.Drawing.Point(791, 27);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(30, 30);
            this.siticoneCircleButton1.TabIndex = 12;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.txbSearch.BorderRadius = 15;
            this.txbSearch.DefaultText = "";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Location = new System.Drawing.Point(518, 24);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txbSearch.PlaceholderText = "What do you want to learn?";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(308, 37);
            this.txbSearch.TabIndex = 11;
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.siticoneComboBox1.BorderRadius = 5;
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.siticoneComboBox1.ItemHeight = 30;
            this.siticoneComboBox1.Items.AddRange(new object[] {
            "All subjects",
            "Data Science",
            "Business",
            "Health",
            "Math and Logic"});
            this.siticoneComboBox1.Location = new System.Drawing.Point(251, 24);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.Size = new System.Drawing.Size(226, 36);
            this.siticoneComboBox1.StartIndex = 0;
            this.siticoneComboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(92, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "TALEMY";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(15, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.owl;
            this.pictureBox1.Location = new System.Drawing.Point(25, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1200, 2);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLearnerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLearnerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stuman";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel header;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txbSearch;
        private UserControls.Avatar avatar1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnHome;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnMyLearning;
        private PictureBox btnCart;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton lblQuantity;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}