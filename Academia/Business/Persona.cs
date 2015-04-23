using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Persona
    {
        int IDPersona { get; set; }
        string Nombre {get; set;}
        String Apellido { get; set; }
        String Direccion { get; set; }
        String Email { get; set; }
        String Telefono { get; set; }
        DateTime FechaNac { get; set; }
        int Legajo { get; set; }
        int TipoPersona { get; set; }
        int IDPlan { get; set; }
    }
}
