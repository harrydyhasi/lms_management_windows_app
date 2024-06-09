namespace UI
{
    partial class frmTest
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
            this.siticonePanel_Header_test = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.LabelTime = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.LabelNumOfQuestions = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.LabelTestName = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel_Body_test = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneShadowPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneShadowPanel();
            this.buttonSubmit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.flowLayoutPanel_Question_list_item = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneHtmlLabel_RemainingTime = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel_Time_remaining = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.flowLayoutPanel_BodyTest = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.siticonePanel_Header_test.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.siticonePanel_Body_test.SuspendLayout();
            this.siticoneShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel_Header_test
            // 
            this.siticonePanel_Header_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.siticonePanel_Header_test.BorderColor = System.Drawing.Color.Transparent;
            this.siticonePanel_Header_test.Controls.Add(this.siticonePanel1);
            this.siticonePanel_Header_test.Controls.Add(this.siticonePanel3);
            this.siticonePanel_Header_test.Controls.Add(this.LabelTime);
            this.siticonePanel_Header_test.Controls.Add(this.LabelNumOfQuestions);
            this.siticonePanel_Header_test.Controls.Add(this.LabelTestName);
            this.siticonePanel_Header_test.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel_Header_test.Name = "siticonePanel_Header_test";
            this.siticonePanel_Header_test.Size = new System.Drawing.Size(1200, 120);
            this.siticonePanel_Header_test.TabIndex = 0;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Location = new System.Drawing.Point(157, 75);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(2, 15);
            this.siticonePanel1.TabIndex = 3;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.BackColor = System.Drawing.Color.White;
            this.siticonePanel3.Controls.Add(this.siticonePanel2);
            this.siticonePanel3.Location = new System.Drawing.Point(157, 75);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(2, 15);
            this.siticonePanel3.TabIndex = 3;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.White;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(2, 15);
            this.siticonePanel2.TabIndex = 3;
            // 
            // LabelTime
            // 
            this.LabelTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTime.ForeColor = System.Drawing.Color.White;
            this.LabelTime.Location = new System.Drawing.Point(187, 69);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(124, 23);
            this.LabelTime.TabIndex = 2;
            this.LabelTime.Text = "1 hour 30 minute";
            // 
            // LabelNumOfQuestions
            // 
            this.LabelNumOfQuestions.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumOfQuestions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNumOfQuestions.ForeColor = System.Drawing.Color.White;
            this.LabelNumOfQuestions.Location = new System.Drawing.Point(38, 69);
            this.LabelNumOfQuestions.Name = "LabelNumOfQuestions";
            this.LabelNumOfQuestions.Size = new System.Drawing.Size(96, 23);
            this.LabelNumOfQuestions.TabIndex = 1;
            this.LabelNumOfQuestions.Text = "50 questions";
            // 
            // LabelTestName
            // 
            this.LabelTestName.BackColor = System.Drawing.Color.Transparent;
            this.LabelTestName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTestName.ForeColor = System.Drawing.Color.White;
            this.LabelTestName.Location = new System.Drawing.Point(38, 12);
            this.LabelTestName.Name = "LabelTestName";
            this.LabelTestName.Size = new System.Drawing.Size(147, 39);
            this.LabelTestName.TabIndex = 0;
            this.LabelTestName.Text = "TEST NAME";
            // 
            // siticonePanel_Body_test
            // 
            this.siticonePanel_Body_test.BorderThickness = 2;
            this.siticonePanel_Body_test.Controls.Add(this.siticoneShadowPanel2);
            this.siticonePanel_Body_test.Controls.Add(this.flowLayoutPanel_BodyTest);
            this.siticonePanel_Body_test.Location = new System.Drawing.Point(0, 120);
            this.siticonePanel_Body_test.Name = "siticonePanel_Body_test";
            this.siticonePanel_Body_test.Size = new System.Drawing.Size(1200, 480);
            this.siticonePanel_Body_test.TabIndex = 1;
            // 
            // siticoneShadowPanel2
            // 
            this.siticoneShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel2.Controls.Add(this.buttonSubmit);
            this.siticoneShadowPanel2.Controls.Add(this.flowLayoutPanel_Question_list_item);
            this.siticoneShadowPanel2.Controls.Add(this.siticoneHtmlLabel_RemainingTime);
            this.siticoneShadowPanel2.Controls.Add(this.siticoneHtmlLabel_Time_remaining);
            this.siticoneShadowPanel2.FillColor = System.Drawing.Color.White;
            this.siticoneShadowPanel2.Location = new System.Drawing.Point(900, 10);
            this.siticoneShadowPanel2.Name = "siticoneShadowPanel2";
            this.siticoneShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel2.Size = new System.Drawing.Size(290, 460);
            this.siticoneShadowPanel2.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BorderRadius = 10;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(101, 401);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 40);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // flowLayoutPanel_Question_list_item
            // 
            this.flowLayoutPanel_Question_list_item.AutoScroll = true;
            this.flowLayoutPanel_Question_list_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Question_list_item.Location = new System.Drawing.Point(19, 100);
            this.flowLayoutPanel_Question_list_item.Name = "flowLayoutPanel_Question_list_item";
            this.flowLayoutPanel_Question_list_item.Padding = new System.Windows.Forms.Padding(20, 10, 10, 20);
            this.flowLayoutPanel_Question_list_item.Size = new System.Drawing.Size(261, 185);
            this.flowLayoutPanel_Question_list_item.TabIndex = 2;
            // 
            // siticoneHtmlLabel_RemainingTime
            // 
            this.siticoneHtmlLabel_RemainingTime.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel_RemainingTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel_RemainingTime.ForeColor = System.Drawing.Color.Black;
            this.siticoneHtmlLabel_RemainingTime.Location = new System.Drawing.Point(26, 55);
            this.siticoneHtmlLabel_RemainingTime.Name = "siticoneHtmlLabel_RemainingTime";
            this.siticoneHtmlLabel_RemainingTime.Size = new System.Drawing.Size(52, 27);
            this.siticoneHtmlLabel_RemainingTime.TabIndex = 1;
            this.siticoneHtmlLabel_RemainingTime.Text = "17:11";
            // 
            // siticoneHtmlLabel_Time_remaining
            // 
            this.siticoneHtmlLabel_Time_remaining.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel_Time_remaining.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel_Time_remaining.Location = new System.Drawing.Point(26, 22);
            this.siticoneHtmlLabel_Time_remaining.Name = "siticoneHtmlLabel_Time_remaining";
            this.siticoneHtmlLabel_Time_remaining.Size = new System.Drawing.Size(137, 27);
            this.siticoneHtmlLabel_Time_remaining.TabIndex = 0;
            this.siticoneHtmlLabel_Time_remaining.Text = "Time remaining";
            // 
            // flowLayoutPanel_BodyTest
            // 
            this.flowLayoutPanel_BodyTest.AllowDrop = true;
            this.flowLayoutPanel_BodyTest.AutoScroll = true;
            this.flowLayoutPanel_BodyTest.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_BodyTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_BodyTest.Location = new System.Drawing.Point(9, 8);
            this.flowLayoutPanel_BodyTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_BodyTest.Name = "flowLayoutPanel_BodyTest";
            this.flowLayoutPanel_BodyTest.Size = new System.Drawing.Size(877, 462);
            this.flowLayoutPanel_BodyTest.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.siticonePanel_Header_test);
            this.Controls.Add(this.siticonePanel_Body_test);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Test";
            this.Load += new System.EventHandler(this.frm_Test_Load);
            this.siticonePanel_Header_test.ResumeLayout(false);
            this.siticonePanel_Header_test.PerformLayout();
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel_Body_test.ResumeLayout(false);
            this.siticoneShadowPanel2.ResumeLayout(false);
            this.siticoneShadowPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel_Header_test;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelTime;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelNumOfQuestions;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelTestName;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel_Body_test;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_Time_remaining;
        private FlowLayoutPanel flowLayoutPanel_Question_list_item;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_RemainingTime;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonSubmit;
        private FlowLayoutPanel flowLayoutPanel_BodyTest;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}