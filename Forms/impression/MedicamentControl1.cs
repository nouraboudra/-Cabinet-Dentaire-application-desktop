using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentaire.Forms.impression
{
    public partial class MedicamentControl1 : UserControl
    {
        public  string med;
        public int qte;
        public string util;
        public MedicamentControl1(string med,int qte,string utilisation)
        {
            this.med = med;
            this.qte = qte;
            this.util = utilisation;
            InitializeComponent();
        }

        private void MedicamentControl1_Load(object sender, EventArgs e)
        {
            Medicament.Text="Médicament "+med;
            Quantite.Text = Convert.ToString(qte);
            utilisation.Text = util;
        }
    }
}
