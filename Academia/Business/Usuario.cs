using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Usuario : BusinessEntity
    {
       String Apellido {get;set;}
       String Clave    {get;set;}
       String Email    {get;set;}
       bool Habilitado {get;set;}
       String Nombre   {get;set;}
       String NombreUsuario { get; set; }
    }
}
