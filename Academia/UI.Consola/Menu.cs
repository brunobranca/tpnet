using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Consola
{
    public abstract class Menu
    {
        protected void MostrarMenu()
        {
            Console.WriteLine("1-Listado General");
            Console.WriteLine("2-Consulta");
            Console.WriteLine("3-Agregar");
            Console.WriteLine("4-Modificar");
            Console.WriteLine("5-Eliminar");
            Console.WriteLine("6-Salir");
        }

        protected string IngresarDato(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }
    }
}
