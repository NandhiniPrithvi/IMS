namespace InventoryManagement
{
    partial class Item
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlhead = new System.Windows.Forms.Panel();
            this.lblItemMaster = new System.Windows.Forms.Label();
            this.pnlcenter = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvItems = new System.Windows.Forms.DataGridView();
            this.srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.tblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagementDataSet1 = new InventoryManagement.InventoryManagementDataSet1();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagementDataSet = new InventoryManagement.InventoryManagementDataSet();
            this.lblCategory = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new InventoryManagement.InventoryManagementDataSetTableAdapters.CategoryTableAdapter();
            this.tblCompanyTableAdapter = new InventoryManagement.InventoryManagementDataSet1TableAdapters.tblCompanyTableAdapter();
            this.panel2.SuspendLayout();
            this.pnlhead.SuspendLayout();
            this.pnlcenter.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            this.pnlcontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlcenter);
            this.panel2.Controls.Add(this.pnlhead);
            this.panel2.Controls.SetChildIndex(this.pnlhead, 0);
            this.panel2.Controls.SetChildIndex(this.pnlcenter, 0);
            // 
            // pnlhead
            // 
            this.pnlhead.BackColor = System.Drawing.Color.Teal;
            this.pnlhead.Controls.Add(this.lblItemMaster);
            this.pnlhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhead.Location = new System.Drawing.Point(0, 24);
            this.pnlhead.Name = "pnlhead";
            this.pnlhead.Size = new System.Drawing.Size(1055, 30);
            this.pnlhead.TabIndex = 1;
            // 
            // lblItemMaster
            // 
            this.lblItemMaster.AutoSize = true;
            this.lblItemMaster.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblItemMaster.ForeColor = System.Drawing.Color.White;
            this.lblItemMaster.Location = new System.Drawing.Point(3, 5);
            this.lblItemMaster.Name = "lblItemMaster";
            this.lblItemMaster.Size = new System.Drawing.Size(102, 22);
            this.lblItemMaster.TabIndex = 0;
            this.lblItemMaster.Text = "Item Master";
            // 
            // pnlcenter
            // 
            this.pnlcenter.Controls.Add(this.panel3);
            this.pnlcenter.Controls.Add(this.pnlcontent);
            this.pnlcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcenter.Location = new System.Drawing.Point(0, 54);
            this.pnlcenter.Name = "pnlcenter";
            this.pnlcenter.Size = new System.Drawing.Size(1055, 338);
            this.pnlcenter.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gvItems);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1055, 158);
            this.panel3.TabIndex = 1;
            // 
            // gvItems
            // 
            this.gvItems.AllowUserToAddRows = false;
            this.gvItems.AllowUserToDeleteRows = false;
            this.gvItems.AllowUserToResizeColumns = false;
            this.gvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srno,
            this.category,
            this.name,
            this.code,
            this.company,
            this.price,
            this.description});
            this.gvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvItems.Location = new System.Drawing.Point(0, 0);
            this.gvItems.Name = "gvItems";
            this.gvItems.ReadOnly = true;
            this.gvItems.RowHeadersVisible = false;
            this.gvItems.Size = new System.Drawing.Size(1055, 158);
            this.gvItems.TabIndex = 0;
            // 
            // srno
            // 
            this.srno.HeaderText = "SR NO";
            this.srno.Name = "srno";
            this.srno.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Item Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // pnlcontent
            // 
            this.pnlcontent.Controls.Add(this.btnadd);
            this.pnlcontent.Controls.Add(this.txtRemarks);
            this.pnlcontent.Controls.Add(this.lblRemarks);
            this.pnlcontent.Controls.Add(this.txtPrice);
            this.pnlcontent.Controls.Add(this.lblPrice);
            this.pnlcontent.Controls.Add(this.txtItemName);
            this.pnlcontent.Controls.Add(this.lblItemName);
            this.pnlcontent.Controls.Add(this.txtItemCode);
            this.pnlcontent.Controls.Add(this.lblItemCode);
            this.pnlcontent.Controls.Add(this.cbCompany);
            this.pnlcontent.Controls.Add(this.lblCompany);
            this.pnlcontent.Controls.Add(this.cbCategory);
            this.pnlcontent.Controls.Add(this.lblCategory);
            this.pnlcontent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcontent.Location = new System.Drawing.Point(0, 0);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(1055, 180);
            this.pnlcontent.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(128, 128);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 30);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add Item";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtRemarks.Location = new System.Drawing.Point(786, 64);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(300, 50);
            this.txtRemarks.TabIndex = 12;
            this.txtRemarks.Text = "Remarks";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRemarks.Location = new System.Drawing.Point(693, 66);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(100, 18);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "Remarks* :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtPrice.Location = new System.Drawing.Point(463, 66);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 25);
            this.txtPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(347, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 18);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Item Price* :";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtItemName.Location = new System.Drawing.Point(128, 66);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 25);
            this.txtItemName.TabIndex = 8;
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblItemName.Location = new System.Drawing.Point(22, 68);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(100, 18);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "Item Item* :";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtItemCode.Location = new System.Drawing.Point(723, 13);
            this.txtItemCode.Multiline = true;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(200, 25);
            this.txtItemCode.TabIndex = 6;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblItemCode.Location = new System.Drawing.Point(608, 16);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(100, 18);
            this.lblItemCode.TabIndex = 5;
            this.lblItemCode.Text = "Item Code* :";
            // 
            // cbCompany
            // 
            this.cbCompany.BackColor = System.Drawing.Color.White;
            this.cbCompany.DataSource = this.tblCompanyBindingSource;
            this.cbCompany.DisplayMember = "CompanyName";
            this.cbCompany.DropDownHeight = 110;
            this.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompany.DropDownWidth = 100;
            this.cbCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCompany.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.cbCompany.IntegralHeight = false;
            this.cbCompany.Location = new System.Drawing.Point(418, 13);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(160, 25);
            this.cbCompany.TabIndex = 4;
            this.cbCompany.ValueMember = "CompanyId";
            // 
            // tblCompanyBindingSource
            // 
            this.tblCompanyBindingSource.DataMember = "tblCompany";
            this.tblCompanyBindingSource.DataSource = this.inventoryManagementDataSet1;
            // 
            // inventoryManagementDataSet1
            // 
            this.inventoryManagementDataSet1.DataSetName = "InventoryManagementDataSet1";
            this.inventoryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompany.Location = new System.Drawing.Point(312, 16);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(100, 18);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company* :";
            // 
            // cbCategory
            // 
            this.cbCategory.DataSource = this.categoryBindingSource;
            this.cbCategory.DisplayMember = "name";
            this.cbCategory.DropDownHeight = 110;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.DropDownWidth = 100;
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCategory.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.IntegralHeight = false;
            this.cbCategory.Location = new System.Drawing.Point(128, 13);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 25);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.ValueMember = "categoryId";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.inventoryManagementDataSet;
            // 
            // inventoryManagementDataSet
            // 
            this.inventoryManagementDataSet.DataSetName = "InventoryManagementDataSet";
            this.inventoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategory.Location = new System.Drawing.Point(22, 16);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 18);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category* :";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tblCompanyTableAdapter
            // 
            this.tblCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 441);
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlhead.ResumeLayout(false);
            this.pnlhead.PerformLayout();
            this.pnlcenter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            this.pnlcontent.ResumeLayout(false);
            this.pnlcontent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlhead;
        private System.Windows.Forms.Label lblItemMaster;
        private System.Windows.Forms.Panel pnlcenter;
        private System.Windows.Forms.Panel pnlcontent;
        private System.Windows.Forms.Label lblCategory;
        private InventoryManagementDataSet inventoryManagementDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private InventoryManagementDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cbCompany;
        private InventoryManagementDataSet1 inventoryManagementDataSet1;
        private System.Windows.Forms.BindingSource tblCompanyBindingSource;
        private InventoryManagementDataSet1TableAdapters.tblCompanyTableAdapter tblCompanyTableAdapter;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}