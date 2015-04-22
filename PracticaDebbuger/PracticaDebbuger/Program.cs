using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDebbuger
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            Console.WriteLine("La Suma es: " + o.Suma());
            Console.WriteLine("La Resta es: " + o.Resta());
            Console.WriteLine("El Producto es: " + o.Producto());
            Console.WriteLine("El Cociente es: " + o.Division());
            Console.ReadKey();
        }
    }
}
