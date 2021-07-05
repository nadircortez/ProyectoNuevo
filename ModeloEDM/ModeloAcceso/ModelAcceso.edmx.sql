
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/02/2021 11:05:15
-- Generated from EDMX file: C:\Users\Ligia\source\repos\ProyectoPracticas\ModeloEDM\ModeloAcceso\ModelAcceso.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDAcceso];
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

-- Creating table 'Permiso'
CREATE TABLE [dbo].[Permiso] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nchar(25)  NOT NULL,
    [CodPemiso] nchar(10)  NOT NULL
);
GO

-- Creating table 'AsignacionPermisos'
CREATE TABLE [dbo].[AsignacionPermisos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PermisoId] int  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Users] nchar(50)  NOT NULL,
    [Pass] nchar(50)  NOT NULL,
    [Nombres] nchar(50)  NOT NULL,
    [Apellidos] nchar(50)  NOT NULL,
    [Cedula] nchar(16)  NOT NULL,
    [Salario] decimal(18,0)  NOT NULL,
    [Direccion] nchar(80)  NOT NULL,
    [Estado] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [PK_Permiso]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AsignacionPermisos'
ALTER TABLE [dbo].[AsignacionPermisos]
ADD CONSTRAINT [PK_AsignacionPermisos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PermisoId] in table 'AsignacionPermisos'
ALTER TABLE [dbo].[AsignacionPermisos]
ADD CONSTRAINT [FK_PermisoAsignacionPermisos]
    FOREIGN KEY ([PermisoId])
    REFERENCES [dbo].[Permiso]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermisoAsignacionPermisos'
CREATE INDEX [IX_FK_PermisoAsignacionPermisos]
ON [dbo].[AsignacionPermisos]
    ([PermisoId]);
GO

-- Creating foreign key on [UsuarioId] in table 'AsignacionPermisos'
ALTER TABLE [dbo].[AsignacionPermisos]
ADD CONSTRAINT [FK_UsuarioAsignacionPermisos]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioAsignacionPermisos'
CREATE INDEX [IX_FK_UsuarioAsignacionPermisos]
ON [dbo].[AsignacionPermisos]
    ([UsuarioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------