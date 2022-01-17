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
    public partial class PatientRv : UserControl
    {
        public PatientRv()
        {
            InitializeComponent();
        }

        public void loadPatients(string nom, string heure)
        {
            p.Text = nom;
            h.Text = heure;
        }

        
    }
}
