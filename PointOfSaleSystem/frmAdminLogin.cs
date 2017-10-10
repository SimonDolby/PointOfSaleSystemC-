using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleSystem
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();



            String Passcode;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();

            SqlDataAdapter cmd = new SqlDataAdapter("SELECT Passcode,Admin FROM [Employee] WHERE Passcode = @pass and Admin = 'Yes'", con);
            cmd.SelectCommand.Parameters.AddWithValue("@pass", txtPassCode.Text);

            cmd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                AdminUserPanel AdminPanel = new AdminUserPanel();
                AdminPanel.Show();

            }

            con.Close();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "0";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPassCode.Text = txtPassCode.Text + "1";
        }

        private void txtPassCode_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtPassCode.Text.Length != 0)
            {
                txtPassCode.Text = txtPassCode.Text.Remove(txtPassCode.Text.Length - 1, 1);
            }
            else
            {
                MessageBox.Show("The box is empty");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassCode.ReadOnly == true)
            {

                txtPassCode.ReadOnly = false;

            }
            else
            {

                txtPassCode.ReadOnly = true;

            }
            

        }
    }
}
