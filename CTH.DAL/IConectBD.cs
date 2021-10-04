using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.DAL
{
    interface IConectBD<T>
    {


         T GetElement(T _element);
        List<T> GetAll(T _element);




    }
}
