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
    public partial class Vendor : Dashboard
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public Vendor()
        {
            InitializeComponent();
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblstate_Click(object sender, EventArgs e)
        {

        }
        private void getVendorList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spGetVendors", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    gvvendor.Columns["vendorid"].DataPropertyName = dt.Columns["vendorID"].ToString();
                    gvvendor.Columns["orgname"].DataPropertyName = dt.Columns["organisationName"].ToString();
                    gvvendor.Columns["vendorname"].DataPropertyName = dt.Columns["vendorName"].ToString();
                    gvvendor.Columns["vendorcode"].DataPropertyName = dt.Columns["vendorCode"].ToString();
                    gvvendor.Columns["address"].DataPropertyName = dt.Columns["address"].ToString();
                    gvvendor.Columns["city"].DataPropertyName = dt.Columns["city"].ToString();
                    gvvendor.Columns["state"].DataPropertyName = dt.Columns["state"].ToString();
                    gvvendor.Columns["pincode"].DataPropertyName = dt.Columns["postalcode"].ToString();
                    gvvendor.Columns["contactno"].DataPropertyName = dt.Columns["contactno"].ToString();
                    gvvendor.Columns["mail"].DataPropertyName = dt.Columns["mail"].ToString();
                    gvvendor.DataSource = dt;
                }

            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertVendor", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@organme", SqlDbType.VarChar).Value = txtorg.Text;
                    cmd.Parameters.Add("@vendorname", SqlDbType.VarChar).Value = txtvendorname.Text;
                    cmd.Parameters.Add("@vendorCode", SqlDbType.VarChar).Value = txtvendorcode.Text;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtaddress.Text;
                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = txtcity.Text;
                    cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = txtstate.Text;
                    cmd.Parameters.Add("@pin", SqlDbType.VarChar).Value = txtPostal.Text;
                    cmd.Parameters.Add("@contactno", SqlDbType.VarChar).Value = txtcontactno.Text;
                    cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtemail.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            getVendorList();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            getVendorList();
        }
    }
}
