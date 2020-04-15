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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DBConnection dbms;
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            dbms = new DBConnection();
            //validation
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter A Username.");
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password.");
                txtPassword.Focus();
                return;
            }
            txtUsername.Focus();
            string query = "select fName from adminInfo where username='" + txtUsername.Text + "'and password ='" +
                txtPassword.Text + "';";
            DataTable a = dbms.retrieve(query);
            if (a.Rows.Count > 0)// to check if a row is in the data table
            {
                frmDashboard frmd = new frmDashboard();
                this.Hide();
                frmd.ShowDialog();
                this.Close();   
            }
            else
            {
                 
                MessageBox.Show("Username or Password Incorrect."+ Environment.NewLine + "Please Try Again.","LogIn");
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frms = new frmSignUp();
            frms.ShowDialog();
        }
    }
}
