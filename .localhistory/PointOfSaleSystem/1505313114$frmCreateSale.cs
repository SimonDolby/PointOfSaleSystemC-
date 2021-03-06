﻿using System;
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
            cmd = new SqlCommand("Select * From Category", con);
            rder = cmd.ExecuteReader();
            while (rder.Read())
            {
                cboxCategories.Items.Add(rder["Category"]);
            }
        }

        private void btnStartSale_Click(object sender, EventArgs e)
        {
            decimal price;
            decimal percentage;
            
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
            if (cboxCategories.SelectedIndex > 0 & cboxBarcode.SelectedIndex == 0)
            {
                string Category;

                percentage = Convert.ToDecimal(txtPercentage.Text);
           cmd = new SqlCommand("INSERT INTO ActiveSales (Category,DiscountPercentage) VALUES (@Category,@percentage)", con);
                        cmd.Parameters.AddWithValue("@percentage", percentage);
            cmd.Parameters.AddWithValue("@Category", Convert.ToString(cboxCategories.SelectedItem));

            cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SELECT * FROM Product", con);
                SqlDataReader rder;
                rder = cmd.ExecuteReader();
                while (rder.Read())
                {
                    cmd = new SqlCommand("Update Product Set Price = @Price Where Category = @Category", con);
                    price = Convert.ToDecimal(rder["Price"]) - ((Convert.ToDecimal(rder["Price"]) / 100) * 20);
                    cmd.Parameters.AddWithValue("@Price", price);
                    Category = cboxCategories.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@Category",Category);

                };
            con.Close();
            }
            else
            {

                string Barcode;

                percentage = Convert.ToDecimal(txtPercentage.Text);
                cmd = new SqlCommand("INSERT INTO ActiveSales (Barcode,DiscountPercentage) VALUES (@Barcode,@percentage)", con);
                cmd.Parameters.AddWithValue("@percentage", percentage);
                cmd.Parameters.AddWithValue("@Barcode", Convert.ToString(cboxCategories.SelectedItem));

                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SELECT * FROM Product", con);
                SqlDataReader rder;
                rder = cmd.ExecuteReader();
                while (rder.Read())
                {
                    cmd = new SqlCommand("Update Product Set Price = @Price Where Barcode = @Barcode", con);
                    price = Convert.ToDecimal(rder["Price"]) - ((Convert.ToDecimal(rder["Price"]) / 100) * 20);
                    cmd.Parameters.AddWithValue("@Price", price);
                    Barcode = cboxBarcode.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@Barcode", Barcode);

                };

            }
            else if (cboxCategories.SelectedIndex == 0 & cboxBarcode.SelectedIndex == 0)
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
