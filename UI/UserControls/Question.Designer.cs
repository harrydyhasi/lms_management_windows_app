namespace UI.UserControls
{
    partial class Question
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
            this.siticoneHtmlLabel_Question_title = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.flowLayoutPanel_Choices = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneHtmlLabel_Point = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel_Question_title
            // 
            this.siticoneHtmlLabel_Question_title.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel_Question_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel_Question_title.Location = new System.Drawing.Point(48, 15);
            this.siticoneHtmlLabel_Question_title.Name = "siticoneHtmlLabel_Question_title";
            this.siticoneHtmlLabel_Question_title.Size = new System.Drawing.Size(248, 23);
            this.siticoneHtmlLabel_Question_title.TabIndex = 0;
            this.siticoneHtmlLabel_Question_title.Text = "Question 1: This is title of question?";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.AutoSize = true;
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.flowLayoutPanel_Choices);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel_Point);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel_Question_title);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(800, 150);
            this.siticonePanel1.TabIndex = 1;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // flowLayoutPanel_Choices
            // 
            this.flowLayoutPanel_Choices.AutoSize = true;
            this.flowLayoutPanel_Choices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Choices.Location = new System.Drawing.Point(48, 56);
            this.flowLayoutPanel_Choices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_Choices.Name = "flowLayoutPanel_Choices";
            this.flowLayoutPanel_Choices.Size = new System.Drawing.Size(601, 54);
            this.flowLayoutPanel_Choices.TabIndex = 4;
            // 
            // siticoneHtmlLabel_Point
            // 
            this.siticoneHtmlLabel_Point.BackColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel_Point.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel_Point.ForeColor = System.Drawing.Color.Black;
            this.siticoneHtmlLabel_Point.Location = new System.Drawing.Point(710, 15);
            this.siticoneHtmlLabel_Point.Name = "siticoneHtmlLabel_Point";
            this.siticoneHtmlLabel_Point.Size = new System.Drawing.Size(52, 23);
            this.siticoneHtmlLabel_Point.TabIndex = 3;
            this.siticoneHtmlLabel_Point.Text = "Point 1";
            this.siticoneHtmlLabel_Point.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel1);
            this.Name = "Question";
            this.Size = new System.Drawing.Size(800, 150);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_Question_title;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_Point;
        private FlowLayoutPanel flowLayoutPanel_Choices;
    }
}
