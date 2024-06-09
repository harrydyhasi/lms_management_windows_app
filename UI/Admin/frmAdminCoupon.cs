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

namespace UI.Admin
{
    public partial class frmAdminCoupon : Form
    {
        public string Username { get; set; }
        string err;
        bool isCreate;
        bool isUpdate;
        string id;
        public frmAdminCoupon(string username)
        {
            InitializeComponent();
            Username = username;
            LoadData();
            Init(false);
            this.btnCancel.Enabled = false;
            this.btnsave.Enabled = false;
            this.txbCode.Enabled = false;
            isCreate = false;
            isUpdate = false;
            this.btndelete.Enabled = false;
        }
        private void LoadData()
        {
            dtgvCoupon.DataSource = BLL.CouponBLL.Instance.getAll();
            Init(false);
        }

        private void Init(bool check)
        {
            this.txbvalue.Enabled= check;
            this.cbcourse.Enabled= check;
            this.dtimee.Enabled= check;
            this.dtimev.Enabled= check;
        }

        private void Null()
        {
            this.txbvalue.ResetText();
            this.cbcourse.ResetText();
            this.txbCode.ResetText();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Init(true);
            Null();
            this.btnCancel.Enabled = true;
            this.btnsave.Enabled = true;
            this.txbCode.Text = BLL.CouponBLL.Instance.RandomCode();
            isUpdate= false;
            isCreate= true;
            cbcourse.DataSource = CourseBLL.Instance.ListId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Init(false);
            if (isCreate)
                Null();
            isCreate = false;
            isUpdate = false;
            this.btnCancel.Enabled = false;
            this.btnsave.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Init(true);
            isCreate= false;
            this.btnCancel.Enabled = true;
            this.btnsave.Enabled = true;
            isUpdate = true;
            cbcourse.DataSource = CourseBLL.Instance.ListId();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (isCreate)
            {
                BLL.Models.Coupon coupon = new BLL.Models.Coupon(this.txbCode.Text, this.dtimev.Value, this.dtimee.Value,float.Parse(this.txbvalue.Text),this.cbcourse.Text);
                int check = BLL.CouponBLL.Instance.add(coupon, ref err);
                if(check < 1)
                {
                    MessageBox.Show(err);
                }
                else
                {
                    LoadData();
                }
            } 

            if(isUpdate)
            {       
                BLL.Models.Coupon coupon = new BLL.Models.Coupon(id,this.txbCode.Text, Convert.ToDateTime(this.dtimev.Value), Convert.ToDateTime(this.dtimee.Value), float.Parse(this.txbvalue.Text), this.cbcourse.Text);
                int check = BLL.CouponBLL.Instance.update(coupon, ref err);
                if (check < 1)
                {
                    MessageBox.Show(err);
                }
                else
                {
                    LoadData();
                }
            }
        }

        private void dtgvCoupon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Init(false);
            this.btnCancel.Enabled = false;
            this.btnsave.Enabled = false;
            int r = dtgvCoupon.CurrentCell.RowIndex;
            if (r < 0 || r > dtgvCoupon.RowCount - 1)
                return;

            id = dtgvCoupon.Rows[r].Cells[0].Value.ToString();

            this.btndelete.Enabled = true;

            this.txbCode.Text = dtgvCoupon.Rows[r].Cells[1].Value.ToString();
            this.dtimev.Value = Convert.ToDateTime(dtgvCoupon.Rows[r].Cells[2].Value.ToString());
            this.dtimee.Value = Convert.ToDateTime(dtgvCoupon.Rows[r].Cells[3].Value.ToString());
            this.txbvalue.Text = dtgvCoupon.Rows[r].Cells[4].Value.ToString();
            this.cbcourse.Text = dtgvCoupon.Rows[r].Cells[5].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int r = dtgvCoupon.CurrentCell.RowIndex;
            if (r < 0 || r > dtgvCoupon.RowCount - 1)
                return;
            id = dtgvCoupon.Rows[r].Cells[0].Value.ToString();

            int check = BLL.CouponBLL.Instance.Delete(id, ref err);
            if (check < 1)
            {
                MessageBox.Show(err);
            }
            else
            {
                LoadData();
            }
        }
    }
}
