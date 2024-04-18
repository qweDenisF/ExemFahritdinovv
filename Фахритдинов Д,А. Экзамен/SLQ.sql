USE [master]
GO
/****** Object:  Database [BeautyShopFD]    Script Date: 18.04.2024 15:36:59 ******/
CREATE DATABASE [BeautyShopFD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BeautyShopFD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BeautyShopFD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'BeautyShopFD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BeautyShopFD_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BeautyShopFD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BeautyShopFD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BeautyShopFD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BeautyShopFD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BeautyShopFD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BeautyShopFD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BeautyShopFD] SET ARITHABORT OFF 
GO
ALTER DATABASE [BeautyShopFD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BeautyShopFD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BeautyShopFD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BeautyShopFD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BeautyShopFD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BeautyShopFD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BeautyShopFD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BeautyShopFD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BeautyShopFD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BeautyShopFD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BeautyShopFD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BeautyShopFD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BeautyShopFD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BeautyShopFD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BeautyShopFD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BeautyShopFD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BeautyShopFD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BeautyShopFD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BeautyShopFD] SET  MULTI_USER 
GO
ALTER DATABASE [BeautyShopFD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BeautyShopFD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BeautyShopFD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BeautyShopFD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BeautyShopFD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BeautyShopFD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BeautyShopFD] SET QUERY_STORE = OFF
GO
USE [BeautyShopFD]
GO
/****** Object:  Table [dbo].[Запись]    Script Date: 18.04.2024 15:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Запись](
	[IDK] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [nchar](40) NULL,
	[Time] [datetime] NOT NULL,
	[Serves] [nchar](40) NOT NULL,
	[Master] [nchar](40) NOT NULL,
 CONSTRAINT [PK_Запись] PRIMARY KEY CLUSTERED 
(
	[IDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Клиент]    Script Date: 18.04.2024 15:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Клиент](
	[IDK] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [nchar](40) NOT NULL,
	[PhoneK] [real] NOT NULL,
	[EMail] [nchar](20) NOT NULL,
	[KolZak] [int] NULL,
	[Name] [nchar](40) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Клиент] PRIMARY KEY CLUSTERED 
(
	[IDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Расписание]    Script Date: 18.04.2024 15:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Расписание](
	[IDS] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [nchar](40) NOT NULL,
	[PhoneSot] [real] NOT NULL,
	[Dolg] [nchar](40) NOT NULL,
	[Rasp] [time](4) NOT NULL,
	[Rasp2] [time](4) NOT NULL,
 CONSTRAINT [PK_Расписание] PRIMARY KEY CLUSTERED 
(
	[IDS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Услуги]    Script Date: 18.04.2024 15:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Услуги](
	[NameServ] [nchar](40) NOT NULL,
	[Dolg] [nchar](40) NOT NULL,
	[Price] [float] NOT NULL,
	[IDS] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Услуги] PRIMARY KEY CLUSTERED 
(
	[IDS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Запись]  WITH CHECK ADD  CONSTRAINT [FK_Запись_Клиент] FOREIGN KEY([IDK])
REFERENCES [dbo].[Клиент] ([IDK])
GO
ALTER TABLE [dbo].[Запись] CHECK CONSTRAINT [FK_Запись_Клиент]
GO
USE [master]
GO
ALTER DATABASE [BeautyShopFD] SET  READ_WRITE 
GO
