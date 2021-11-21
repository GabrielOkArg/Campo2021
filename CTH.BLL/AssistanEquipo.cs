using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.DAL;
using CTH.BE;
using CTH.Servicios;


namespace CTH.BLL
{
    public class AssistanEquipo
    {


        private mapperEquipo mapperEquipo;
        public AssistanEquipo()
        {
            mapperEquipo = new mapperEquipo();
        }


        public Equipo GetById(int id)
        {
            return mapperEquipo.GetById(id);
        }
    }
}
