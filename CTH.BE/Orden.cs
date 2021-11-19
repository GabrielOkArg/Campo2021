using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public class Orden
    {


        public int id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaFinalizado { get; set; }
        public DateTime fechaCierre { get; set; }
        public string  solicitante { get; set; }
        public string coordinador { get; set; }
        public string agente { get; set; }
        public string descripcion { get; set; }
        public string sector { get; set; }
        public int equipo { get; set; }
        public bool terminada { get; set; }
        public bool finalizada { get; set; }
        public bool cierre { get; set; }
        public string urgencia { get; set; }
        public int id_solicitante { get; set; }
    }
}
