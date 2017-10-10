namespace PointOfSaleSystem
{
    partial class frmCreateSale
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
            this.btnStartSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartSale
            // 
            this.btnStartSale.Location = new System.Drawing.Point(163, 214);
            this.btnStartSale.Name = "btnStartSale";
            this.btnStartSale.Size = new System.Drawing.Size(75, 23);
            this.btnStartSale.TabIndex = 0;
            this.btnStartSale.Text = "Start Sale";
            this.btnStartSale.UseVisualStyleBackColor = true;
            // 
            // frmCreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.btnStartSale);
            this.Name = "frmCreateSale";
            this.Text = "frmCreateSale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartSale;
    }
}