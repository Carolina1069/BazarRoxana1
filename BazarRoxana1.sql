USE [master]
GO
/****** Object:  Database [BazarRoxana]    Script Date: 18/6/2021 07:02:50 ******/
CREATE DATABASE [BazarRoxana]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BazarRoxana', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BazarRoxana.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BazarRoxana_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BazarRoxana_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BazarRoxana] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BazarRoxana].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BazarRoxana] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BazarRoxana] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BazarRoxana] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BazarRoxana] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BazarRoxana] SET ARITHABORT OFF 
GO
ALTER DATABASE [BazarRoxana] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BazarRoxana] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BazarRoxana] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BazarRoxana] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BazarRoxana] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BazarRoxana] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BazarRoxana] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BazarRoxana] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BazarRoxana] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BazarRoxana] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BazarRoxana] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BazarRoxana] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BazarRoxana] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BazarRoxana] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BazarRoxana] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BazarRoxana] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BazarRoxana] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BazarRoxana] SET RECOVERY FULL 
GO
ALTER DATABASE [BazarRoxana] SET  MULTI_USER 
GO
ALTER DATABASE [BazarRoxana] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BazarRoxana] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BazarRoxana] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BazarRoxana] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BazarRoxana] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BazarRoxana', N'ON'
GO
ALTER DATABASE [BazarRoxana] SET QUERY_STORE = OFF
GO
USE [BazarRoxana]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[CodCateg] [int] IDENTITY(1,1) NOT NULL,
	[NombCateg] [nvarchar](50) NOT NULL,
	[EstadoCateg] [bit] NOT NULL,
	[DescripCateg] [nvarchar](75) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[CodCateg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[CodCli] [int] IDENTITY(1,1) NOT NULL,
	[NombCli] [nvarchar](50) NOT NULL,
	[DirecCli] [nvarchar](150) NOT NULL,
	[TelCli] [int] NOT NULL,
	[CorreoCli] [nvarchar](50) NOT NULL,
	[EstadoCli] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[CodCli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[NumCompra] [int] IDENTITY(1,1) NOT NULL,
	[CodProv] [int] NOT NULL,
	[CodPago] [int] NOT NULL,
	[CodTransa] [int] NOT NULL,
	[CodEmple] [int] NOT NULL,
	[FechayHora] [smalldatetime] NOT NULL,
	[Total] [float] NOT NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[NumCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[NumCompra] [int]  NOT NULL,
	[CodProduc] [int] NOT NULL,
	[NombProduc] [nvarchar](50) NOT NULL,
	[Impuesto] [float] NOT NULL,
	[CantProduc] [int] NOT NULL,
	[PrecioProduc] [int] NOT NULL,
	[SubTotal] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVentas](
	[NumVent] [int] NOT NULL,
	[CodProduc] [int] NOT NULL,
	[NombProduc] [nvarchar](50) NOT NULL,
	[Impuesto] [float] NOT NULL,
	[CantVenta] [int] NOT NULL,
	[PrecioVenta] [int] NOT NULL,
	[SubTotal] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[CodEmple] [int] IDENTITY(1,1) NOT NULL,
	[NombEmple] [nvarchar](50) NOT NULL,
	[UsuarioEmple] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[NivelEmple] [int] NOT NULL,
	[EstadoEmple] [bit] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[CodEmple] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormasPago]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormasPago](
	[CodPago] [int] NOT NULL,
	[DescPago] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_FormasPago] PRIMARY KEY CLUSTERED 
(
	[CodPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NivelEmpleado]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelEmpleado](
	[NivelEmple] [int] NOT NULL,
	[DescriNivel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NivelEmpleado] PRIMARY KEY CLUSTERED 
(
	[NivelEmple] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[CodProduc] [int] IDENTITY(1,1) NOT NULL,
	[NombProduc] [nvarchar](50) NOT NULL,
	[DescripProduc] [nvarchar](50) NOT NULL,
	[CodProv] [int] NOT NULL,
	[CodCateg] [int] NOT NULL,
	[PrimerPrecio] [int] NOT NULL,
	[SegundoPrecio] [int] NOT NULL,
	[TercerPrecio] [int] NOT NULL,
	[UnidadesStock] [int] NOT NULL,
	[Minimo] [int] NOT NULL,
	[Maximo] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[CodProduc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[CodProv] [int] IDENTITY(1,1) NOT NULL,
	[NombProv] [nvarchar](35) NOT NULL,
	[TelProv] [int] NOT NULL,
	[NombContProv] [nvarchar](50) NOT NULL,
	[CorreoProv] [nvarchar](50) NOT NULL,
	[CorreoContProv] [nvarchar](50) NOT NULL,
	[TelContProv] [int] NOT NULL,
	[DirecProv] [nvarchar](150) NOT NULL,
	[EstadoProv] [bit] NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[CodProv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transacciones]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transacciones](
	[CodTransa] [int] NOT NULL,
	[DescTransa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Transacciones] PRIMARY KEY CLUSTERED 
(
	[CodTransa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[NumVent] [int] IDENTITY(1,1) NOT NULL,
	[CodCli] [int] NOT NULL,
	[FechayHoraVenta] [datetime] NOT NULL,
	[CodPago] [int] NOT NULL,
	[CodTransa] [int] NOT NULL,
	[CodEmple] [int] NOT NULL,
	[Total] [float] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[NumVent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([CodCateg], [NombCateg], [EstadoCateg], [DescripCateg]) VALUES (1, N'Pantalones', 1, N'Pantalones de dama')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([CodCli], [NombCli], [DirecCli], [TelCli], [CorreoCli], [EstadoCli]) VALUES (1, N'Rouse Palomo', N'Col. San Angel  2da entrada ', 98053535, N'Rouse@gmail.com', 1)
INSERT [dbo].[Clientes] ([CodCli], [NombCli], [DirecCli], [TelCli], [CorreoCli], [EstadoCli]) VALUES (2, N'Bessy Leiva', N'barrio la reforma', 87976463, N'bessu@unicah.edu', 1)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (1, 1, N'PepeJean', 0.25, 100, 250, 31250)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (2, 1, N'PepeJean', 0.25, 150, 250, 46875)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (4, 1, N'PepeJean', 0.25, 5, 250, 1562.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (5, 1, N'PepeJean', 0.25, 6, 250, 1875)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (7, 1, N'PepeJean', 0.25, 1, 250, 312.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (8, 1, N'PepeJean', 0.25, 1, 250, 312.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (9, 1, N'PepeJean', 0.25, 1, 250, 312.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (9, 1, N'PepeJean', 0.25, 7, 400, 3500)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (10, 1, N'PepeJean', 0.25, 1, 250, 312.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (10, 1, N'PepeJean', 0.25, 2, 350, 875)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (12, 1, N'PepeJean', 0.25, 1, 250, 312.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (13, 1, N'PepeJean', 0.25, 2, 250, 625)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (13, 1, N'PepeJean', 0.25, 3, 350, 1312.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (15, 1, N'PepeJean', 0.25, 2, 250, 625)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (15, 1, N'PepeJean', 0.25, 1, 350, 437.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (11, 1, N'PepeJean', 0.25, 10, 250, 3125)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (11, 1, N'PepeJean', 0.25, 3, 350, 1312.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (14, 1, N'PepeJean', 0.25, 1, 250, 312.5)
INSERT [dbo].[DetalleVentas] ([NumVent], [CodProduc], [NombProduc], [Impuesto], [CantVenta], [PrecioVenta], [SubTotal]) VALUES (14, 1, N'PepeJean', 0.25, 2, 350, 875)
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([CodEmple], [NombEmple], [UsuarioEmple], [Contraseña], [NivelEmple], [EstadoEmple]) VALUES (1, N'Carlos Amaya', N'Amasha15', N'Amasha1015', 1, 1)
INSERT [dbo].[Empleados] ([CodEmple], [NombEmple], [UsuarioEmple], [Contraseña], [NivelEmple], [EstadoEmple]) VALUES (2, N'Daniel Rueda', N'Danielr22', N'12345678', 1, 1)
INSERT [dbo].[Empleados] ([CodEmple], [NombEmple], [UsuarioEmple], [Contraseña], [NivelEmple], [EstadoEmple]) VALUES (3, N'Bessy Guevara', N'Carolina10', N'10081626', 1, 1)
INSERT [dbo].[Empleados] ([CodEmple], [NombEmple], [UsuarioEmple], [Contraseña], [NivelEmple], [EstadoEmple]) VALUES (4, N'Admin', N'Admin', N'Admin', 2, 1)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
INSERT [dbo].[FormasPago] ([CodPago], [DescPago]) VALUES (1, N'Crédito')
INSERT [dbo].[FormasPago] ([CodPago], [DescPago]) VALUES (2, N'Contado')
GO
INSERT [dbo].[NivelEmpleado] ([NivelEmple], [DescriNivel]) VALUES (1, N'Gerente')
INSERT [dbo].[NivelEmpleado] ([NivelEmple], [DescriNivel]) VALUES (2, N'General')
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([CodProduc], [NombProduc], [DescripProduc], [CodProv], [CodCateg], [PrimerPrecio], [SegundoPrecio], [TercerPrecio], [UnidadesStock], [Minimo], [Maximo]) VALUES (1, N'PepeJean', N'Pantalon Dama', 1, 1, 250, 350, 400, 701, 500, 10000)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([CodProv], [NombProv], [TelProv], [NombContProv], [CorreoProv], [CorreoContProv], [TelContProv], [DirecProv], [EstadoProv]) VALUES (1, N'PePeJeans', 2765368, N'Carlos Amaya', N'pepejeansca@gmail.com', N'carlosamaya@gmail.com', 97504233, N'Tegucigalpa,Honduras C.A', 1)
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
INSERT [dbo].[Transacciones] ([CodTransa], [DescTransa]) VALUES (1, N'Efectivo')
INSERT [dbo].[Transacciones] ([CodTransa], [DescTransa]) VALUES (2, N'Tarjeta de crédito')
INSERT [dbo].[Transacciones] ([CodTransa], [DescTransa]) VALUES (3, N'Tarjeta de débito')
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (1, 2, CAST(N'2021-06-18T14:19:53.237' AS DateTime), 2, 1, 3, 31250)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (2, 1, CAST(N'2021-06-18T15:15:57.453' AS DateTime), 2, 1, 3, 47875)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (3, 2, CAST(N'2021-06-18T15:18:54.020' AS DateTime), 2, 2, 4, 2500)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (4, 2, CAST(N'2021-06-18T15:38:43.953' AS DateTime), 2, 3, 3, 2437.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (5, 2, CAST(N'2021-06-18T15:42:14.137' AS DateTime), 2, 2, 3, 2312.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (6, 2, CAST(N'2021-06-18T15:45:00.273' AS DateTime), 2, 1, 3, 2375)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (7, 1, CAST(N'2021-06-18T15:46:37.443' AS DateTime), 2, 2, 3, 1187.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (8, 2, CAST(N'2021-06-18T15:47:51.130' AS DateTime), 1, 1, 3, 1312.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (9, 2, CAST(N'2021-06-18T15:52:06.953' AS DateTime), 2, 1, 3, 3812.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (10, 1, CAST(N'2021-06-18T15:58:51.490' AS DateTime), 1, 1, 3, 1187.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (11, 1, CAST(N'2021-06-18T17:15:56.850' AS DateTime), 2, 1, 3, 4437.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (12, 1, CAST(N'2021-06-18T17:19:16.067' AS DateTime), 2, 1, 3, 312.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (13, 1, CAST(N'2021-06-18T17:41:04.453' AS DateTime), 2, 3, 3, 1937.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (14, 2, CAST(N'2021-06-18T18:04:39.403' AS DateTime), 2, 1, 3, 1187.5)
INSERT [dbo].[Ventas] ([NumVent], [CodCli], [FechayHoraVenta], [CodPago], [CodTransa], [CodEmple], [Total]) VALUES (15, 1, CAST(N'2021-06-18T18:21:21.247' AS DateTime), 2, 1, 3, 1062.5)
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Empleados] FOREIGN KEY([CodEmple])
REFERENCES [dbo].[Empleados] ([CodEmple])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Empleados]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_FormasPago] FOREIGN KEY([CodPago])
REFERENCES [dbo].[FormasPago] ([CodPago])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_FormasPago]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Transacciones] FOREIGN KEY([CodTransa])
REFERENCES [dbo].[Transacciones] ([CodTransa])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Transacciones]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Compras] FOREIGN KEY([NumCompra])
REFERENCES [dbo].[Compras] ([NumCompra])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Compras]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Producto] FOREIGN KEY([CodProduc])
REFERENCES [dbo].[Producto] ([CodProduc])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Producto]
GO
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas_Producto] FOREIGN KEY([CodProduc])
REFERENCES [dbo].[Producto] ([CodProduc])
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [FK_DetalleVentas_Producto]
GO
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas_Ventas] FOREIGN KEY([NumVent])
REFERENCES [dbo].[Ventas] ([NumVent])
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [FK_DetalleVentas_Ventas]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_NivelEmpleado] FOREIGN KEY([NivelEmple])
REFERENCES [dbo].[NivelEmpleado] ([NivelEmple])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_NivelEmpleado]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([CodCateg])
REFERENCES [dbo].[Categoria] ([CodCateg])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Proveedores] FOREIGN KEY([CodProv])
REFERENCES [dbo].[Proveedores] ([CodProv])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Proveedores]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([CodCli])
REFERENCES [dbo].[Clientes] ([CodCli])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Empleados] FOREIGN KEY([CodEmple])
REFERENCES [dbo].[Empleados] ([CodEmple])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Empleados]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_FormasPago] FOREIGN KEY([CodPago])
REFERENCES [dbo].[FormasPago] ([CodPago])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_FormasPago]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Transacciones] FOREIGN KEY([CodTransa])
REFERENCES [dbo].[Transacciones] ([CodTransa])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Transacciones]
GO
/****** Object:  StoredProcedure [dbo].[SelectCliente]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCliente]
AS
	SET NOCOUNT ON;
SELECT        CodCli, NombCli, DirecCli, TelCli, CorreoCli, CASE WHEN EstadoCli = 1 THEN 'Habilitado' ELSE 'Inhabilitado' END AS 'EstadoCliente'
FROM            Clientes
GO
/****** Object:  StoredProcedure [dbo].[SelectCompraFecha]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCompraFecha]
(
	@FechayHora smalldatetime,
	@CodPago smalldatetime
)
AS
	SET NOCOUNT ON;
SELECT        NumCompra, CodProv, CodPago, CodTransa, CodEmple, FechayHora, Total
FROM            Compras
WHERE        (FechayHora >= @FechayHora) AND (FechayHora <= @CodPago)
GO
/****** Object:  StoredProcedure [dbo].[SelectCompras]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCompras]
AS
	SET NOCOUNT ON;
SELECT        NumCompra, CodProv, CodPago, CodTransa, CodEmple, FechayHora, Total
FROM            Compras
GO
/****** Object:  StoredProcedure [dbo].[SelectDetalleVenta]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectDetalleVenta]
(
	@NumVent int
)
AS
	SET NOCOUNT ON;
SELECT        NumVent, CodProduc, NombProduc, Impuesto, CantVenta, PrecioVenta, SubTotal
FROM            DetalleVentas
WHERE        (NumVent = @NumVent)
ORDER BY NumVent DESC
GO
/****** Object:  StoredProcedure [dbo].[SelectEmpleado]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectEmpleado]
AS
	SET NOCOUNT ON;
SELECT        CodEmple, NombEmple, Contraseña, CASE WHEN NivelEmple = 1 THEN 'Gerente' ELSE 'General' END AS 'NiveldelEmpleado', 
                         CASE WHEN EstadoEmple = 1 THEN 'Habilitado' ELSE 'Inhabilitado' END AS 'EstadodelEmpleado'
FROM            Empleados
GO
/****** Object:  StoredProcedure [dbo].[SelectFactura]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFactura]
AS
	SET NOCOUNT ON;
SELECT        TOP (1) V.NumVent, C.NombCli, V.FechayHoraVenta, F.DescPago, T.DescTransa, E.NombEmple, V.Total
FROM            Ventas AS V INNER JOIN
                         Clientes AS C ON V.CodCli = C.CodCli INNER JOIN
                         FormasPago AS F ON V.CodPago = F.CodPago INNER JOIN
                         Transacciones AS T ON V.CodTransa = T.CodTransa INNER JOIN
                         Empleados AS E ON V.CodEmple = E.CodEmple
ORDER BY V.NumVent DESC
GO
/****** Object:  StoredProcedure [dbo].[SelectFacturaV]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFacturaV]
(
	@NumVent int
)
AS
	SET NOCOUNT ON;
SELECT        V.NumVent, C.NombCli, V.FechayHoraVenta, FP.DescPago, T.DescTransa, E.NombEmple, V.Total, DV.NumVent AS Expr1, DV.CodProduc, DV.NombProduc, DV.Impuesto, DV.CantVenta, DV.PrecioVenta, DV.SubTotal
FROM            Ventas AS V INNER JOIN
                         DetalleVentas AS DV ON V.NumVent = DV.NumVent INNER JOIN
                         Clientes AS C ON V.CodCli = C.CodCli INNER JOIN
                         FormasPago AS FP ON V.CodPago = FP.CodPago INNER JOIN
                         Transacciones AS T ON V.CodTransa = T.CodTransa INNER JOIN
                         Empleados AS E ON E.CodEmple = V.CodEmple INNER JOIN
                         Producto AS P ON DV.CodProduc = P.CodProduc
WHERE        (V.NumVent = @NumVent)
GO
/****** Object:  StoredProcedure [dbo].[SelectMasVendido]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectMasVendido]
AS
	SET NOCOUNT ON;
SELECT        CodProduc AS 'CodigoProducto', NombProduc AS 'NombreProducto', SUM(CantVenta) AS 'Cantidad'
FROM            DetalleVentas
GROUP BY CodProduc, NombProduc
ORDER BY 'Cantidad' DESC
GO
/****** Object:  StoredProcedure [dbo].[SelectProductoParametro]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectProductoParametro]
(
	@CodCateg int
)
AS
	SET NOCOUNT ON;
SELECT        CodProduc AS 'CodigoProducto', NombProduc AS 'NombreProducto', DescripProduc AS 'Descripcion', CodProv AS 'CodigoProveedor', PrimerPrecio, SegundoPrecio, TercerPrecio, UnidadesStock AS 'UnidadesEnStock', 
                         Minimo AS 'UnidadesMinimas', Maximo AS 'UnidadesMaximas'
FROM            Producto
WHERE        (CodCateg = @CodCateg)
GO
/****** Object:  StoredProcedure [dbo].[SelectProveedor]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectProveedor]
AS
	SET NOCOUNT ON;
SELECT        CodProv, NombProv, TelProv, NombContProv, CorreoProv, CorreoContProv, TelContProv, DirecProv, CASE WHEN EstadoProv = 1 THEN 'Habilitado' ELSE 'Inhabilitado' END AS EstadoProveedor
FROM            Proveedores
GO
/****** Object:  StoredProcedure [dbo].[SelectVenta]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVenta]
(
	@NumVent int
)
AS
	SET NOCOUNT ON;
SELECT        NumVent, CodCli, FechayHoraVenta, CodPago, CodTransa, CodEmple, Total
FROM            Ventas
WHERE        (NumVent = @NumVent)
GO
/****** Object:  StoredProcedure [dbo].[SelectVentaDetalle]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVentaDetalle]
(
	@NumVent int
)
AS
	SET NOCOUNT ON;
SELECT        NumVent, CodProduc, NombProduc, Impuesto, CantVenta, PrecioVenta, SubTotal
FROM            DetalleVentas
WHERE        (NumVent = @NumVent)
GO
/****** Object:  StoredProcedure [dbo].[SelectVentaEncabezado]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVentaEncabezado]
AS
	SET NOCOUNT ON;
SELECT        TOP (1) V.NumVent, C.NombCli, V.FechayHoraVenta, F.DescPago, T.DescTransa, E.NombEmple, V.Total
FROM            Ventas AS V INNER JOIN
                         Clientes AS C ON V.CodCli = C.CodCli INNER JOIN
                         FormasPago AS F ON V.CodPago = F.CodPago INNER JOIN
                         Transacciones AS T ON V.CodTransa = T.CodTransa INNER JOIN
                         Empleados AS E ON V.CodEmple = E.CodEmple
ORDER BY V.NumVent DESC
GO
/****** Object:  StoredProcedure [dbo].[SelectVentaFecha]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVentaFecha]
(
	@FechayHoraVenta datetime,
	@CodPago datetime
)
AS
	SET NOCOUNT ON;
SELECT        NumVent, CodCli, FechayHoraVenta, CodPago, CodTransa, CodEmple, Total
FROM            Ventas
WHERE        (FechayHoraVenta >= @FechayHoraVenta) AND (FechayHoraVenta <= @CodPago)
GO
/****** Object:  StoredProcedure [dbo].[SelectVentas]    Script Date: 18/6/2021 07:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVentas]
AS
	SET NOCOUNT ON;
SELECT        NumVent, CodCli, FechayHoraVenta, CodPago, CodTransa, CodEmple, Total
FROM            Ventas
GO
USE [master]
GO
ALTER DATABASE [BazarRoxana] SET  READ_WRITE 
GO
