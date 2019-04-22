using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace InventoryManagement
{
    public partial class ProductDetails : Dashboard
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public ProductDetails()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            getProducts();
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
            gvProduct.Columns["ProductName"].DataPropertyName = dt.Columns["productName"].ToString();
            gvProduct.Columns["Quantity"].DataPropertyName = dt.Columns["quantity"].ToString();
            gvProduct.Columns["Price"].DataPropertyName = dt.Columns["price"].ToString();
            gvProduct.Columns["ProductId"].DataPropertyName = dt.Columns["productId"].ToString();
            gvProduct.Columns["category"].DataPropertyName = dt.Columns["category"].ToString();
            gvProduct.Columns["lastupdated"].DataPropertyName = dt.Columns["lastUpdated"].ToString();
            gvProduct.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
           // AddNewRowToGrid();
        }
       
    }
}
