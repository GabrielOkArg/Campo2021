using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;

namespace CTH.Servicios
{
    public class GlobalOrden
    {
        private static object _lock = new Object();
        private static GlobalOrden _orden;

        public Orden Orden { get; set; }

        public static GlobalOrden GetOrden
        {
            get
            {
                try
                {
                    //if (_session == null) throw new FalloLoginException("Sesión no iniciada");

                    return _orden;
                }
                catch (Exception)
                {
                    throw new FalloLoginException("Sesión no iniciada");

                }
            }
        }

        public static void loadOrden(Orden orden)
        {

            lock (_lock)
            {
                if (_orden == null)
                {
                    _orden = new GlobalOrden();
                    _orden.Orden = orden;
                 
                }
            }
        }


        public static void ClearOrden()
        {
            lock (_lock)
            {
                if (_orden != null)
                {
                    _orden = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }


        }

    }
}
