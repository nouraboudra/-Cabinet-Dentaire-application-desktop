using Dentaire.Forms;
using System.Timers;

namespace Dentaire
{
    public partial class Dashboard : MaterialSkin.Controls.MaterialForm
    {

        //élements 
        private Button current;
        private Form activeForm;
    
        public Dashboard()
        {
            
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
            

        }

                private void ActivateButton(object BtnSender)
                {
                    if (BtnSender != null)
                    {

                    }
                    if (current != (Button)BtnSender )
                    {
                        DisableButton();
                        Color color = ColorTranslator.FromHtml("#5e97f6");
                        current = (Button)BtnSender;
                        current.BackColor=color;


                    }
                }

                private void openChild(Form childForm,object btnSender)
                {
                        Container.Controls.Clear();
                        if (activeForm != null)
                        {
                            activeForm.Close();
                        }
                        ActivateButton(btnSender);
                        activeForm = childForm;
                        childForm.TopLevel = false;
                        childForm.FormBorderStyle = FormBorderStyle.None;
                        childForm.Dock = DockStyle.Fill;
                        Container.Controls.Add(childForm);
                        Container.BringToFront();
                        childForm.Show();

                }


                private void DisableButton()
                {
                    foreach(Control priviousBtn in Controls)
                    {
                        if (priviousBtn.GetType() == typeof(Button))
                        {
                            priviousBtn.BackColor=Color.FromArgb(100, 181, 246);
                           // priviousBtn.ForeColor = Color.White;
                        }
                    }
                }

                       

        private void Close(object sender, FormClosingEventArgs e)
                {
                    Application.Exit();
                }

        private void patient_Click(object sender, EventArgs e)
        {
            openChild(new Forms.FormPatients(), sender);
        }

        private void rdv_Click(object sender, EventArgs e)
        {
            openChild(new Forms.RDV(), sender);
        }

        private void consultation_Click(object sender, EventArgs e)
        {
                openChild(new Forms.consultations(), sender);
        }

        private void certificat_Click(object sender, EventArgs e)
        {
            if (FormLogin.priv)
            {
               openChild(new Forms.certificat(), sender);
            }
            else
            {
                MessageBox.Show("vous n'avez pas l'autorisation d'accèder ");
            }
        }

        private void facture_Click(object sender, EventArgs e)
        {
            openChild(new Forms.factures(), sender);
        }

        private void ordonnance_Click(object sender, EventArgs e)
        {
            if (FormLogin.priv) { 
             openChild(new Forms.FormOrdonnance(), sender);
            }
            else
            {
                MessageBox.Show("vous n'avez pas l'autorisation d'accèder ");
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            FormPatients p = new FormPatients();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Dock = DockStyle.Fill;
            Container.Controls.Add(p);
            p.BringToFront();
            p.Show();
            ;
        }



        //Déconnexion
        private void button8_Click_1(object sender, EventArgs e)
        {
            FormLogin.CodeUser = -1;
            if (FormLogin.CodeUser == -1)
            {
                this.Hide();
                new FormLogin().Show();
            }
        }
    }
}