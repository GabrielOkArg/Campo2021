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
   
    public partial class frmSolicitante : Form
    {
     

        public frmSolicitante()
        {
            InitializeComponent();
            AssitanOT assitanOT = new AssitanOT();
            dgvsolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsolicitudes.DataSource = assitanOT.GetByIduser(SessionManager.GetInstance.Usuario.id);
            dgvsolicitudes.DataSource = assitanOT.GetByIduser(SessionManager.GetInstance.Usuario.id).Select(o => new
            {
                ID = o.id,
                Creado = o.fechaCreacion,
                Sector = o.sector,
                Urgencia = o.urgencia,
                Estado = o.estado
            }
            ).ToList();
        }

        private void dgvsolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Orden orden= (Orden)dgvsolicitudes.SelectedRows[0].DataBoundItem;
            //Console.WriteLine(orden);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvsolicitudes.SelectedRows[0].Cells[0].Value.ToString());
            frmDetalleSolicitante frmDetalleSolicitante = new frmDetalleSolicitante(id);
            frmDetalleSolicitante.Show();


        }

     
    }
}
