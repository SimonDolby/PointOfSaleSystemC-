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
            SqlCommand cmd = new SqlCommand("INSERT INTO Product (Barcode,ItemName,Price) VALUES (@Barcode, @ItemName, @Price)",con);
            cmd.Parameters.AddWithValue("@Barcode", Convert.ToInt32(txtBarcode.Text));
            cmd.Parameters.AddWithValue("@ItemName", Convert.ToString(txtName.Text));
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Price", txtCategory.text);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
