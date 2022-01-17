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

namespace Dentaire.Forms.impression
{
    public partial class CertficatPDF : Form
    {
        PrintPreviewDialog printpreview = new PrintPreviewDialog();
        PrintDocument doc = new PrintDocument();
        string nom;
             
        public CertficatPDF(string nom)
        {
            InitializeComponent();
            this.nom = nom;
        }

        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.fpanel);

        }
        public void Print(Panel p)
        {
            PrinterSettings ps = new PrinterSettings();
            fpanel = p;
            getPrintArea(p);
            printpreview.Document = doc;
            doc.PrintPage += new PrintPageEventHandler(print_page);
            printpreview.ShowDialog();
        }

        public void print_page(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryimg,0,0);
        }

        Bitmap memoryimg;
        public void getPrintArea(Panel p)
        {
            memoryimg = new Bitmap(this.Width, this.Height);
            p.DrawToBitmap(memoryimg, new Rectangle(0, 0, this.Width, this.Height));
        }

        private void CertficatPDF_Load(object sender, EventArgs e)
        {
            Nom_patient.Text = nom;
            dr.Text = FormLogin.nomUser;
        }
    }
}
