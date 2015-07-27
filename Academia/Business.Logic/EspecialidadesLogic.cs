using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadesLogic
    {
        public void Add(Business.Especialidad Especialidad)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                especialidade especialidad;
                try{
                    especialidad = new especialidade();
                    especialidad.desc_especialidad = Especialidad.Descripcion;

                    context.especialidades.Add(especialidad);
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally 
                {
                    especialidad = null;
                }
            }
        }

        public void Update(Business.Especialidad especialidad) 
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                    especialidade oEspecialidad;
                try
                {
                    oEspecialidad = FindEspecialidad(context, especialidad);
                    oEspecialidad.desc_especialidad = especialidad.Descripcion;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    oEspecialidad = null;
                }
            }
        }

        public void Delete(Business.Especialidad especialidad)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                especialidade oEspecialidad;
                try
                {
                    oEspecialidad = FindEspecialidad(context, especialidad);
                    context.especialidades.Remove(oEspecialidad);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    oEspecialidad = null;
                }
            }
        }

        private especialidade FindEspecialidad(AcademiaEntities context, Business.Especialidad esp)
        {

            return context.especialidades.First(e => e.id_especialidad == esp.ID);
        }
    }
}
