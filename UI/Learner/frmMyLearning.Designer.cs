namespace UI
{
    partial class frmMyLearning
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProgress = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnCompleted = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pnlContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "My learning";
            // 
            // btnProgress
            // 
            this.btnProgress.BackColor = System.Drawing.Color.White;
            this.btnProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnProgress.BorderRadius = 13;
            this.btnProgress.BorderThickness = 1;
            this.btnProgress.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProgress.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnProgress.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnProgress.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnProgress.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnProgress.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProgress.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProgress.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProgress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProgress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProgress.FillColor = System.Drawing.Color.White;
            this.btnProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnProgress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnProgress.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnProgress.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnProgress.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnProgress.Location = new System.Drawing.Point(12, 77);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.PressedDepth = 0;
            this.btnProgress.Size = new System.Drawing.Size(114, 31);
            this.btnProgress.TabIndex = 1;
            this.btnProgress.Text = "In Progress";
            this.btnProgress.CheckedChanged += new System.EventHandler(this.btnProgress_CheckedChanged);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.White;
            this.btnCompleted.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnCompleted.BorderRadius = 13;
            this.btnCompleted.BorderThickness = 1;
            this.btnCompleted.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCompleted.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnCompleted.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnCompleted.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnCompleted.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCompleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompleted.FillColor = System.Drawing.Color.White;
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCompleted.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnCompleted.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnCompleted.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnCompleted.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.Location = new System.Drawing.Point(150, 77);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.PressedDepth = 0;
            this.btnCompleted.Size = new System.Drawing.Size(114, 31);
            this.btnCompleted.TabIndex = 2;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.CheckedChanged += new System.EventHandler(this.btnCompleted_CheckedChanged);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(12, 131);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1176, 437);
            this.pnlContainer.TabIndex = 3;
            // 
            // frmMyLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 580);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMyLearning";
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnProgress;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCompleted;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlContainer;
    }
}