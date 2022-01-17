using Dentaire.Forms.impression;
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
    public partial class FormOrdonnance : Form
    {
        PatientDaoImpl patientDao;
        OrdonnanceDaoImpl ordonnanceDao;
        DetOrdonnanceDaoImpl detordDao;
        public static int codeDet;
        public string nomPatient;
        public  string dateOrdonnance;
        public string remarqueO;
     
        public FormOrdonnance()
        {
            InitializeComponent();
            patientDao = new PatientDaoImpl();
            ordonnanceDao = new OrdonnanceDaoImpl();
            detordDao = new DetOrdonnanceDaoImpl();
        }

        //Get data from db
        private void FormOrdonnance_Load(object sender, EventArgs e)
        {
            ords.DataSource = ordonnanceDao.ordonnances();
            detOrds.DataSource = detordDao.getDetOrdonnance();
        }

        private void rehercheOrd_Click(object sender, EventArgs e)
        {
            ords.DataSource = ordonnanceDao.ordonnances(cin_patient.Text);
            if (ords.RowCount >= 1)
            {
                DataTable c = new ConsultationDaoImpl().consultations(cin_patient.Text);
                if (c.Rows.Count != 0)
                {
                    codeConsult.Text = c.Rows[c.Rows.Count - 1]["Code"].ToString();
                    DateTime d = DateTime.UtcNow;
                    date_o.Text = d.Year + "-" + d.Month + "-" + d.Day;
                }
                else MessageBox.Show("Aucune consultation pour ce patient");

            }
        }

        //Séléction d'une ligne
        private void ords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.ords.Rows[e.RowIndex];
                codeConsult.Text = row.Cells["Code Consultation"].Value.ToString();
                codeOrd.Text = row.Cells["Code Ordonnance"].Value.ToString();
                nomPatient = row.Cells["nom"].Value.ToString();
                dateOrdonnance = row.Cells["dateOrd"].Value.ToString();
                remarqueO= row.Cells["remarque"].Value.ToString();
                detOrds.DataSource = detordDao.getDetOrdonnance(Convert.ToInt32(codeOrd.Text));


            }
        }
       
      

        //Button ajouter ordonnance
        private void add_ord_Click(object sender, EventArgs e)
        {
            int codeC = Convert.ToInt32(codeConsult.Text);
            Ordonnance o = new Ordonnance(0, codeC, remarque.Text, DateTime.Parse(date_o.Text));
            if (ordonnanceDao.ordonnances(codeC)== 0)
            {
                if (ordonnanceDao.add_ord(o) == 1)
                {
                    MessageBox.Show("Bien noté");
                    codeConsult.Text = "";
                    codeOrd.Text = "";
                    remarque.Text = "";
                    ords.DataSource = ordonnanceDao.ordonnances(cin_patient.Text);
                }
            }
            else MessageBox.Show("Vous avez dèja une ordonnance pour cette consultation");
            
        }

        //Button supprimer ordonnance
        private void delete_ord_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Confirmer la supression??", "Supprimer Patient", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (ordonnanceDao.DeleteOrd(Convert.ToInt32(codeOrd.Text)))
                {
                    MessageBox.Show("Bien supprimé");
                    detOrds.DataSource = detordDao.getDetOrdonnance();
                    ords.DataSource = ordonnanceDao.ordonnances();

                }
            }
        }


        //Button ajouter Détail Ordonnance

        private void add_det_Click(object sender, EventArgs e)
        {

            int codeO = Convert.ToInt32(codeOrd.Text);
            int qte = Convert.ToInt32(quantite.Text);
            detailsOrdonnance d = new detailsOrdonnance(0, codeO, medicament.Text, qte, utilisation.Text);
            if (detordDao.add_detOrd(d) == 1)
            {
                MessageBox.Show("Bien Ajouté");
                codeConsult.Text = "";
                ords.DataSource = ordonnanceDao.ordonnances();
                detOrds.DataSource = detordDao.getDetOrdonnance();

            }
        }


        //Selection ligne détail
        private void SelectDet(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.detOrds.Rows[e.RowIndex];
                codeDet = Convert.ToInt32(row.Cells["Code"].Value);
            }

        }

        private void supp_det_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Confirmer la supression??", "Supprimer Patient", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (detordDao.delete_detOrd(codeDet) == 1)
                {
                    MessageBox.Show("Bien supprimé");
                    detOrds.DataSource = detordDao.getDetOrdonnance();
                }
            }
        }

        private void imprimerOrd_Click(object sender, EventArgs e)
        {
            if (codeOrd.Text !=""  && detOrds.RowCount>1 )
            {
                new OrdPDF(Convert.ToInt32(codeOrd.Text), nomPatient,remarqueO, dateOrdonnance).Show();

            }else MessageBox.Show("Sélectionner un ordonnance ");
        }

     
    }
}
