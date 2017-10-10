namespace PointOfSaleSystem
{
    partial class frmLookupItem
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
            this.btnFindCode = new System.Windows.Forms.Button();
            this.txtBarcodeLookUp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFindCode
            // 
            this.btnFindCode.Location = new System.Drawing.Point(258, 30);
            this.btnFindCode.Name = "btnFindCode";
            this.btnFindCode.Size = new System.Drawing.Size(108, 23);
            this.btnFindCode.TabIndex = 0;
            this.btnFindCode.Text = "Lookup Barcode";
            this.btnFindCode.UseVisualStyleBackColor = true;
            this.btnFindCode.Click += new System.EventHandler(this.btnFindCode_Click);
            // 
            // txtBarcodeLookUp
            // 
            this.txtBarcodeLookUp.Location = new System.Drawing.Point(26, 32);
            this.txtBarcodeLookUp.Name = "txtBarcodeLookUp";
            this.txtBarcodeLookUp.Size = new System.Drawing.Size(226, 20);
            this.txtBarcodeLookUp.TabIndex = 1;
            this.txtBarcodeLookUp.Click += new System.EventHandler(this.txtboxBarcodeLookUp_Click);
            // 
            // frmLookupItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(388, 78);
            this.Controls.Add(this.txtBarcodeLookUp);
            this.Controls.Add(this.btnFindCode);
            this.Name = "frmLookupItem";
            this.Text = "frmLookupItem";
            this.Load += new System.EventHandler(this.frmLookupItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindCode;
        public System.Windows.Forms.TextBox txtBarcodeLookUp;
    }
}