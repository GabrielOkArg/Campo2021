using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public class Sector
    {

        public int id { get; set; }
        public string nombre { get; set; }

        public List<Equipo> equipos { get; set; }
    }
}
