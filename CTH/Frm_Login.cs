using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTH.BLL;

namespace CTH
{
    public partial class Frm_Login : Form
    {

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            AssistanSession assistanSession = new AssistanSession();
            assistanSession.GetUsuario(txtUsuario.Text, txtContra.Text);
            assistanSession.logIn();
            CTH_home cTH_Home = (CTH_home)this.MdiParent;
            cTH_Home.Validar();
            this.Close();
            this.Close();
        }
    }
}
