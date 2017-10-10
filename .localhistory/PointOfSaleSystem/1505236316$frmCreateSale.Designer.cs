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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCategories = new System.Windows.Forms.ComboBox();
            this.cboxBarcode = new System.Windows.Forms.ComboBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartSale
            // 
            this.btnStartSale.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnStartSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSale.Location = new System.Drawing.Point(191, 165);
            this.btnStartSale.Name = "btnStartSale";
            this.btnStartSale.Size = new System.Drawing.Size(138, 46);
            this.btnStartSale.TabIndex = 0;
            this.btnStartSale.Text = "Start Sale";
            this.btnStartSale.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount %:";
            // 
            // cboxCategories
            // 
            this.cboxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategories.FormattingEnabled = true;
            this.cboxCategories.Location = new System.Drawing.Point(191, 31);
            this.cboxCategories.Name = "cboxCategories";
            this.cboxCategories.Size = new System.Drawing.Size(138, 39);
            this.cboxCategories.TabIndex = 4;
            // 
            // cboxBarcode
            // 
            this.cboxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBarcode.FormattingEnabled = true;
            this.cboxBarcode.Location = new System.Drawing.Point(191, 76);
            this.cboxBarcode.Name = "cboxBarcode";
            this.cboxBarcode.Size = new System.Drawing.Size(138, 39);
            this.cboxBarcode.TabIndex = 5;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentage.Location = new System.Drawing.Point(191, 121);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.ShortcutsEnabled = false;
            this.txtPercentage.Size = new System.Drawing.Size(138, 38);
            this.txtPercentage.TabIndex = 6;
            // 
            // frmCreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(381, 272);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.cboxBarcode);
            this.Controls.Add(this.cboxCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartSale);
            this.Name = "frmCreateSale";
            this.Text = "frmCreateSale";
            this.Load += new System.EventHandler(this.frmCreateSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxCategories;
        private System.Windows.Forms.ComboBox cboxBarcode;
        private System.Windows.Forms.TextBox txtPercentage;
    }
}