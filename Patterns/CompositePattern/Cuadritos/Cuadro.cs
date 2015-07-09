using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadritos
{
    class Cuadro : Dibujable
    {

        private List<Dibujable> figuras = new List<Dibujable>();

        public Cuadro(string name)
            : base(name)
        {
        }

        public override void agregar(Dibujable d)
        {
            this.figuras.Add(d);
        }

        public override void eliminar(Dibujable d)
        {
            this.figuras.Remove(d);
        }

        public override void mostrar()
        {
            Console.Out.WriteLine("Cuadro " + "con:");

            foreach (Dibujable d in figuras)
            {
                d.mostrar();
            }
        }
    }
}
