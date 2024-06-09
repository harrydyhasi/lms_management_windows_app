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
using UI.UserControls;
using BLL.Models;
using Coupon = UI.UserControls.Coupon;

namespace UI
{
    public partial class frmCart : Form
    {
        int x, y;
        public string IdCart;
        string err;
        public float TotalPrice;
        public static bool isLoad = false;

        public frmCart(string idCart)
        {
            InitializeComponent(); 
            x = this.pnlEnterCoupon.Location.X;
            y = this.pnlEnterCoupon.Location.Y;
            this.IdCart = idCart;
            this.timerRemoveItem.Start();
            //LoadData();
        }

        private void btnAppy_Click(object sender, EventArgs e)
        {
            string tmp = this.txCoupon.Text;
            if (CouponBLL.Instance.isExist(tmp) == 0)
            {
                MessageBox.Show("Coupon is unvalid!");
            }
            else
            {
                this.pnlCoupon.Controls.Add(new Coupon(tmp));
                int xTmp = x;
                int yTmp = y + this.pnlCoupon.Controls.Count * 40;
                if (yTmp >= this.panel1.Height - 40)
                {
                    this.pnlCoupon.AutoScroll = true;
                    this.pnlCoupon.FlowDirection = FlowDirection.TopDown;
                }
                else
                {
                    this.pnlCoupon.Height = this.pnlCoupon.Controls.Count * 40;
                    this.pnlEnterCoupon.Location = new Point(xTmp, yTmp);
                }

                //this.TotalPrice = this.TotalPrice + this.TotalPrice * 
                
            }
            

        }

        private void btnKeepShopping_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerRemoveItem_Tick(object sender, EventArgs e)
        {
            if (ItemInCart.IsRemove)
            {
                ItemInCart.IsRemove = false;
                if (CartBLL.Instance.RemoveItemInCart(ItemInCart.CurrentID, ref err))
                {
                    LoadData();
                    MessageBox.Show("Removed Successfully!");
                }
                else
                {
                    MessageBox.Show(err);
                }
            }

            if (Coupon.IsDrop)
            {
                Coupon.IsDrop = false;
            }    
        }

        private void frm_Cart_Load(object sender, EventArgs e)
        {
            List<String> crs = CartBLL.Instance.GetItemsListInCartByIdCart(IdCart);
            foreach (string item in crs)
            {
                this.pnlCart.Controls.Add(new ItemInCart(item));
            }
            BLL.Models.Cart B = BLL.CartBLL.Instance.getById(IdCart);
            this.lblTotal.Text = B.TotalPrice.ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<String> crs = CartBLL.Instance.GetItemsListInCartByIdCart(IdCart);
            foreach(string item in crs)
            {
                CourseBLL.Instance.EnrollCourse(frmLogin.CurAcc.Username,item, ref err);
                CartBLL.Instance.RemoveAllItemsInCart(IdCart, ref err);
            }
            this.pnlCart.Controls.Clear();
            this.lblTotal.Text = "0";
            MessageBox.Show("Payment Successful");
        }

        private void frmCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLearnerHome.isLoadQuantity = true;
            frmCart.isLoad = true;
        }

        private void LoadData()
        {
            this.pnlCart.Controls.Clear();
            List<String> crs = CartBLL.Instance.GetItemsListInCartByIdCart(IdCart);
            foreach (string item in crs)
            {
                this.pnlCart.Controls.Add(new ItemInCart(item));
            }
            BLL.Models.Cart B = BLL.CartBLL.Instance.getById(IdCart);
            this.lblTotal.Text = B.TotalPrice.ToString();
            if (this.pnlCart.Controls.Count == 0)
            {
                this.pnlCart.Visible = true;
            }
            else
            {
                this.pnlCart.Visible = false;
            }
        }
    }
}
