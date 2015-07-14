using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Consola
{
    class Especialidades : Menu
    {

        public void Menu()
        {


        }

        public void Agregar()
        {
            Console.Clear();
            string descripcion = IngresarDato("Descripcion: ");
        }

    }
}
