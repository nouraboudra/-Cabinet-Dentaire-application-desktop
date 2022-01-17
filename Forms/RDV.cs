using Dentaire.Forms.Calendrier;
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
using System.Timers;

namespace Dentaire.Forms
{
    public partial class RDV : Form
    {
        public int mois, annee;
        public static int static_mois, static_annee;

        public RDV()
        {
            InitializeComponent();
        }

        private void RDV_Load(object sender, EventArgs e)
        {

            System.Timers.Timer timera = new System.Timers.Timer();
            timera.Interval = 1000;//1s
            timera.Elapsed += Timer_Elapsed;
            timera.Start();
            afficherJours();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {

            if (InvokeRequired)
            {
                circularProgressBar1.Invoke((MethodInvoker)delegate
                {
                    circularProgressBar1.Text = DateTime.Now.ToString("HH:mm:ss");

                });

            }


        }

        private void afficherJours()
        {
            DateTime now = DateTime.Now;
            mois = Convert.ToInt32(now.Month);
            annee = Convert.ToInt32(now.Year);
            static_mois = mois;
            static_annee = annee;
            DateTime debutMois = new DateTime(annee, mois,1);

            string moisString = DateTimeFormatInfo.CurrentInfo.GetMonthName(mois);
            MoisLabel.Text = moisString + " " + annee;

            int nbr_jours = DateTime.DaysInMonth(annee, mois);

            //Jour par entiers
            int joursSemaine = Convert.ToInt32(debutMois.DayOfWeek.ToString("d"))+1;
            for(int i = 1; i < joursSemaine; i++)
            {
                UserControlBlanc ucblank = new UserControlBlanc();
                JoursContainer.Controls.Add(ucblank);
            }

            for(int i=1;i<= nbr_jours; i++)
            {
                UserJours ucdays = new UserJours();
                ucdays.jours(i);
                JoursContainer.Controls.Add(ucdays);

            }

        }

        private void precedent_Click(object sender, EventArgs e)
        {
            mois--;
            static_mois = mois;
            static_annee = annee;
            string moisString = DateTimeFormatInfo.CurrentInfo.GetMonthName(mois);
            MoisLabel.Text = moisString + " " + annee;

            JoursContainer.Controls.Clear();
            DateTime debutMois = new DateTime(annee, mois, 1);

            int nbr_jours = DateTime.DaysInMonth(annee, mois);

            //Jour par entiers
            int joursSemaine = Convert.ToInt32(debutMois.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < joursSemaine; i++)
            {
                UserControlBlanc ucblank = new UserControlBlanc();
                JoursContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= nbr_jours; i++)
            {
                UserJours ucdays = new UserJours();
                ucdays.jours(i);
                ucdays.jour = i;
                JoursContainer.Controls.Add(ucdays);

            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            new Forms.Calendrier.AddRdvForm().Show();
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            mois++;
            static_mois = mois;
            static_annee = annee;
            string moisString = DateTimeFormatInfo.CurrentInfo.GetMonthName(mois);
            MoisLabel.Text = moisString + " " + annee;

            JoursContainer.Controls.Clear();
            DateTime debutMois = new DateTime(annee, mois, 1);

            int nbr_jours = DateTime.DaysInMonth(annee, mois);

            //Jour par entiers
            int joursSemaine = Convert.ToInt32(debutMois.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < joursSemaine; i++)
            {
                UserControlBlanc ucblank = new UserControlBlanc();
                JoursContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= nbr_jours; i++)
            {
                UserJours ucdays = new UserJours();
                ucdays.jours(i);
                JoursContainer.Controls.Add(ucdays);

            }

        }

      
    }
}
