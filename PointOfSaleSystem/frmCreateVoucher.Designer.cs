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
            this.lblTypeOfVoucher = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnCreateVoucher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateBarcode
            // 
            this.btnCreateBarcode.Location = new System.Drawing.Point(237, 161);
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
            // lblTypeOfVoucher
            // 
            this.lblTypeOfVoucher.AutoSize = true;
            this.lblTypeOfVoucher.Location = new System.Drawing.Point(24, 142);
            this.lblTypeOfVoucher.Name = "lblTypeOfVoucher";
            this.lblTypeOfVoucher.Size = new System.Drawing.Size(63, 13);
            this.lblTypeOfVoucher.TabIndex = 10;
            this.lblTypeOfVoucher.Text = "Amount Off:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(93, 139);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(121, 20);
            this.txtItem.TabIndex = 11;
            // 
            // btnCreateVoucher
            // 
            this.btnCreateVoucher.Location = new System.Drawing.Point(93, 183);
            this.btnCreateVoucher.Name = "btnCreateVoucher";
            this.btnCreateVoucher.Size = new System.Drawing.Size(106, 39);
            this.btnCreateVoucher.TabIndex = 12;
            this.btnCreateVoucher.Text = "Create Voucher";
            this.btnCreateVoucher.UseVisualStyleBackColor = true;
            this.btnCreateVoucher.Click += new System.EventHandler(this.btnCreateVoucher_Click);
            // 
            // frmCreateVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 392);
            this.Controls.Add(this.btnCreateVoucher);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblTypeOfVoucher);
            this.Controls.Add(this.btnGenerateNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVoucherNumber);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.btnCreateBarcode);
            this.Name = "frmCreateVoucher";
            this.Text = "frmCreateVoucher";
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBarcode;
        private System.Windows.Forms.PictureBox barcode;
        private System.Windows.Forms.TextBox txtVoucherNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateNumber;
        private System.Windows.Forms.Label lblTypeOfVoucher;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnCreateVoucher;
    }
}