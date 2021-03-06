﻿using System;
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

            barcode.BackgroundImage = b.Encode(type, "45283", W, H);
            b.IncludeLabel = true;
            b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;
            //reposition the barcode image to the middle
            barcode.Location = new Point((barcode.Location.X + barcode.Width / 2) - barcode.Width / 2, (barcode.Location.Y + barcode.Height / 2) - barcode.Height / 2);
            SaveFileDialog sfd = new SaveFileDialog();
            b.SaveImage("B:\\Users\\Simon Dolby\\Documents\\tests.jpg", BarcodeLib.SaveTypes.JPG);

        }
    }
}
