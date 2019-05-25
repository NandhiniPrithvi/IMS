using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class POOrder : Dashboard
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public POOrder()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodList list = new prodList(this);
            list.ShowDialog();
        }

        private void txtquantityneede_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtquantityneede.Text != null && txtquantityneede.Text != "")
            {
                txttotal.Text = (Convert.ToInt16(txtquantityneede.Text) * (Convert.ToDecimal(txtpurchaseprice.Text)  + Convert.ToDecimal(txtcgstamount.Text) + Convert.ToDecimal(txtsgstamount.Text))).ToString();
                txtcgstamount.Text = ((Convert.ToDecimal(txtpurchaseprice.Text) * Convert.ToDecimal(txtcgst.Text) * Convert.ToInt16(txtquantityneede.Text)) / 100).ToString();
                txtsgstamount.Text = ((Convert.ToDecimal(txtpurchaseprice.Text) * Convert.ToDecimal(txtsgst.Text) * Convert.ToInt16(txtquantityneede.Text)) / 100).ToString();
            }
            else
            {
                txttotal.Text = "";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertPurchaseOrder", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@productCode", SqlDbType.VarChar).Value = txtPO.Text;
                    cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = txtproductname.Text;
                    cmd.Parameters.Add("@purchasePrice", SqlDbType.Decimal).Value = Convert.ToDecimal(txtpurchaseprice.Text);
                    cmd.Parameters.Add("@discount", SqlDbType.Decimal).Value = ((txtdiscount.Text) != null && (txtdiscount.Text) != "") ? Convert.ToDecimal(txtdiscount.Text) : 0;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = ((txtquantity.Text) != null && (txtquantity.Text) != "") ? Convert.ToDecimal(txtquantity.Text) : 0;
                    cmd.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = Convert.ToDecimal(txttotal.Text);
                    cmd.Parameters.Add("@quantityNeeded", SqlDbType.Int).Value =Convert.ToInt16(txtquantityneede.Text);
                    cmd.Parameters.Add("@supplierCode", SqlDbType.VarChar).Value = txtsuppliercode.Text;
                    cmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar).Value = txtinvoiceno.Text;
                    cmd.Parameters.Add("@invoiceDate", SqlDbType.DateTime).Value =Convert.ToDateTime(txtinvoicedate.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            getPurchaseOrderList();
        }
        private void getPurchaseOrderList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string command = "spGetPurchaseOrder";
            SqlCommand sqlcommand = new SqlCommand(command, conn);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcommand);
            conn.Open();
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            gvpurchaseorder.Columns["porderid"].DataPropertyName = dt.Columns["porderid"].ToString();
            gvpurchaseorder.Columns["productCode"].DataPropertyName = dt.Columns["productCode"].ToString();
            gvpurchaseorder.Columns["productName"].DataPropertyName = dt.Columns["productName"].ToString();
            gvpurchaseorder.Columns["purchasePrice"].DataPropertyName = dt.Columns["purchasePrice"].ToString();
            gvpurchaseorder.Columns["discount"].DataPropertyName = dt.Columns["discount"].ToString();
            gvpurchaseorder.Columns["quantity"].DataPropertyName = dt.Columns["quantity"].ToString();
            gvpurchaseorder.Columns["quantityNeeded"].DataPropertyName = dt.Columns["quantityNeeded"].ToString();
            gvpurchaseorder.Columns["totalAmount"].DataPropertyName = dt.Columns["totalAmount"].ToString();
            gvpurchaseorder.Columns["category"].DataPropertyName = dt.Columns["category"].ToString();
            gvpurchaseorder.Columns["company"].DataPropertyName = dt.Columns["company"].ToString();
            gvpurchaseorder.Columns["sgst"].DataPropertyName = dt.Columns["sgst"].ToString();
            gvpurchaseorder.Columns["cgst"].DataPropertyName = dt.Columns["cgst"].ToString();
            gvpurchaseorder.Columns["hsn"].DataPropertyName = dt.Columns["hsnCode"].ToString();
            gvpurchaseorder.Columns["supplierCode"].DataPropertyName = dt.Columns["supplierCode"].ToString();
            gvpurchaseorder.Columns["supplierName"].DataPropertyName = dt.Columns["supplierName"].ToString();
            gvpurchaseorder.Columns["invoiceNo"].DataPropertyName = dt.Columns["invoiceNo"].ToString();
            gvpurchaseorder.Columns["invoiceDate"].DataPropertyName = dt.Columns["invoiceDate"].ToString();
            gvpurchaseorder.Columns["orderDate"].DataPropertyName = dt.Columns["orderDate"].ToString();
            gvpurchaseorder.DataSource = dt;
            txtsubtotal.Text = (dt.AsEnumerable().Sum(row => row.Field<decimal>("totalAmount"))).ToString();
            txtsgs.Text = (dt.AsEnumerable().Sum(row => row.Field<decimal>("sgst"))).ToString();
            txtcgs.Text = (dt.AsEnumerable().Sum(row => row.Field<decimal>("cgst"))).ToString();
            txtgrandtotal.Text = (Convert.ToDecimal(txtsubtotal.Text) + Convert.ToDecimal(txtsgs.Text) + Convert.ToDecimal(txtcgs.Text)).ToString();
        }
        
        private void btnsupplier_Click(object sender, EventArgs e)
        {
            SupplierList supplier = new SupplierList(this);
            supplier.Show();
        }

        private void btncalendar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtinvoicedate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
            loadInvoiceNoBasedOnSupplierCode();
        }
        private void loadInvoiceNoBasedOnSupplierCode()
        {
            string invoiceno;
            SqlConnection conn = new SqlConnection(connectionString);
            string command = "select dbo.getInvoicebySupplier(@suppliercode,@invoicedate)";
            SqlCommand sqlcommand = new SqlCommand(command, conn);
            sqlcommand.CommandType = CommandType.Text;
            sqlcommand.Parameters.Add("@invoicedate", SqlDbType.DateTime).Value = Convert.ToDateTime(txtinvoicedate.Text);
            sqlcommand.Parameters.Add("@suppliercode", SqlDbType.VarChar).Value = txtsuppliercode.Text;
            SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcommand);
            conn.Open();
            invoiceno = sqlcommand.ExecuteScalar().ToString();
            conn.Close();
            if (invoiceno == "" || invoiceno == null)
            {
                txtinvoiceno.Text = getInvoiceNo();
            }
            else
            {
                txtinvoiceno.Text = invoiceno;
            }
        }

        private void POOrder_Load(object sender, EventArgs e)
        {
            getPurchaseOrderList();
        }
        public string getInvoiceNo()
        {
            string invoiceno;
            SqlConnection conn = new SqlConnection(connectionString);
            string command = "select dbo.spGetInvoiceNo()";
            SqlCommand sqlcommand = new SqlCommand(command, conn);
            sqlcommand.CommandType = CommandType.Text;
            SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcommand);
            conn.Open();
            invoiceno = sqlcommand.ExecuteScalar().ToString();
            conn.Close();
            return invoiceno;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure. Do you want to remove item?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow dr = gvpurchaseorder.SelectedRows[0];
                int id = Convert.ToInt16(dr.Cells[0].Value);
                SqlConnection conn = new SqlConnection(connectionString);
                string command = "spDeletePurchaseOrder";
                SqlCommand sqlcommand = new SqlCommand(command, conn);
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.Parameters.Add("@porderid", SqlDbType.Int).Value = id;
                conn.Open();
                sqlcommand.ExecuteNonQuery();
                conn.Close();
                getPurchaseOrderList();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
            
        }

        private void gvpurchaseorder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnremove.Enabled = true;
            btnprint.Enabled = true;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //using (PrintUsingWndowsOptioncs print = new PrintUsingWndowsOptioncs())
            //{
            //    print.label3.Text = "Hi";
            //    print.printmenthod() ; }
            vbprint print = new vbprint();
            print.setValueforfields("Supplier Name : Nandhini", "Supplier Code  : V1001", "Invoice No : IN1001", "Invoice Date : 21/05/2019");
            print.ShowDialog();
        }
    }
}
