using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Course;

namespace UI.UserControls
{
    public partial class File : UserControl
    {
        public string fileName
        {
            get { return buttonFile.Text; }
            set { buttonFile.Text = value; }
        }
        public Image image
        {
            get { return buttonFile.Image; }
            set { buttonFile.Image = value; }
        }
        public string url { get; set; }
        public File()
        {
            InitializeComponent();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });

        }
    }
}
