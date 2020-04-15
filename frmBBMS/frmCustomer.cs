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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        customerBLL cBll = new customerBLL();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query;
            //validation
            if (txtFname.Text == "")
            {
                lblError.Text=("Please Enter Your First Name.");
                txtFname.Focus();
                return;
            }
            if (txtLname.Text == "")
            {
                lblError.Text=("Please Enter Your Last Name.");
                txtLname.Focus();
                return;
            }
            if (txtPhone.Text == "")
            {
                lblError.Text=("Please Enter Your Phone Number.");
                txtPhone.Focus();
                return;
            }
            if (txtDOB.Text == "")
            {
                lblError.Text=("Please Enter Your Date Of Birth.");
                txtDOB.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                lblError.Text=("Please Enter Your Address.");
                txtAddress.Focus();
                return;
            }
            if (cmbNationality.Text == "")
            {
                lblError.Text=("Please Select Your Nationality.");
                cmbNationality.Focus();
                return;
            }
            //sex Radio button
            string sex;
            if (rdoMale.Checked)
            {
                sex = "Male";
            }
            else if (rdoFemale.Checked)
            {
                sex = "Female";
            }
            else if (rdoOther.Checked)
            {
                sex = "Other";
            }
            else
            {
                lblError.Text=("Enter Your Sex.");
                return;
                
            }
            //calling setters
            cBll.setFirstName(txtFname.Text);
            cBll.setLastName(txtLname.Text);
            cBll.setDate(txtDOB.Text);
            cBll.setAddress(txtAddress.Text);
            cBll.setNationality(cmbNationality.Text);
            cBll.setGender(sex);
            cBll.setPhone(txtPhone.Text);
            if (btnSubmit.Text == "Submit")
            {
                cBll.insert();
            }
            else
            {
                cBll.update();
                btnSubmit.Text = "Submit";
            }

            loadData();
            clearAll();
        }
        private void loadData()
        {//to load data
            DataTable dt = cBll.loadGrid();
            dgCustomer.DataSource = dt;
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadData();
            cmbNationality.Items.Add("---Please Select---");
            cmbNationality.Items.Add("Nepal");
            cmbNationality.Items.Add("India");
            cmbNationality.Items.Add("China");
            cmbNationality.Items.Add("Bangladesh");
            cmbNationality.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int customerId;
        private void dgCustomer_Click(object sender, EventArgs e)
        {
            int columnIndex = dgCustomer.CurrentCell.ColumnIndex;
            customerId = int.Parse(dgCustomer.CurrentRow.Cells["customerID"].Value.ToString());
            cBll.setCustomerID(customerId);
            DataTable dt;
            if (dgCustomer.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {

                dt =cBll.select();
                txtFname.Text = dt.Rows[0][0].ToString();
                txtLname.Text = dt.Rows[0][1].ToString();
                txtDOB.Text = dt.Rows[0][2].ToString();
                txtPhone.Text = dt.Rows[0][3].ToString();
                txtAddress.Text = dt.Rows[0][4].ToString();
                cmbNationality.Text = dt.Rows[0][5].ToString();
                if (dt.Rows[0][6].ToString() == "Male")
                {
                    rdoMale.Checked = true;
                }
                else if (dt.Rows[0][6].ToString() == "Female")
                {
                    rdoFemale.Checked = true;
                }
                else if(dt.Rows[0][6 ].ToString() == "Others")
                {
                    rdoOther.Checked = true;
                }
                btnSubmit.Text = "Update";
            }
            else if (dgCustomer.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {//displaynf the interactive message box
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete customer?",
                    "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    cBll.delete();
                }
                
            }
            loadData();
        }
        private void clearAll()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtPhone.Clear();
            txtDOB.Clear();
            txtAddress.Clear();
        }
    }
}
