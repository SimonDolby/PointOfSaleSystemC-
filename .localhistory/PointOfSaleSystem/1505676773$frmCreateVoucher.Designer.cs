namespace PointOfSaleSystem
{
    partial class frmCreateVoucher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateBarcode = new System.Windows.Forms.Button();
            this.barcode = new System.Windows.Forms.PictureBox();
            this.txtVoucherNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateNumber = new System.Windows.Forms.Button();
            this.cboxTypeofDiscount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.pnlItemPrice = new System.Windows.Forms.Panel();
            this.cboxProducts = new System.Windows.Forms.ComboBox();
            this.lblTypeOfVoucher = new System.Windows.Forms.Label();
            this.txtMoneyOff = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
            this.pnlItemPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateBarcode
            // 
            this.btnCreateBarcode.Location = new System.Drawing.Point(237, 203);
            this.btnCreateBarcode.Name = "btnCreateBarcode";
            this.btnCreateBarcode.Size = new System.Drawing.Size(106, 38);
            this.btnCreateBarcode.TabIndex = 0;
            this.btnCreateBarcode.Text = "Create Barcode";
            this.btnCreateBarcode.UseVisualStyleBackColor = true;
            this.btnCreateBarcode.Click += new System.EventHandler(this.btnCreateBarcode_Click);
            // 
            // barcode
            // 
            this.barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.barcode.Location = new System.Drawing.Point(237, 25);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(216, 130);
            this.barcode.TabIndex = 1;
            this.barcode.TabStop = false;
            // 
            // txtVoucherNumber
            // 
            this.txtVoucherNumber.Location = new System.Drawing.Point(93, 63);
            this.txtVoucherNumber.Name = "txtVoucherNumber";
            this.txtVoucherNumber.Size = new System.Drawing.Size(121, 20);
            this.txtVoucherNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voucher Number:";
            // 
            // btnGenerateNumber
            // 
            this.btnGenerateNumber.Location = new System.Drawing.Point(93, 89);
            this.btnGenerateNumber.Name = "btnGenerateNumber";
            this.btnGenerateNumber.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateNumber.TabIndex = 4;
            this.btnGenerateNumber.Text = "Generate Number";
            this.btnGenerateNumber.UseVisualStyleBackColor = true;
            this.btnGenerateNumber.Click += new System.EventHandler(this.btnGenerateNumber_Click);
            // 
            // cboxTypeofDiscount
            // 
            this.cboxTypeofDiscount.FormattingEnabled = true;
            this.cboxTypeofDiscount.Items.AddRange(new object[] {
            "",
            "Money off next shop",
            "Buy one get one free"});
            this.cboxTypeofDiscount.Location = new System.Drawing.Point(93, 130);
            this.cboxTypeofDiscount.Name = "cboxTypeofDiscount";
            this.cboxTypeofDiscount.Size = new System.Drawing.Size(121, 21);
            this.cboxTypeofDiscount.TabIndex = 5;
            this.cboxTypeofDiscount.SelectedIndexChanged += new System.EventHandler(this.cboxTypeofDiscount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type of Voucher:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscount.Location = new System.Drawing.Point(0, 0);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(138, 23);
            this.txtDiscount.TabIndex = 7;
            // 
            // pnlItemPrice
            // 
            this.pnlItemPrice.Controls.Add(this.txtDiscount);
            this.pnlItemPrice.Controls.Add(this.cboxProducts);
            this.pnlItemPrice.Controls.Add(this.txtMoneyOff);
            this.pnlItemPrice.Location = new System.Drawing.Point(93, 168);
            this.pnlItemPrice.Name = "pnlItemPrice";
            this.pnlItemPrice.Size = new System.Drawing.Size(138, 23);
            this.pnlItemPrice.TabIndex = 8;
            // 
            // cboxProducts
            // 
            this.cboxProducts.FormattingEnabled = true;
            this.cboxProducts.Location = new System.Drawing.Point(-3, 0);
            this.cboxProducts.Name = "cboxProducts";
            this.cboxProducts.Size = new System.Drawing.Size(138, 21);
            this.cboxProducts.TabIndex = 9;
            // 
            // lblTypeOfVoucher
            // 
            this.lblTypeOfVoucher.AutoSize = true;
            this.lblTypeOfVoucher.Location = new System.Drawing.Point(12, 171);
            this.lblTypeOfVoucher.Name = "lblTypeOfVoucher";
            this.lblTypeOfVoucher.Size = new System.Drawing.Size(0, 13);
            this.lblTypeOfVoucher.TabIndex = 10;
            // 
            // txtMoneyOff
            // 
            this.txtMoneyOff.Location = new System.Drawing.Point(0, 1);
            this.txtMoneyOff.Name = "txtMoneyOff";
            this.txtMoneyOff.Size = new System.Drawing.Size(138, 20);
            this.txtMoneyOff.TabIndex = 11;
            // 
            // frmCreateVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 392);
            this.Controls.Add(this.lblTypeOfVoucher);
            this.Controls.Add(this.pnlItemPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxTypeofDiscount);
            this.Controls.Add(this.btnGenerateNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVoucherNumber);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.btnCreateBarcode);
            this.Name = "frmCreateVoucher";
            this.Text = "frmCreateVoucher";
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).EndInit();
            this.pnlItemPrice.ResumeLayout(false);
            this.pnlItemPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBarcode;
        private System.Windows.Forms.PictureBox barcode;
        private System.Windows.Forms.TextBox txtVoucherNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateNumber;
        private System.Windows.Forms.ComboBox cboxTypeofDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Panel pnlItemPrice;
        private System.Windows.Forms.ComboBox cboxProducts;
        private System.Windows.Forms.Label lblTypeOfVoucher;
        private System.Windows.Forms.TextBox txtMoneyOff;
    }
}