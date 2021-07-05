
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/02/2021 21:52:57
-- Generated from EDMX file: C:\Users\Ligia\source\repos\ProyectoPracticas\ModeloEDM\ModeloDistribuidora\ModelDistribuidora.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DistribuidoraBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [IdPersona] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(5)  NOT NULL,
    [PrimerNombre] char(15)  NOT NULL,
    [SegundoNombre] char(15)  NOT NULL,
    [PrimerApellido] char(15)  NOT NULL,
    [SegundoApellido] char(15)  NOT NULL,
    [Telefono] char(10)  NOT NULL,
    [Genero] char(10)  NOT NULL,
    [Correo] char(20)  NOT NULL,
    [Direccion] char(50)  NOT NULL
);
GO

-- Creating table 'Proveedores'
CREATE TABLE [dbo].[Proveedores] (
    [IProveedor] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(5)  NOT NULL,
    [Nombre] char(15)  NOT NULL,
    [RazonSocial] char(20)  NOT NULL,
    [Ruc] char(20)  NOT NULL,
    [Telefono] char(10)  NOT NULL,
    [Correo] char(20)  NOT NULL,
    [Direccion] char(50)  NOT NULL
);
GO

-- Creating table 'Productos'
CREATE TABLE [dbo].[Productos] (
    [IdProducto] int IDENTITY(1,1) NOT NULL,
    [Codigo] int  NOT NULL,
    [Descripcion] char(30)  NOT NULL,
    [Marca] char(20)  NOT NULL,
    [Presentacion] char(20)  NOT NULL,
    [Costo] float  NOT NULL,
    [Precio] float  NOT NULL,
    [UPC] int  NOT NULL,
    [Categoria] char(20)  NOT NULL,
    [Minimo] int  NOT NULL,
    [Maximo] int  NOT NULL,
    [Cantidad] int  NOT NULL,
    [CategoriaIdCategoria] int  NOT NULL,
    [InventarioIdInventario] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [IdCategoria] int IDENTITY(1,1) NOT NULL,
    [Codigo] int  NOT NULL,
    [Descripcion] char(20)  NOT NULL
);
GO

-- Creating table 'Inventarios'
CREATE TABLE [dbo].[Inventarios] (
    [IdInventario] int IDENTITY(1,1) NOT NULL,
    [Codigo] int  NOT NULL,
    [Descripcion] char(30)  NOT NULL,
    [Fecha] datetime  NOT NULL
);
GO

-- Creating table 'FacVentas'
CREATE TABLE [dbo].[FacVentas] (
    [IdFacVenta] int IDENTITY(1,1) NOT NULL,
    [NumFactura] int  NOT NULL,
    [Fecha] char(15)  NOT NULL,
    [Ruc] char(20)  NOT NULL,
    [Cliente] char(30)  NOT NULL,
    [Vendedor] char(30)  NOT NULL,
    [SubTotal] float  NOT NULL,
    [IVA] float  NOT NULL,
    [Total] float  NOT NULL,
    [Pago] float  NOT NULL,
    [ClienteIdPersona] int  NOT NULL
);
GO

-- Creating table 'DetalleFacVentas'
CREATE TABLE [dbo].[DetalleFacVentas] (
    [IdDetalleVenta] int IDENTITY(1,1) NOT NULL,
    [Codigo] int  NOT NULL,
    [DesPro] char(15)  NOT NULL,
    [MarPro] char(15)  NOT NULL,
    [CanPro] float  NOT NULL,
    [PrePro] float  NOT NULL,
    [TotPro] float  NOT NULL,
    [ProductoIdProducto] int  NOT NULL,
    [FacVentaIdFacVenta] int  NOT NULL
);
GO

-- Creating table 'FacCompras'
CREATE TABLE [dbo].[FacCompras] (
    [IdFacCompra] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Codigo] int  NOT NULL,
    [NumFactura] char(15)  NOT NULL,
    [SubTotal] float  NOT NULL,
    [IVA] float  NOT NULL,
    [Total] float  NOT NULL,
    [ProveedorIProveedor] int  NOT NULL,
    [EmpleadoIdPersona] int  NOT NULL
);
GO

