namespace InventoryManagement
{
    partial class Company
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnllhead = new System.Windows.Forms.Panel();
            this.lblcompanymaster = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gvCompany = new System.Windows.Forms.DataGridView();
            this.srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnladd = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnllhead.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).BeginInit();
            this.pnladd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Size = new System.Drawing.Size(982, 49);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnllhead);
            this.panel2.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Size = new System.Drawing.Size(982, 350);
            this.panel2.Controls.SetChildIndex(this.pnllhead, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            // 
            // pnllhead
            // 
            this.pnllhead.BackColor = System.Drawing.Color.Teal;
            this.pnllhead.Controls.Add(this.lblcompanymaster);
            this.pnllhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnllhead.Location = new System.Drawing.Point(0, 24);
            this.pnllhead.Name = "pnllhead";
            this.pnllhead.Size = new System.Drawing.Size(982, 30);
            this.pnllhead.TabIndex = 1;
            // 
            // lblcompanymaster
            // 
            this.lblcompanymaster.AutoSize = true;
            this.lblcompanymaster.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanymaster.ForeColor = System.Drawing.Color.White;
            this.lblcompanymaster.Location = new System.Drawing.Point(3, 5);
            this.lblcompanymaster.Name = "lblcompanymaster";
            this.lblcompanymaster.Size = new System.Drawing.Size(140, 22);
            this.lblcompanymaster.TabIndex = 0;
            this.lblcompanymaster.Text = "Company Master";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.pnladd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 296);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gvCompany);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 196);
            this.panel5.TabIndex = 1;
            // 
            // gvCompany
            // 
            this.gvCompany.AllowUserToAddRows = false;
            this.gvCompany.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.gvCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCompany.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srno,
            this.companyName,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCompany.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCompany.GridColor = System.Drawing.Color.Honeydew;
            this.gvCompany.Location = new System.Drawing.Point(0, 0);
            this.gvCompany.Name = "gvCompany";
            this.gvCompany.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCompany.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvCompany.RowHeadersVisible = false;
            this.gvCompany.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCompany.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.gvCompany.Size = new System.Drawing.Size(982, 196);
            this.gvCompany.TabIndex = 0;
            this.gvCompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCompany_CellContentClick);
            // 
            // srno
            // 
            this.srno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.srno.Frozen = true;
            this.srno.HeaderText = "SR NO";
            this.srno.Name = "srno";
            this.srno.ReadOnly = true;
            this.srno.Width = 326;
            // 
            // companyName
            // 
            this.companyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.companyName.Frozen = true;
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Width = 326;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Delete";
            this.Action.UseColumnTextForLinkValue = true;
            this.Action.Width = 327;
            // 
            // pnladd
            // 
            this.pnladd.Controls.Add(this.btnadd);
            this.pnladd.Controls.Add(this.txtcompanyname);
            this.pnladd.Controls.Add(this.lblcompanyname);
            this.pnladd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnladd.Location = new System.Drawing.Point(0, 0);
            this.pnladd.Name = "pnladd";
            this.pnladd.Size = new System.Drawing.Size(982, 100);
            this.pnladd.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(469, 31);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 30);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add Company";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcompanyname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyname.Location = new System.Drawing.Point(236, 31);
            this.txtcompanyname.Multiline = true;
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(200, 30);
            this.txtcompanyname.TabIndex = 1;
            this.txtcompanyname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyname.Location = new System.Drawing.Point(59, 31);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(149, 21);
            this.lblcompanyname.TabIndex = 0;
            this.lblcompanyname.Text = "Company Name* :";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 399);
            this.Name = "Company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnllhead.ResumeLayout(false);
            this.pnllhead.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).EndInit();
            this.pnladd.ResumeLayout(false);
            this.pnladd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnllhead;
        private System.Windows.Forms.Label lblcompanymaster;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnladd;
        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView gvCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
    }
}