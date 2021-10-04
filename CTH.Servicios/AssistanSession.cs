using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL;

namespace CTH.Servicios
{
    public class AssistanSession
    {

        private Usuario _usuario_;
        private string _pass_;

        public void GetUsuario(string username, string pass)
        {
            _pass_ = pass;
            MapperUsusario mapperUsusario = new MapperUsusario();
            Usuario usuario = new Usuario(username);
           usuario = mapperUsusario.GetElement(usuario);
            _usuario_= usuario;
        }

        public  void logIn()
        {

            string passMD5 = Encriptacion.GetMD5(_pass_);
            if (passMD5 == _usuario_.pass)
            {
                SessionManager.Login(_usuario_);
            }
        }
    }
}
