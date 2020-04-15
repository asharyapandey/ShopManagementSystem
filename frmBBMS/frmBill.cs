using frmBBMS.BLL;
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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }
        BLLBill bllB = new BLLBill();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bllB.setBillNumber(int.Parse(lblBillNum.Text));
            float total = float.Parse(txtRate.Text) * float.Parse(txtQty.Text);
            bllB.setTotal(total);
            bllB.setQuantity(int.Parse(txtQty.Text));
            bllB.setRate(int.Parse(txtRate.Text));
            bllB.insert();
            loadGrid();
            calculateSum();
            
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            loadCombo();
            loadBill();
            txtCustomerCode.Select();
        }
        
        private void loadCombo()
        {
            //loding combo box
            DataTable dt = bllB.loadCombo();
            cmbItem.DataSource = dt;
            cmbItem.DisplayMember = "itemName";
            cmbItem.ValueMember = "itemCode";
            txtQty.Text = 1.ToString();
            
        }

        private void cmbItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //to view item in the text box
            int a = int.Parse(cmbItem.SelectedValue.ToString());
            bllB.setItemCode(a);
            DataTable dt = bllB.retriveItem();
            txtItemname.Text = dt.Rows[0][0].ToString();
            txtRate.Text = dt.Rows[0][1].ToString();

        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            //show customer info
            bllB.setCustomerID(int.Parse(txtCustomerCode.Text));
            if (txtCustomerCode.Text != "")
            {
                DataTable dt = bllB.retriveCustomer();
                string a = dt.Rows[0][0].ToString(); 
                string b= dt.Rows[0][1].ToString();
                txtName.Text = a +" " + b;
                txtDOB.Text = dt.Rows[0][2].ToString();
                txtPhone.Text = dt.Rows[0][3].ToString();
                txtAddress.Text = dt.Rows[0][4].ToString();
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtDOB.Clear();
            txtAddress.Clear();
            
        }
        private void loadBill()
        {
            //load bill number
            
            DataTable dt = bllB.retriveBill();
            lblBillNum.Text = dt.Rows[0][0].ToString();
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            
            DataTable dt = bllB.retriveBill();
            int increment = int.Parse(dt.Rows[0][0].ToString()) + 1;
            bllB.setNewBill(increment);
            bllB.Click();
            this.Hide();
            frmGeneratedBill frmg = new frmGeneratedBill(int.Parse(lblBillNum.Text),txtName.Text,txtCustomerCode.Text);
            frmg.ShowDialog();
            this.Close();
            loadBill();
            clearAll();
        }
        private void loadGrid()
        {
            DataTable dt = bllB.loadGrid();
            dgBill.DataSource = dt;

        }
        private void calculateSum()
        {
            DataTable dt = bllB.calculateSum();
            lblTotal.Text = dt.Rows[0][0].ToString();
        }
        int itemID;
        private void dgBill_Click(object sender, EventArgs e)
        {
            int columnIndex = dgBill.CurrentCell.ColumnIndex;
            itemID = int.Parse(dgBill.CurrentRow.Cells["itemCode"].Value.ToString());
            bllB.setItemCode(itemID);
            
            if(dgBill.CurrentRow.Cells[columnIndex].Value.ToString()=="Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete the Item?",
                    "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bllB.delete();
                }
                loadGrid();
                calculateSum();
            }
        }
    }
}
