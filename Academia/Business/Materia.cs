using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Materia : BusinessEntity
    {
        string Descripcion { get; set; }
        int HSSemanales { get; set; }
        int HSTotales { get; set; }
        int IDPlan { get; set; }
    }
}
