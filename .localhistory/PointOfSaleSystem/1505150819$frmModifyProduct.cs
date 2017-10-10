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

      

        private void btnModifyItem_Click(object sender, EventArgs e)
        {
            txtBarcode.ReadOnly = false;
            txtName.ReadOnly = false;
            txtPrice.ReadOnly = false;


        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

            decimal price;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
            price = Convert.ToDecimal(txtPrice.Text);
            SqlCommand cmd = new SqlCommand("UPDATE Product SET Barcode = @Barcode, ItemName = @ItemName, Price = @Price WHERE Barcode = @Barcode ", con);
            cmd.Parameters.AddWithValue("@Barcode", Convert.ToInt32(txtBarcode.Text));
            cmd.Parameters.AddWithValue("@ItemName", Convert.ToString(txtName.Text));
            cmd.Parameters.AddWithValue("@Price", price);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void dgvModProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
         
            
                        
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            int Index;
            Index = dataGridView1.CurrentRow.Index;
            DataGridViewRow row = this.dataGridView1.SelectedRows[Index];
            txtBarcode.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPrice.Text = row.Cells[2].Value.ToString();
        }
    }
    }



