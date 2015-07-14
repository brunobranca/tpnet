using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Usuario : BusinessEntity
    {
       public string Apellido {get;set;}
       public string Clave { get; set; }
       public string Email { get; set; }
       public bool Habilitado { get; set; }
       public string Nombre { get; set; }
       public string NombreUsuario { get; set; }
 
        public Usuario(string NombreUsuario, string Nombre, string Apellido, string Email, string Clave, bool Habilitado)
       {
            this.NombreUsuario = NombreUsuario;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Clave = Clave;
            this.Habilitado = Habilitado;
       }
    }
}
