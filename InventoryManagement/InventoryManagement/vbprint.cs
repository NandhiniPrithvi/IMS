using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class vbprint : Form
    {
        private string InvTitle;
        private string InvSubTitle1;
        private string InvSubTitle2;
        private string InvSubTitle3;
        private string InvSubTitle4;
        private string InvFoot;
        private int CurrentY;
        private int CurrentX;
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private int InvoiceWidth;
        private int InvoiceHeight;
        public string leftData1;
        public string leftData2;
        public string leftData3;
        public string rightData1;
        public string rightData2;
        private decimal rightData3;
       
     
        // Title Font
        private Font InvTitleFont = new Font("Arial", 24, FontStyle.Regular);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 14, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        // Invoice Font height
        private int InvoiceFontHeight;

        private Font InvFootFont = new Font("Arial", 10, FontStyle.Regular);
        private int InvFootHeight;
        // Blue Color
        private SolidBrush BlueBrush = new SolidBrush(Color.Blue);
        // Red Color
        private SolidBrush RedBrush = new SolidBrush(Color.Red);
        // Black Color
        private SolidBrush BlackBrush = new SolidBrush(Color.Black);
        public vbprint()
        {
            InitializeComponent();
        }
        public void setValueforfields(string leftData1, string leftData2,string rightData1,string rightData2)
        {
            this.leftData1 = leftData1;
            this.leftData2 = leftData2;
            this.rightData1 = rightData1;
            this.rightData2 = rightData2;
        }
        public void button2_Click(object sender, EventArgs e)
        {
            //printreport();
            //printPreviewDialog1.Document = printDocument1;
            // printPreviewDialog1.ShowDialog();

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
            //if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}

        }
        private void printreport()
        {
            try
            {

                printDocument1.Print();
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;
            SetInvoiceHead(e.Graphics); // Draw Invoice Head
            SetOrderData(e.Graphics); // Draw Order Data
            SetInvoiceData(e.Graphics, e); // Draw Invoice Data
            SetInvoiceFooter(e.Graphics);
        }
        private void ReadInvoiceHead()
        {
            InvTitle = "Vasudevan & Brothers";
            InvSubTitle1 = "23 Ab street";
            InvSubTitle2 = "Kanchipuram Tamilnadu -631502";
            InvSubTitle3 = "Phone 2233445566";
            InvSubTitle4 = "GSTIN 94567467456";
        }
        private void SetInvoiceHead(Graphics g)
        {
            ReadInvoiceHead();

            CurrentY = topMargin;
            CurrentX = leftMargin;
            int ImageHeight = 0;

            // Draw Invoice image:
          
            InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
            InvSubTitleHeight = (int)(InvSubTitleFont.GetHeight(g));

            // Get Titles Length:
            int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
            int lenInvSubTitle1 = (int)g.MeasureString(InvSubTitle1, InvSubTitleFont).Width;
            int lenInvSubTitle2 = (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width;
            int lenInvSubTitle3 = (int)g.MeasureString(InvSubTitle3, InvSubTitleFont).Width;
            int lenInvSubTitle4 = (int)g.MeasureString(InvSubTitle4, InvSubTitleFont).Width;
            // Set Titles Left:
            int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
            int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;
            int xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2;

            // Draw Invoice Head:
            if (InvTitle != "")
            {
                CurrentY = CurrentY + ImageHeight;
                g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY);
            }
            if (InvSubTitle1 != "")
            {
                CurrentY = CurrentY + InvTitleHeight;
                g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY);
            }
            if (InvSubTitle2 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY);
            }
            if (InvSubTitle3 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY);
            }
            if (InvSubTitle4 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle4, InvSubTitleFont, BlueBrush, xInvSubTitle4, CurrentY);
            }

            // Draw line:
            CurrentY = CurrentY + InvSubTitleHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY);
        }
        private void SetInvoiceFooter(Graphics g)
        {
            CurrentY = bottomMargin;
            CurrentX = leftMargin;
            ReadInvoiceFoot();

            if (InvFoot != "")
            {
                CurrentY = CurrentY + InvFootHeight;
                g.DrawString(InvFoot, InvFootFont, BlueBrush, CurrentX, CurrentY);
            }
        }
        private void ReadInvoiceFoot()
        {
            InvFoot = "Powered by Vasudevan & Brothers";
        }
        private void SetOrderData(Graphics g)
        {// Set Company Name, City, Salesperson, Order ID and Order Date
            string FieldValue = "";
            InvoiceFontHeight = (int)(InvoiceFont.GetHeight(g));
            // Set Company Name:
            CurrentX = leftMargin;
            CurrentY = CurrentY + 8;
            FieldValue = leftData1;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set City:
            FieldValue = rightData1;
            
               // (CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + (150 - CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width));
            FieldValue = rightData1;
            CurrentX = rightMargin - (int)g.MeasureString(FieldValue, InvoiceFont).Width;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = leftData2;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            FieldValue = rightData2;
            CurrentX = rightMargin - (int)g.MeasureString(FieldValue, InvoiceFont).Width;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set Salesperson:
            //CurrentX = leftMargin;
            //CurrentY = CurrentY + InvoiceFontHeight;
            //FieldValue = "Salesperson: " + SellerName;
            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            //// Set Order ID:
            //CurrentX = leftMargin;
            //CurrentY = CurrentY + InvoiceFontHeight;
            //FieldValue = "Order ID: " + SaleID;
            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            //// Set Order Date:
            //CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
            //FieldValue = "Order Date: " + SaleDate;
            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            // Draw line:
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);
        }
        private void SetInvoiceData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {// Set Invoice Table:
           
           
        }

        private void vbprint_Load(object sender, EventArgs e)
        {
            //PrintPreviewDialog
            printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.ContextMenuStrip.Enabled = false;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
           // ((ToolStrip)printPreviewDialog1.Controls[1]).Items.Remove(((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]));
            printPreviewDialog1.Controls.Remove((ToolStrip)printPreviewDialog1.Controls[1]);
            System.Windows.Forms.Button btn = new Button();
          //  btn.Text = "Click";
            btn.Enabled = true;
            btn.Click += button1_Click;
            printPreviewDialog1.Controls.Add(btn);
            
            printPreviewDialog1.ShowDialog();


            // printPreviewDialog1.Document = printDocument1;
            // printPreviewDialog1.WindowState = FormWindowState.Maximized;
            // ToolStripButton b = new ToolStripButton();
            //// b.Image = Properties.Resources.pr
            // b.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // b.Click += printPreview_PrintClick;
            // ((ToolStrip)(printPreviewDialog1.Controls[1])).Items.RemoveAt(0);
            // ((ToolStrip)(printPreviewDialog1.Controls[1])).Items.Insert(0, b);
            // printPreviewDialog1.ShowDialog();
            //ToolStripButton b = new ToolStripButton();
           // b.ImageIndex = ((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]).ImageIndex;

            
           // b.Visible = true;
           // ((ToolStrip)printPreviewDialog1.Controls[1]).Items.Insert(0, b);
           // ((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]).Click += new System.EventHandler(this.button1_Click);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ToString());
            }
        }
    }
}
