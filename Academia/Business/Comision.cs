using Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    public class Comision : BusinessEntity
    {
        public int AnioEspecialidad { get; set; }
        public int IDPlan { get; set; }
        public string Descripcion { get; set; }
    }
}
