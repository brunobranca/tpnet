using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entity;

namespace Business.Entity.Logic
{
    public class EspecialidadesLogic
    {
        public void Add(Especialidad Especialidad)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                especialidade dbEspecialidad;
                try
                {
                    dbEspecialidad = new especialidade();
                    dbEspecialidad.desc_especialidad = Especialidad.Descripcion;

                    context.especialidades.Add(dbEspecialidad);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbEspecialidad = null;
                }
            }
        }

        public void Delete(Especialidad especialidad)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                especialidade dbEspecialidad;
                try
                {
                    dbEspecialidad = FindEspecialidad(context, especialidad);
                    context.especialidades.Remove(dbEspecialidad);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbEspecialidad = null;
                }
            }
        }

        public void Update(Especialidad especialidad)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                especialidade dbEspecialidad;

                try
                {
                    dbEspecialidad = FindEspecialidad(context, especialidad);
                    dbEspecialidad.desc_especialidad = especialidad.Descripcion;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbEspecialidad = null;
                }
            }
        }

        public IList<Especialidad> getList()
        {
            IList<Especialidad> lista = new List<Especialidad>();

            using (AcademiaEntities context = new AcademiaEntities())
            {
                IList<especialidade> listaEspecialidades = context.especialidades.ToList();

                foreach(especialidade esp in listaEspecialidades) 
                {
                    Especialidad especialidad = new Especialidad();
                    especialidad.Descripcion = esp.desc_especialidad;
                    especialidad.ID = esp.id_especialidad;

                    lista.Add(especialidad);
                }
            }

            return lista;
        }

        private especialidade FindEspecialidad(AcademiaEntities context, Especialidad esp)
        {
            return context.especialidades.First(e => e.id_especialidad == esp.ID);
        }
    }
}
