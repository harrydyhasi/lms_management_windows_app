namespace UI.UserControls
{
    partial class s
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
            this.ButtonMaterial = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PanelMaterials = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.PanelAssignments = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.ButtonAssignment = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PanelTests = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.ButtonTest = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ButtonBack = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PanelVideo = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.Video = new System.Windows.Forms.WebBrowser();
            this.ButtonAddVideo = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PanelMaterials.SuspendLayout();
            this.PanelAssignments.SuspendLayout();
            this.PanelTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonMaterial
            // 
            this.ButtonMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMaterial.CustomImages.ImageOffset = new System.Drawing.Point(50, 0);
            this.ButtonMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonMaterial.FillColor = System.Drawing.Color.White;
            this.ButtonMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMaterial.ForeColor = System.Drawing.Color.Black;
            this.ButtonMaterial.Image = global::UI.Properties.Resources.right_arrow;
            this.ButtonMaterial.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonMaterial.ImageOffset = new System.Drawing.Point(50, 0);
            this.ButtonMaterial.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonMaterial.Location = new System.Drawing.Point(0, 3);
            this.ButtonMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMaterial.Name = "ButtonMaterial";
            this.ButtonMaterial.Size = new System.Drawing.Size(682, 77);
            this.ButtonMaterial.TabIndex = 5;
            this.ButtonMaterial.Text = "Material";
            this.ButtonMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonMaterial.TextOffset = new System.Drawing.Point(50, 0);
            this.ButtonMaterial.Click += new System.EventHandler(this.ButtonMaterial_Click);
            // 
            // PanelMaterials
            // 
            this.PanelMaterials.AutoSize = true;
            this.PanelMaterials.BorderThickness = 1;
            this.PanelMaterials.Controls.Add(this.ButtonMaterial);
            this.PanelMaterials.Location = new System.Drawing.Point(0, 228);
            this.PanelMaterials.Name = "PanelMaterials";
            this.PanelMaterials.Size = new System.Drawing.Size(682, 80);
            this.PanelMaterials.TabIndex = 11;
            // 
            // PanelAssignments
            // 
            this.PanelAssignments.AutoSize = true;
            this.PanelAssignments.BorderThickness = 1;
            this.PanelAssignments.Controls.Add(this.ButtonAssignment);
            this.PanelAssignments.Location = new System.Drawing.Point(0, 310);
            this.PanelAssignments.Name = "PanelAssignments";
            this.PanelAssignments.Size = new System.Drawing.Size(682, 80);
            this.PanelAssignments.TabIndex = 12;
            // 
            // ButtonAssignment
            // 
            this.ButtonAssignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAssignment.CustomImages.ImageOffset = new System.Drawing.Point(50, 0);
            this.ButtonAssignment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAssignment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAssignment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAssignment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAssignment.FillColor = System.Drawing.Color.White;
            this.ButtonAssignment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAssignment.ForeColor = System.Drawing.Color.Black;
            this.ButtonAssignment.Image = global::UI.Properties.Resources.right_arrow;
            this.ButtonAssignment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonAssignment.ImageOffset = new System.Drawing.Point(50, 0);
            this.ButtonAssignment.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonAssignment.Location = new System.Drawing.Point(0, 0);
            this.ButtonAssignment.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAssignment.Name = "ButtonAssignment";
            this.ButtonAssignment.Size = new System.Drawing.Size(682, 77);
            this.ButtonAssignment.TabIndex = 5;
            this.ButtonAssignment.Text = "Assignment";
            this.ButtonAssignment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonAssignment.TextOffset = new System.Drawing.Point(50, 0);
            this.ButtonAssignment.Click += new System.EventHandler(this.ButtonAssignment_Click);
            // 
            // PanelTests
            // 
            this.PanelTests.AutoSize = true;
            this.PanelTests.BorderThickness = 1;
            this.PanelTests.Controls.Add(this.ButtonTest);
            this.PanelTests.Location = new System.Drawing.Point(0, 391);
            this.PanelTests.Name = "PanelTests";
            this.PanelTests.Size = new System.Drawing.Size(682, 77);
            this.PanelTests.TabIndex = 13;
            // 
            // ButtonTest
            // 
            this.ButtonTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTest.CustomImages.ImageOffset = new System.Drawing.Point(50, 0);
            this.ButtonTest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonTest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonTest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonTest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonTest.FillColor = System.Drawing.Color.White;
            this.ButtonTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonTest.ForeColor = System.Drawing.Color.Black;
            this.ButtonTest.Image = global::UI.Properties.Resources.right_arrow;
            this.ButtonTest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonTest.ImageOffset = new System.Drawing.Point(50, 0);
            this.ButtonTest.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonTest.Location = new System.Drawing.Point(0, 0);
            this.ButtonTest.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(682, 77);
            this.ButtonTest.TabIndex = 5;
            this.ButtonTest.Text = "Test";
            this.ButtonTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonTest.TextOffset = new System.Drawing.Point(50, 0);
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonBack.FillColor = System.Drawing.Color.Transparent;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ButtonBack.ForeColor = System.Drawing.Color.Black;
            this.ButtonBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonBack.Location = new System.Drawing.Point(595, 3);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(87, 28);
            this.ButtonBack.TabIndex = 14;
            this.ButtonBack.Text = "< Back";
            this.ButtonBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // PanelVideo
            // 
            this.PanelVideo.Location = new System.Drawing.Point(3, 76);
            this.PanelVideo.Name = "PanelVideo";
            this.PanelVideo.Size = new System.Drawing.Size(679, 152);
            this.PanelVideo.TabIndex = 15;
            // 
            // Video
            // 
            this.Video.Location = new System.Drawing.Point(0, 77);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(682, 149);
            this.Video.TabIndex = 0;
            // 
            // ButtonAddVideo
            // 
            this.ButtonAddVideo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonAddVideo.BorderRadius = 10;
            this.ButtonAddVideo.BorderThickness = 1;
            this.ButtonAddVideo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddVideo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddVideo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddVideo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddVideo.FillColor = System.Drawing.Color.White;
            this.ButtonAddVideo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.ButtonAddVideo.Location = new System.Drawing.Point(572, 33);
            this.ButtonAddVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddVideo.Name = "ButtonAddVideo";
            this.ButtonAddVideo.Size = new System.Drawing.Size(110, 38);
            this.ButtonAddVideo.TabIndex = 57;
            this.ButtonAddVideo.Text = "Add Video";
            this.ButtonAddVideo.Click += new System.EventHandler(this.ButtonAddVideo_Click);
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.ButtonAddVideo);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.PanelVideo);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.PanelTests);
            this.Controls.Add(this.PanelAssignments);
            this.Controls.Add(this.PanelMaterials);
            this.Name = "s";
            this.Size = new System.Drawing.Size(790, 481);
            this.PanelMaterials.ResumeLayout(false);
            this.PanelAssignments.ResumeLayout(false);
            this.PanelTests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonMaterial;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelMaterials;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelAssignments;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonAssignment;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelTests;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonTest;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonBack;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelVideo;
        private WebBrowser Video;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonAddVideo;
    }
}