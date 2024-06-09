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
    public partial class frmAdminCourseSection : Form
    {
        public string Username;
        bool isCreate;
        bool isUpdate;
        public string err;
        public frmAdminCourseSection(string username)
        {
            InitializeComponent();
            Username = username;
            LoadData();
            Init(false);
            
            this.txbNumber.Enabled = false;
            this.txbcourseid.Enabled = false;

            this.cbCheck.SelectedIndex = 0;
        }
        private void LoadData()
        {
            dtgvCourse.DataSource = CourseBLL.Instance.getAll();
            lblNumber.Text = BLL.CourseBLL.Instance.CountCourse();
        }
        private void Init(bool check)
        {
            this.btnCancel.Enabled = false;
            this.btnSave.Enabled = false;
            this.isCreate = false;
            this.isUpdate = false;
            this.txboprice.Enabled = check;
            this.txbsprice.Enabled = check;
            this.txbdiscount.Enabled = check;
            this.txbname.Enabled = check;
            this.txblecturerid.Enabled = check;
        }
        private void dtgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dtgvCourse.CurrentCell.RowIndex;

                if (r < 0 || r > dtgvCourse.RowCount - 1)
                    return;
                string courseid = dtgvCourse.Rows[r].Cells[0].Value.ToString();

                this.txbcourseid.Text = courseid;
                BLL.Models.Course course = BLL.CourseBLL.Instance.getById(courseid);

                this.txbdiscount.Text = course.Discount.ToString();
                this.txblecturerid.Text = course.LecturerId.ToString();
                this.txbname.Text = course.CourseName.ToString();
                this.txbsprice.Text = course.SellingPrice.ToString();
                this.txboprice.Text = course.OriginalPrice.ToString();

                this.txbNumber.Text = CourseBLL.Instance.GetNumberLeaner(courseid).ToString();
                Init(false);

            }
            catch
            {
                return;
            }
            
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmAdminDetailCourse f = new frmAdminDetailCourse(this.txbcourseid.Text);
            f.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string courseid = this.txbcourseid.Text;
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int check = CourseBLL.Instance.DeleteCourse(courseid, ref err);
                if (check == 0)
                {
                    MessageBox.Show(err);
                }
                else
                {
                    LoadData();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Init(true);
            isUpdate = true;
            isCreate = false;
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Init(true);
            isUpdate = false;
            isCreate = true;
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;
            InitNull();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Init(false);
        }

        private void InitNull()
        {
            this.txbname.ResetText();
            this.txbcourseid.ResetText();
            this.txbdiscount.ResetText();
            this.txblecturerid.ResetText();
            this.txbname.ResetText();
            this.txbNumber.ResetText();
            this.txboprice.ResetText();
            this.txbsprice.ResetText();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            

            string name = txbname.Text;
            float oprice = float.Parse(txboprice.Text);
            float sprice = float.Parse(txbsprice.Text);
            float discount = float.Parse(txbdiscount.Text);
            string lecturer = txblecturerid.Text;

            if (isUpdate)
            {
                int r = dtgvCourse.CurrentCell.RowIndex;
                string courseid = dtgvCourse.Rows[r].Cells[0].Value.ToString();
                float avg = float.Parse(dtgvCourse.Rows[r].Cells[6].Value.ToString());

                int check = CourseBLL.Instance.update(new BLL.Models.Course(courseid,name,lecturer,oprice,discount,sprice,avg), ref err);
                if(check < 1)
                {
                    MessageBox.Show(err);
                }
                else
                {
                    LoadData();
                }
            }
            if (isCreate)
            {
                
                int check = CourseBLL.Instance.add(new BLL.Models.Course("", name, lecturer, oprice, discount, sprice, 0), ref err);
                if (check < 1)
                {
                    MessageBox.Show(err);
                }
                else
                {
                    LoadData();
                }
            }
            LoadData();
        }

        private void frmAdminCourseSection_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txbSearch.Text;
            if(this.cbCheck.SelectedIndex == 0)
            {
                dtgvCourse.DataSource = BLL.CourseBLL.Instance.SearchCourseById(input);
            }
            else
            {
                dtgvCourse.DataSource = BLL.CourseBLL.Instance.SearchCourseByName(input);
            }
        }

        private void frmAdminCourseSection_Click(object sender, EventArgs e)
        {
            txbSearch.SelectAll();
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.SelectAll();
        }
    }
}
