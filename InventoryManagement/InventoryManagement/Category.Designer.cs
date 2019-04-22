namespace InventoryManagement
{
    partial class Category
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
            this.pnlhead = new System.Windows.Forms.Panel();
            this.lblCategoryheader = new System.Windows.Forms.Label();
            this.pnladd = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.gvCategory = new System.Windows.Forms.DataGridView();
            this.srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel2.SuspendLayout();
            this.pnlhead.SuspendLayout();
            this.pnladd.SuspendLayout();
            this.pnlcontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlcontent);
            this.panel2.Controls.Add(this.pnladd);
            this.panel2.Controls.Add(this.pnlhead);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Controls.SetChildIndex(this.pnlhead, 0);
            this.panel2.Controls.SetChildIndex(this.pnladd, 0);
            this.panel2.Controls.SetChildIndex(this.pnlcontent, 0);
            // 
            // pnlhead
            // 
            this.pnlhead.BackColor = System.Drawing.Color.Teal;
            this.pnlhead.Controls.Add(this.lblCategoryheader);
            this.pnlhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhead.Location = new System.Drawing.Point(0, 24);
            this.pnlhead.Name = "pnlhead";
            this.pnlhead.Size = new System.Drawing.Size(1055, 30);
            this.pnlhead.TabIndex = 1;
            // 
            // lblCategoryheader
            // 
            this.lblCategoryheader.AutoSize = true;
            this.lblCategoryheader.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryheader.ForeColor = System.Drawing.Color.White;
            this.lblCategoryheader.Location = new System.Drawing.Point(3, 5);
            this.lblCategoryheader.Name = "lblCategoryheader";
            this.lblCategoryheader.Size = new System.Drawing.Size(135, 22);
            this.lblCategoryheader.TabIndex = 0;
            this.lblCategoryheader.Text = "Category Master";
            // 
            // pnladd
            // 
            this.pnladd.Controls.Add(this.btnupdate);
            this.pnladd.Controls.Add(this.txtRemarks);
            this.pnladd.Controls.Add(this.lbldescription);
            this.pnladd.Controls.Add(this.btnadd);
            this.pnladd.Controls.Add(this.txtcategory);
            this.pnladd.Controls.Add(this.label1);
            this.pnladd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnladd.Location = new System.Drawing.Point(0, 54);
            this.pnladd.Name = "pnladd";
            this.pnladd.Size = new System.Drawing.Size(1055, 100);
            this.pnladd.TabIndex = 2;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.White;
            this.btnupdate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(841, 31);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(120, 30);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update Category";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(473, 31);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 30);
            this.txtRemarks.TabIndex = 6;
            // 
            // lbldescription
            // 
            this.lbldescription.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbldescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldescription.Location = new System.Drawing.Point(367, 35);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(100, 21);
            this.lbldescription.TabIndex = 5;
            this.lbldescription.Text = "Remarks :";
            this.lbldescription.Click += new System.EventHandler(this.lbldescription_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(714, 31);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 30);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Add Category";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtcategory
            // 
            this.txtcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategory.Location = new System.Drawing.Point(133, 31);
            this.txtcategory.Multiline = true;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(200, 30);
            this.txtcategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category* :";
            // 
            // pnlcontent
            // 
            this.pnlcontent.Controls.Add(this.gvCategory);
            this.pnlcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontent.Location = new System.Drawing.Point(0, 154);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(1055, 238);
            this.pnlcontent.TabIndex = 3;
            // 
            // gvCategory
            // 
            this.gvCategory.AllowUserToAddRows = false;
            this.gvCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.gvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srno,
            this.categoryname,
            this.Description,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCategory.GridColor = System.Drawing.Color.Honeydew;
            this.gvCategory.Location = new System.Drawing.Point(0, 0);
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvCategory.RowHeadersVisible = false;
            this.gvCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gvCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.gvCategory.Size = new System.Drawing.Size(1055, 238);
            this.gvCategory.TabIndex = 1;
            this.gvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCategory_CellContentClick_1);
            this.gvCategory.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCategory_CellEnter);
            this.gvCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvCategory_CellMouseClick);
            this.gvCategory.SelectionChanged += new System.EventHandler(this.gvCategory_SelectionChanged);
            // 
            // srno
            // 
            this.srno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.srno.HeaderText = "SR NO";
            this.srno.Name = "srno";
            this.srno.ReadOnly = true;
            this.srno.Width = 326;
            // 
            // categoryname
            // 
            this.categoryname.HeaderText = "Category";
            this.categoryname.Name = "categoryname";
            this.categoryname.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
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
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 441);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlhead.ResumeLayout(false);
            this.pnlhead.PerformLayout();
            this.pnladd.ResumeLayout(false);
            this.pnladd.PerformLayout();
            this.pnlcontent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlhead;
        private System.Windows.Forms.Label lblCategoryheader;
        private System.Windows.Forms.Panel pnladd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel pnlcontent;
        private System.Windows.Forms.DataGridView gvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnupdate;
    }
}