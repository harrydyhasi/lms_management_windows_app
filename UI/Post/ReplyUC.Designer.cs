namespace UI.UserControls
{
    partial class ReplyUC
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
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.avatar = new UI.UserControls.Avatar();
            this.txbContent = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(158)))));
            this.lblRole.Location = new System.Drawing.Point(145, 12);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(67, 21);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Learner";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorName.ForeColor = System.Drawing.Color.Black;
            this.lblAuthorName.Location = new System.Drawing.Point(62, 11);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(68, 21);
            this.lblAuthorName.TabIndex = 11;
            this.lblAuthorName.Text = "rocking";
            // 
            // avatar
            // 
            this.avatar.Image = global::UI.Properties.Resources.user;
            this.avatar.Location = new System.Drawing.Point(4, 4);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(40, 38);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 10;
            this.avatar.TabStop = false;
            // 
            // txbContent
            // 
            this.txbContent.AutoScroll = true;
            this.txbContent.DefaultText = "";
            this.txbContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txbContent.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txbContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txbContent.Enabled = false;
            this.txbContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbContent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbContent.Location = new System.Drawing.Point(6, 52);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.PasswordChar = '\0';
            this.txbContent.PlaceholderText = "";
            this.txbContent.SelectedText = "";
            this.txbContent.Size = new System.Drawing.Size(695, 104);
            this.txbContent.TabIndex = 16;
            // 
            // ReplyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.avatar);
            this.Name = "ReplyUC";
            this.Size = new System.Drawing.Size(707, 163);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRole;
        private Label lblAuthorName;
        private Avatar avatar;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txbContent;
    }
}
