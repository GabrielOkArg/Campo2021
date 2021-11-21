using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public class Equipo
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string numeroserie { get; set; }
        public DateTime fechaalta { get; set; }
        public DateTime fechabaja { get; set; }
        public bool estado { get; set; }
        public int id_sector { get; set; }
    }
}
