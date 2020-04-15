using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBBMS
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnCustomerD_Click(object sender, EventArgs e)
        {
            frmCustomer frmc = new frmCustomer();
            frmc.ShowDialog();

        }

        private void btnItemD_Click(object sender, EventArgs e)
        {
            frmItem frmi = new frmItem();
            frmi.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBill frmb = new frmBill();
            frmb.ShowDialog();
        }

    } 
}
