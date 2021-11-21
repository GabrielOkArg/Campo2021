USE [master]
GO
/****** Object:  Database [CTH_INT]    Script Date: 20/11/2021 20:31:39 ******/
CREATE DATABASE [CTH_INT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CTH_INT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CTH_INT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CTH_INT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CTH_INT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CTH_INT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CTH_INT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CTH_INT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CTH_INT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CTH_INT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CTH_INT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CTH_INT] SET ARITHABORT OFF 
GO
ALTER DATABASE [CTH_INT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CTH_INT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CTH_INT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CTH_INT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CTH_INT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CTH_INT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CTH_INT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CTH_INT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CTH_INT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CTH_INT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CTH_INT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CTH_INT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CTH_INT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CTH_INT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CTH_INT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CTH_INT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CTH_INT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CTH_INT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CTH_INT] SET  MULTI_USER 
GO
ALTER DATABASE [CTH_INT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CTH_INT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CTH_INT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CTH_INT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CTH_INT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CTH_INT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CTH_INT] SET QUERY_STORE = OFF
GO
USE [CTH_INT]
GO
/****** Object:  Table [dbo].[equipo]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[equipo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[marca] [nvarchar](50) NULL,
	[numSerie] [nvarchar](50) NULL,
	[fechaAlta] [date] NULL,
	[fechaBaja] [date] NULL,
	[estado] [bit] NULL,
	[id_sector] [int] NOT NULL,
 CONSTRAINT [PK_equipo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orden]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orden](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fechaCreacion] [date] NULL,
	[fechaFinalizado] [date] NULL,
	[fechaCierre] [date] NULL,
	[solicitante] [nvarchar](120) NULL,
	[coordinador] [nvarchar](120) NULL,
	[agente] [nvarchar](120) NULL,
	[descripcion] [nvarchar](800) NULL,
	[sector] [nvarchar](120) NULL,
	[equipo] [int] NULL,
	[terminada] [bit] NULL,
	[finalizada] [bit] NULL,
	[cierre] [bit] NULL,
	[urgencia] [nvarchar](50) NULL,
	[id_solicitante] [int] NOT NULL,
	[tiempo] [int] NULL,
	[asignada] [bit] NULL,
	[estado] [nvarchar](50) NULL,
	[id_agente] [int] NULL,
	[comentario_tecnico] [nvarchar](1000) NULL,
 CONSTRAINT [PK_orden] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[nombre] [varchar](100) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[permiso] [varchar](50) NULL,
 CONSTRAINT [PK_permiso] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_padre] [int] NULL,
	[id_permiso_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sector]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sector](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_sector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_permisos](
	[id_usuario] [int] NOT NULL,
	[id_permiso] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[equipo] ON 

INSERT [dbo].[equipo] ([id], [nombre], [marca], [numSerie], [fechaAlta], [fechaBaja], [estado], [id_sector]) VALUES (1, N'Cobas', N'Cobas', N'asd123', CAST(N'1980-01-01' AS Date), NULL, 1, 1)
INSERT [dbo].[equipo] ([id], [nombre], [marca], [numSerie], [fechaAlta], [fechaBaja], [estado], [id_sector]) VALUES (2, N'Arco en C', N'Samsung', N'00012344a', CAST(N'2015-10-22' AS Date), NULL, 1, 2)
INSERT [dbo].[equipo] ([id], [nombre], [marca], [numSerie], [fechaAlta], [fechaBaja], [estado], [id_sector]) VALUES (3, N'Compresor Aire', N'Tausem', N'as123as', CAST(N'2019-10-10' AS Date), NULL, 1, 4)
INSERT [dbo].[equipo] ([id], [nombre], [marca], [numSerie], [fechaAlta], [fechaBaja], [estado], [id_sector]) VALUES (4, N'Bomba vacio', N'Pascal', N'78aa88', CAST(N'1901-02-01' AS Date), NULL, 1, 4)
SET IDENTITY_INSERT [dbo].[equipo] OFF
GO
SET IDENTITY_INSERT [dbo].[orden] ON 

INSERT [dbo].[orden] ([id], [fechaCreacion], [fechaFinalizado], [fechaCierre], [solicitante], [coordinador], [agente], [descripcion], [sector], [equipo], [terminada], [finalizada], [cierre], [urgencia], [id_solicitante], [tiempo], [asignada], [estado], [id_agente], [comentario_tecnico]) VALUES (1, CAST(N'2021-11-19' AS Date), NULL, NULL, N'solicitante usuario', NULL, NULL, N'no anda', N'sala de gases', 4, 0, 0, 0, N'Critica', 4, 0, 0, N'Abierta', NULL, NULL)
INSERT [dbo].[orden] ([id], [fechaCreacion], [fechaFinalizado], [fechaCierre], [solicitante], [coordinador], [agente], [descripcion], [sector], [equipo], [terminada], [finalizada], [cierre], [urgencia], [id_solicitante], [tiempo], [asignada], [estado], [id_agente], [comentario_tecnico]) VALUES (2, CAST(N'2021-11-19' AS Date), NULL, NULL, N'solicitante usuario', NULL, NULL, N'ver', N'laboratorio', 1, 0, 0, 0, N'Baja', 4, 0, 0, N'Abierta', NULL, NULL)
INSERT [dbo].[orden] ([id], [fechaCreacion], [fechaFinalizado], [fechaCierre], [solicitante], [coordinador], [agente], [descripcion], [sector], [equipo], [terminada], [finalizada], [cierre], [urgencia], [id_solicitante], [tiempo], [asignada], [estado], [id_agente], [comentario_tecnico]) VALUES (3, CAST(N'2021-11-20' AS Date), NULL, NULL, N'solicitante usuario', NULL, NULL, N'luz quemada', N'recepcion guardia', 0, 0, 0, 0, N'Baja', 4, 0, 0, N'Abierta', NULL, NULL)
INSERT [dbo].[orden] ([id], [fechaCreacion], [fechaFinalizado], [fechaCierre], [solicitante], [coordinador], [agente], [descripcion], [sector], [equipo], [terminada], [finalizada], [cierre], [urgencia], [id_solicitante], [tiempo], [asignada], [estado], [id_agente], [comentario_tecnico]) VALUES (4, CAST(N'2021-11-20' AS Date), NULL, NULL, N'solicitante usuario', NULL, NULL, N'poca precion', N'sala de gases', 3, 0, 0, 0, N'Alta', 4, 0, 0, N'Abierta', NULL, NULL)
INSERT [dbo].[orden] ([id], [fechaCreacion], [fechaFinalizado], [fechaCierre], [solicitante], [coordinador], [agente], [descripcion], [sector], [equipo], [terminada], [finalizada], [cierre], [urgencia], [id_solicitante], [tiempo], [asignada], [estado], [id_agente], [comentario_tecnico]) VALUES (8, CAST(N'2021-11-20' AS Date), NULL, NULL, N'solicitante usuario', NULL, NULL, N'roto', N'recepcion guardia', 0, 0, 0, 0, N'Baja', 4, 0, 0, N'Abierta', NULL, NULL)
SET IDENTITY_INSERT [dbo].[orden] OFF
GO
SET IDENTITY_INSERT [dbo].[permiso] ON 

INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Admin', 5, N'Administrador')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Admin_tecnico', 6, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Operador', 7, N'Tecnico')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'OperadorTecnico', 8, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'CoordinadorTec', 9, N'Coordinador')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Coordinador', 10, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Jefe Tecnico', 11, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'profesor', 12, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'permisoProfesor', 13, N'Administrador')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'nueva', 14, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Solicitante', 15, N'Solicitante')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'AgenteTecnico', 16, N'Agente')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Agente_tecnico', 17, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Coordinador', 18, N'Coordinador')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Jefe', 19, N'JefeTecnico')
SET IDENTITY_INSERT [dbo].[permiso] OFF
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (6, 5)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (8, 7)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (11, 5)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (11, 7)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (11, 9)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (12, 13)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (17, 16)
GO
SET IDENTITY_INSERT [dbo].[sector] ON 

INSERT [dbo].[sector] ([id], [nombre]) VALUES (1, N'laboratorio')
INSERT [dbo].[sector] ([id], [nombre]) VALUES (2, N'quirofano')
INSERT [dbo].[sector] ([id], [nombre]) VALUES (3, N'recepcion guardia')
INSERT [dbo].[sector] ([id], [nombre]) VALUES (4, N'sala de gases')
INSERT [dbo].[sector] ([id], [nombre]) VALUES (5, N'sala aire comprimido')
SET IDENTITY_INSERT [dbo].[sector] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (1, N'Gabriel', N'Silva', N'gsilva', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (2, N'Lucas', N'Silva', N'lsilva', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (3, N'Administrador', N'Admin', N'Admin', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (4, N'solicitante', N'usuario', N'usolicitante', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (5, N'agente', N'test', N'agentetest', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (6, N'coordinador', N'test', N'coordinadortest', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (7, N'jefe', N'tecnico', N'jefetecnico', N'81dc9bdb52d04dc20036dbd8313ed055')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (4, 15)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (2, 9)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (3, 6)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (3, 11)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (5, 17)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (6, 18)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (7, 19)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (3, 10)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 7)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 12)
GO
ALTER TABLE [dbo].[orden] ADD  CONSTRAINT [DF_orden_terminada]  DEFAULT ((0)) FOR [terminada]
GO
ALTER TABLE [dbo].[orden] ADD  CONSTRAINT [DF_orden_finalizada]  DEFAULT ((0)) FOR [finalizada]
GO
ALTER TABLE [dbo].[orden] ADD  CONSTRAINT [DF_orden_cierre]  DEFAULT ((0)) FOR [cierre]
GO
ALTER TABLE [dbo].[orden] ADD  CONSTRAINT [DF_orden_tiempo]  DEFAULT ((0)) FOR [tiempo]
GO
ALTER TABLE [dbo].[orden] ADD  CONSTRAINT [DF_orden_asignada]  DEFAULT ((0)) FOR [asignada]
GO
ALTER TABLE [dbo].[permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_permiso_permiso] FOREIGN KEY([id_permiso_padre])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[permiso_permiso] CHECK CONSTRAINT [FK_permiso_permiso_permiso]
GO
ALTER TABLE [dbo].[permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_permiso_permiso1] FOREIGN KEY([id_permiso_hijo])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[permiso_permiso] CHECK CONSTRAINT [FK_permiso_permiso_permiso1]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_permiso] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_permiso]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_usuarios]
GO
/****** Object:  StoredProcedure [dbo].[AddOrden]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddOrden]
@fechaCreacion date,
@solicitante nvarchar(120),
@sector nvarchar(120),
@equipo int,
@descripcion nvarchar(800),
@urgencia nvarchar(50),
@id_solicitante int
as
begin
	insert into orden (
	fechaCreacion, 
	solicitante,
	sector,
	equipo,
	descripcion,
	urgencia,
	id_solicitante
	)
	values(
	@fechaCreacion,
	@solicitante,
	@sector,
	@equipo,
	@descripcion,
	@urgencia,
	@id_solicitante
	)
	 SELECT SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[getAgentes]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getAgentes]
as
  select * from usuarios
  inner join usuarios_permisos on  usuarios.id = usuarios_permisos.id_usuario
  inner join permiso on permiso.id = usuarios_permisos.id_permiso
  where usuarios_permisos.id_permiso =17

GO
/****** Object:  StoredProcedure [dbo].[GetAllSectores]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllSectores]
AS
SELECT * FROM sector
GO;
GO
/****** Object:  StoredProcedure [dbo].[GetEquipoBySector]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEquipoBySector] @id_sector int
AS
SELECT * FROM equipo where id_sector = @id_sector
GO
/****** Object:  StoredProcedure [dbo].[getOrdenByIDot]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getOrdenByIDot] @id int
as
select *
from orden
where id = @id
GO
/****** Object:  StoredProcedure [dbo].[GetOrdenByIdUser]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetOrdenByIdUser] @id int
as
select *
from orden
where id_solicitante = @id
GO
/****** Object:  StoredProcedure [dbo].[getOrdenLibre]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getOrdenLibre]
as
  select *from orden
  where asignada = 0
GO
/****** Object:  StoredProcedure [dbo].[Getuser]    Script Date: 20/11/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
-- ================================================
CREATE PROCEDURE [dbo].[Getuser]
@username nvarchar(50)
AS
begin
SELECT * FROM usuarios
where username = @username
end
GO
USE [master]
GO
ALTER DATABASE [CTH_INT] SET  READ_WRITE 
GO
