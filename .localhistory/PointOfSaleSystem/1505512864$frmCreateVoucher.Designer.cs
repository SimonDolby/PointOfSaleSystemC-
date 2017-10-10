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
            this.SuspendLayout();
            // 
            // btnCreateBarcode
            // 
            this.btnCreateBarcode.Location = new System.Drawing.Point(195, 89);
            this.btnCreateBarcode.Name = "btnCreateBarcode";
            this.btnCreateBarcode.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBarcode.TabIndex = 0;
            this.btnCreateBarcode.Text = "Barcode";
            this.btnCreateBarcode.UseVisualStyleBackColor = true;
            // 
            // frmCreateVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 392);
            this.Controls.Add(this.btnCreateBarcode);
            this.Name = "frmCreateVoucher";
            this.Text = "frmCreateVoucher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBarcode;
    }
}