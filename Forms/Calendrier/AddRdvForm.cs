using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceDaoImpl;
using Models;

namespace Dentaire.Forms.Calendrier
{
    public partial class AddRdvForm : Form
    {
        
        public AddRdvForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient p = new PatientDaoImpl().getPatientByCin(cin.Text);
            if (p != null)
            {
                int codeP = p.codePatient;
                DateTime date_r = Convert.ToDateTime(date_rdv.Text);
                RendezVous rv = new RendezVous(0, codeP, date_r, heure.Text, objet.Text, FormLogin.CodeUser);
                if (new RdvDaoImpl().Add_rdv(rv))
                {
                    MessageBox.Show("Bien Ajouté");
                }
            }else
            {
                MessageBox.Show("Patient Introuvable");
            }
        }

        
    }
}
