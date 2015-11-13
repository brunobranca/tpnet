using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entity;

namespace Business.Entity.Logic
{
    public class CursosLogic
    {
        public void Add(Curso curso)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                curso dbCurso;
                try
                {
                    dbCurso = new curso();
                    dbCurso.id_curso = curso.ID;
                    dbCurso.id_materia = curso.IDMateria;
                    dbCurso.id_comision = curso.IDComision;
                    dbCurso.anio_calendario = curso.AnioCalendario;
                    dbCurso.cupo = curso.Cupo;

                    context.cursos.Add(dbCurso);
                    context.SaveChanges();
                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbCurso = null;
                }
            }
        }

        public void Delete(Curso curso)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                curso dbCurso = new curso();
                try
                {
                    dbCurso = FindCurso(context, curso);
                    context.cursos.Remove(dbCurso);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbCurso = null;
                }
            }
        }

        public void Update(Curso cur)
        {
            using (AcademiaEntities contex = new AcademiaEntities())
            {
                curso dbCurso;

                try
                {
                    dbCurso = FindCurso (contex, cur);
                    dbCurso.id_curso = cur.ID;
                    contex.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbCurso = null;
                }
            }
        }

        private curso FindCurso(AcademiaEntities context, Curso cur)
        {
            return context.cursos.First(c => c.id_curso == cur.ID);
        }

        public IList<Curso> GetList()
        {
            IList<Curso> lista = new List<Curso>();

            using (AcademiaEntities context = new AcademiaEntities())
            {
                IList<curso> listaCursos = context.cursos.ToList();

                foreach (curso c in listaCursos)
                {
                    Curso curso = new Curso();
                    curso.ID = c.id_curso;
                    curso.IDMateria = c.id_materia;
                    curso.IDComision = c.id_comision;
                    curso.AnioCalendario = c.anio_calendario;
                    curso.Cupo = c.cupo;
                    lista.Add(curso);
                }
            }

            return lista;
        }
    }
}
