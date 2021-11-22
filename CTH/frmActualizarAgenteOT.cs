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
            if (_equipo.id == 0)
            {
                btndetalle.Enabled = false;
                grupoEquipo.Enabled = false;
            }
            Console.WriteLine(GlobalOrden.GetOrden.Orden);
            rbAbierta.Checked = !orden.terminada;
            rbokequipo.Checked = equipo.estado;
            rbnookequipo.Checked = !equipo.estado;
            btnterminar.Enabled = false;
            this.Text = "Orden de trabajo n°: " + _orden.id;
            lblid.Text ="Orden n°: " +_orden.id.ToString();
            lblequipo.Text = "Equipo: "+ _equipo.nombre;
            lblsector.Text ="Sector: "+ _orden.sector;
            lblsolicitante.Text ="Solicitante: "+ _orden.solicitante;
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

        private void btnterminar_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            Orden orden = GlobalOrden.GetOrden.Orden;
            orden.terminada = false;
            orden.tiempo += Convert.ToInt32(txthoras.Text);
            orden.comentario_tecnico += rtxtdetalle.Text +"//" + DateTime.Now.ToString() +"//";
            GlobalOrden.ClearOrden();
            GlobalOrden.loadOrden(orden);
            if (_equipo.id != 0)
            {
                _equipo.estado = rbokequipo.Checked == true ? rbokequipo.Checked : rbnookequipo.Checked;
            }
            
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
           
        }

        private void rbTerminada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTerminada.Checked == true)
            {
                btnterminar.Enabled = true;
                btnguardar.Enabled = false;
            }
            else
            {
                btnterminar.Enabled = false;
                btnguardar.Enabled = true;
            }
        }
    }
}
