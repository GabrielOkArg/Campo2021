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
    public partial class frmCoordinadornuevas : Form
    {
        public frmCoordinadornuevas()
        {
            InitializeComponent();
            AssitanOT assitanOT = new AssitanOT();
            dgvnuevas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgvnuevas.DataSource = assitanOT.Getlibres().Select(o => new
            {
                ID = o.id,
                Creado = o.fechaCreacion,
                Sector = o.sector,
                Urgencia = o.urgencia,
                Estado = o.estado
            }
            ).ToList();
            
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            int orden = Convert.ToInt32(dgvnuevas.SelectedRows[0].Cells[0].Value.ToString());
            frmdetallecoordinador frmdetallecoordinador = new frmdetallecoordinador(orden);
            frmdetallecoordinador.Show();
        }
    }
}
