USE [HappyCanCampERP]
GO

/****** Object: Table [dbo].[Clientes] Script Date: 28/10/2017 19:56:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes] (
    [Id]                  INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]              NVARCHAR (50) NOT NULL,
    [Correo]              NVARCHAR (50) NULL,
    [Telefono]            NVARCHAR (13) NULL,
    [Celular]             NVARCHAR (13) NULL,
    [Calle]               NVARCHAR (30) NULL,
    [NumeroExterior]      NVARCHAR (10) NULL,
    [NumeroInterior]      NVARCHAR (10) NULL,
    [Fraccionamiento]     NVARCHAR (40) NULL,
    [Colonia]             NVARCHAR (40) NULL,
    [Localidad]           NVARCHAR (50) NULL,
    [DelegacionMunicipio] NVARCHAR (50) NULL,
    [Estado]              NVARCHAR (20) NULL,
    [CP]                  NVARCHAR (10) NULL,
	[Geo]                 NVARCHAR (20) NULL,
	[Comentarios]         NVARCHAR (100) NULL,
    [RfcID]               NVARCHAR (20) NULL
);


