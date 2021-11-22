using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;

namespace CTH.Servicios
{
    public class GlobalEquipo
    {

        private static object _lock = new Object();
        private static GlobalEquipo _equipo;

        public Equipo equipo { get; set; }

        public static GlobalEquipo GetOrden
        {
            get
            {
                try
                {
                    //if (_session == null) throw new FalloLoginException("Sesión no iniciada");

                    return _equipo;
                }
                catch (Exception)
                {
                    throw new FalloLoginException("Sesión no iniciada");

                }
            }
        }

        public static void loadEquipo(Equipo equipo)
        {

            lock (_lock)
            {
                if (_equipo == null)
                {
                    _equipo = new GlobalEquipo();
                    _equipo.equipo = equipo;

                }
            }
        }


        public static void ClearEquipo()
        {
            lock (_lock)
            {
                if (_equipo != null)
                {
                    _equipo = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }


        }

    }
}
}
