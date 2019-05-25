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
    public partial class Print : Form
    {
        string prodname;
        public Print(string prodname)
        {
            InitializeComponent();
            this.prodname = prodname;
        }

        private void Print_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter para = new Microsoft.Reporting.WinForms.ReportParameter("productname",this.prodname);
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
