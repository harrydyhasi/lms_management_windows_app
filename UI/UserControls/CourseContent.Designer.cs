namespace UI.UserControls
{
    partial class CourseContent
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
            this.siticoneHtmlLabel_Content = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.PanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel_Content
            // 
            this.siticoneHtmlLabel_Content.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel_Content.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel_Content.Location = new System.Drawing.Point(90, 44);
            this.siticoneHtmlLabel_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel_Content.Name = "siticoneHtmlLabel_Content";
            this.siticoneHtmlLabel_Content.Size = new System.Drawing.Size(121, 47);
            this.siticoneHtmlLabel_Content.TabIndex = 0;
            this.siticoneHtmlLabel_Content.Text = "Content";
            // 
            // PanelContainer
            // 
            this.PanelContainer.AllowDrop = true;
            this.PanelContainer.AutoScroll = true;
            this.PanelContainer.Location = new System.Drawing.Point(95, 125);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Padding = new System.Windows.Forms.Padding(20);
            this.PanelContainer.Size = new System.Drawing.Size(760, 454);
            this.PanelContainer.TabIndex = 1;
            // 
            // CourseContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.siticoneHtmlLabel_Content);
            this.Location = new System.Drawing.Point(1, 0);
            this.Name = "CourseContent";
            this.Size = new System.Drawing.Size(950, 600);
            this.Load += new System.EventHandler(this.Course_content_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_Content;
        private FlowLayoutPanel PanelContainer;
    }
}
