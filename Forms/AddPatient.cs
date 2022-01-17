using Connexion;
using InterfaceDaoImpl;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dentaire.Forms
{
    public partial class AddPatient : Form
    {
        PatientDaoImpl pdao;
        char gender;
        public AddPatient(FormPatients frm)
        {
            InitializeComponent();
            pdao = new PatientDaoImpl();
        }

        private void sex_CheckedChanged(object sender, EventArgs e)
        {
            gender = 'M';
        }



        private void sex2_CheckedChanged(object sender, EventArgs e)
        {
            gender = 'F';
        }

        private void add_patient_Click_1(object sender, EventArgs e)
        {
            DateTime date_naiss = Convert.ToDateTime(date_n.Text);
            Patient p = new Patient(0, nom.Text, prenom.Text, cin.Text, telephone.Text, adresse.Text, gender, date_naiss);
            if (add_patient.Text == "Ajouter")
            {
                if (pdao.add_p(p))
                {
                    MessageBox.Show("bien ajouté");
                    insert();

                }
                else MessageBox.Show("no");
            }
            else
            {
                p.codePatient = FormPatients.idP;
                if (pdao.UpdatePatient(p))
                {
                    insert();
                    MessageBox.Show("bien modifié");
                }
                else MessageBox.Show("no");

            }
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            Patient p = new PatientDaoImpl().getPatientById(FormPatients.idP);
            if (p != null)
            {

                nom.Text = p.nom;
                prenom.Text = p.prenom;
                cin.Text = p.cin;
                telephone.Text = p.telephone;
                adresse.Text = p.adresse;
                date_n.Text = Convert.ToString(p.date_naissance.Date.ToString("yyyy-MM-dd"));
                if (p.sexe == 'M') sex.Checked = true;
                else sex2.Checked = true;
                add_patient.Text = "Modifier";


            }
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        
    }




}
