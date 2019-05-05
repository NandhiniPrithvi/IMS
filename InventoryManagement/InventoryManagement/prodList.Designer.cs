namespace InventoryManagement
{
    partial class prodList
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
            this.gvProdList = new System.Windows.Forms.DataGridView();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtprodname = new System.Windows.Forms.TextBox();
            this.lblprodname = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvProdList
            // 
            this.gvProdList.AllowUserToAddRows = false;
            this.gvProdList.AllowUserToDeleteRows = false;
            this.gvProdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCode,
            this.productName,
            this.hsnCode,
            this.category,
            this.company,
            this.purchasePrice,
            this.salesPrice,
            this.quantity,
            this.sgst,
            this.cgst,
            this.discount});
            this.gvProdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvProdList.GridColor = System.Drawing.Color.White;
            this.gvProdList.Location = new System.Drawing.Point(0, 100);
            this.gvProdList.Name = "gvProdList";
            this.gvProdList.ReadOnly = true;
            this.gvProdList.Size = new System.Drawing.Size(1064, 366);
            this.gvProdList.TabIndex = 0;
            this.gvProdList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvProdList_RowHeaderMouseDoubleClick);
            // 
            // productCode
            // 
            this.productCode.HeaderText = "Product Code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // hsnCode
            // 
            this.hsnCode.HeaderText = "HSN";
            this.hsnCode.Name = "hsnCode";
            this.hsnCode.ReadOnly = true;
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
            // salesPrice
            // 
            this.salesPrice.HeaderText = "Sales Price";
            this.salesPrice.Name = "salesPrice";
            this.salesPrice.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.lblprodname);
            this.panel1.Controls.Add(this.txtprodname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 366);
            this.panel2.TabIndex = 2;
            // 
            // txtprodname
            // 
            this.txtprodname.Location = new System.Drawing.Point(12, 39);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.Size = new System.Drawing.Size(200, 20);
            this.txtprodname.TabIndex = 0;
            this.txtprodname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtprodname_KeyUp);
            // 
            // lblprodname
            // 
            this.lblprodname.AutoSize = true;
            this.lblprodname.Location = new System.Drawing.Point(12, 23);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(75, 13);
            this.lblprodname.TabIndex = 1;
            this.lblprodname.Text = "Product Name";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(232, 39);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // prodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 466);
            this.Controls.Add(this.gvProdList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "prodList";
            this.Text = "prodList";
            this.Load += new System.EventHandler(this.prodList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProdList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvProdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblprodname;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.Button btnsearch;
    }
}