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
    public partial class frmAddNewStaff : Form
    {
        public frmAddNewStaff()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee (Username,Passcode,Admin) VALUES (@Username, @Passcode, @admin)", con);
            cmd.Parameters.AddWithValue("@Barcode", Convert.ToInt32(txtBarcode.Text));
            cmd.Parameters.AddWithValue("@ItemName", Convert.ToString(txtName.Text));
            cmd.Parameters.AddWithValue("@Price", price);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
