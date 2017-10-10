using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Drawing;

namespace PointOfSaleSystemUnitTests
{
    [TestClass]
    public class BarcodeTests
    {
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();
        [TestMethod]
        public void GeneratingTheBarcode()
        {
            PictureBox barcode = new PictureBox();
            
            int W = 120;
            int H = 75;

            b.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            type = BarcodeLib.TYPE.CODE128;

            barcode.BackgroundImage = b.Encode(type, "test", W, H);
            b.IncludeLabel = true;
            //reposition the barcode image to the middle
            barcode.Location = new Point((this.barcode.Location.X + this.barcode.Width / 2) - barcode.Width / 2, (this.barcode.Location.Y + this.barcode.Height / 2) - barcode.Height / 2);



        }
    }
}
