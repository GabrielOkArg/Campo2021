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
using CTH.BE;

namespace CTH
{
    public partial class CTH_home : Form
    {
        public CTH_home()
        {
            InitializeComponent();
            IsMdiContainer = true;
            cerrarSesionToolStripMenuItem.Visible = false;
            treeHome.Visible = false;
            ocualtarMenuInicio();
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

        void MostrarPermisos(Usuario u)
        {
            this.treeHome.Nodes.Clear();
            TreeNode root = new TreeNode(u.getUserName);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeHome.Nodes.Add(root);
            this.treeHome.ExpandAll();
            treeHome.Visible = true;
        }

        void LlenarTreeView(TreeNode padre, Componente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }

        }

        public void Validar()
        {
            if (SessionManager.GetInstance != null)
            {

                lbl_usuarioconectado.Text = SessionManager.GetInstance.Usuario.nombre + " " + SessionManager.GetInstance.Usuario.apellido;
                lbl_usuarioconectado.Visible = true;
                iniciarSesionToolStripMenuItem.Visible = false;
                cerrarSesionToolStripMenuItem.Visible = true;
                MostrarPermisos(SessionManager.GetInstance.Usuario);
                ValidarPermisos();
            }
            else
            {
                lbl_usuarioconectado.Text = "";
            }
        }

        private void ValidarPermisos()
        {
            this.InicioSolicitante.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.Solicitante);
            this.inicioAgente.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.Agente);
            this.inicioCoordinador.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.Coordinador);
            this.inicioJefeTecnico.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.JefeTecnico);
            //this.configuracionToolStripMenuItem.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.Administrador);
            this.configuracionToolStripMenuItem.Visible = true;
        }
         private void ocualtarMenuInicio()
        {
            InicioSolicitante.Visible = false;
            inicioAgente.Visible = false;
            inicioCoordinador.Visible = false;
            inicioJefeTecnico.Visible = false;
            configuracionToolStripMenuItem.Visible = false;
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            cerrarSesionToolStripMenuItem.Visible = false;
            iniciarSesionToolStripMenuItem.Visible = true;
            lbl_usuarioconectado.Text = "";
            ocualtarMenuInicio();
        }

        private void lbl_usuarioconectado_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void patentesYFamiliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatentesFamilias frm = new frmPatentesFamilias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            treeHome.Visible = false;
        }

        private void oTNuevasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoordinadornuevas frmCoordinadornuevas = new frmCoordinadornuevas();
            frmCoordinadornuevas.Show();
        }

        private void nuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaOT nuevaOT = new NuevaOT();
            nuevaOT.Show();
        }

        private void misOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitante frmSolicitante = new frmSolicitante();
            frmSolicitante.Show();
        }

        private void oTAsignadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmisOT frmmisOT = new frmmisOT();
            frmmisOT.Show();
        }
    }
}
