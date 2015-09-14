using Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    class Comision : BusinessEntity
    {
        int AnioEspecialidad { get; set; }
        int IDPlan { get; set; }
        string Descripcion { get; set; }
    }
}
