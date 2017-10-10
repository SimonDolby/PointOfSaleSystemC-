using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleSystem
{
    public partial class frmCashPayment : Form
    {
        private StaffUserPanel GetTotal;
        public frmCashPayment(StaffUserPanel GetTotal)
        {
            InitializeComponent();
            this.GetTotal = GetTotal;
        }

        private void frmCashPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenTill_Click(object sender, EventArgs e)
        {
            txtChangeDue.Text = Convert.ToString(Convert.ToDouble(txtCashGiven.Text) - Convert.ToDouble(GetTotal.txtTotal.Text));
            if (Convert.ToDouble(txtChangeDue.Text) < 0)
            {



            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "3";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "4";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "8";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + "1";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = txtCashGiven.Text + ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCashGiven.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtCashGiven.Text.Length != 0)
            {
                txtCashGiven.Text = txtCashGiven.Text.Remove(txtCashGiven.Text.Length - 1, 1);
            }
            else
            {
                MessageBox.Show("The box is empty");

            }
        }
    }
}
