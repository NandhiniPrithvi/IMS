using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class POList : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public POList()
        {
            InitializeComponent();
        }

        private void POList_Load(object sender, EventArgs e)
        {
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
    }
}
