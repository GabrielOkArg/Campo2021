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
using CTH.Servicios.Enums;

namespace CTH
{
    public partial class NuevaOT : Form
    {
        List<Sector> sectores;
        public NuevaOT()
        {
            InitializeComponent();
            cmbUrgencia.DataSource = Enum.GetValues(typeof(TipoUrgencia));
            AssistanSector sectorBLL = new AssistanSector();
           sectores= sectorBLL.GetAll();
            cmbSector.DisplayMember = "nombre";
            cmbSector.ValueMember = "nombre";

            cmbSector.DataSource = sectores;
            cmbSector.SelectedItem = null;
            cmbSector.SelectedText = "Sectores";
            cmbEquipo.SelectedItem = null;
            cmbEquipo.SelectedText = "Equipos";
        }

        private void cmbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sector sector = (Sector)cmbSector.SelectedItem;
            if (sector!=null)
            {
                if (sector.equipos.Count > 0)
                {
                    cmbEquipo.DisplayMember = "nombre";
                    cmbEquipo.ValueMember = "id";

                    cmbEquipo.DataSource = sector.equipos;
                    cmbEquipo.SelectedItem = null;
                    cmbEquipo.SelectedText = "Equipos";
                }
                else
                {
                    cmbEquipo.DataSource = null;
                    cmbEquipo.SelectedItem = null;
                    cmbEquipo.SelectedText = "Equipos";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Orden orden = new Orden();
            orden.estado = "Abierto";
            orden.solicitante = SessionManager.GetInstance.Usuario.getFullName;
            orden.fechaCreacion = DateTime.Now;
            orden.sector = cmbSector.SelectedValue.ToString();
            orden.equipo = cmbEquipo.SelectedValue == null? 0 : Convert.ToInt32(cmbEquipo.SelectedValue.ToString());//ver cuando es null
            orden.descripcion = txtDescripcion.Text;
            orden.urgencia = cmbUrgencia.SelectedValue.ToString();
            orden.id_solicitante = SessionManager.GetInstance.Usuario.id;
            AssitanOT assitanOT = new AssitanOT();
            int result = assitanOT.SaveOT(orden);
            if ( result >0)
            {
                MessageBox.Show("Orden de traajo guardada bajo el número: "+result.ToString());
            }
            else
            {
                MessageBox.Show("Ocurrio un problema no se pudo guardar la orden de trabajo");
            }
        }
    }
}
