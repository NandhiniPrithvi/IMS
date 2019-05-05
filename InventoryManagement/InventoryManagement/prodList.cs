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
    public partial class prodList : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public POOrder poorder;
        public prodList(POOrder poorder)
        {
            InitializeComponent();
            this.poorder = poorder;
        }
        private void prodList_Load(object sender, EventArgs e)
        {
            getProducts();
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            searchProducts();
        }
        private void txtprodname_KeyUp(object sender, KeyEventArgs e)
        {
            searchProducts();
        }
        private void gvProdList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = gvProdList.SelectedRows[0];
            int sgst = Convert.ToInt16(dr.Cells[6].Value);
            int cgst = Convert.ToInt16(dr.Cells[7].Value);
            decimal pprice = Convert.ToInt16(dr.Cells[4].Value);
            poorder.txtPO.Text = dr.Cells[0].Value.ToString();
            poorder.txtproductname.Text = dr.Cells[1].Value.ToString();
            poorder.txthsn.Text = dr.Cells[3].Value.ToString();
            poorder.txtpurchaseprice.Text = dr.Cells[4].Value.ToString();
            poorder.txtsgst.Text = dr.Cells[6].Value.ToString();
            poorder.txtcgst.Text = dr.Cells[7].Value.ToString();
            poorder.txtdiscount.Text = dr.Cells[9].Value.ToString();
            poorder.txtquantity.Text = dr.Cells[6].Value.ToString();
            decimal txtsgstamountvalue = (pprice * sgst) / 100;
            decimal txtcgstamountvalue = (pprice * cgst) / 100;
            poorder.txtsgstamount.Text = txtsgstamountvalue.ToString();
            poorder.txtcgstamount.Text = txtcgstamountvalue.ToString();

            this.Close();
        }
        private void getProducts()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string command = "select * from Product";
            SqlCommand sqlcommand = new SqlCommand(command, conn);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcommand);
            conn.Open();
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            loadDataTOGrid(dt);
        }
        private void searchProducts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSearchProduct", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.Add("@ProdName", SqlDbType.VarChar).Value = txtprodname.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    loadDataTOGrid(dt);
                }
            }
        }
        private void loadDataTOGrid(DataTable dt)
        {
            gvProdList.Columns["productCode"].DataPropertyName = dt.Columns["productCode"].ToString();
            gvProdList.Columns["productName"].DataPropertyName = dt.Columns["productName"].ToString();
            gvProdList.Columns["category"].DataPropertyName = dt.Columns["category"].ToString();
            gvProdList.Columns["company"].DataPropertyName = dt.Columns["company"].ToString();
            gvProdList.Columns["purchasePrice"].DataPropertyName = dt.Columns["purchasePrice"].ToString();
            gvProdList.Columns["salesPrice"].DataPropertyName = dt.Columns["salesPrice"].ToString();
            gvProdList.Columns["sgst"].DataPropertyName = dt.Columns["sgst"].ToString();
            gvProdList.Columns["cgst"].DataPropertyName = dt.Columns["cgst"].ToString();
            gvProdList.Columns["hsnCode"].DataPropertyName = dt.Columns["hsnCode"].ToString();
            gvProdList.Columns["discount"].DataPropertyName = dt.Columns["discount"].ToString();
            gvProdList.Columns["quantity"].DataPropertyName = dt.Columns["quantity"].ToString();
            gvProdList.DataSource = dt;
        }
    }
}
