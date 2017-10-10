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

    public partial class frmLookupItem : Form
    {
        
        private StaffUserPanel LookupItem;
        public frmLookupItem(StaffUserPanel LookupItem)
        {
            InitializeComponent();
            
            this.LookupItem = LookupItem;

             

        }
        public double SubTotal;
        public double Total;
        const int Tax = 20;



        private void txtboxBarcodeLookUp_Click(object sender, EventArgs e)
        {
            frmLookUpItemKeypad Keypadshow = new frmLookUpItemKeypad(this);
            Keypadshow.Show();
        }

        private void frmLookupItem_Load(object sender, EventArgs e)
        {
            SubTotal = System.Convert.ToDouble(LookupItem.txtSubTotal.Text);
            Total = System.Convert.ToDouble(LookupItem.txtTotal.Text);
        }

        private void btnFindCode_Click(object sender, EventArgs e)
        {

            //This button gets the input from the text box, search the products table for an item that matches 
            // the barcode. Then will add the item to the order shown by the Staff User panel.
         


           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT ItemName,Price FROM  Product WHERE Barcode = @Barcode", con);
            //Parameterising my SQL to help prevent Injection attacks.
            cmd.Parameters.AddWithValue("@Barcode", txtBarcodeLookUp.Text);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
             //   string[] row = { (String)rdr["ItemName"], (String)rdr["Price"].ToString(), "1" };
                ListViewItem listviewItem = new ListViewItem((String)rdr["ItemName"]);
                listviewItem.SubItems.Add((String)rdr["Price"].ToString());
                String Price = (String)rdr["Price"].ToString();

                SubTotal = SubTotal + System.Convert.ToDouble(Price);
                listviewItem.SubItems.Add("1");
                LookupItem.lstOrder.Items.Add(listviewItem);
                LookupItem.txtSubTotal.Text = SubTotal.ToString();
                
                if (LookupItem.cboxStaffDiscount.Checked == true )
                {
                    LookupItem.txtVATAdded.Text = ((SubTotal / 100) * 10).ToString();
                    LookupItem.txtTotal.Text =  ((double)SubTotal + ((SubTotal / 100) * 10)).ToString();
                }
                else
                {
                    LookupItem.txtTotal.Text =  ((double)SubTotal + ((SubTotal / 100) * 20)).ToString();
                    LookupItem.txtVATAdded.Text = ((SubTotal / 100) * 20).ToString();
                }
             
            }
                 

        }
    }
}
