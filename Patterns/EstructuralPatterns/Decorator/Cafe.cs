using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Cafe
    {
        public abstract double calcularPrecio();

        public abstract string getDetalle();
    }
}
