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
    public partial class factures : Form
    {
        FactureDaoImpl fdao;
        public int id;
        DateTime date_f;
        Double prix;
        public factures()
        {
            InitializeComponent();
            fdao = new FactureDaoImpl();
        }

        private void facture_Load(object sender, EventArgs e)
        {
            facture_grid.DataSource = fdao.factures();
        }

        private void facture_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.facture_grid.Rows[e.RowIndex];
                codeC.Text = row.Cells["Code"].Value.ToString();
                id = Convert.ToInt32(row.Cells["Code Patient"].Value.ToString());
                date_f = DateTime.Parse(row.Cells["date"].Value.ToString());
                prix = Convert.ToDouble(row.Cells["prix"].Value.ToString());
            }
        }

        private void add_facture_Click(object sender, EventArgs e)
        {
            if (codeC.Text != "")
            {
                if (fdao.factures(Convert.ToInt32(codeC.Text))== 0)
                {
                    Facture f = new Facture(0, Convert.ToInt32(codeC.Text), float.Parse(prixF.Text), DateTime.Parse(date_consult.Text));
                    if (fdao.add_Facture(f))
                    {
                        MessageBox.Show("bien Ajouté");
                        facture_grid.DataSource = fdao.factures();
                    }
                }
                else MessageBox.Show("Vous avez dèja une facture pour cette consultation");

            }
        }

        private void rehercheFacture_Click(object sender, EventArgs e)
        {
            if (cin_patient.Text != null && date_consult.Text!=null)
            {
                facture_grid.DataSource = fdao.factures(cin_patient.Text);
                DataTable c = new ConsultationDaoImpl().consultations(cin_patient.Text);
                if (c.Rows.Count != 0)
                {
                    codeC.Text = c.Rows[c.Rows.Count - 1]["Code"].ToString();
                    DateTime d = DateTime.UtcNow;
                    date_consult.Text = d.Year + "-" + d.Month + "-" + d.Day;
                }
                else MessageBox.Show("Aucune consultation pour ce patient");

            }
        }

        private void impression_facture_Click(object sender, EventArgs e)
        {
            new FacturePDF(id,date_f, prix).Show();
        }

    
    }
}