-- Creating table 'DetalleFacCompras'
CREATE TABLE [dbo].[DetalleFacCompras] (
    [IdDetalleCompra] int IDENTITY(1,1) NOT NULL,
    [CodPro] int  NOT NULL,
    [DesPro] char(30)  NOT NULL,
    [MarPro] char(30)  NOT NULL,
    [CanPro] float  NOT NULL,
    [PrecPro] float  NOT NULL,
    [TotalPro] float  NOT NULL,
    [FacCompraIdFacCompra] int  NOT NULL,
    [ProductoIdProducto] int  NOT NULL
);
GO

-- Creating table 'Personas_Cliente'
CREATE TABLE [dbo].[Personas_Cliente] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Ruc] nchar(20)  NOT NULL,
    [IdPersona] int  NOT NULL
);
GO

-- Creating table 'Personas_Empleado'
CREATE TABLE [dbo].[Personas_Empleado] (
    [IdEmplado] int IDENTITY(1,1) NOT NULL,
    [Inss] char(10)  NOT NULL,
    [Cargo] char(20)  NOT NULL,
    [Carnet] char(10)  NOT NULL,
    [FecIngreso] datetime  NOT NULL,
    [IdPersona] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPersona] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IProveedor] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [PK_Proveedores]
    PRIMARY KEY CLUSTERED ([IProveedor] ASC);
GO

-- Creating primary key on [IdProducto] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [PK_Productos]
    PRIMARY KEY CLUSTERED ([IdProducto] ASC);
GO

-- Creating primary key on [IdCategoria] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
GO

-- Creating primary key on [IdInventario] in table 'Inventarios'
ALTER TABLE [dbo].[Inventarios]
ADD CONSTRAINT [PK_Inventarios]
    PRIMARY KEY CLUSTERED ([IdInventario] ASC);
GO

-- Creating primary key on [IdFacVenta] in table 'FacVentas'
ALTER TABLE [dbo].[FacVentas]
ADD CONSTRAINT [PK_FacVentas]
    PRIMARY KEY CLUSTERED ([IdFacVenta] ASC);
GO

-- Creating primary key on [IdDetalleVenta] in table 'DetalleFacVentas'
ALTER TABLE [dbo].[DetalleFacVentas]
ADD CONSTRAINT [PK_DetalleFacVentas]
    PRIMARY KEY CLUSTERED ([IdDetalleVenta] ASC);
GO

-- Creating primary key on [IdFacCompra] in table 'FacCompras'
ALTER TABLE [dbo].[FacCompras]
ADD CONSTRAINT [PK_FacCompras]
    PRIMARY KEY CLUSTERED ([IdFacCompra] ASC);
GO

-- Creating primary key on [IdDetalleCompra] in table 'DetalleFacCompras'
ALTER TABLE [dbo].[DetalleFacCompras]
ADD CONSTRAINT [PK_DetalleFacCompras]
    PRIMARY KEY CLUSTERED ([IdDetalleCompra] ASC);
GO

