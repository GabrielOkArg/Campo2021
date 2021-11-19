using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL;

namespace CTH.BLL
{
   public class UsuarioBLL
    {
        MapperUsusario _usuarios;
        public UsuarioBLL()
        {
            _usuarios = new MapperUsusario();
        }
        public void GuardarPermisos(UsuarioView u)
        {
            _usuarios.GuardarPermisos(u);
        }

        public void GuardarPermisos(Usuario u)
        {
            _usuarios.GuardarPermisos(u);
        }
        public List<UsuarioView> GetAll()
        {
            return _usuarios.GetAllS();
        }
    }
}
