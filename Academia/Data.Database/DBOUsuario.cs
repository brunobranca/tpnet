using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using System.Data.SqlClient;

namespace Data.Database
{
    class DBOUsuario : DBO
    {
        private static const string AGREGAR_USUARIO = "insert into dbo.usuario values (";


        public Usuario guardar(Usuario usuario)
        {

            SqlConnection conn = OpenConnection();

            SqlCommand command = conn.CreateCommand();

            command.CommandText = AGREGAR_USUARIO + usuario.NombreUsuario + ", " + usuario.Clave + ", " + usuario.Habilitado.ToString() + ", " + usuario.Nombre + ", " + usuario.Apellido + ", " + usuario.Email + ")";

            command.ExecuteNonQuery();

            return null;
        }

    }
}
