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
    public partial class PrintUsingWndowsOptioncs : Form
    {
        public PrintUsingWndowsOptioncs()
        {
            
            InitializeComponent();
           
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Pen pen = Pens.Red;
            string header = "nandhini & co" + "\r\n" + "no 15 gandhi road" + "\r\n" + "kanchipuram - 631502"
                + "\r\n" + "gstin - 87634716" + "\r\n " + "phone no : 9498071320";
            Font verdana10Font = new Font("Times new Roman", 14);
            e.Graphics.DrawString(header, verdana10Font, Brushes.Black, new PointF(100, 100));
            ////e.Graphics.DrawLine(pen, new PointF(100, 200), new PointF(100, 100));
            //e.Graphics.
        }
        public void printmenthod()
        {
            //PrintScreen();
            printPreviewDialog1.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //PrintScreen();
            printPreviewDialog1.ShowDialog();
        }       
        //private void PrintScreen()
        //{
            
        //    Graphics mygraphics = this.CreateGraphics();
        //    Size s = this.Size;
        //    memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
        //    Graphics memoryGraphics = Graphics.FromImage(memoryImage);
        //    IntPtr dc1 = mygraphics.GetHdc();
        //    IntPtr dc2 = memoryGraphics.GetHdc();
        //    BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
        //    mygraphics.ReleaseHdc(dc1);
        //    memoryGraphics.ReleaseHdc(dc2);
        //}

        private void TextPrint(object sender, PrintPageEventArgs e)
        {
           Font verdana10Font = new Font("Verdana", 10);
            e.Graphics.DrawString("Hi", verdana10Font, Brushes.AliceBlue , new PointF(100,100));
        }
       
       
    }
}
