//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModeloEDM.ModeloDistribuidora
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacVenta
    {
        public FacVenta()
        {
            this.DetalleFacVenta = new HashSet<DetalleFacVenta>();
        }
    
        public int IdFacVenta { get; set; }
        public int NumFactura { get; set; }
        public string Fecha { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public double SubTotal { get; set; }
        public double IVA { get; set; }
        public double Total { get; set; }
        public double Pago { get; set; }
        public int ClienteIdPersona { get; set; }
    
        public virtual ICollection<DetalleFacVenta> DetalleFacVenta { get; set; }
        public virtual Cliente Cliente1 { get; set; }
    }
}
