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
    public partial class SupplierList : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public POOrder poorder;
        public SupplierList(POOrder poorder)
        {
            InitializeComponent();
            this.poorder = poorder;
        }
        private void SupplierList_Load(object sender, EventArgs e)
        {
            getSuppliers();
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            searchSupplier();
        }
        private void txtsuppliername_KeyUp(object sender, KeyEventArgs e)
        {
            searchSupplier();
        }
        private void gvsupplierlist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = gvsupplierlist.SelectedRows[0];
            poorder.txtsuppliername.Text = dr.Cells[3].Value.ToString();
            poorder.txtsuppliercode.Text = dr.Cells[2].Value.ToString();
            this.Close();
        }
       
        private void getSuppliers()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string command = "select * from Vendor";
            SqlCommand sqlcommand = new SqlCommand(command, conn);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcommand);
            conn.Open();
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            loadDataTOGrid(dt);
        }
        private void searchSupplier()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSearchSupplier", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = txtsuppliername.Text;

                    con.Open();
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    loadDataTOGrid(dt);
                }
            }
        }
        private void loadDataTOGrid(DataTable dt)
        {
            gvsupplierlist.Columns["vendorID"].DataPropertyName = dt.Columns["vendorID"].ToString();
            gvsupplierlist.Columns["organisationName"].DataPropertyName = dt.Columns["organisationName"].ToString();
            gvsupplierlist.Columns["vendorCode"].DataPropertyName = dt.Columns["vendorCode"].ToString();
            gvsupplierlist.Columns["vendorName"].DataPropertyName = dt.Columns["vendorName"].ToString();
            gvsupplierlist.Columns["address"].DataPropertyName = dt.Columns["address"].ToString();
            gvsupplierlist.Columns["city"].DataPropertyName = dt.Columns["city"].ToString();
            gvsupplierlist.Columns["state"].DataPropertyName = dt.Columns["state"].ToString();
            gvsupplierlist.Columns["postalcode"].DataPropertyName = dt.Columns["postalcode"].ToString();
            gvsupplierlist.Columns["contactno"].DataPropertyName = dt.Columns["contactno"].ToString();
            gvsupplierlist.Columns["mail"].DataPropertyName = dt.Columns["mail"].ToString();
           
            gvsupplierlist.DataSource = dt;
        }
        
    }
}
