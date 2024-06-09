using BLL.Models;
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
using UI.Lecturer;
using UI.UserControls;
using System.Drawing.Printing;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Reflection;

namespace UI.Learner
{
    public partial class frmCertificate : Form
    {
        private string Learner;
        private string Course;
        Certificate certificate;

        public frmCertificate(string username, string course)
        {
            InitializeComponent();
            Learner = username;
            Course = course;
            Init();
        }
        private void Init()
        {          
            certificate = new Certificate(Learner, Course);
            this.pn.Controls.Clear();
            this.pn.Controls.Add(certificate);
            
        }

        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Panel grd = pn;
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
             System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
             doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
             doc.Print();
             certificate.Print();
        }
    }
}