-- Creating primary key on [IdPersona] in table 'Personas_Cliente'
ALTER TABLE [dbo].[Personas_Cliente]
ADD CONSTRAINT [PK_Personas_Cliente]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IdPersona] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [PK_Personas_Empleado]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProveedorIProveedor] in table 'FacCompras'
ALTER TABLE [dbo].[FacCompras]
ADD CONSTRAINT [FK_ProveedorFacCompra]
    FOREIGN KEY ([ProveedorIProveedor])
    REFERENCES [dbo].[Proveedores]
        ([IProveedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorFacCompra'
CREATE INDEX [IX_FK_ProveedorFacCompra]
ON [dbo].[FacCompras]
    ([ProveedorIProveedor]);
GO

-- Creating foreign key on [FacCompraIdFacCompra] in table 'DetalleFacCompras'
ALTER TABLE [dbo].[DetalleFacCompras]
ADD CONSTRAINT [FK_FacCompraDetalleFacCompra]
    FOREIGN KEY ([FacCompraIdFacCompra])
    REFERENCES [dbo].[FacCompras]
        ([IdFacCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacCompraDetalleFacCompra'
CREATE INDEX [IX_FK_FacCompraDetalleFacCompra]
ON [dbo].[DetalleFacCompras]
    ([FacCompraIdFacCompra]);
GO

-- Creating foreign key on [ProductoIdProducto] in table 'DetalleFacCompras'
ALTER TABLE [dbo].[DetalleFacCompras]
ADD CONSTRAINT [FK_ProductoDetalleFacCompra]
    FOREIGN KEY ([ProductoIdProducto])
    REFERENCES [dbo].[Productos]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoDetalleFacCompra'
CREATE INDEX [IX_FK_ProductoDetalleFacCompra]
ON [dbo].[DetalleFacCompras]
    ([ProductoIdProducto]);
GO

-- Creating foreign key on [ProductoIdProducto] in table 'DetalleFacVentas'
ALTER TABLE [dbo].[DetalleFacVentas]
ADD CONSTRAINT [FK_ProductoDetalleFacVenta]
    FOREIGN KEY ([ProductoIdProducto])
    REFERENCES [dbo].[Productos]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoDetalleFacVenta'
CREATE INDEX [IX_FK_ProductoDetalleFacVenta]
ON [dbo].[DetalleFacVentas]
    ([ProductoIdProducto]);
GO

-- Creating foreign key on [FacVentaIdFacVenta] in table 'DetalleFacVentas'
ALTER TABLE [dbo].[DetalleFacVentas]
ADD CONSTRAINT [FK_FacVentaDetalleFacVenta]
    FOREIGN KEY ([FacVentaIdFacVenta])
    REFERENCES [dbo].[FacVentas]
        ([IdFacVenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacVentaDetalleFacVenta'
CREATE INDEX [IX_FK_FacVentaDetalleFacVenta]
ON [dbo].[DetalleFacVentas]
    ([FacVentaIdFacVenta]);
GO

-- Creating foreign key on [CategoriaIdCategoria] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [FK_CategoriaProducto]
    FOREIGN KEY ([CategoriaIdCategoria])
    REFERENCES [dbo].[Categorias]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaProducto'
CREATE INDEX [IX_FK_CategoriaProducto]
ON [dbo].[Productos]
    ([CategoriaIdCategoria]);
GO

-- Creating foreign key on [InventarioIdInventario] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [FK_InventarioProducto]
    FOREIGN KEY ([InventarioIdInventario])
    REFERENCES [dbo].[Inventarios]
        ([IdInventario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InventarioProducto'
CREATE INDEX [IX_FK_InventarioProducto]
ON [dbo].[Productos]
    ([InventarioIdInventario]);
GO

-- Creating foreign key on [ClienteIdPersona] in table 'FacVentas'
ALTER TABLE [dbo].[FacVentas]
ADD CONSTRAINT [FK_ClienteFacVenta]
    FOREIGN KEY ([ClienteIdPersona])
    REFERENCES [dbo].[Personas_Cliente]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFacVenta'
CREATE INDEX [IX_FK_ClienteFacVenta]
ON [dbo].[FacVentas]
    ([ClienteIdPersona]);
GO

-- Creating foreign key on [EmpleadoIdPersona] in table 'FacCompras'
ALTER TABLE [dbo].[FacCompras]
ADD CONSTRAINT [FK_EmpleadoFacCompra]
    FOREIGN KEY ([EmpleadoIdPersona])
    REFERENCES [dbo].[Personas_Empleado]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoFacCompra'
CREATE INDEX [IX_FK_EmpleadoFacCompra]
ON [dbo].[FacCompras]
    ([EmpleadoIdPersona]);
GO

-- Creating foreign key on [IdPersona] in table 'Personas_Cliente'
ALTER TABLE [dbo].[Personas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Persona]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Personas]
        ([IdPersona])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPersona] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [FK_Empleado_inherits_Persona]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Personas]
        ([IdPersona])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------