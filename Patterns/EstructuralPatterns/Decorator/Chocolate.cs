using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Chocolate : CafeDecorador
    {
        public Chocolate(Cafe cafeBase)
            : base(cafeBase)
        {
            this.Detalle = "chocolate";
            this.Precio = 5.0;
        }
    }
}
