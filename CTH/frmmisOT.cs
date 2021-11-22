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
    
    public partial class frmmisOT : Form
    {
        Orden _orden;
        Equipo _equipo;
        AssitanOT assitanOT;
        public frmmisOT()
        {
            InitializeComponent();
             assitanOT = new AssitanOT();
            dgvot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvot.DataSource = assitanOT.getByAgente(SessionManager.GetInstance.Usuario.id);
            List<Orden> listado = new List<Orden>();
            foreach (Orden item in assitanOT.getByAgente(SessionManager.GetInstance.Usuario.id))
            {
                if (item.terminada == false)
                {
                    listado.Add(item);
                }
            }
            dgvot.DataSource = listado;
            btnActualizar.Enabled = false;
        }

        private void dgvot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            //arreglar concatenaciones
            _orden = (Orden)dgvot.SelectedRows[0].DataBoundItem;
            _orden = assitanOT.GetByIdOrden(_orden.id);
            GlobalOrden.loadOrden(_orden);
            _equipo = new Equipo();
            if (_orden.equipo !=0)
            {
                AssistanEquipo equipo = new AssistanEquipo();
                _equipo = equipo.GetById(_orden.equipo);
                GlobalEquipo.loadEquipo(equipo.GetById(_orden.equipo));
                List<Equipo> equipos = new List<Equipo>();
                equipos.Add(_equipo);
                dgvequipo.DataSource = equipos;
            }
            else
            {
                dgvequipo.DataSource = null;
            }
            lblsector.Text = "Sector: "+ _orden.sector;
            lblfechasolicitud.Text ="Solicitado"+ _orden.fechaCreacion.ToString("dd/MM/yyyy");
            lblcoordinador.Text ="Coordinador: "+ _orden.coordinador;
            lblurgencia.Text = _orden.urgencia;
            txtdetalle.Text = _orden.descripcion;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarAgenteOT frmActualizarAgenteOT = new frmActualizarAgenteOT(_orden,_equipo);
            frmActualizarAgenteOT.Show();
        }
    }
}
