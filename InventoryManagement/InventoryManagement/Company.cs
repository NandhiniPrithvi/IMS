using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagement
{
    public partial class Company : Dashboard
    {
        string connectionString = ConfigurationManager.ConnectionStrings["IMCON"].ConnectionString;
        public Company()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertCompany", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@companyname", SqlDbType.VarChar).Value = txtcompanyname.Text;
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            getCompanyList();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            getCompanyList();
        }
        private void getCompanyList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblCompany", conn))
                {
                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    gvCompany.Columns["srno"].DataPropertyName = dt.Columns["CompanyId"].ToString();
                    gvCompany.Columns["companyName"].DataPropertyName = dt.Columns["CompanyName"].ToString();
                    gvCompany.DataSource = dt;
                }

            }
        }

        private void gvCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvCompany.CurrentCell.ColumnIndex == 0)
            {
                int id =Convert.ToInt16(gvCompany.Rows[e.RowIndex].Cells["srno"].Value);
                string companyname = Convert.ToString(gvCompany.Rows[e.RowIndex].Cells["companyName"].Value);
                DialogResult dr = MessageBox.Show("Are You Sure. You want to delete "+ companyname + " from the list.", "Confirm", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("spDeleteCompany", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@companyid", SqlDbType.Int).Value = id;

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    getCompanyList();

                }
            }
        }
    }
}
