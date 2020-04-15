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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }
        itemBLL itemBLL = new itemBLL();
        private void loadData()
        {//loading data in data grid
            DataTable dt = itemBLL.loadData(); 
            dgItem.DataSource = dt;
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int itemId;
        private void dgItem_Click(object sender, EventArgs e)
        {// editing and deleting
            int columnIndex = dgItem.CurrentCell.ColumnIndex;
            itemId = int.Parse(dgItem.CurrentRow.Cells["itemCode"].Value.ToString());
            itemBLL.setItemID(itemId);
            DataTable dt;
            if (dgItem.CurrentRow.Cells[columnIndex].Value.ToString()== "Edit")
            {
                
                dt = itemBLL.retrive();
                txtItemname.Text = dt.Rows[0][0].ToString();
                txtRate.Text = dt.Rows[0][1].ToString();
                btnSubmit.Text = "Update"; 
            }
            else if (dgItem.CurrentRow.Cells[columnIndex].Value.ToString()=="Delete")
            {//displaynf the interactive message box
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete customer?",
                    "Confirm Delete?", MessageBoxButtons.YesNo);
                if(confirmResult == DialogResult.Yes)
                {
                    itemBLL.delete(); 
                }

            }
            loadData();
            
            
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            itemBLL.setName(txtItemname.Text);
            itemBLL.setRate(int.Parse(txtRate.Text));

            if (btnSubmit.Text == "Submit")//btn ma text submit xa vane submit hunxa else update hhunxa
            {
                itemBLL.insert();
            }
            else
            {
                itemBLL.update();
                btnSubmit.Text = "Submit";
            }
            
            loadData();
            clearAll();
        }
        private void clearAll()
        {
            txtRate.Clear();
            txtItemname.Clear();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtItemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
