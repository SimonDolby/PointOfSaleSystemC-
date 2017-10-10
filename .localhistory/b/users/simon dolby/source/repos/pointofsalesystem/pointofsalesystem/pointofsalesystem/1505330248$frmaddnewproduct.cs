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
    public partial class FrmAddNewProduct : Form
    {
        public FrmAddNewProduct()
        {
            InitializeComponent();



        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            decimal price;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
            price = Convert.ToDecimal(txtPrice.Text);
            SqlCommand cmd = new SqlCommand("INSERT INTO Product (Barcode,ItemName,Price, Category) VALUES (@Barcode, @ItemName, @Price, @Category)",con);
            cmd.Parameters.AddWithValue("@Barcode", Convert.ToInt32(txtBarcode.Text));
            cmd.Parameters.AddWithValue("@ItemName", Convert.ToString(txtName.Text));
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Category", Convert.ToString(txtCategory.Text));

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void FrmAddNewProduct_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
            SqlCommand cmd;
            SqlDataReader rder = cmd.ExecuteReader();
                     txtCategory.Items.Add("");
          
            cmd = new SqlCommand("Select * From Category", con);

            rder = cmd.ExecuteReader();
            while (rder.Read())
            {
              txtCategories.Items.Add(rder["Category"]);
            }
            rder.Close();
            con.Close();
        }
    }
}
