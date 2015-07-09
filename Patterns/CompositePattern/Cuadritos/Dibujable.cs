using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadritos
{
    abstract class Dibujable
    {
        protected string name;

        public Dibujable(string name)
        {
            this.name = name;
        }

        public abstract void agregar(Dibujable d);
        public abstract void eliminar(Dibujable d);
        public abstract void mostrar();
    }
}
