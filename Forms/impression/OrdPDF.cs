using InterfaceDaoImpl;
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
    public partial class OrdPDF : Form
    {
        PrintPreviewDialog printpreview = new PrintPreviewDialog();
        PrintDocument doc = new PrintDocument();
        public int code;
        public string nom;
        public string remrque;
        public string dateO;

        public OrdPDF(int code,string nom,string remrque,string date)
        {
            InitializeComponent();
            this.code = code;
            this.nom=nom;
            this.remrque = remrque;
            this.dateO = date;
        }

        Bitmap bmp;


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

        public void print_page(object sender,PrintPageEventArgs e)
        {
          
            e.Graphics.DrawImage(memoryimg,0,0);
        }

        Bitmap memoryimg;
        public void getPrintArea(Panel p)
        {
            memoryimg = new Bitmap(this.Width,this.Height);
            p.DrawToBitmap(memoryimg, new Rectangle(0, 0, this.Width, this.Height));
        }

        private void OrdPDF_Load(object sender, EventArgs e)
        {
            DataTable data = new DetOrdonnanceDaoImpl().getDetOrdonnance(code);
                int k = 1;
            for(int i = 0; i < data.Rows.Count; i++)
            {
                string medicament =k +" : "+ data.Rows[i]["médicament"].ToString();
           
                int qte = Convert.ToInt32(data.Rows[i]["quantite"].ToString());
                string utilisation= data.Rows[i]["utilisation"].ToString();
                MedicamentControl1 m = new MedicamentControl1(medicament, qte, utilisation);
                fpanel.Controls.Add(m);
                k++;
            }
            dr.Text = FormLogin.nomUser;
            patient.Text = nom;
            remarque.Text = remrque;
            DateTime date_o=DateTime.Parse(dateO);
            date.Text =date_o.Day+"/"+date_o.Month+"/"+date_o.Year ;
        }

     
    }
}
