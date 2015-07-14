using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {

        DBOUsuario dboUsuario { get; set; }

        public UsuarioLogic()
        {
            dboUsuario = new DBOUsuario();
        }

        public void CrearUsuario(string usuario, string nombreUsuario, string apellidoUsuario, string emailUsuario, string claveUsuario)
        {
            Usuario nuevoUsuario = new Business.Usuario(usuario, nombreUsuario, apellidoUsuario, emailUsuario, claveUsuario, false);
            dboUsuario.guardar(nuevoUsuario);
        }
    }
}
