using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Usuario : BusinessEntity
    {
       string Apellido {get;set;}
       string Clave    {get;set;}
       string Email    {get;set;}
       bool Habilitado {get;set;}
       string Nombre   {get;set;}
       string NombreUsuario { get; set; }
    }
}
