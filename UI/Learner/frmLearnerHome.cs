using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UserControls;

namespace UI
{
    public partial class frmLearnerHome : Form
    {
        public string LearnerID;
        BLL.Models.Cart C;
        public string err;
        public static bool isLoadQuantity = false;
        public frmLearnerHome(string learnerId)
        {
            InitializeComponent();
            LearnerID = learnerId;
            C = CartBLL.Instance.getById(LearnerID);
            LoadData();
            timer1.Start();
        }

        private void frm_DisplayCourseList_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (UI.UserControls.CourseTypeCard.isAddItemToCart)
            {
                UI.UserControls.CourseTypeCard.isAddItemToCart = false;

                if (CartBLL.Instance.AddItemToCart(UI.UserControls.CourseTypeCard.CurrentCourseID, C.CartId, ref err))
                {
                    isLoadQuantity = true;
                }
                else
                {
                    MessageBox.Show(err);
                }
            }

            if (frmCart.isLoad)
            {
                frmCart.isLoad = false;
                LoadData();
            }
        }

        private void LoadData()
        {
            this.plCourse.Controls.Clear();
            List<string> list = CourseBLL.Instance.getLearnerCourseInHome(LearnerID);
            foreach (var c in list)
            {
                this.plCourse.Controls.Add(new UI.UserControls.CourseTypeCard(c));
            }
        }
    }
}
