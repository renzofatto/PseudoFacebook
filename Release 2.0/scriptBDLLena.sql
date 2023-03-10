USE [ObligatorioDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 18/11/2021 23:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublicacionEntities]    Script Date: 18/11/2021 23:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicacionEntities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](max) NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Cancion] [nvarchar](max) NULL,
	[Album] [nvarchar](max) NULL,
	[Artista] [nvarchar](max) NULL,
	[TextoDeEstado] [nvarchar](max) NULL,
	[Juego] [nvarchar](max) NULL,
	[Puntaje] [int] NULL,
	[Discriminator] [nvarchar](128) NOT NULL,
	[CreadoPor_Id_Usuario] [int] NULL,
	[Jugador_Id_Usuario] [int] NULL,
 CONSTRAINT [PK_dbo.PublicacionEntities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioEntities]    Script Date: 18/11/2021 23:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioEntities](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](max) NULL,
	[Contrasena] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Apellido] [nvarchar](max) NULL,
	[DireccionPersona_Pais] [nvarchar](max) NULL,
	[DireccionPersona_Ciudad] [nvarchar](max) NULL,
	[DireccionPersona_Calle] [nvarchar](max) NULL,
	[Administrador] [bit] NOT NULL,
	[Logeado] [bit] NOT NULL,
	[PicturePath] [nvarchar](max) NULL,
	[UsuarioEntity_Id_Usuario] [int] NULL,
 CONSTRAINT [PK_dbo.UsuarioEntities] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[PublicacionEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PublicacionEntities_dbo.UsuarioEntities_CreadoPor_Id_Usuario] FOREIGN KEY([CreadoPor_Id_Usuario])
REFERENCES [dbo].[UsuarioEntities] ([Id_Usuario])
GO
ALTER TABLE [dbo].[PublicacionEntities] CHECK CONSTRAINT [FK_dbo.PublicacionEntities_dbo.UsuarioEntities_CreadoPor_Id_Usuario]
GO
ALTER TABLE [dbo].[PublicacionEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PublicacionEntities_dbo.UsuarioEntities_Jugador_Id_Usuario] FOREIGN KEY([Jugador_Id_Usuario])
REFERENCES [dbo].[UsuarioEntities] ([Id_Usuario])
GO
ALTER TABLE [dbo].[PublicacionEntities] CHECK CONSTRAINT [FK_dbo.PublicacionEntities_dbo.UsuarioEntities_Jugador_Id_Usuario]
GO
ALTER TABLE [dbo].[UsuarioEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UsuarioEntities_dbo.UsuarioEntities_UsuarioEntity_Id_Usuario] FOREIGN KEY([UsuarioEntity_Id_Usuario])
REFERENCES [dbo].[UsuarioEntities] ([Id_Usuario])
GO
ALTER TABLE [dbo].[UsuarioEntities] CHECK CONSTRAINT [FK_dbo.UsuarioEntities_dbo.UsuarioEntities_UsuarioEntity_Id_Usuario]
GO
