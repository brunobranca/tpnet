using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data.Database
{
    class DBO
    {
        private static const string CONNECTION_STRING = "data source = BRUNO-PC\\SQLEXPRESS;" + "initial catalog = Academia; User ID = SA; Password = bruno";
        protected SqlConnection OpenConnection() {
            SqlConnection conn = null;
            
            try{
                conn = new SqlConnection();
                conn.Open();
            } catch(SqlException cause) {
                Console.WriteLine("Error abriendo conexion: " + cause.StackTrace);
            }
            return conn;
        }

    }
}
