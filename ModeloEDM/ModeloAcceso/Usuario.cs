//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModeloEDM.ModeloAcceso
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.AsignacionPermisos = new HashSet<AsignacionPermisos>();
        }
    
        public int Id { get; set; }
        public string Users { get; set; }
        public string Pass { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public decimal Salario { get; set; }
        public string Direccion { get; set; }
        public int Estado { get; set; }
    
        public virtual ICollection<AsignacionPermisos> AsignacionPermisos { get; set; }
    }
}
