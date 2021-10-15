﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;

namespace CTH.Servicios
{
    public class SessionManager
    {
        private static object _lock = new Object();
        private static SessionManager _session;

        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        public static SessionManager GetInstance
        {
            get
            {
                try
                {
                    //if (_session == null) throw new FalloLoginException("Sesión no iniciada");

                    return _session;
                }
                catch (Exception)
                {
                    throw new FalloLoginException("Sesión no iniciada");

                }
            }
        }

        public static void Login(Usuario usuario)
        {

            lock (_lock)
            {
                if (_session == null)
                {
                    _session = new SessionManager();
                    _session.Usuario = usuario;
                    _session.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }


        }

        private SessionManager()
        {

        }

    }
}
