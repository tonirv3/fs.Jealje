USE [fs.jealje]
GO

/****** Object:  Table [dbo].[Vehiculos]    Script Date: 22/05/2023 9:25:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vehiculos](
	[Id] [bigint] NULL,
	[OIDAgencia] [bigint] NULL,
	[Marca] [varchar](50) NULL,
	[TipoVehiculo] [varchar](50) NULL,
	[Matricula] [varchar](50) NULL,
	[Remolque] [varchar](50) NULL,
	[CodTransportista] [varchar](50) NULL,
	[Estado]  [bit] NULL,
	[UsuarioAlta] [varchar](50) NULL,
	[HoraAlta] [time](7) NULL,
	[FechaAlta] [date] NULL,
	[UsuarioModificacion] [varchar](50) NULL,
	[FechaModificacion] [datetime] NULL,
) ON [PRIMARY]
GO