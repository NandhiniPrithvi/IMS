namespace InventoryManagement
{
    partial class PurchaseOrder
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
            this.pnlPurchaseOrder = new System.Windows.Forms.Panel();
            this.lblPurchaseOrder = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlPurchaseOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 303);
            this.panel1.Size = new System.Drawing.Size(940, 49);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPurchaseOrder);
            this.panel2.Size = new System.Drawing.Size(940, 303);
            this.panel2.Controls.SetChildIndex(this.pnlPurchaseOrder, 0);
            // 
            // pnlPurchaseOrder
            // 
            this.pnlPurchaseOrder.BackColor = System.Drawing.Color.Teal;
            this.pnlPurchaseOrder.Controls.Add(this.lblPurchaseOrder);
            this.pnlPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPurchaseOrder.Location = new System.Drawing.Point(0, 24);
            this.pnlPurchaseOrder.Name = "pnlPurchaseOrder";
            this.pnlPurchaseOrder.Size = new System.Drawing.Size(940, 30);
            this.pnlPurchaseOrder.TabIndex = 1;
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.AutoSize = true;
            this.lblPurchaseOrder.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblPurchaseOrder.ForeColor = System.Drawing.Color.White;
            this.lblPurchaseOrder.Location = new System.Drawing.Point(3, 5);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(126, 22);
            this.lblPurchaseOrder.TabIndex = 2;
            this.lblPurchaseOrder.Text = "Purchase Order";
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 352);
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPurchaseOrder.ResumeLayout(false);
            this.pnlPurchaseOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPurchaseOrder;
        private System.Windows.Forms.Label lblPurchaseOrder;
    }
}