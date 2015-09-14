using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entity;
using Data.Database;
using System.Data;


namespace Business.Entity.Logic
{
    public class UsuarioLogic : BusinessLogic
    {

        public void devolverUsuario()
        {
            using (var ctx = new AcademiaEntities())
            {
                try
                {
                    
                    Console.WriteLine((ctx.especialidades.First<Data.Database.especialidade>()).desc_especialidad);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                }

        }


    }
}
