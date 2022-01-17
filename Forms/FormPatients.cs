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

namespace Dentaire.Forms
{
    public partial class FormPatients : Form
    {
        public static int idP=-1;
        public FormPatients()
        {
            InitializeComponent();
       

        }

     

        private void search_Click(object sender, EventArgs e)
        {
             if(value.Text!=null && col.SelectedText != null)
             {
                 dataPatients.DataSource = new PatientDaoImpl().patients(value.Text, col.GetItemText(col.SelectedItem));
             }
         
        }

        private void dataPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataPatients.Rows[e.RowIndex];
                idP = Convert.ToInt32(row.Cells["Code"].Value);
                
            }else
            {
                MessageBox.Show("Isa");
            }

        }

     

        private void edit_Click(object sender, EventArgs e)
        {
            if (idP != -1)
            {
                AddPatient add= new AddPatient(this);
                add.UpdateEventHandler += AddPatient_UpdateEventHandler;
                add.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selectionner un patient");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idP = -1;
            if (idP == -1)
            {
                AddPatient add = new AddPatient(this);
                add.UpdateEventHandler += AddPatient_UpdateEventHandler;
                add.ShowDialog();
            }
           
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {

            dataPatients.DataSource = new PatientDaoImpl().patients();
        }

       
        //Refresh Form
        private void AddPatient_UpdateEventHandler(object sender,AddPatient.UpdateEventArgs args)
        {
            dataPatients.DataSource = new PatientDaoImpl().patients();
        }
    }
}
