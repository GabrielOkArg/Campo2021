using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL;

namespace CTH.BLL
{
    public class AssitanOT
    {


        public int SaveOT(Orden ot)
        {
            mapperOrden mapperOrden = new mapperOrden();

            return mapperOrden.Save(ot);
        }

        public List<Orden> GetByIduser(int id)
        {
            mapperOrden mapperOrden = new mapperOrden();
            return mapperOrden.GetByUser(id);
        }

        public Orden GetByIdOrden(int id)
        {
            mapperOrden mapperOrden = new mapperOrden();
            return mapperOrden.GetOrdenByID(id);
        }

        public List<Orden> Getlibres()
        {
            mapperOrden mapperOrden = new mapperOrden();
            return mapperOrden.GetLibres();
        }
    }
}
