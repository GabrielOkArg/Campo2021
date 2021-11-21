using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTH.BE;
using CTH.BLL;
using CTH.Servicios; 

namespace CTH
{
    public partial class frmActualizarAgenteOT : Form
    {

        Orden _orden;
        Equipo _equipo;
        public frmActualizarAgenteOT(Orden orden, Equipo equipo)
        {
            InitializeComponent();
            _equipo = equipo;
            _orden = orden;
            rbAbierta.Checked = !orden.terminada;
            btnterminar.Enabled = false;
            this.Text = "Orden de trabajo n°: " + _orden.id;
            lblid.Text = _orden.id.ToString();
            lblequipo.Text = _equipo.nombre;
            lblsector.Text = _orden.sector;
            lblsolicitante.Text = _orden.solicitante;
            lblurgencia.Text = _orden.urgencia;
            switch (_orden.urgencia)
            {
                case "Baja":
                    lblurgencia.BackColor = Color.Green;
                    break;
                case "Media":
                    lblurgencia.BackColor = Color.Yellow;
                    break;
                case "Alta":
                    lblurgencia.BackColor = Color.Orange;
                    break;
                case "Critica":
                    lblurgencia.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void btndetalleot_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_orden.descripcion, "informacion de orden de trabajo", MessageBoxButtons.OK);
        }
    }
}
