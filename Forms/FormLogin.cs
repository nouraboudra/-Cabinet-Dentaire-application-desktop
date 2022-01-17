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
/*using InterfaceDaoImpl;
using InterfacesDAO;
using Models;*/

namespace Dentaire.Forms
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        public static string? nomUser;
        public static bool priv;
        public static int CodeUser;
        UserDaoImpl udao;
        public FormLogin()
        {
            InitializeComponent();
             udao = new UserDaoImpl();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            User user = udao.login(username.Text, password.Text);
            if (user != null)
            {
                CodeUser = user.CodeUser;
                nomUser = user.nom + " " + user.prenom;
                priv = user.privilege;
                this.Hide();
                new Dashboard().Show();
            }
            else MessageBox.Show("Nom utilisateur et/ou mot de passe incorrect(s)");

        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
  }

        
 

