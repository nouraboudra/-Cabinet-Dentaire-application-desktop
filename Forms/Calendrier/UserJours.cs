using InterfaceDaoImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentaire.Forms.Calendrier
{
    public partial class UserJours : UserControl
    {
        public int jour { get; set; }
        public UserJours()
        {
            InitializeComponent();
        }


        public void jours(int num)
        {
            jrslabel.Text = num + "";
            jour = Convert.ToInt32(jrslabel.Text);
        }

        //Affichage des évenements

        private void AffichageNbrPatients()
        {
            var cultureInfo = new CultureInfo("de-DE");
            string date_s =RDV.static_annee + "/" + RDV.static_mois + "/" +jour;
            DateTime date_r;
            if(DateTime.TryParse(date_s,out date_r))
            {
                date_r = DateTime.Parse(date_s, cultureInfo);
                int nbr_total = new RdvDaoImpl().nbrRvparJour(date_r);
                rv_number.Text = nbr_total+" Patients";
            }

        }

        private void UserJours_Load(object sender, EventArgs e)
        {
            timer1.Start();
            AffichageNbrPatients();
        }

        private void ClikOnDy(object sender, EventArgs e)
        {

            new DetRdv(Convert.ToInt32(jrslabel.Text)).Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AffichageNbrPatients();
        }
    }
}
