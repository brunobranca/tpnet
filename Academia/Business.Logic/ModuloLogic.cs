using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using System.Text.RegularExpressions;


namespace Business.Entity.Logic
{
    public class ModuloLogic
    {
        public void Add(Business.Entity.Modulo Modulo)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                if(!validateDesc (Modulo.Descripcion))
                {
                    throw new Exception();
                }
                modulo oMod ;
                try
                {
                    oMod = new modulo();
                    oMod.desc_modulo = Modulo.Descripcion;

                    context.modulos.Add(oMod);
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    oMod = null;
                }
            }
        }
            
       public void Update (Business.Entity.Modulo Modulo)
        {
           using (AcademiaEntities context = new AcademiaEntities())
           {
               modulo oMod;
               try
               {
                   oMod = FindModulo(context, Modulo);
                   oMod.desc_modulo = Modulo.Descripcion;
                   context.SaveChanges();
               }
               catch (Exception ex)
               {
                   throw ex;
               }
               finally
               {
                   oMod = null;
               }
               
               
           }
       }
           private modulo FindModulo(AcademiaEntities c , Business.Entity.Modulo mod)
           {
               return c.modulos.First(m => m.id_modulo == mod.ID);
           }
        public void Delete (Business.Entity.Modulo Modulo)
           {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                modulo oMod;
                try
                {
                    oMod = FindModulo(context, Modulo);
                    context.modulos.Remove(oMod);

                    context.SaveChanges();

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    oMod = null;
                }
            }
        
           }
        private static bool validateDesc (string st)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9.;:,\- ]");
            Match match = regex.Match(st);
            return !match.Success;

        }
        
             
        }
    

      
    }

