using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Leche : CafeDecorador
    {
        public Leche(Cafe cafeBase) : base(cafeBase) 
        {
            this.Detalle = "leche";
            this.Precio = 3.0;
        }
    }
}
