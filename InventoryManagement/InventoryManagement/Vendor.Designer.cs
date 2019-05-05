namespace InventoryManagement
{
    partial class Vendor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlhead = new System.Windows.Forms.Panel();
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.pnlgrid = new System.Windows.Forms.Panel();
            this.gvvendor = new System.Windows.Forms.DataGridView();
            this.vendorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pincode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlheadcontent = new System.Windows.Forms.Panel();
            this.txtvendorcode = new System.Windows.Forms.TextBox();
            this.lblvendorcode = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblpin = new System.Windows.Forms.Label();
            this.lblcontactno = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtstate = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblstate = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtvendorname = new System.Windows.Forms.TextBox();
            this.lblVendorname = new System.Windows.Forms.Label();
            this.txtorg = new System.Windows.Forms.TextBox();
            this.lblorg = new System.Windows.Forms.Label();
            this.lblVendorMaster = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlhead.SuspendLayout();
            this.pnlcontent.SuspendLayout();
            this.pnlgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvvendor)).BeginInit();
            this.pnlheadcontent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Size = new System.Drawing.Size(1347, 49);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlcontent);
            this.panel2.Controls.Add(this.pnlhead);
            this.panel2.Size = new System.Drawing.Size(1347, 479);
            this.panel2.Controls.SetChildIndex(this.pnlhead, 0);
            this.panel2.Controls.SetChildIndex(this.pnlcontent, 0);
            // 
            // pnlhead
            // 
            this.pnlhead.BackColor = System.Drawing.Color.Teal;
            this.pnlhead.Controls.Add(this.lblVendorMaster);
            this.pnlhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhead.Location = new System.Drawing.Point(0, 24);
            this.pnlhead.Name = "pnlhead";
            this.pnlhead.Size = new System.Drawing.Size(1347, 30);
            this.pnlhead.TabIndex = 1;
            // 
            // pnlcontent
            // 
            this.pnlcontent.Controls.Add(this.pnlgrid);
            this.pnlcontent.Controls.Add(this.pnlheadcontent);
            this.pnlcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontent.Location = new System.Drawing.Point(0, 54);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(1347, 425);
            this.pnlcontent.TabIndex = 2;
            // 
            // pnlgrid
            // 
            this.pnlgrid.Controls.Add(this.gvvendor);
            this.pnlgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlgrid.Location = new System.Drawing.Point(0, 200);
            this.pnlgrid.Name = "pnlgrid";
            this.pnlgrid.Size = new System.Drawing.Size(1347, 225);
            this.pnlgrid.TabIndex = 1;
            // 
            // gvvendor
            // 
            this.gvvendor.AllowUserToAddRows = false;
            this.gvvendor.AllowUserToDeleteRows = false;
            this.gvvendor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvvendor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvvendor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvvendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvvendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorid,
            this.vendorcode,
            this.orgname,
            this.vendorname,
            this.address,
            this.city,
            this.state,
            this.pincode,
            this.contactno,
            this.mail});
            this.gvvendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvvendor.Location = new System.Drawing.Point(0, 0);
            this.gvvendor.Name = "gvvendor";
            this.gvvendor.ReadOnly = true;
            this.gvvendor.RowHeadersVisible = false;
            this.gvvendor.Size = new System.Drawing.Size(1347, 225);
            this.gvvendor.TabIndex = 0;
            // 
            // vendorid
            // 
            this.vendorid.HeaderText = "Vendor ID";
            this.vendorid.Name = "vendorid";
            this.vendorid.ReadOnly = true;
            // 
            // vendorcode
            // 
            this.vendorcode.HeaderText = "Vendor Code";
            this.vendorcode.Name = "vendorcode";
            this.vendorcode.ReadOnly = true;
            // 
            // orgname
            // 
            this.orgname.HeaderText = "Organisation Name";
            this.orgname.Name = "orgname";
            this.orgname.ReadOnly = true;
            // 
            // vendorname
            // 
            this.vendorname.HeaderText = "Vendor Name";
            this.vendorname.Name = "vendorname";
            this.vendorname.ReadOnly = true;
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
            // pincode
            // 
            this.pincode.HeaderText = "Postal Code";
            this.pincode.Name = "pincode";
            this.pincode.ReadOnly = true;
            // 
            // contactno
            // 
            this.contactno.HeaderText = "Contact No";
            this.contactno.Name = "contactno";
            this.contactno.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "Email";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // pnlheadcontent
            // 
            this.pnlheadcontent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlheadcontent.Controls.Add(this.txtvendorcode);
            this.pnlheadcontent.Controls.Add(this.lblvendorcode);
            this.pnlheadcontent.Controls.Add(this.btnadd);
            this.pnlheadcontent.Controls.Add(this.txtPostal);
            this.pnlheadcontent.Controls.Add(this.txtcontactno);
            this.pnlheadcontent.Controls.Add(this.txtemail);
            this.pnlheadcontent.Controls.Add(this.lblpin);
            this.pnlheadcontent.Controls.Add(this.lblcontactno);
            this.pnlheadcontent.Controls.Add(this.lblmail);
            this.pnlheadcontent.Controls.Add(this.txtstate);
            this.pnlheadcontent.Controls.Add(this.txtcity);
            this.pnlheadcontent.Controls.Add(this.lblcity);
            this.pnlheadcontent.Controls.Add(this.lblstate);
            this.pnlheadcontent.Controls.Add(this.txtaddress);
            this.pnlheadcontent.Controls.Add(this.lbladdress);
            this.pnlheadcontent.Controls.Add(this.txtvendorname);
            this.pnlheadcontent.Controls.Add(this.lblVendorname);
            this.pnlheadcontent.Controls.Add(this.txtorg);
            this.pnlheadcontent.Controls.Add(this.lblorg);
            this.pnlheadcontent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheadcontent.Location = new System.Drawing.Point(0, 0);
            this.pnlheadcontent.Name = "pnlheadcontent";
            this.pnlheadcontent.Size = new System.Drawing.Size(1347, 200);
            this.pnlheadcontent.TabIndex = 0;
            // 
            // txtvendorcode
            // 
            this.txtvendorcode.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtvendorcode.Location = new System.Drawing.Point(990, 7);
            this.txtvendorcode.Multiline = true;
            this.txtvendorcode.Name = "txtvendorcode";
            this.txtvendorcode.Size = new System.Drawing.Size(200, 25);
            this.txtvendorcode.TabIndex = 28;
            // 
            // lblvendorcode
            // 
            this.lblvendorcode.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblvendorcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblvendorcode.Location = new System.Drawing.Point(839, 14);
            this.lblvendorcode.Name = "lblvendorcode";
            this.lblvendorcode.Size = new System.Drawing.Size(120, 18);
            this.lblvendorcode.TabIndex = 27;
            this.lblvendorcode.Text = "Vendor Code* :";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(432, 155);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 30);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add Vendor";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtPostal
            // 
            this.txtPostal.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtPostal.Location = new System.Drawing.Point(131, 109);
            this.txtPostal.Multiline = true;
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(200, 25);
            this.txtPostal.TabIndex = 23;
            // 
            // txtcontactno
            // 
            this.txtcontactno.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtcontactno.Location = new System.Drawing.Point(543, 111);
            this.txtcontactno.Multiline = true;
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(200, 25);
            this.txtcontactno.TabIndex = 24;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtemail.Location = new System.Drawing.Point(990, 111);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 25);
            this.txtemail.TabIndex = 25;
            // 
            // lblpin
            // 
            this.lblpin.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblpin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblpin.Location = new System.Drawing.Point(12, 111);
            this.lblpin.Name = "lblpin";
            this.lblpin.Size = new System.Drawing.Size(120, 18);
            this.lblpin.TabIndex = 22;
            this.lblpin.Text = "Postal Code* :";
            // 
            // lblcontactno
            // 
            this.lblcontactno.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblcontactno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcontactno.Location = new System.Drawing.Point(447, 116);
            this.lblcontactno.Name = "lblcontactno";
            this.lblcontactno.Size = new System.Drawing.Size(100, 18);
            this.lblcontactno.TabIndex = 21;
            this.lblcontactno.Text = "Contact No :";
            // 
            // lblmail
            // 
            this.lblmail.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmail.Location = new System.Drawing.Point(914, 116);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(100, 18);
            this.lblmail.TabIndex = 20;
            this.lblmail.Text = "Email * :";
            // 
            // txtstate
            // 
            this.txtstate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtstate.Location = new System.Drawing.Point(1017, 61);
            this.txtstate.Multiline = true;
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(200, 25);
            this.txtstate.TabIndex = 19;
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtcity.Location = new System.Drawing.Point(531, 59);
            this.txtcity.Multiline = true;
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(200, 25);
            this.txtcity.TabIndex = 18;
            // 
            // lblcity
            // 
            this.lblcity.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblcity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcity.Location = new System.Drawing.Point(467, 61);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(100, 18);
            this.lblcity.TabIndex = 17;
            this.lblcity.Text = "City* :";
            // 
            // lblstate
            // 
            this.lblstate.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblstate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblstate.Location = new System.Drawing.Point(944, 63);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(100, 18);
            this.lblstate.TabIndex = 16;
            this.lblstate.Text = "State* :";
            this.lblstate.Click += new System.EventHandler(this.lblstate_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtaddress.Location = new System.Drawing.Point(108, 66);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(200, 25);
            this.txtaddress.TabIndex = 15;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // lbladdress
            // 
            this.lbladdress.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lbladdress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbladdress.Location = new System.Drawing.Point(12, 68);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(100, 18);
            this.lbladdress.TabIndex = 14;
            this.lbladdress.Text = "Address* :";
            // 
            // txtvendorname
            // 
            this.txtvendorname.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtvendorname.Location = new System.Drawing.Point(580, 14);
            this.txtvendorname.Multiline = true;
            this.txtvendorname.Name = "txtvendorname";
            this.txtvendorname.Size = new System.Drawing.Size(200, 25);
            this.txtvendorname.TabIndex = 13;
            // 
            // lblVendorname
            // 
            this.lblVendorname.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblVendorname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVendorname.Location = new System.Drawing.Point(427, 21);
            this.lblVendorname.Name = "lblVendorname";
            this.lblVendorname.Size = new System.Drawing.Size(120, 18);
            this.lblVendorname.TabIndex = 12;
            this.lblVendorname.Text = "Vendor Name* :";
            // 
            // txtorg
            // 
            this.txtorg.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtorg.Location = new System.Drawing.Point(164, 14);
            this.txtorg.Multiline = true;
            this.txtorg.Name = "txtorg";
            this.txtorg.Size = new System.Drawing.Size(200, 25);
            this.txtorg.TabIndex = 11;
            // 
            // lblorg
            // 
            this.lblorg.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.lblorg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblorg.Location = new System.Drawing.Point(32, 14);
            this.lblorg.Name = "lblorg";
            this.lblorg.Size = new System.Drawing.Size(100, 18);
            this.lblorg.TabIndex = 10;
            this.lblorg.Text = "Org Name* :";
            // 
            // lblVendorMaster
            // 
            this.lblVendorMaster.AutoSize = true;
            this.lblVendorMaster.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblVendorMaster.ForeColor = System.Drawing.Color.White;
            this.lblVendorMaster.Location = new System.Drawing.Point(3, 5);
            this.lblVendorMaster.Name = "lblVendorMaster";
            this.lblVendorMaster.Size = new System.Drawing.Size(122, 22);
            this.lblVendorMaster.TabIndex = 1;
            this.lblVendorMaster.Text = "Vendor Master";
            // 
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 528);
            this.Name = "Vendor";
            this.Text = "Vendor";
            this.Load += new System.EventHandler(this.Vendor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlhead.ResumeLayout(false);
            this.pnlhead.PerformLayout();
            this.pnlcontent.ResumeLayout(false);
            this.pnlgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvvendor)).EndInit();
            this.pnlheadcontent.ResumeLayout(false);
            this.pnlheadcontent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlhead;
        private System.Windows.Forms.Panel pnlcontent;
        private System.Windows.Forms.Panel pnlheadcontent;
        private System.Windows.Forms.TextBox txtorg;
        private System.Windows.Forms.Label lblorg;
        private System.Windows.Forms.TextBox txtvendorname;
        private System.Windows.Forms.Label lblVendorname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtstate;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblpin;
        private System.Windows.Forms.Label lblcontactno;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel pnlgrid;
        private System.Windows.Forms.DataGridView gvvendor;
        private System.Windows.Forms.TextBox txtvendorcode;
        private System.Windows.Forms.Label lblvendorcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgname;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn pincode;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.Label lblVendorMaster;
    }
}