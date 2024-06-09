namespace UI.Learner
{
    partial class frmCertificate
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
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            btnexport = new Button();
            pn = new Panel();
            SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.FillColor = Color.FromArgb(0, 65, 158);
            siticoneControlBox1.IconColor = Color.White;
            siticoneControlBox1.Location = new Point(803, 13);
            siticoneControlBox1.Margin = new Padding(3, 4, 3, 4);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.Size = new Size(24, 28);
            siticoneControlBox1.TabIndex = 1;
            // 
            // btnexport
            // 
            btnexport.Location = new Point(696, 619);
            btnexport.Name = "btnexport";
            btnexport.Size = new Size(131, 47);
            btnexport.TabIndex = 3;
            btnexport.Text = "Export";
            btnexport.UseVisualStyleBackColor = true;
            btnexport.Click += btnexport_Click;
            // 
            // pn
            // 
            pn.Location = new Point(12, 48);
            pn.Name = "pn";
            pn.Size = new Size(815, 565);
            pn.TabIndex = 4;
            // 
            // frmCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 678);
            Controls.Add(pn);
            Controls.Add(btnexport);
            Controls.Add(siticoneControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCertificate";
            Text = "frmCertificate";
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Button btnexport;
        private Panel pn;
    }
}