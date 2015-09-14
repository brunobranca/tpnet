using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    class AlumnoInscripcion : BusinessEntity
    {
        string Condicion { get; set; }
        int IDAlumno { get; set; }
        int IDCurso { get; set; }
        int Nota { get; set; }
        
    }
}
