USE [master]
GO
/****** Object:  Database [BazarRoxana]    Script Date: 8/4/2021 09:51:52 ******/
CREATE DATABASE [BazarRoxana]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BazarRoxana', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.CAROLINA\MSSQL\DATA\BazarRoxana.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BazarRoxana_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.CAROLINA\MSSQL\DATA\BazarRoxana_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Categoria]    Script Date: 8/4/2021 09:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[CodCateg] [int] NOT NULL,
	[NombCateg] [nvarchar](50) NOT NULL,
	[EstadoCateg] [bit] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[CodCateg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 8/4/2021 09:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[CodCli] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Compras]    Script Date: 8/4/2021 09:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[NumCompra] [int] NOT NULL,
	[CodProv] [int] NOT NULL,
	[CodPago] [int] NOT NULL,
	[CodTransa] [int] NOT NULL,
	[CodEmple] [int] NOT NULL,
	[FechayHora] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[NumCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 8/4/2021 09:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[NumCompra] [int] NOT NULL,
	[CodProduc] [int] NOT NULL,
	[NombProduc] [nvarchar](50) NOT NULL,
	[Impuesto] [float] NOT NULL,
	[CantProduc] [int] NOT NULL,
	[PrecioProduc] [int] NOT NULL,
	[SubTotal] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 8/4/2021 09:51:53 ******/
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
/****** Object:  Table [dbo].[Empleados]    Script Date: 8/4/2021 09:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[CodEmple] [int] NOT NULL,
	[NombEmple] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[NivelEmple] [int] NOT NULL,
	[EstadoEmple] [bit] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[CodEmple] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormasPago]    Script Date: 8/4/2021 09:51:53 ******/
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
/****** Object:  Table [dbo].[NivelEmpleado]    Script Date: 8/4/2021 09:51:53 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 8/4/2021 09:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[CodProduc] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Proveedores]    Script Date: 8/4/2021 09:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[CodProv] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Transacciones]    Script Date: 8/4/2021 09:51:53 ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 8/4/2021 09:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[NumVent] [int] NOT NULL,
	[CodCli] [int] NOT NULL,
	[FechayHoraVenta] [datetime] NOT NULL,
	[CodPago] [int] NOT NULL,
	[CodTransa] [int] NOT NULL,
	[CodEmple] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[NumVent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([CodCli], [NombCli], [DirecCli], [TelCli], [CorreoCli], [EstadoCli]) VALUES (1, N'Carlos Amaya', N'as', 99889977, N'carlos1015@gmail.com', 1)
INSERT [dbo].[Clientes] ([CodCli], [NombCli], [DirecCli], [TelCli], [CorreoCli], [EstadoCli]) VALUES (2, N'Carolina', N'hscauvcsnvcsj', 98053535, N'carolina@gmail.com', 0)
GO
INSERT [dbo].[Empleados] ([CodEmple], [NombEmple], [Contraseña], [NivelEmple], [EstadoEmple]) VALUES (1, N'Daniel', N'rueda', 1, 1)
INSERT [dbo].[Empleados] ([CodEmple], [NombEmple], [Contraseña], [NivelEmple], [EstadoEmple]) VALUES (2, N'Carlos', N'Amaya', 2, 1)
INSERT [dbo].[Empleados] ([CodEmple], [NombEmple], [Contraseña], [NivelEmple], [EstadoEmple]) VALUES (3, N'Bessy', N'Carolina', 2, 1)
GO
INSERT [dbo].[FormasPago] ([CodPago], [DescPago]) VALUES (1, N'Credito')
INSERT [dbo].[FormasPago] ([CodPago], [DescPago]) VALUES (2, N'Contado')
GO
INSERT [dbo].[NivelEmpleado] ([NivelEmple], [DescriNivel]) VALUES (1, N'Gerente')
INSERT [dbo].[NivelEmpleado] ([NivelEmple], [DescriNivel]) VALUES (2, N'General')
GO
INSERT [dbo].[Proveedores] ([CodProv], [NombProv], [TelProv], [NombContProv], [CorreoProv], [CorreoContProv], [TelContProv], [DirecProv], [EstadoProv]) VALUES (1, N'A', 99889988, N'C', N'asd', N'asdasd', 88997788, N'as', 1)
INSERT [dbo].[Proveedores] ([CodProv], [NombProv], [TelProv], [NombContProv], [CorreoProv], [CorreoContProv], [TelContProv], [DirecProv], [EstadoProv]) VALUES (2, N'AssA', 99889988, N'CaaC', N'asdASD', N'asdasd', 88997788, N'as', 1)
GO
INSERT [dbo].[Transacciones] ([CodTransa], [DescTransa]) VALUES (1, N'Efectivo')
INSERT [dbo].[Transacciones] ([CodTransa], [DescTransa]) VALUES (2, N'Tarjeta de Credito')
INSERT [dbo].[Transacciones] ([CodTransa], [DescTransa]) VALUES (3, N'Tarjeta de Debito')
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
USE [master]
GO
ALTER DATABASE [BazarRoxana] SET  READ_WRITE 
GO
