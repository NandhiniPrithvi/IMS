namespace InventoryManagement
{
    partial class SupplierList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsuppliername = new System.Windows.Forms.Label();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.gvsupplierlist = new System.Windows.Forms.DataGridView();
            this.vendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvsupplierlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.txtsuppliername);
            this.panel1.Controls.Add(this.lblsuppliername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvsupplierlist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 353);
            this.panel2.TabIndex = 1;
            // 
            // lblsuppliername
            // 
            this.lblsuppliername.AutoSize = true;
            this.lblsuppliername.Location = new System.Drawing.Point(12, 21);
            this.lblsuppliername.Name = "lblsuppliername";
            this.lblsuppliername.Size = new System.Drawing.Size(76, 13);
            this.lblsuppliername.TabIndex = 2;
            this.lblsuppliername.Text = "Supplier Name";
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Location = new System.Drawing.Point(15, 37);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(200, 20);
            this.txtsuppliername.TabIndex = 3;
            this.txtsuppliername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsuppliername_KeyUp);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(250, 37);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // gvsupplierlist
            // 
            this.gvsupplierlist.AllowUserToAddRows = false;
            this.gvsupplierlist.AllowUserToDeleteRows = false;
            this.gvsupplierlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvsupplierlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsupplierlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorID,
            this.organisationName,
            this.vendorCode,
            this.vendorName,
            this.address,
            this.city,
            this.state,
            this.postalcode,
            this.contactno,
            this.mail});
            this.gvsupplierlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvsupplierlist.Location = new System.Drawing.Point(0, 0);
            this.gvsupplierlist.Name = "gvsupplierlist";
            this.gvsupplierlist.ReadOnly = true;
            this.gvsupplierlist.Size = new System.Drawing.Size(1061, 353);
            this.gvsupplierlist.TabIndex = 0;
            this.gvsupplierlist.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvsupplierlist_RowHeaderMouseDoubleClick);
            // 
            // vendorID
            // 
            this.vendorID.HeaderText = "Vendor ID";
            this.vendorID.Name = "vendorID";
            this.vendorID.ReadOnly = true;
            // 
            // organisationName
            // 
            this.organisationName.HeaderText = "Organisation Name";
            this.organisationName.Name = "organisationName";
            this.organisationName.ReadOnly = true;
            // 
            // vendorCode
            // 
            this.vendorCode.HeaderText = "Vendor Code";
            this.vendorCode.Name = "vendorCode";
            this.vendorCode.ReadOnly = true;
            // 
            // vendorName
            // 
            this.vendorName.HeaderText = "Vendor Name";
            this.vendorName.Name = "vendorName";
            this.vendorName.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // postalcode
            // 
            this.postalcode.HeaderText = "Postal Code";
            this.postalcode.Name = "postalcode";
            this.postalcode.ReadOnly = true;
            // 
            // contactno
            // 
            this.contactno.HeaderText = "Contact No";
            this.contactno.Name = "contactno";
            this.contactno.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "Email ID";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // SupplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SupplierList";
            this.Text = "SupplierList";
            this.Load += new System.EventHandler(this.SupplierList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvsupplierlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblsuppliername;
        private System.Windows.Forms.TextBox txtsuppliername;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView gvsupplierlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
    }
}