//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class modulo
    {
        public modulo()
        {
            this.modulos_usuarios = new HashSet<modulos_usuarios>();
        }
    
        public int id_modulo { get; set; }
        public string desc_modulo { get; set; }
        public string ejecuta { get; set; }
    
        public virtual ICollection<modulos_usuarios> modulos_usuarios { get; set; }
    }
}