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
    public partial class frmModifyProduct : Form
    {
        public frmModifyProduct()
        {
            InitializeComponent();
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.shopDatabaseDataSet.Product);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index;
            Index = e.RowIndex;
            DataGridViewRow row = this.dgvModProduct.Rows[Index];

            txtName.Text = row.Cells["ItemName"].Value.ToString();
            txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();


        }

        private void btnModifyItem_Click(object sender, EventArgs e)
        {
            txtBarcode.ReadOnly = false;
            txtName.ReadOnly = false;
            txtPrice.ReadOnly = false;


        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee (Username,Passcode,Admin) VALUES (@Username, @Passcode, @admin)", con);
            cmd.Parameters.AddWithValue("@Passcode", Convert.ToInt32(txtPasscode.Text));
            cmd.Parameters.AddWithValue("@Username", Convert.ToString(txtName.Text));
            cmd.Parameters.AddWithValue("@Admin", Admin);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
