﻿using System;
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

        private void btnCreateBarcode_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int W = Convert.ToInt32(this.txtWidth.Text.Trim());
            int H = Convert.ToInt32(this.txtHeight.Text.Trim());
            b.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            //barcode alignment
            switch (cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower())
            {
                case "left": b.Alignment = BarcodeLib.AlignmentPositions.LEFT; break;
                case "right": b.Alignment = BarcodeLib.AlignmentPositions.RIGHT; break;
                default: b.Alignment = BarcodeLib.AlignmentPositions.CENTER; break;
            }//switch

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            switch (cbEncodeType.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = BarcodeLib.TYPE.UPCA; break;
                case "UPC-E": type = BarcodeLib.TYPE.UPCE; break;
                case "UPC 2 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                case "UPC 5 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                case "EAN-13": type = BarcodeLib.TYPE.EAN13; break;
                case "JAN-13": type = BarcodeLib.TYPE.JAN13; break;
                case "EAN-8": type = BarcodeLib.TYPE.EAN8; break;
                case "ITF-14": type = BarcodeLib.TYPE.ITF14; break;
                case "Codabar": type = BarcodeLib.TYPE.Codabar; break;
                case "PostNet": type = BarcodeLib.TYPE.PostNet; break;
                case "Bookland/ISBN": type = BarcodeLib.TYPE.BOOKLAND; break;
                case "Code 11": type = BarcodeLib.TYPE.CODE11; break;
                case "Code 39": type = BarcodeLib.TYPE.CODE39; break;
                case "Code 39 Extended": type = BarcodeLib.TYPE.CODE39Extended; break;
                case "Code 39 Mod 43": type = BarcodeLib.TYPE.CODE39_Mod43; break;
                case "Code 93": type = BarcodeLib.TYPE.CODE93; break;
                case "LOGMARS": type = BarcodeLib.TYPE.LOGMARS; break;
                case "MSI": type = BarcodeLib.TYPE.MSI_Mod10; break;
                case "Interleaved 2 of 5": type = BarcodeLib.TYPE.Interleaved2of5; break;
                case "Standard 2 of 5": type = BarcodeLib.TYPE.Standard2of5; break;
                case "Code 128": type = BarcodeLib.TYPE.CODE128; break;
                case "Code 128-A": type = BarcodeLib.TYPE.CODE128A; break;
                case "Code 128-B": type = BarcodeLib.TYPE.CODE128B; break;
                case "Code 128-C": type = BarcodeLib.TYPE.CODE128C; break;
                case "Telepen": type = BarcodeLib.TYPE.TELEPEN; break;
                case "FIM": type = BarcodeLib.TYPE.FIM; break;
                case "Pharmacode": type = BarcodeLib.TYPE.PHARMACODE; break;
                default: MessageBox.Show("Please specify the encoding type."); break;
            }//switch

            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    try
                    {
                        b.BarWidth = textBoxBarWidth.Text.Trim().Length < 1 ? null : (int?)Convert.ToInt32(textBoxBarWidth.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to parse BarWidth: " + ex.Message, ex);
                    }
                    try
                    {
                        b.AspectRatio = textBoxAspectRatio.Text.Trim().Length < 1 ? null : (double?)Convert.ToDouble(textBoxAspectRatio.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to parse AspectRatio: " + ex.Message, ex);
                    }

                    b.IncludeLabel = this.chkGenerateLabel.Checked;

                    b.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.cbRotateFlip.SelectedItem.ToString(), true);

                    //label alignment and position
                    switch (this.cbLabelLocation.SelectedItem.ToString().Trim().ToUpper())
                    {
                        case "BOTTOMLEFT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT; break;
                        case "BOTTOMRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMRIGHT; break;
                        case "TOPCENTER": b.LabelPosition = BarcodeLib.LabelPositions.TOPCENTER; break;
                        case "TOPLEFT": b.LabelPosition = BarcodeLib.LabelPositions.TOPLEFT; break;
                        case "TOPRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.TOPRIGHT; break;
                        default: b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER; break;
                    }//switch

                    //===== Encoding performed here =====
                    barcode.BackgroundImage = b.Encode(type, this.txtData.Text.Trim(), this.btnForeColor.BackColor, this.btnBackColor.BackColor, W, H);
                    //===================================

                    //show the encoding time
                    this.lblEncodingTime.Text = "(" + Math.Round(b.EncodingTime, 0, MidpointRounding.AwayFromZero).ToString() + "ms)";

                    txtEncoded.Text = b.EncodedValue;

                    tsslEncodedType.Text = "Encoding Type: " + b.EncodedType.ToString();

                    // Read dynamically calculated Width/Height because the user is interested.
                    if (b.BarWidth.HasValue)
                        txtWidth.Text = b.Width.ToString();
                    if (b.AspectRatio.HasValue)
                        txtHeight.Text = b.Height.ToString();
                }//if

                //reposition the barcode image to the middle
                barcode.Location = new Point((this.barcode.Location.X + this.barcode.Width / 2) - barcode.Width / 2, (this.barcode.Location.Y + this.barcode.Height / 2) - barcode.Height / 2);
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//catch
        }//btnEncode_Click
    }
    }
}
