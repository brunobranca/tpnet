using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Persona : BusinessEntity
    {
        int IDPersona { get; set; }
        string Nombre {get; set;}
        string Apellido { get; set; }
        string Direccion { get; set; }
        string Email { get; set; }
        string Telefono { get; set; }
        DateTime FechaNac { get; set; }
        int Legajo { get; set; }
        int TipoPersona { get; set; }
        int IDPlan { get; set; }
    }
}
