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
    public partial class frmLookUpItemKeypad : Form
    {

        private frmLookupItem Keypad;
        
        public frmLookUpItemKeypad(frmLookupItem Keypad)
        {
            InitializeComponent();
            this.Keypad = Keypad;
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "3";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "7";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "4";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text + "1";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Keypad.txtBarcodeLookUp.Text.Length != 0)
            {
                Keypad.txtBarcodeLookUp.Text = Keypad.txtBarcodeLookUp.Text.Remove(Keypad.txtBarcodeLookUp.Text.Length - 1, 1);

            }
            else
            {
                MessageBox.Show("The box is empty");

            }
        }
    }
}
