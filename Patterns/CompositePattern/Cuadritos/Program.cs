using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadritos
{
    class Program
    {
        static void Main(string[] args)
        {

            Dibujable cuadro = new Cuadro("Mi obra de arte");

            Dibujable casa = new Figura("casa");

            Dibujable flor = new Figura("mi flor amarilla");

            cuadro.agregar(casa);
            cuadro.agregar(flor);

            cuadro.mostrar();

            Console.ReadKey();

        }
    }
}
