namespace UI.UserControls
{
    partial class File
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
            this.buttonFile = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFile.CustomImages.Image = global::UI.Properties.Resources.download;
            this.buttonFile.CustomImages.ImageOffset = new System.Drawing.Point(50, 0);
            this.buttonFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFile.FillColor = System.Drawing.Color.White;
            this.buttonFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFile.ForeColor = System.Drawing.Color.Black;
            this.buttonFile.Image = global::UI.Properties.Resources.docx;
            this.buttonFile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonFile.ImageOffset = new System.Drawing.Point(50, 0);
            this.buttonFile.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonFile.Location = new System.Drawing.Point(0, 0);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(680, 75);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "File name";
            this.buttonFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonFile.TextOffset = new System.Drawing.Point(69, 0);
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // File
            // 
            this.Controls.Add(this.buttonFile);
            this.Name = "File";
            this.Size = new System.Drawing.Size(680, 75);
            this.ResumeLayout(false);

        }


        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonFile;
    
    }
}
