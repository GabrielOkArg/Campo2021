using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL;
using CTH.Servicios;

namespace CTH.BLL
{
   public  class AssistanSession
    {

        private Usuario _usuario_;
        private string _pass_;
        AssistanPermisos _assistanPermisos;
        public AssistanSession()
        {
            _assistanPermisos = new AssistanPermisos();
        }
        public void GetUsuario(string username, string pass)
        {
            _pass_ = pass;
            MapperUsusario mapperUsusario = new MapperUsusario();
            Usuario usuario = new Usuario(username);
            usuario = mapperUsusario.GetElement(usuario);
            _usuario_ = usuario;
        }

        public void logIn()
        {

            try
            {
                string passMD5 = Encriptacion.GetMD5(_pass_);
                if (_usuario_ != null)
                {
                    if (passMD5 == _usuario_.pass)
                    {

                        SessionManager.Login(_usuario_);
                        _assistanPermisos.FillUserComponents(SessionManager.GetInstance.Usuario);
                    }
                }else
                {
                    throw new FalloLoginException("Usuario o Contraseña incorrecto");
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
