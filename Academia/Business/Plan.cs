using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{

    public class Plan: BusinessEntity
    {
        string Descripcion { get; set; }
        int IDEspecialidad { get; set; }
    }
}
