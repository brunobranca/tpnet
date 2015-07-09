using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Data.Database;

namespace UI.Consola
{
    public class Usuarios
    {
        UsuarioLogic UsuarioNegocio { get; set; }
        public void Menu()
        {
            Class1 c = new Class1();
            c.prueba();
            int opc;
            Console.WriteLine("1-Listado General");
            Console.WriteLine("2-Consulta");
            Console.WriteLine("3-Agregar");
            Console.WriteLine("4-Modificar");
            Console.WriteLine("5-Eliminar");
            Console.WriteLine("6-Salir");
            opc = Console.Read();
            Console.Write(opc);
            Console.ReadKey();
            
        }
        private void ListadoGeneral()
        { }
        private void Consultar()
        { }
        private void Agregar()
        { }
        private void Modificar()
        { }
        private void Eliminar()
        { }
        private void MostrarDatos()
        { }

    }

}
