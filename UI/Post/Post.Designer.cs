namespace UI.UserControls
{
    partial class Post
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLike = new System.Windows.Forms.Label();
            this.lblReply = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avatar = new UI.UserControls.Avatar();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.btnLike = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txbContent = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnEdit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnReply = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblTitle.Location = new System.Drawing.Point(9, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "All slide of this course";
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblLike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLike.Location = new System.Drawing.Point(46, 141);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(51, 17);
            this.lblLike.TabIndex = 2;
            this.lblLike.Text = "Like 20";
            this.lblLike.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReply
            // 
            this.lblReply.AutoSize = true;
            this.lblReply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblReply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReply.Location = new System.Drawing.Point(161, 141);
            this.lblReply.Name = "lblReply";
            this.lblReply.Size = new System.Drawing.Size(60, 17);
            this.lblReply.TabIndex = 4;
            this.lblReply.Text = "Reply 20";
            this.lblReply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.panel1.Location = new System.Drawing.Point(11, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 2);
            this.panel1.TabIndex = 2;
            // 
            // avatar
            // 
            this.avatar.Image = global::UI.Properties.Resources.user;
            this.avatar.Location = new System.Drawing.Point(744, 135);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(41, 33);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 6;
            this.avatar.TabStop = false;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblAuthorName.Location = new System.Drawing.Point(802, 135);
            this.lblAuthorName.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(60, 34);
            this.lblAuthorName.TabIndex = 7;
            this.lblAuthorName.Text = "Anh Duy Nguyen";
            // 
            // btnLike
            // 
            this.btnLike.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLike.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLike.CheckedState.Image = global::UI.Properties.Resources.liked;
            this.btnLike.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLike.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLike.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLike.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLike.FillColor = System.Drawing.Color.White;
            this.btnLike.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLike.ForeColor = System.Drawing.Color.White;
            this.btnLike.Image = global::UI.Properties.Resources.like;
            this.btnLike.Location = new System.Drawing.Point(11, 131);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(29, 33);
            this.btnLike.TabIndex = 8;
            this.btnLike.CheckedChanged += new System.EventHandler(this.btnLike_CheckedChanged);
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // txbContent
            // 
            this.txbContent.AutoScroll = true;
            this.txbContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txbContent.BorderRadius = 2;
            this.txbContent.DefaultText = "";
            this.txbContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txbContent.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txbContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txbContent.Enabled = false;
            this.txbContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txbContent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txbContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbContent.Location = new System.Drawing.Point(11, 42);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.PasswordChar = '\0';
            this.txbContent.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txbContent.PlaceholderText = "";
            this.txbContent.SelectedText = "";
            this.txbContent.Size = new System.Drawing.Size(705, 86);
            this.txbContent.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::UI.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(852, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 34);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(188)))));
            this.btnSave.BorderRadius = 3;
            this.btnSave.DefaultAutoSize = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(188)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(611, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReply
            // 
            this.btnReply.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReply.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReply.CheckedState.Image = global::UI.Properties.Resources.liked;
            this.btnReply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReply.FillColor = System.Drawing.Color.White;
            this.btnReply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReply.ForeColor = System.Drawing.Color.White;
            this.btnReply.Image = global::UI.Properties.Resources.conversation1;
            this.btnReply.Location = new System.Drawing.Point(126, 134);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(29, 33);
            this.btnReply.TabIndex = 13;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblReply);
            this.Controls.Add(this.lblLike);
            this.Controls.Add(this.lblTitle);
            this.Name = "Post";
            this.Size = new System.Drawing.Size(900, 182);
            this.Load += new System.EventHandler(this.Post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblLike;
        private Label lblReply;
        private Panel panel1;
        private Avatar avatar;
        private Label lblAuthorName;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLike;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txbContent;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEdit;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSave;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnReply;
    }
}
