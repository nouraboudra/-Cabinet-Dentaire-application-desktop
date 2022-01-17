using InterfaceDaoImpl;
using Models;
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
    public partial class FacturePDF : Form
    {
        int id;
        DateTime date_f;
        Double prix_f;
        public FacturePDF(int id, DateTime date_f,Double prix_f)
        {
            InitializeComponent();
            this.id = id;
            this.date_f = date_f;
            this.prix_f = prix_f;
        }

        PrintPreviewDialog printpreview = new PrintPreviewDialog();
        PrintDocument doc = new PrintDocument();


        private void FacturePDF_Load(object sender, EventArgs e)
        {
           Patient p =new PatientDaoImpl().getPatientById(id);
            patient.Text = p.nom + " " + p.prenom;
            cin.Text = p.cin;
            date_n.Text = p.date_naissance.Day + " / " + p.date_naissance.Month + " / " + p.date_naissance.Year;
            prix.Text = ""+prix_f+" DHS";
            date.Text = date_f.Day + " / " + date_f.Month + " / " + date_f.Year;
            codeP.Text = " " + id;
            dr.Text = FormLogin.nomUser;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        public void Print(Panel p)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = p;
            getPrintArea(p);
            printpreview.Document = doc;
            doc.PrintPage += new PrintPageEventHandler(print_page);
            printpreview.ShowDialog();
        }

        public void print_page(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryimg, 0, 0);
        }

        Bitmap memoryimg;
        public void getPrintArea(Panel p)
        {
            memoryimg = new Bitmap(this.Width, this.Height);
            p.DrawToBitmap(memoryimg, new Rectangle(0, 0, this.Width, this.Height));
        }

     
    }
}
