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
    public partial class Coupon : UserControl
    {
        public static string CurrentCode;
        public static bool IsDrop = false;
        private string Code;
        public Coupon(string code)
        {
            InitializeComponent();
            Code = code;
            this.lblCoupon.Text = code;
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            CurrentCode = Code;
            IsDrop = true;
        }
    }
}
