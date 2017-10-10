namespace PointOfSaleSystem
{
    partial class StaffUserPanel
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnNewTransaction = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnLookupItem = new System.Windows.Forms.Button();
            this.BtnCard = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblSubLable = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstOrder = new System.Windows.Forms.ListView();
            this.cboxStaffDiscount = new System.Windows.Forms.CheckBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtVATAdded = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNewTransaction
            // 
            this.BtnNewTransaction.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewTransaction.Location = new System.Drawing.Point(0, 0);
            this.BtnNewTransaction.Name = "BtnNewTransaction";
            this.BtnNewTransaction.Size = new System.Drawing.Size(226, 42);
            this.BtnNewTransaction.TabIndex = 1;
            this.BtnNewTransaction.Text = "New Transaction";
            this.BtnNewTransaction.UseVisualStyleBackColor = false;
            this.BtnNewTransaction.Click += new System.EventHandler(this.BtnNewTransaction_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(0, 41);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(226, 45);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "Cash Payments";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnLookupItem
            // 
            this.btnLookupItem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLookupItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookupItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookupItem.Location = new System.Drawing.Point(0, 132);
            this.btnLookupItem.Name = "btnLookupItem";
            this.btnLookupItem.Size = new System.Drawing.Size(226, 48);
            this.btnLookupItem.TabIndex = 3;
            this.btnLookupItem.Text = "Lookup Item";
            this.btnLookupItem.UseVisualStyleBackColor = false;
            this.btnLookupItem.Click += new System.EventHandler(this.btnLookupItem_Click);
            // 
            // BtnCard
            // 
            this.BtnCard.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCard.Location = new System.Drawing.Point(0, 85);
            this.BtnCard.Name = "BtnCard";
            this.BtnCard.Size = new System.Drawing.Size(226, 48);
            this.BtnCard.TabIndex = 4;
            this.BtnCard.Text = "Card Payments";
            this.BtnCard.UseVisualStyleBackColor = false;
            this.BtnCard.Click += new System.EventHandler(this.BtnCard_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(226, 602);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // lblSubLable
            // 
            this.lblSubLable.AutoSize = true;
            this.lblSubLable.Location = new System.Drawing.Point(447, 15);
            this.lblSubLable.Name = "lblSubLable";
            this.lblSubLable.Size = new System.Drawing.Size(56, 13);
            this.lblSubLable.TabIndex = 10;
            this.lblSubLable.Text = "Sub Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(538, 12);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(57, 20);
            this.txtSubTotal.TabIndex = 11;
            this.txtSubTotal.Text = "£0.00";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(538, 91);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(57, 20);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "£0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(447, 94);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total(Inc VAT):";
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // lstOrder
            // 
            this.lstOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Price,
            this.Quantity});
            this.lstOrder.Location = new System.Drawing.Point(244, 12);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(197, 590);
            this.lstOrder.TabIndex = 9;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            // 
            // cboxStaffDiscount
            // 
            this.cboxStaffDiscount.AutoSize = true;
            this.cboxStaffDiscount.Location = new System.Drawing.Point(450, 41);
            this.cboxStaffDiscount.Name = "cboxStaffDiscount";
            this.cboxStaffDiscount.Size = new System.Drawing.Size(93, 17);
            this.cboxStaffDiscount.TabIndex = 14;
            this.cboxStaffDiscount.Text = "Staff Discount";
            this.cboxStaffDiscount.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(0, 179);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(226, 47);
            this.btnRemoveItem.TabIndex = 15;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtVATAdded
            // 
            this.txtVATAdded.Location = new System.Drawing.Point(538, 57);
            this.txtVATAdded.Name = "txtVATAdded";
            this.txtVATAdded.Size = new System.Drawing.Size(57, 20);
            this.txtVATAdded.TabIndex = 17;
            this.txtVATAdded.Text = "£0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "VAT(Total)";
            // 
            // StaffUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 602);
            this.Controls.Add(this.txtVATAdded);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.cboxStaffDiscount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblSubLable);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.BtnCard);
            this.Controls.Add(this.btnLookupItem);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.BtnNewTransaction);
            this.Controls.Add(this.splitter1);
            this.Name = "StaffUserPanel";
            this.Text = "StaffUserPanel";
            this.Load += new System.EventHandler(this.StaffUserPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnNewTransaction;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnLookupItem;
        private System.Windows.Forms.Button BtnCard;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblSubLable;
        public System.Windows.Forms.TextBox txtSubTotal;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        public System.Windows.Forms.ListView lstOrder;
        public System.Windows.Forms.CheckBox cboxStaffDiscount;
        private System.Windows.Forms.Button btnRemoveItem;
        public System.Windows.Forms.TextBox txtVATAdded;
        private System.Windows.Forms.Label label1;
    }
}