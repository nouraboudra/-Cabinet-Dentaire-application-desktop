using InterfaceDaoImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentaire.Forms.Calendrier
{
    public partial class DetRdv : Form
    {
        int jour;
        public DetRdv(int j)
        {
            InitializeComponent();
            jour = j;
        }

        private void DetRdv_Load(object sender, EventArgs e)
        {
            string date_r = RDV.static_annee + "-" + RDV.static_mois + "-" + jour;
            DataTable dt = new RdvDaoImpl().Rvs(date_r);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PatientRv prv = new PatientRv();
                string nom = dt.Rows[i]["nom"].ToString() + " " + dt.Rows[i]["prenom"].ToString();
                string heure = dt.Rows[i]["heure"].ToString();
                prv.loadPatients(nom, heure);
                DateTime dt1 = DateTime.Parse(heure);
                int h_int = Convert.ToInt32(dt1.ToString("HH"));

                if (h_int >= 14)
                {
                    evening.Controls.Add(prv);
                }
                else if (h_int >= 8 && h_int <= 12) morning.Controls.Add(prv);


            }


        }


    }
}
