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
    public partial class Item : Dashboard
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryManagementDataSet1.tblCompany' table. You can move, or remove it, as needed.
            this.tblCompanyTableAdapter.Fill(this.inventoryManagementDataSet1.tblCompany);
            // TODO: This line of code loads data into the 'inventoryManagementDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.inventoryManagementDataSet.Category);
            getItemList();
        }
        private void getItemList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spGetItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    gvItems.Columns["srno"].DataPropertyName = dt.Columns["itemId"].ToString();
                    gvItems.Columns["name"].DataPropertyName = dt.Columns["itemName"].ToString();
                    gvItems.Columns["code"].DataPropertyName = dt.Columns["itemCode"].ToString();
                    gvItems.Columns["description"].DataPropertyName = dt.Columns["itemDescription"].ToString();
                    gvItems.Columns["price"].DataPropertyName = dt.Columns["price"].ToString();
                    gvItems.Columns["category"].DataPropertyName = dt.Columns["categoryname"].ToString();
                    gvItems.Columns["company"].DataPropertyName = dt.Columns["CompanyName"].ToString();
                    gvItems.DataSource = dt;
                }

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertItem", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@itemname", SqlDbType.VarChar).Value = txtItemName.Text;
                    cmd.Parameters.Add("@category", SqlDbType.Int).Value = Convert.ToInt16(cbCategory.SelectedValue);
                    cmd.Parameters.Add("@company", SqlDbType.Int).Value = Convert.ToInt16(cbCompany.SelectedValue);
                    cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtItemCode.Text;
                    cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtRemarks.Text;
                    cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            getItemList();
        }
    }
}
