using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmBBMS.BLL;

namespace frmBBMS
{
    public partial class frmGeneratedBill : Form
    {
        BLLBill bllB = new BLLBill();
        string name,customerCode;
        int billNumber;
        public frmGeneratedBill(int abillNumber, string aname, string aCode)
        {
            name = aname;
            billNumber = abillNumber;
            customerCode = aCode;
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmGeneratedBill_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblDate.Text = DateTime.Today.ToShortDateString();//to show todays date
            lblCustomerCode.Text = customerCode;
            lblBillNumber.Text = billNumber.ToString();
            loadGrid();
        }

        private void dgGenerateBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadGrid()
        {
            bllB.setBillNumber(billNumber);
            DataTable dt = bllB.generateBillRetrive();
            dgGenerateBill.DataSource = dt;
            dt = bllB.calculateSum();
            lblTotal.Text = dt.Rows[0][0].ToString();
            float vat = float.Parse(lblTotal.Text) * 0.13f;
            lblVat.Text = vat.ToString();
            float grandTotal = float.Parse(lblTotal.Text) + vat;
            lblGrandTotal.Text = grandTotal.ToString();


        }
       
    }
}
