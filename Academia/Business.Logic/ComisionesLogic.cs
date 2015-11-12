using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entity;

namespace Business.Entity.Logic
{
    public class ComisionesLogic
    {
        public void Add(Comision comision)
        {
            using (AcademiaEntities contex = new AcademiaEntities())
            {
                comisione dbComision;
                try
                {
                    dbComision = new comisione();
                    dbComision.desc_comision = comision.Descripcion;

                    contex.comisiones.Add(dbComision);
                    contex.SaveChanges();
                }

                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbComision = null;
                }
            }
        }

        public void Delete(Comision comision)
        {
            using (AcademiaEntities contex = new AcademiaEntities())
            {
                comisione dbComision = new comisione();
                try
                {
                    dbComision = FindComision(contex, comision);
                    contex.comisiones.Remove(dbComision);
                    contex.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbComision = null;
                }
            }

        }

        public void Update(Comision com)
        {
            using (AcademiaEntities contex = new AcademiaEntities())
            {
                comisione dbComision;

                try
                {
                    dbComision = FindComision(contex, com);
                    dbComision.desc_comision = com.Descripcion;
                    contex.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbComision = null;
                }
            }
        }
        private comisione FindComision(AcademiaEntities context, Comision com)
        {
            return context.comisiones.First(c => c.id_comision == com.ID);
        }

        public IList<Comision> GetList()
        {
            IList<Comision> lista = new List<Comision>();

            using (AcademiaEntities context = new AcademiaEntities())
            {
                IList<comisione> listaComisiones = context.comisiones.ToList();

                foreach (comisione c in listaComisiones)
                {
                    Comision comision = new Comision();
                    comision.ID = c.id_comision;
                    comision.Descripcion = c.desc_comision;
                    comision.AnioEspecialidad = c.anio_especialidad;
                    comision.IDPlan = c.id_plan;
                    lista.Add(comision);                    
                }
            }

            return lista;
        }
    }
}
