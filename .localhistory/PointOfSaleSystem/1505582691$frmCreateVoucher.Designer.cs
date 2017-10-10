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
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
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
            this.txtVoucherNumber.Size = new System.Drawing.Size(100, 20);
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
            this.btnGenerateNumber.Location = new System.Drawing.Point(0, 97);
            this.btnGenerateNumber.Name = "btnGenerateNumber";
            this.btnGenerateNumber.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateNumber.TabIndex = 4;
            this.btnGenerateNumber.Text = "Generate Number";
            this.btnGenerateNumber.UseVisualStyleBackColor = true;
            // 
            // frmCreateVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 392);
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
    }
}