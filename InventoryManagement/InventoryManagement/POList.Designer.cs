namespace InventoryManagement
{
    partial class POList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srno,
            this.prodCode,
            this.hsncode,
            this.prodName,
            this.category,
            this.company,
            this.purchasePrice,
            this.salePrice,
            this.sgst,
            this.cgst,
            this.discount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(819, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // srno
            // 
            this.srno.HeaderText = "SRNO";
            this.srno.Name = "srno";
            this.srno.ReadOnly = true;
            // 
            // prodCode
            // 
            this.prodCode.HeaderText = "Product Code";
            this.prodCode.Name = "prodCode";
            this.prodCode.ReadOnly = true;
            // 
            // hsncode
            // 
            this.hsncode.HeaderText = "HSN";
            this.hsncode.Name = "hsncode";
            this.hsncode.ReadOnly = true;
            // 
            // prodName
            // 
            this.prodName.HeaderText = "Product Name";
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // purchasePrice
            // 
            this.purchasePrice.HeaderText = "Purchase Price";
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.ReadOnly = true;
            // 
            // salePrice
            // 
            this.salePrice.HeaderText = "Sale Price";
            this.salePrice.Name = "salePrice";
            this.salePrice.ReadOnly = true;
            // 
            // sgst
            // 
            this.sgst.HeaderText = "SGST";
            this.sgst.Name = "sgst";
            this.sgst.ReadOnly = true;
            // 
            // cgst
            // 
            this.cgst.HeaderText = "CGST";
            this.cgst.Name = "cgst";
            this.cgst.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // POList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 395);
            this.Controls.Add(this.dataGridView1);
            this.Name = "POList";
            this.Text = "POList";
            this.Load += new System.EventHandler(this.POList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
    }
}