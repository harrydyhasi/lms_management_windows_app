namespace UI.Lecturer
{
    partial class frmForumDetail
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
            this.lblForumName = new System.Windows.Forms.Label();
            this.lblForumDecs = new System.Windows.Forms.Label();
            this.txbSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnSearch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnCreatePost = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.fpnlPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.SuspendLayout();
            // 
            // lblForumName
            // 
            this.lblForumName.AutoSize = true;
            this.lblForumName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForumName.ForeColor = System.Drawing.Color.Black;
            this.lblForumName.Location = new System.Drawing.Point(15, 16);
            this.lblForumName.Name = "lblForumName";
            this.lblForumName.Size = new System.Drawing.Size(130, 45);
            this.lblForumName.TabIndex = 0;
            this.lblForumName.Text = "Week 1";
            // 
            // lblForumDecs
            // 
            this.lblForumDecs.AutoSize = true;
            this.lblForumDecs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForumDecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblForumDecs.Location = new System.Drawing.Point(26, 70);
            this.lblForumDecs.MaximumSize = new System.Drawing.Size(375, 0);
            this.lblForumDecs.Name = "lblForumDecs";
            this.lblForumDecs.Size = new System.Drawing.Size(280, 21);
            this.lblForumDecs.TabIndex = 1;
            this.lblForumDecs.Text = "Discuss and ask question about week 1";
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColor = System.Drawing.Color.Black;
            this.txbSearch.BorderRadius = 5;
            this.txbSearch.DefaultText = "";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Location = new System.Drawing.Point(26, 141);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(393, 36);
            this.txbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.DefaultAutoSize = true;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(430, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnCreatePost.BorderRadius = 5;
            this.btnCreatePost.BorderThickness = 1;
            this.btnCreatePost.DefaultAutoSize = true;
            this.btnCreatePost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreatePost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreatePost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreatePost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreatePost.FillColor = System.Drawing.Color.White;
            this.btnCreatePost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatePost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnCreatePost.Location = new System.Drawing.Point(530, 141);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(119, 33);
            this.btnCreatePost.TabIndex = 5;
            this.btnCreatePost.Text = "Create post";
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // fpnlPosts
            // 
            this.fpnlPosts.AutoScroll = true;
            this.fpnlPosts.Location = new System.Drawing.Point(15, 203);
            this.fpnlPosts.Name = "fpnlPosts";
            this.fpnlPosts.Size = new System.Drawing.Size(973, 485);
            this.fpnlPosts.TabIndex = 6;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(943, 12);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 7;
            // 
            // frmForumDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.ControlBox = false;
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.fpnlPosts);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lblForumDecs);
            this.Controls.Add(this.lblForumName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForumDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Forum";
            this.Load += new System.EventHandler(this.frm_Forum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblForumName;
        private Label lblForumDecs;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txbSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCreatePost;
        private FlowLayoutPanel fpnlPosts;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
    }
}