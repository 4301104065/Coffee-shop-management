﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class fReceipt : Form
    {
        public fReceipt()
        {
            InitializeComponent();
        }

        private void fReceipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GetListBillByDateForReport.USP_GetListBillByDateForReport' table. You can move, or remove it, as needed.
            


            this.reportViewer1.RefreshReport();
        }
    }
}
