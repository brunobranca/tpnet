using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadritos
{
    class Figura : Dibujable
    {
        public Figura(string nombre)
            : base(nombre)
        {
        }

        public override void agregar(Dibujable d)
        {
            Console.Out.WriteLine("No se puede agregar a una figura");
        }

        public override void eliminar(Dibujable d)
        {
            Console.Out.WriteLine("No se puede eliminar de una figura");
        }

        public override void mostrar()
        {
            Console.Out.WriteLine("*" + name);
        }
    }
}
