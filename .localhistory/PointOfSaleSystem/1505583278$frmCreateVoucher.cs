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
    public partial class frmCreateVoucher : Form
    {
        public frmCreateVoucher()
        {
            InitializeComponent();
        }
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();

        private void btnCreateBarcode_Click(object sender, EventArgs e)
        {
            if (txtVoucherNumber.Text == "")
            {
                int W = 120;
                int H = 75;

                b.Alignment = BarcodeLib.AlignmentPositions.CENTER;

                BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
                type = BarcodeLib.TYPE.CODE128;

                barcode.BackgroundImage = b.Encode(type, txtVoucherNumber.Text, W, H);
                b.IncludeLabel = true;
                b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;

                //reposition the barcode image to the middle
                barcode.BackgroundImage = b.Encode(type, txtVoucherNumber.Text, W, H);
                ba}
            //catch
        }//btnEncode_Click

        private void btnGenerateNumber_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Random random = new Random();
            int voucherNumber = random.Next(1000, 1000000);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.PointOfSaleConString;
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT VoucherNumber from Voucher Where VoucherNumber = @Voucher", con);
            cmd.SelectCommand.Parameters.AddWithValue("@Voucher", voucherNumber);
            
            cmd.Fill(dt);
         
            while (dt.Rows.Count > 0)
            {
                cmd = new SqlDataAdapter("SELECT VoucherNumber from Voucher Where VoucherNumber = @Voucher", con);
                cmd.SelectCommand.Parameters.AddWithValue("@Voucher", voucherNumber);
                voucherNumber = random.Next(1000, 1000000);

            }

            txtVoucherNumber.Text = voucherNumber.ToString();


        }
    }
}
