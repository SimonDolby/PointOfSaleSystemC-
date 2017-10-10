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
    public partial class frmCreateVoucher : Form
    {
        public frmCreateVoucher()
        {
            InitializeComponent();
        }
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();

        private void btnCreateBarcode_Click(object sender, EventArgs e)
        {
            
            int W = 120;
            int H =75;
                
              b.Alignment = BarcodeLib.AlignmentPositions.CENTER; 
          
            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            type = BarcodeLib.TYPE.CODE128;

            barcode.BackgroundImage = b.Encode(type,  "test",  W, H);

            //reposition the barcode image to the middle
            barcode.Location = new Point((this.barcode.Location.X + this.barcode.Width / 2) - barcode.Width / 2, (this.barcode.Location.Y + this.barcode.Height / 2) - barcode.Height / 2);
     
                
            //catch
        }//btnEncode_Click
    }
    }
}
