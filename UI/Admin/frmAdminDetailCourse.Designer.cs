namespace UI.Admin
{
    partial class frmAdminDetailCourse
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
            this.dtgvLstLeaner = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLstLeaner)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLstLeaner
            // 
            this.dtgvLstLeaner.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvLstLeaner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLstLeaner.Location = new System.Drawing.Point(12, 56);
            this.dtgvLstLeaner.Name = "dtgvLstLeaner";
            this.dtgvLstLeaner.RowHeadersWidth = 51;
            this.dtgvLstLeaner.RowTemplate.Height = 25;
            this.dtgvLstLeaner.Size = new System.Drawing.Size(411, 382);
            this.dtgvLstLeaner.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnExit.Location = new System.Drawing.Point(400, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 25);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblid.Location = new System.Drawing.Point(12, 13);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(90, 21);
            this.lblid.TabIndex = 38;
            this.lblid.Text = "List learner";
            // 
            // frmAdminDetailCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtgvLstLeaner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDetailCourse";
            this.Text = "frmAdminLeanerCourse";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLstLeaner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvLstLeaner;
        private Label btnExit;
        private Label lblid;
    }
}