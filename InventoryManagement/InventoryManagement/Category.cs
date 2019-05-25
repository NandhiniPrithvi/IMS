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
    public partial class Category : Dashboard
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            btnupdate.Enabled = false;
            getCategoryList();
        }
        private void getCategoryList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select categoryId,name,description from Category", conn))
                {
                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    gvCategory.Columns["srno"].DataPropertyName = dt.Columns["categoryId"].ToString();
                    gvCategory.Columns["categoryname"].DataPropertyName = dt.Columns["name"].ToString();
                    gvCategory.Columns["Description"].DataPropertyName = dt.Columns["description"].ToString();
                    gvCategory.DataSource = dt;
                }

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertCategory", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@categoryname", SqlDbType.VarChar).Value = txtcategory.Text;
                    cmd.Parameters.Add("@categorydesc", SqlDbType.VarChar).Value = txtRemarks.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            getCategoryList();
        }

       

        private void gvCategory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gvCategory.CurrentCell.ColumnIndex == 0)
            {
                int id = Convert.ToInt16(gvCategory.Rows[e.RowIndex].Cells["srno"].Value);
                string categoryname = Convert.ToString(gvCategory.Rows[e.RowIndex].Cells["categoryname"].Value);
                DialogResult dr = MessageBox.Show("Are You Sure. You want to delete " + categoryname + " from the list.", "Confirm", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("spDeleteCategory", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = id;

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    getCategoryList();

                }
            }

        }

        private void lbldescription_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
        //    if (txtcategory.Text != null || txtcategory.Text != string.Empty)
        //    {
        //        int id = Convert.ToInt16(gvCategory.Rows[e.RowIndex].Cells["srno"].Value);
        //        string categoryname = Convert.ToString(gvCategory.Rows[e.RowIndex].Cells["categoryname"].Value);
        //        DialogResult dr = MessageBox.Show("Are You Sure. You want to delete " + categoryname + " from the list.", "Confirm", MessageBoxButtons.YesNoCancel);

        //        if (dr == DialogResult.Yes)
        //        {
        //            using (SqlConnection con = new SqlConnection(connectionString))
        //            {
        //                using (SqlCommand cmd = new SqlCommand("spDeleteCategory", con))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;

        //                    cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = id;

        //                    con.Open();
        //                    cmd.ExecuteNonQuery();
        //                }
        //            }
        //            getCategoryList();
        //        }

        //        }
           }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvCategory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvCategory_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void gvCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt16(gvCategory.Rows[e.RowIndex].Cells["srno"].Value);
            txtcategory.Text = Convert.ToString(gvCategory.Rows[e.RowIndex].Cells["categoryname"].Value);
            btnupdate.Enabled = true;
        }
    }
}
