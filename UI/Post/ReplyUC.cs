﻿using BLL;
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
    public partial class ReplyUC : UserControl
    {
        public BLL.Models.Reply CurReply;
        public ReplyUC(BLL.Models.Reply A)
        {
            InitializeComponent();
            CurReply = A;
            LoadData();
        }

        private void LoadData()
        {
            this.lblAuthorName.Text = CurReply.Author;
            this.txbContent.Text = CurReply.Content;
        }


    }
}
