﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelDistribuidoraContainer : DbContext
    {
        public ModelDistribuidoraContainer()
            : base("name=ModelDistribuidoraContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<FacVenta> FacVentas { get; set; }
        public DbSet<DetalleFacVenta> DetalleFacVentas { get; set; }
        public DbSet<FacCompra> FacCompras { get; set; }
        public DbSet<DetalleFacCompra> DetalleFacCompras { get; set; }
    }
}
