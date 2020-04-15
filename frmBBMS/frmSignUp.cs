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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        signupBLL sBll = new signupBLL();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //validation
            if (txtFname.Text == "")
            {
                lblError.Text = ("Please Enter Your First Name.");
                txtFname.Focus();
                return;
            }
            if (txtLname.Text == "")
            {
                lblError.Text = ("Please Enter Your Last Name.");
                txtLname.Focus();
                return;
            }
            if (txtPhone.Text == "")
            {
                lblError.Text = ("Please Enter Your Phone Number.");
                txtPhone.Focus();
                return;
            }
            if (txtDOB.Text == "")
            {
                lblError.Text = ("Please Enter Your Date Of Birth.");
                txtDOB.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                lblError.Text = ("Please Enter Your Address.");
                txtAddress.Focus();
                return;
            }

            if (cmbNationality.Text == "")
            {
                lblError.Text = ("Please Select Your Nationality.");
                cmbNationality.Focus();
                return;
            }
            if (txtUsername.Text == "")
            {
                lblError.Text = ("Please Enter A Username.");
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                lblError.Text = ("Please Enter Your Password.");
                txtPassword.Focus();
                return;
            }
            if (txtCPassword.Text == "")
            {
                lblError.Text = ("Please Confirm Your Password.");
                txtCPassword.Focus();
                return;
            }

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
                lblError.Text = ("Enter Your Sex.");
                return;
            }

            if (txtPassword.Text != txtCPassword.Text)
            {
                lblError.Text = "Passwords aren't matching.";
                txtCPassword.Clear();
                txtCPassword.Select();
                return;
            }
            //calling setters
            sBll.setFirstName(txtFname.Text);
            sBll.setLastName(txtLname.Text);
            sBll.setDate(txtDOB.Text);
            sBll.setAddress(txtAddress.Text);
            sBll.setNationality(cmbNationality.Text);
            sBll.setGender(sex);
            sBll.setPhone(txtPhone.Text);
            sBll.setUsername(txtUsername.Text);
            sBll.setPassword(txtPassword.Text);
            
            if (btnSubmit.Text == "Submit")
            {
                sBll.insert();
            }
            else
            {
                sBll.update();
                btnSubmit.Text = "Submit";
            }
            

            loadData();
            clearAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadData()
        {
            DataTable dt = sBll.loadGrid();
            dgSignup.DataSource = dt;
        }
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            loadData();

            txtPassword.UseSystemPasswordChar = true;
            txtCPassword.UseSystemPasswordChar = true;
            cmbNationality.Items.Add("---Please Select---");
            cmbNationality.Items.Add("Nepal");
            cmbNationality.Items.Add("India");
            cmbNationality.Items.Add("China");
            cmbNationality.Items.Add("Bangladesh");
            cmbNationality.SelectedIndex = 0;

        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbShow2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShow.Checked)
            {
                txtCPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtCPassword.UseSystemPasswordChar = true;
            }

        }
        string userId;
        private void dgSignup_Click(object sender, EventArgs e)
        {

            int columnIndex = dgSignup.CurrentCell.ColumnIndex;
            userId = (dgSignup.CurrentRow.Cells["username"].Value.ToString());
            sBll.setUserID(userId);
            DataTable dt;
            if (dgSignup.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                dt = sBll.select();
                txtFname.Text = dt.Rows[0][0].ToString();
                txtLname.Text = dt.Rows[0][1].ToString();
                txtDOB.Text = dt.Rows[0][2].ToString();
                txtPhone.Text = dt.Rows[0][3].ToString();
                txtAddress.Text = dt.Rows[0][4].ToString();
                cmbNationality.Text = dt.Rows[0][5].ToString();
                txtUsername.Text = dt.Rows[0][6].ToString();
                txtPassword.Text = dt.Rows[0][7].ToString();
                if (dt.Rows[0][8].ToString() == "Male")
                {
                    rdoMale.Checked = true;
                }
                else if (dt.Rows[0][8].ToString() == "Female")
                {
                    rdoFemale.Checked = true;
                }
                else if(dt.Rows[0][8].ToString() == "Others")
                {
                    rdoOther.Checked = true;
                }
                btnSubmit.Text = "Update";
            }
            else if (dgSignup.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {//displaynf the interactive message box
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete customer?",
                    "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    sBll.delete();
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
            txtCPassword.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}
