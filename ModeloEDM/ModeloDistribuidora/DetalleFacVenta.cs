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
    
    public partial class DetalleFacVenta
    {
        public int IdDetalleVenta { get; set; }
        public int Codigo { get; set; }
        public string DesPro { get; set; }
        public string MarPro { get; set; }
        public double CanPro { get; set; }
        public double PrePro { get; set; }
        public double TotPro { get; set; }
        public int ProductoIdProducto { get; set; }
        public int FacVentaIdFacVenta { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual FacVenta FacVenta { get; set; }
    }
}