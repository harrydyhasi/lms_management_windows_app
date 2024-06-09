namespace UI.Forum
{
    partial class frmForum
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
            this.lblForumName = new System.Windows.Forms.Label();
            this.txbSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnSearch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pnlTabs = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnAllTab = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pnlContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pnlControls.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblForumName
            // 
            this.lblForumName.AutoSize = true;
            this.lblForumName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForumName.ForeColor = System.Drawing.Color.Black;
            this.lblForumName.Location = new System.Drawing.Point(3, 6);
            this.lblForumName.Name = "lblForumName";
            this.lblForumName.Size = new System.Drawing.Size(132, 45);
            this.lblForumName.TabIndex = 2;
            this.lblForumName.Text = "Forums";
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColor = System.Drawing.Color.Black;
            this.txbSearch.BorderRadius = 5;
            this.txbSearch.DefaultText = "";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Location = new System.Drawing.Point(3, 10);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txbSearch.PlaceholderText = "Search forum";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(476, 37);
            this.txbSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(492, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 37);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Controls.Add(this.txbSearch);
            this.pnlControls.Controls.Add(this.btnSearch);
            this.pnlControls.Location = new System.Drawing.Point(13, 66);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(922, 62);
            this.pnlControls.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(588, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 37);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add new forum";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlTabs
            // 
            this.pnlTabs.Controls.Add(this.btnAllTab);
            this.pnlTabs.Location = new System.Drawing.Point(13, 138);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(922, 57);
            this.pnlTabs.TabIndex = 16;
            // 
            // btnAllTab
            // 
            this.btnAllTab.BackColor = System.Drawing.Color.White;
            this.btnAllTab.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllTab.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnAllTab.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAllTab.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.btnAllTab.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAllTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllTab.FillColor = System.Drawing.Color.White;
            this.btnAllTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnAllTab.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAllTab.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAllTab.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAllTab.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(158)))));
            this.btnAllTab.Location = new System.Drawing.Point(10, 5);
            this.btnAllTab.Name = "btnAllTab";
            this.btnAllTab.PressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAllTab.PressedDepth = 0;
            this.btnAllTab.Size = new System.Drawing.Size(110, 45);
            this.btnAllTab.TabIndex = 2;
            this.btnAllTab.Text = "All forums";
            this.btnAllTab.CheckedChanged += new System.EventHandler(this.btnAllTab_CheckedChanged);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(13, 201);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(922, 386);
            this.pnlContainer.TabIndex = 17;
            // 
            // frmForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblForumName);
            this.Name = "frmForum";
            this.Size = new System.Drawing.Size(950, 600);
            this.pnlControls.ResumeLayout(false);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblForumName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txbSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSearch;
        private Panel pnlControls;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlTabs;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAllTab;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAdd;
    }
}
