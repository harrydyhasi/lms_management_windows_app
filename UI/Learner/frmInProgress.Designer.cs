﻿namespace UI.Learner
{
    partial class frmInProgress
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
            this.fpnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fpnlContainer
            // 
            this.fpnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlContainer.Location = new System.Drawing.Point(0, 0);
            this.fpnlContainer.Name = "fpnlContainer";
            this.fpnlContainer.Size = new System.Drawing.Size(952, 387);
            this.fpnlContainer.TabIndex = 0;
            // 
            // frmInProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fpnlContainer);
            this.Name = "frmInProgress";
            this.Size = new System.Drawing.Size(952, 387);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel fpnlContainer;
    }
}
