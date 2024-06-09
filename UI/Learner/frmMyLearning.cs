using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Learner;

namespace UI
{
    public partial class frmMyLearning : Form
    {
        private string LearnerId;
        public frmMyLearning(string learnerId)
        {
            InitializeComponent();
            LearnerId = learnerId;
            this.btnProgress.Checked = true;

        }

        private void btnProgress_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlContainer.Controls.Clear();
            frmInProgress f = new frmInProgress(LearnerId);
            f.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(f);
        }

        private void btnCompleted_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlContainer.Controls.Clear();
            frmCompleted f = new frmCompleted(LearnerId);
            f.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(f);
        }
    }
}
