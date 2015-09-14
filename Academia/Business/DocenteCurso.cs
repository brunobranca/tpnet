using Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    class DocenteCurso : BusinessEntity
    {
        int IDCurso { get; set; }
        int IDDocente { get; set; }

    }
}
