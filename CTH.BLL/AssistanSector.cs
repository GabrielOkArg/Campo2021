using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL;

namespace CTH.BLL
{
    public class AssistanSector
    {




        public List<Sector> GetAll()
        {
            mapperSector mapperSector = new mapperSector();
            mapperEquipo mapperEquipo = new mapperEquipo();
            List<Sector> listado = mapperSector.GetAll();
            foreach (Sector item in listado)
            {
                item.equipos = mapperEquipo.GetByIdSector(item.id);
            }
            return listado;
           
        }
    }
}
