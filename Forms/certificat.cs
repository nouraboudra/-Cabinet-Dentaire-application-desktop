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
    public partial class certificat : Form
    {
        CertificatDaoImpl certificatDao;
        string nom;
        public certificat()
        {
            InitializeComponent();
            certificatDao = new CertificatDaoImpl();
        }

        private void certificat_Load(object sender, EventArgs e)
        {
            certficat_grid.DataSource = certificatDao.certificats();
        }

     

        private void rehercheCertificat_Click(object sender, EventArgs e)
        {
            if(cin_patient.Text != "")
            {
                certficat_grid.DataSource = certificatDao.certificats(cin_patient.Text );
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

       
        private void certficat_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.certficat_grid.Rows[e.RowIndex];
                codeC.Text = row.Cells["Code"].Value.ToString();
                nom =row.Cells["nom"].Value.ToString();
            }

        }

        private void impression_certificat_Click(object sender, EventArgs e)
        {
            if(nom!="" && certficat_grid.RowCount > 1)
            {
                new CertficatPDF(nom).Show();
            }else
            {
                MessageBox.Show("Sélctionner un certificat");
            }
           
        }


        private void add_certi_Click(object sender, EventArgs e)
        {
            if (codeC.Text != "" && cin_patient.Text!="")
            {
                if (certificatDao.certificats(Convert.ToInt32(codeC.Text))==0) {
                    Certificat c = new Certificat(0, Convert.ToInt32(codeC.Text), DateTime.Parse(date_consult.Text));
                    if (certificatDao.add_Certificat(c))
                    {
                        MessageBox.Show("Bien ajouté");
                        certficat_grid.DataSource = certificatDao.certificats();
                    }
                    else
                    {
                        MessageBox.Show("erreur");
                    }
                }
                else MessageBox.Show("Vous avez dèja un certificat pour cette consultation");

            }
        }
    }
}
