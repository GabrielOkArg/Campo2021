using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTH.Servicios;

namespace CTH
{
    public partial class CTH_home : Form
    {
        public CTH_home()
        {
            InitializeComponent();
            IsMdiContainer = true;
            cerrarSesionToolStripMenuItem.Visible = false;
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.MdiParent = this;
            frm_Login.Show();
        }

        private void CTH_home_Load(object sender, EventArgs e)
        {
            
        }

        public void Validar()
        {
            if (SessionManager.GetInstance != null)
            {

                lbl_usuarioconectado.Text = SessionManager.GetInstance.Usuario.nombre + " " + SessionManager.GetInstance.Usuario.apellido;
                lbl_usuarioconectado.Visible = true;
                iniciarSesionToolStripMenuItem.Visible = false;
                cerrarSesionToolStripMenuItem.Visible = true;
            }
            else
            {
                lbl_usuarioconectado.Text = "";
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            cerrarSesionToolStripMenuItem.Visible = false;
            iniciarSesionToolStripMenuItem.Visible = true;
            lbl_usuarioconectado.Text = "";
        }

        private void lbl_usuarioconectado_Click(object sender, EventArgs e)
        {

        }
    }
}
