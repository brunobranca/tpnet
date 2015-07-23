using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Data.Database;

namespace UI.Consola
{
    public class Usuarios : Menu
    {
        UsuarioLogic UsuarioNegocio { get; set; }
        public Usuarios() {
            UsuarioNegocio = new UsuarioLogic();
        }
        
        public void Menu()
        {

            UsuarioNegocio.devolverUsuario();


            int opc = 0;
            MostrarMenu();

            opc = int.Parse(Console.ReadLine());
            while (opc != 0)
            {
                switch (opc)
                {
                    case 1:
                        ListadoGeneral();
                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        Agregar();
                        break;
                    case 4:
                        Modificar();
                        break;
                    case 5:
                        Eliminar();
                        break;
                    case 6:
                        break;
                    default:
                        opc = 0;
                        break;
                }
                Console.Clear();
                MostrarMenu();
                opc = int.Parse(Console.ReadLine());
            }
            
            Console.ReadKey();  
        }
        private void ListadoGeneral()
        { }
        private void Consultar()
        { }
        private void Agregar()
        {
            Console.Clear();
            string  usuario = IngresarDato("Usuario: ");

            Console.WriteLine("Nombre: ");
            string nombreUsuario = Console.ReadLine();

            Console.WriteLine("Apellido: ");
            string apellidoUsuario = Console.ReadLine();

            Console.WriteLine("Email: ");
            string emailUsuario = Console.ReadLine();

            Console.WriteLine("Clave: ");
            string claveUsuario = Console.ReadLine();

        
        }
        private void Modificar()
        { }
        private void Eliminar()
        { }
        private void MostrarDatos()
        { }
    }

}
