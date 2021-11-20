USE [master]
GO
/****** Object:  Database [CTH_INT]    Script Date: 19/11/2021 22:20:27 ******/
CREATE DATABASE [CTH_INT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CTH_INT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\CTH_INT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CTH_INT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\CTH_INT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[equipo]    Script Date: 19/11/2021 22:20:27 ******/
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
/****** Object:  Table [dbo].[orden]    Script Date: 19/11/2021 22:20:27 ******/
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
 CONSTRAINT [PK_orden] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 19/11/2021 22:20:27 ******/
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
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 19/11/2021 22:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_padre] [int] NULL,
	[id_permiso_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sector]    Script Date: 19/11/2021 22:20:27 ******/
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
/****** Object:  Table [dbo].[usuarios]    Script Date: 19/11/2021 22:20:27 ******/
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
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 19/11/2021 22:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_permisos](
	[id_usuario] [int] NOT NULL,
	[id_permiso] [int] NOT NULL
) ON [PRIMARY]
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
/****** Object:  StoredProcedure [dbo].[AddOrden]    Script Date: 19/11/2021 22:20:27 ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllSectores]    Script Date: 19/11/2021 22:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllSectores]
AS
SELECT * FROM sector
GO;
GO
/****** Object:  StoredProcedure [dbo].[GetEquipoBySector]    Script Date: 19/11/2021 22:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEquipoBySector] @id_sector int
AS
SELECT * FROM equipo where id_sector = @id_sector
GO
/****** Object:  StoredProcedure [dbo].[Getuser]    Script Date: 19/11/2021 22:20:27 ******/
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
