using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    class Curso : BusinessEntity
    {
        int AnioCalendario { get; set; }
        int Cupo { get; set; }
        string Descripcion { get; set; }
        int IDComision { get; set; }
        int IDMateria { get; set; }
    }
}
