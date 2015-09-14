using Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    public class ModuloUsuario : BusinessEntity
    {
        int IDModulo { get; set; }
        int IDUsuario { get; set; }
        bool PermiteAlta { get; set; }
        bool PermiteBaja { get; set; }
        bool PermiteConsulta { get; set; }
        bool PermiteModificacion { get; set; }
    }
}
