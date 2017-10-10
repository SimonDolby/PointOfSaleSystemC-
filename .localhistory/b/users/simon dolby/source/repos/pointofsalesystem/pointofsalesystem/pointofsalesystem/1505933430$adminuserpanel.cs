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
    public partial class AdminUserPanel : Form
    {
        public AdminUserPanel()
        {
            InitializeComponent();
        }

        private void BtnAddNewProduct_Click(object sender, EventArgs e)
        {
            FrmAddNewProduct AddNewProduct = new FrmAddNewProduct();
            AddNewProduct.Show();
        }

        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            frmAddNewStaff AddNewStaff = new frmAddNewStaff();
                AddNewStaff.Show();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            frmModifyProduct ModItem = new frmModifyProduct();
            ModItem.Show();
        }

        private void btnStartSale_Click(object sender, EventArgs e)
        {
            frmCreateSale CreateSale = new frmCreateSale();
            CreateSale.Show();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            frmCreateVoucher CreateVoucher = new frmCreateVoucher();
            CreateVoucher.Show();
        }
    }
}
