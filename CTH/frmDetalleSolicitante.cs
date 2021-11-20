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
    public partial class frmDetalleSolicitante : Form
    {

        Orden Orden;
        public frmDetalleSolicitante(int id)
        {
            InitializeComponent();
            AssitanOT assitanOT = new AssitanOT();

            Orden = assitanOT.GetByIdOrden(id);
            loadDatos();
        }



        public void loadDatos()
        {
            lblfechaalta.Text = Orden.fechaCreacion.ToString();
            lblestado.Text += Orden.estado;
        }
    }
}
