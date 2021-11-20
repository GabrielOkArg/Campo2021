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
    public partial class frmdetallecoordinador : Form
    {
        Orden _orden;
        public frmdetallecoordinador(int id)
        {
            InitializeComponent();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            comboBox1.DisplayMember = "getFullName";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = usuarioBLL.GetAgentes();
            label1.Text += SessionManager.GetInstance.Usuario.getFullName;
            AssitanOT assitanOT = new AssitanOT();
            _orden = assitanOT.GetByIdOrden(id);
            lblfechacreado.Text += _orden.fechaCreacion.ToString();
            lblsolicitante.Text += _orden.solicitante;
            lblsector.Text += _orden.sector;
            lblequipo.Text += "buscar en base";
            txtdescripcion.Text = _orden.descripcion;
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
    }
}
