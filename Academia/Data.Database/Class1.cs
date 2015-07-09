using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Class1
    {
        public void prueba()
        {
            try
            {

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(sCnn);
                con.Open();
                System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
                comando.Connection = con;
                comando.CommandText = "SELECT count (*) FROM dbo.materias";
                int Cant = Convert.ToInt32(comando.ExecuteScalar());
                con.Close();
                Console.WriteLine("Cantidad de registros: " + Cant.ToString());
            }
            catch(Exception e)
            {
               Console.WriteLine( e.StackTrace);
                    
            }
        }
        string sCnn = "data source = BRUNO-PC\\SQLEXPRESS;" + "initial catalog = Academia; User ID = SA; Password = bruno";

    }
}
