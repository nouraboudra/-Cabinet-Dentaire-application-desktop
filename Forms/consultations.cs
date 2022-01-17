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
    public partial class consultations : Form
    {
        ConsultationDaoImpl cdao;
        InterventionDaoImpl idao;
        int idI;

        public consultations()
        {
            InitializeComponent();
            cdao = new ConsultationDaoImpl();
            idao = new InterventionDaoImpl();
        }

        private void consultations_Load(object sender, EventArgs e)
        {
            consults_grid.DataSource = cdao.consultations();
            intervs_grid.DataSource = idao.inteventions();
        }

        private void rehercheOrd_Click(object sender, EventArgs e)
        {

            if (cin_patient.Text != "")
            {

              consults_grid.DataSource = cdao.consultations(cin_patient.Text);
            }

            


        }

        private void add_ord_Click(object sender, EventArgs e)
        {
            if (cin_patient.Text != "" && date_consult.Text != "")
            {
                Patient p = new PatientDaoImpl().getPatientByCin(cin_patient.Text);

                if (p != null)
                {
                    Consultation c = new Consultation(0, p.codePatient, DateTime.Parse(date_consult.Text));
                    if (cdao.Add_consultation(c))
                    {
                        MessageBox.Show("Bien ajouté");
                        consults_grid.DataSource = cdao.consultations();
                    }
                }
                else MessageBox.Show("patient Introuvable");
            }
        }

        private void consults_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.consults_grid.Rows[e.RowIndex];
                codeConsult.Text = row.Cells["Code"].Value.ToString();
                 intervs_grid.DataSource = idao.inteventions(Convert.ToInt32(codeConsult.Text));
            }
        }

        private void delete_Consult_Click(object sender, EventArgs e)
        {
            if (codeConsult.Text !=null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Confirmer la supression??", "Supprimer Consultation", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    if (cdao.delete_Consultation(Convert.ToInt32(codeConsult.Text)))
                    {
                        MessageBox.Show("bien supprimé");
                        codeConsult.Text = "";
                        consults_grid.DataSource = cdao.consultations();
                    }
                    
                }
            }
        }

        private void add_det_Click(object sender, EventArgs e)
        {
            if (codeConsult.Text != "")
            {
                Intervention i = new Intervention(0, Convert.ToInt32(codeConsult.Text), Convert.ToInt32(dent.Text), inter.Text);
                if (idao.Add_Intervention(i))
                {
                    MessageBox.Show("bien ajouté");
                    intervs_grid.DataSource = idao.inteventions();
                }else MessageBox.Show("erreur");
            }
        }

        private void intervs_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.consults_grid.Rows[e.RowIndex];
                idI =Convert.ToInt32(row.Cells["Code"].Value.ToString());
                
            }
        }

        private void supp_inter_Click(object sender, EventArgs e)
        {
            if (idI != -1)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("vous êtes sure??", "Supprimer Consultation", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    if (idao.delete_Intervention(idI))
                    {
                        intervs_grid.DataSource = idao.inteventions();
                    }

                }
            }
        }
    }
}
