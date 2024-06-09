using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace UI.Course
{
    public partial class frmAddVideo : Form
    {
        private string SectionId;
        private string Path;

        public frmAddVideo(string sectionId)
        {
            InitializeComponent();
            SectionId = sectionId;
        }

        private void siticoneShadowForm1_Load(object sender, EventArgs e)
        {
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.TextboxVideoPath.Text = openFileDialog1.FileName;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Video t = new Video();
            t.SectionId = SectionId;
            t.VideoPath = this.TextboxVideoPath.Text;
            VideoBLL videoBLL = new VideoBLL();
            string err = string.Empty;
            if (videoBLL.add(t, ref err) == 0)
            {
                MessageBox.Show(err);
            }
            else
            {
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
