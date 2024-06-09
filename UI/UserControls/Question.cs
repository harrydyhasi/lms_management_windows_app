using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class Question : UserControl
    {
        public bool Type { get; set; }
        public string QuestionId { get; set; }
        public Question()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get { return siticoneHtmlLabel_Question_title.Text; }
            set { siticoneHtmlLabel_Question_title.Text = value; }
        }
        public FlowLayoutPanel PanelChoices {
            get { return flowLayoutPanel_Choices; }
        }
        public string LabelPoint
        {
            get { return siticoneHtmlLabel_Point.Text; }
            set { siticoneHtmlLabel_Point.Text = value; }
        }
        
        
        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
