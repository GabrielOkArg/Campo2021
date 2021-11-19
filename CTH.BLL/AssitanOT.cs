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
    }
}
