namespace UI.Forum
{
    partial class frmPostDetail
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.avatar = new UI.UserControls.Avatar();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.PictureBox();
            this.lblReply = new System.Windows.Forms.Label();
            this.lblLike = new System.Windows.Forms.Label();
            this.plReply = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.plComment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLike = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReply)).BeginInit();
            this.plReply.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "All slide of this course";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblContent.Location = new System.Drawing.Point(12, 102);
            this.lblContent.MaximumSize = new System.Drawing.Size(500, 35);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(421, 34);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Hi everyone This is all slide of this course. Hope you enjoy this course. https:/" +
    "/drive.google.com/open?id=0B1Mq7kkwjPxLYnZwdkxnLWc0dXM";
            // 
            // avatar
            // 
            this.avatar.Image = global::UI.Properties.Resources.user;
            this.avatar.Location = new System.Drawing.Point(12, 51);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(41, 32);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 7;
            this.avatar.TabStop = false;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorName.ForeColor = System.Drawing.Color.Black;
            this.lblAuthorName.Location = new System.Drawing.Point(72, 58);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(68, 21);
            this.lblAuthorName.TabIndex = 8;
            this.lblAuthorName.Text = "rocking";
            // 
            // btnReply
            // 
            this.btnReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReply.Image = global::UI.Properties.Resources.conversation;
            this.btnReply.Location = new System.Drawing.Point(132, 157);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(24, 24);
            this.btnReply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReply.TabIndex = 13;
            this.btnReply.TabStop = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // lblReply
            // 
            this.lblReply.AutoSize = true;
            this.lblReply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblReply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReply.Location = new System.Drawing.Point(162, 161);
            this.lblReply.Name = "lblReply";
            this.lblReply.Size = new System.Drawing.Size(60, 17);
            this.lblReply.TabIndex = 12;
            this.lblReply.Text = "Reply 20";
            this.lblReply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lblLike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLike.Location = new System.Drawing.Point(47, 161);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(51, 17);
            this.lblLike.TabIndex = 10;
            this.lblLike.Text = "Like 20";
            this.lblLike.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plReply
            // 
            this.plReply.Controls.Add(this.label1);
            this.plReply.Controls.Add(this.siticoneTextBox1);
            this.plReply.Location = new System.Drawing.Point(17, 204);
            this.plReply.Name = "plReply";
            this.plReply.Size = new System.Drawing.Size(959, 100);
            this.plReply.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Post reply";
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.AutoScroll = true;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(6, 37);
            this.siticoneTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneTextBox1.Multiline = true;
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.siticoneTextBox1.PlaceholderText = "Add details for others to answer your question";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(949, 50);
            this.siticoneTextBox1.TabIndex = 0;
            // 
            // plComment
            // 
            this.plComment.AutoScroll = true;
            this.plComment.Location = new System.Drawing.Point(17, 328);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(959, 360);
            this.plComment.TabIndex = 15;
            // 
            // btnLike
            // 
            this.btnLike.Checked = true;
            this.btnLike.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLike.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLike.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLike.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLike.FillColor = System.Drawing.Color.White;
            this.btnLike.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLike.ForeColor = System.Drawing.Color.White;
            this.btnLike.Image = global::UI.Properties.Resources.like;
            this.btnLike.Location = new System.Drawing.Point(13, 153);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(33, 33);
            this.btnLike.TabIndex = 16;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(943, 12);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(33, 28);
            this.siticoneControlBox1.TabIndex = 17;
            // 
            // frmPostDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.ControlBox = false;
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.plComment);
            this.Controls.Add(this.plReply);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.lblReply);
            this.Controls.Add(this.lblLike);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(17, 204);
            this.Name = "frmPostDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PostDetail";
            this.Load += new System.EventHandler(this.frm_PostDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReply)).EndInit();
            this.plReply.ResumeLayout(false);
            this.plReply.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblContent;
        private UserControls.Avatar avatar;
        private Label lblAuthorName;
        private PictureBox btnReply;
        private Label lblReply;
        private Label lblLike;
        private Panel plReply;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private FlowLayoutPanel plComment;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLike;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}