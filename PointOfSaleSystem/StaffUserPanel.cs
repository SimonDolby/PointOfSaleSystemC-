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
    
    

    public partial class StaffUserPanel : Form

    
    {

       

        public StaffUserPanel()
        {
            InitializeComponent();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            frmCashPayment CashPayments;
            CashPayments = new frmCashPayment(this);
            CashPayments.Show();


        }

        private void btnLookupItem_Click(object sender, EventArgs e)
        {
            

            frmLookupItem LookupItem = new frmLookupItem(this);
            LookupItem.Show();

        }

        private void StaffUserPanel_Load(object sender, EventArgs e)
        {
            
           
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStaffDiscount_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnNewTransaction_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            txtTotal.Text = "0.00";
            txtSubTotal.Text = "0.00";
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count != 0)
            {


                foreach (ListViewItem lvItem in lstOrder.SelectedItems)
                {
                    double SubTotal;
                    double Total;
                    
                    String Price = lvItem.SubItems[1].Text;
                    SubTotal = System.Convert.ToDouble(txtSubTotal.Text);
                    Total = System.Convert.ToDouble(txtTotal.Text);
                    SubTotal = SubTotal - Convert.ToDouble(Price);
                    txtSubTotal.Text = SubTotal.ToString();
                    txtVATAdded.Text = ((SubTotal / 100) * 20).ToString();
                    double VATPrice = Convert.ToDouble(txtVATAdded.Text);
                    Total = (SubTotal + VATPrice);
                    txtTotal.Text = Total.ToString();
                    lstOrder.Items.Remove(lvItem);
                    
                }

            }
            else
            {

                MessageBox.Show("No Items");

            }
            
        }

        private void BtnCard_Click(object sender, EventArgs e)
        {

        }
    }
}
