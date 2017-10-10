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
    public partial class frmCreateSale : Form
    {
        public frmCreateSale()
        {
            InitializeComponent();
          
        }

        private void frmCreateSale_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
              SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);
            SqlDataReader rder = cmd.ExecuteReader();
            while (rder.Read()) 
                {

                cboxBarcode.Items.Add(rder["Barcode"]);





                };


        }

        private void btnStartSale_Click(object sender, EventArgs e)
        {
            if (cboxCategories.SelectedIndex > 0 & cboxBarcode.SelectedIndex == 0)
            { 
            decimal price;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
            price = Convert.ToDecimal(txtPercentage.Text);
            SqlCommand cmd = new SqlCommand("INSERT INTO ActiveSales (Category,DiscountPercentage) VALUES (@Category,@Price)", con);
                        cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Category", Convert.ToString(cboxCategories.SelectedItem.ToString()));

            cmd.ExecuteNonQuery();

            con.Close();
            }
            else if  (cboxBarcode.SelectedIndex > 0 & cboxCategories.SelectedIndex ==0 )
            {

            }
            else
            {
                MessageBox.Show("Please select either a Barcode or a Category to put on sale");

            }
           
        }

        private void cboxBarcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
