using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CafeSimple : Cafe
    {

        public override double calcularPrecio()
        {
            return 5.0;
        }

        public override string getDetalle()
        {
            return "Cafe";
        }
    }
}
