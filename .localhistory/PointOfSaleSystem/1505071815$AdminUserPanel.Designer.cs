namespace PointOfSaleSystem
{
    partial class AdminUserPanel
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BtnAddNewProduct = new System.Windows.Forms.Button();
            this.btnAddNewStaff = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(236, 526);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // BtnAddNewProduct
            // 
            this.BtnAddNewProduct.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnAddNewProduct.Location = new System.Drawing.Point(0, 0);
            this.BtnAddNewProduct.Name = "BtnAddNewProduct";
            this.BtnAddNewProduct.Size = new System.Drawing.Size(236, 50);
            this.BtnAddNewProduct.TabIndex = 1;
            this.BtnAddNewProduct.Text = "Add New Product";
            this.BtnAddNewProduct.UseVisualStyleBackColor = false;
            this.BtnAddNewProduct.Click += new System.EventHandler(this.BtnAddNewProduct_Click);
            // 
            // btnAddNewStaff
            // 
            this.btnAddNewStaff.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStaff.Location = new System.Drawing.Point(0, 48);
            this.btnAddNewStaff.Name = "btnAddNewStaff";
            this.btnAddNewStaff.Size = new System.Drawing.Size(236, 50);
            this.btnAddNewStaff.TabIndex = 2;
            this.btnAddNewStaff.Text = "Add New Staff";
            this.btnAddNewStaff.UseVisualStyleBackColor = false;
            this.btnAddNewStaff.Click += new System.EventHandler(this.btnAddNewStaff_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.Location = new System.Drawing.Point(0, 97);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(236, 50);
            this.btnModifyProduct.TabIndex = 3;
            this.btnModifyProduct.Text = "Modify Product";
            this.btnModifyProduct.UseVisualStyleBackColor = false;
            // 
            // AdminUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 526);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnAddNewStaff);
            this.Controls.Add(this.BtnAddNewProduct);
            this.Controls.Add(this.splitter1);
            this.Name = "AdminUserPanel";
            this.Text = "AdminUserPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button BtnAddNewProduct;
        private System.Windows.Forms.Button btnAddNewStaff;
        private System.Windows.Forms.Button btnModifyProduct;
    }
}