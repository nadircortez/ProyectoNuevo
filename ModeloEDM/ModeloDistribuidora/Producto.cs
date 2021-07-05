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
    
    public partial class Producto
    {
        public Producto()
        {
            this.DetalleFacCompra = new HashSet<DetalleFacCompra>();
            this.DetalleFacVenta = new HashSet<DetalleFacVenta>();
        }
    
        public int IdProducto { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Presentacion { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public int UPC { get; set; }
        public string Categoria { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public int Cantidad { get; set; }
        public int CategoriaIdCategoria { get; set; }
        public int InventarioIdInventario { get; set; }
    
        public virtual ICollection<DetalleFacCompra> DetalleFacCompra { get; set; }
        public virtual ICollection<DetalleFacVenta> DetalleFacVenta { get; set; }
        public virtual Categoria Categoria1 { get; set; }
        public virtual Inventario Inventario { get; set; }
    }
}
