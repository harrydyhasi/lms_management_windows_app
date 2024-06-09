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
    public partial class QuestionListItem : UserControl
    {
        SiticoneButton siticoneButton_Question_list_item { get; set; }
        public QuestionListItem()
        {
            InitializeComponent();
        }
    }
}
