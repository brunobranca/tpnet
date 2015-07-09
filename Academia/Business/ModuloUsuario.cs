using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class ModuloUsuario : BusinessEntity
    {
        int IDMoodulo { get; set; }
        int IDUsuario { get; set; }
        bool PermiteAlta { get; set; }
        bool PermiteBaja { get; set; }
        bool PermiteConsulta { get; set; }
        bool PermiteModificacion { get; set; }
    }
}
