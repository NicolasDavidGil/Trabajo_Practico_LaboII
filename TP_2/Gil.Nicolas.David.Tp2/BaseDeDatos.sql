USE [master]
GO
/****** Object:  Database [TP2_LaboratorioII]    Script Date: 20/11/2022 18:19:27 ******/
CREATE DATABASE [TP2_LaboratorioII]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP2_LaboratorioII', FILENAME = N'D:\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP2_LaboratorioII.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP2_LaboratorioII_log', FILENAME = N'D:\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP2_LaboratorioII_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP2_LaboratorioII] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP2_LaboratorioII].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP2_LaboratorioII] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP2_LaboratorioII] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP2_LaboratorioII] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP2_LaboratorioII] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP2_LaboratorioII] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET RECOVERY FULL 
GO
ALTER DATABASE [TP2_LaboratorioII] SET  MULTI_USER 
GO
ALTER DATABASE [TP2_LaboratorioII] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP2_LaboratorioII] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP2_LaboratorioII] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP2_LaboratorioII] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP2_LaboratorioII] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP2_LaboratorioII] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP2_LaboratorioII', N'ON'
GO
ALTER DATABASE [TP2_LaboratorioII] SET QUERY_STORE = OFF
GO
USE [TP2_LaboratorioII]
GO
/****** Object:  Table [dbo].[HistorialUno]    Script Date: 20/11/2022 18:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialUno](
	[Fecha] [varchar](50) NULL,
	[JugadorUno] [varchar](50) NULL,
	[JugadorDos] [varchar](50) NULL,
	[Ganador] [varchar](50) NULL,
	[TipoPartida] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MazoUno]    Script Date: 20/11/2022 18:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MazoUno](
	[SimboloCarta] [varchar](50) NULL,
	[NumeroCarta] [int] NULL,
	[ColorCarta] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaisesUno]    Script Date: 20/11/2022 18:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaisesUno](
	[Pais] [varchar](50) NULL,
	[NumeroPais] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosUno]    Script Date: 20/11/2022 18:19:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosUno](
	[Nombre] [varchar](50) NULL,
	[Edad] [int] NULL,
	[Dni] [int] NULL,
	[Nacionalidad] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
	[NivelAcceso] [varchar](50) NULL,
	[Puntaje] [int] NULL,
	[Victorias] [int] NULL,
	[Derrotas] [int] NULL,
	[EstadoCuenta] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 25 2022 10:34AM', N'MatiRey', N'El luki', N'El luki', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 25 2022 10:41AM', N'ElBigo', N'MDiPino', N'ElBigo', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 25 2022 11:11AM', N'MatyGod', N'MDiva', N'MatyGod', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 25 2022  2:24PM', N'LaRichard', N'Fede Lomas', N'LaRichard', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 26 2022  8:04AM', N'Marito', N'RedDragon', N'RedDragon', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 26 2022 11:14AM', N'Uspe100', N'LopMax', N'LopMax', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 26 2022  3:44PM', N'El N1', N'Aye1990', N'Aye1990', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 27 2022  2:24PM', N'ElBigo', N'Lanus014', N'ElBigo', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 27 2022  3:15PM', N'Madri15', N'LB1422', N'Madri15', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 27 2022  6:31PM', N'Gianni', N'MosJM', N'MosJM', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 27 2022  6:41PM', N'ProGod', N'Fede Lomas', N'ProGod', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 27 2022  7:22PM', N'ElBigo', N'Leilu', N'ElBigo', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 28 2022  9:14AM', N'GAzcu', N'Armaky', N'GAzcu', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 28 2022 11:25AM', N'Armaky', N'LopMax', N'Armaky', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 28 2022  1:45PM', N'MatiRey', N'La Tota', N'La Tota', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 29 2022  5:34AM', N'Lomas21', N'Marito', N'Lomas21', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 29 2022  7:21AM', N'Gonza_King', N'Ate_RJ', N'Gonza_King', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 29 2022 11:02AM', N'RedDragon', N'LacasL', N'RedDragon', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 29 2022  4:55PM', N'LacasL', N'MurderNoob', N'LacasL', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 29 2022  6:32PM', N'Ate_RJ', N'RedDragon', N'Ate_RJ', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 30 2022 11:24AM', N'LopMax', N'El N1', N'Ate_RJ', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 30 2022 12:05PM', N'Marito', N'Uspe100', N'Uspe100', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 30 2022  1:30PM', N'LopMax', N'Lanus014', N'LopMax', N'Partida Express')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'Oct 30 2022  5:05PM', N'Madri15', N'Lu1990', N'Madri15', N'Partida Completa')
INSERT [dbo].[HistorialUno] ([Fecha], [JugadorUno], [JugadorDos], [Ganador], [TipoPartida]) VALUES (N'20/11/2022 15:27:32', N'MatiRey', N'El luki', N'El luki', N'Partida Espress')
GO
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 0, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 1, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 2, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 3, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 4, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 5, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 6, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 7, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 8, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 9, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 0, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 1, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 2, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 3, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 4, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 5, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 6, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 7, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 8, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 9, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 0, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 1, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 2, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 3, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 4, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 5, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 6, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 7, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 8, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 9, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 0, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 1, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 2, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 3, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 4, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 5, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 6, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 7, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 8, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'n', 9, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'+4', -4, N'Comodin')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'+4', -2, N'Comodin')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'cc', -1, N'Comodin')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'p', -10, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'p', -10, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'p', -10, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'p', -10, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N's', -15, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N's', -15, N'Rojo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N's', -15, N'Azul')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N's', -15, N'Amarillo')
GO
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'+2', 22, N'Amarillo')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'+2', 22, N'Verde')
INSERT [dbo].[MazoUno] ([SimboloCarta], [NumeroCarta], [ColorCarta]) VALUES (N'+2', 22, N'Azul')
GO
SET IDENTITY_INSERT [dbo].[PaisesUno] ON 

INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Argentina', 1)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Belice', 2)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Bolivia', 3)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Brasil', 4)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Canadá', 5)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Chile', 6)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Colombia', 7)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Costa Rica', 8)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Cuba', 9)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Ecuador', 10)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Estados Unidos', 11)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'El Salvador', 12)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Bolivia', 13)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Guatemala', 14)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Haití', 15)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Honduras', 16)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Jamaica', 17)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'México', 18)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Panamá', 19)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Paraguay', 20)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Porú', 21)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Puerto Rico', 22)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'República Dominicana', 23)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Uruguay', 24)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Venezuela', 25)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Europa', 26)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Asia', 27)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'Oceania', 28)
INSERT [dbo].[PaisesUno] ([Pais], [NumeroPais]) VALUES (N'África', 29)
SET IDENTITY_INSERT [dbo].[PaisesUno] OFF
GO
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Nicolas Gil', 31, 35394776, N'Argentina', N'Master01', N'12345', N'Admin', 500, 5, 0, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Lucas Rodriguez', 30, 36434555, N'Argentina', N'Master02', N'12345', N'Admin', 1300, 14, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Esteban Prieto', 27, 40188997, N'Argentina', N'Master03', N'12345', N'Admin', 300, 4, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Matias Reinoso', 32, 35644544, N'Argentina', N'MatiRey', N'12345', N'Jugador', 150, 2, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Ricardo Gómez', 36, 31254632, N'Argentina', N'RiDk', N'12345', N'Jugador', 0, 0, 0, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Morena Escudero', 25, 42013632, N'Argentina', N'LaRichard', N'12345', N'Jugador', 50, 1, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Matias Barroso', 26, 41254596, N'Argentina', N'MatyGod', N'12345', N'Jugador', 200, 2, 0, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Lucas Gaggino', 29, 38986596, N'Argentina', N'El luki', N'12345', N'Jugador', 150, 2, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Matias Di Pino', 24, 43056365, N'Brasil', N'MDiPino', N'12345', N'Jugador', 100, 1, 0, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Federico Lemos', 32, 35254632, N'Chile', N'Fede Lomas', N'12345', N'Jugador', 50, 1, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Esteban Gonzalez', 56, 11415254, N'Colombia', N'ProGod', N'12345', N'Jugador', 400, 6, 4, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Marcela Pereyra', 42, 25693889, N'Colombia', N'MDiva', N'12345', N'Jugador', 150, 2, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Guillermo Ascuiz', 30, 37002153, N'Colombia', N'GAzcu', N'12345', N'Jugador', 300, 4, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Sergio Moreno', 41, 26744878, N'Argentina', N'More86', N'12345', N'Jugador', 100, 2, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Leila Quiroz', 26, 41266323, N'Brasil', N'Leilu', N'12345', N'Jugador', 250, 3, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Rodrigo Barrera', 33, 34201004, N'Argentina', N'Armaky', N'12345', N'Jugador', 300, 3, 0, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Andrés Carbonaro', 32, 35621488, N'Argentina', N'Lomas21', N'12345', N'Jugador', 100, 2, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Pablo Erminione', 35, 32989655, N'Chile', N'La Tota', N'12345', N'Jugador', 50, 1, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Mario Bonerba', 46, 21487782, N'Chile', N'Marito', N'12345', N'Jugador', 100, 2, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Gonzalo Alvear', 24, 43266859, N'Brasil', N'Gonza_King', N'12345', N'Jugador', 0, 2, 4, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Jorge Ravetti', 54, 13621488, N'Jamaica', N'Ate_RJ', N'12345', N'Jugador', 700, 8, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Rodrigo Ravetti', 38, 29363222, N'Colombia', N'RedDragon', N'12345', N'Jugador', 600, 9, 6, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Lucio Lacasio', 69, 8263525, N'Estados Unidos', N'LacasL', N'12345', N'Jugador', 550, 6, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Alberto Uspeda', 42, 25464125, N'Estados Unidos', N'Uspe100', N'12345', N'Jugador', 950, 12, 5, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Pedro Roffio', 36, 23132563, N'Brasil', N'RoffMonster', N'12345', N'Jugador', 450, 5, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Maximiliano Loppia', 38, 29489658, N'Argentina', N'LopMax', N'12345', N'Jugador', 1050, 11, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Ezequiel Espinosa', 36, 31521455, N'Colombia', N'EspinaAsesina', N'12345', N'Jugador', 350, 4, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Marcos Muslera', 28, 39719728, N'México', N'El N1', N'12345', N'Jugador', 750, 9, 3, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Hector Izquierdoz', 32, 35611621, N'Porú', N'MurderNoob', N'12345', N'Jugador', 350, 6, 5, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Sebastian Rost', 31, 34122362, N'Uruguay', N'SebaR', N'12345', N'Jugador', 750, 8, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Ayelen Rial', 34, 33896556, N'Uruguay', N'Aye1990', N'12345', N'Jugador', 550, 6, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Lucas Gimenez', 39, 28464130, N'Brasil', N'Trucker54', N'12345', N'Jugador', 900, 10, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Martin Bracchi', 27, 40233696, N'Chile', N'Lanus014', N'12345', N'Jugador', 300, 4, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Mauro Fava', 32, 35757880, N'Colombia', N'ElBigo', N'12345', N'Jugador', 1900, 20, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Rodrigo Manera', 34, 33896556, N'Paraguay', N'RMTrucker', N'12345', N'Jugador', 300, 4, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Veronica Facio', 42, 25699323, N'Paraguay', N'Madri15', N'12345', N'Jugador', 900, 10, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Ludmila Buono', 30, 37105245, N'Porú', N'LB1422', N'12345', N'Jugador', 400, 6, 4, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Veronica Obermeide', 32, 35966486, N'Oceania', N'VeroVete', N'12345', N'Jugador', 300, 5, 4, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Lucia Rioparisi', 43, 25500366, N'Porú', N'Lu1990', N'12345', N'Jugador', 100, 2, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Oscar Wilde', 52, 15589901, N'Brasil', N'OS1000', N'12345', N'Jugador', 300, 4, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Julio Verne', 62, 5784477, N'México', N'JVer12', N'12345', N'Jugador', 100, 2, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Gianni Migliori', 37, 30102033, N'Europa', N'Gianni', N'12345', N'Jugador', 300, 4, 2, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Julio Cortazar', 47, 20515222, N'Europa', N'MosJM', N'12345', N'Jugador', 150, 2, 1, 1)
INSERT [dbo].[UsuariosUno] ([Nombre], [Edad], [Dni], [Nacionalidad], [Usuario], [Contraseña], [NivelAcceso], [Puntaje], [Victorias], [Derrotas], [EstadoCuenta]) VALUES (N'Nickolas', 33, 8888888, N'Brasil', N'KKKKKKKKKKK', N'12345', N'Jugador', 0, 0, 0, 1)
GO
USE [master]
GO
ALTER DATABASE [TP2_LaboratorioII] SET  READ_WRITE 
GO
