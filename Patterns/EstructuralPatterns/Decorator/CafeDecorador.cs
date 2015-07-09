using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CafeDecorador : Cafe
    {

        protected double Precio {get;set;}
        protected string Detalle { get; set; }
        Cafe CafeBase { get; set; }

        public CafeDecorador(Cafe cafeBase)
        {
            CafeBase = cafeBase;
        }
        public override double calcularPrecio()
        {
            return CafeBase.calcularPrecio() + Precio;
        }

        public override string getDetalle()
        {
            return CafeBase.getDetalle() + ", " + Detalle;
        }

    }
}
