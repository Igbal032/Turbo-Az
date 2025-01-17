USE [master]
GO
/****** Object:  Database [TurboAz]    Script Date: 3/31/2019 11:30:13 PM ******/
CREATE DATABASE [TurboAz]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TurboAz', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TurboAz.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TurboAz_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TurboAz_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TurboAz] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TurboAz].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TurboAz] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TurboAz] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TurboAz] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TurboAz] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TurboAz] SET ARITHABORT OFF 
GO
ALTER DATABASE [TurboAz] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TurboAz] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TurboAz] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TurboAz] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TurboAz] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TurboAz] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TurboAz] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TurboAz] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TurboAz] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TurboAz] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TurboAz] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TurboAz] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TurboAz] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TurboAz] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TurboAz] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TurboAz] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TurboAz] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TurboAz] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TurboAz] SET  MULTI_USER 
GO
ALTER DATABASE [TurboAz] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TurboAz] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TurboAz] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TurboAz] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TurboAz] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TurboAz] SET QUERY_STORE = OFF
GO
USE [TurboAz]
GO
/****** Object:  Table [dbo].[AdminPanel]    Script Date: 3/31/2019 11:30:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminPanel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AdminPanel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ModelID] [int] NULL,
	[YearID] [int] NULL,
	[EPowID] [int] NULL,
	[FuelID] [int] NULL,
	[StatusID] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car_Year]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car_Year](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Year] [int] NULL,
 CONSTRAINT [PK_Car_Year] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnginerPower]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnginerPower](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EPowName] [int] NULL,
 CONSTRAINT [PK_EnginerPower_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fuel]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fuel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FuelName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Fuel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marka]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marka](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MarkaName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Marka] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Model]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ModelName] [nvarchar](50) NOT NULL,
	[MarkaID] [int] NOT NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SelledCar]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SelledCar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ModelIDs] [int] NULL,
	[YearIDs] [int] NULL,
	[EpowIDs] [int] NULL,
	[FuelIDs] [int] NULL,
	[StatusIDs] [int] NULL,
	[By] [nvarchar](50) NULL,
 CONSTRAINT [PK_SelledCar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [bit] NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserPanel]    Script Date: 3/31/2019 11:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPanel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[E-mail] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[ForgetingPassword] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserPanel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Car_Year] FOREIGN KEY([YearID])
REFERENCES [dbo].[Car_Year] ([ID])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Car_Year]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_EnginerPower] FOREIGN KEY([EPowID])
REFERENCES [dbo].[EnginerPower] ([ID])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_EnginerPower]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Fuel] FOREIGN KEY([FuelID])
REFERENCES [dbo].[Fuel] ([ID])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Fuel]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Model] FOREIGN KEY([ModelID])
REFERENCES [dbo].[Model] ([ID])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Model]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([ID])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Status]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_Marka] FOREIGN KEY([MarkaID])
REFERENCES [dbo].[Marka] ([ID])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_Marka]
GO
ALTER TABLE [dbo].[SelledCar]  WITH CHECK ADD  CONSTRAINT [FK_SelledCar_Car_Year] FOREIGN KEY([YearIDs])
REFERENCES [dbo].[Car_Year] ([ID])
GO
ALTER TABLE [dbo].[SelledCar] CHECK CONSTRAINT [FK_SelledCar_Car_Year]
GO
ALTER TABLE [dbo].[SelledCar]  WITH CHECK ADD  CONSTRAINT [FK_SelledCar_EnginerPower] FOREIGN KEY([EpowIDs])
REFERENCES [dbo].[EnginerPower] ([ID])
GO
ALTER TABLE [dbo].[SelledCar] CHECK CONSTRAINT [FK_SelledCar_EnginerPower]
GO
ALTER TABLE [dbo].[SelledCar]  WITH CHECK ADD  CONSTRAINT [FK_SelledCar_Fuel] FOREIGN KEY([FuelIDs])
REFERENCES [dbo].[Fuel] ([ID])
GO
ALTER TABLE [dbo].[SelledCar] CHECK CONSTRAINT [FK_SelledCar_Fuel]
GO
ALTER TABLE [dbo].[SelledCar]  WITH CHECK ADD  CONSTRAINT [FK_SelledCar_Model] FOREIGN KEY([ModelIDs])
REFERENCES [dbo].[Model] ([ID])
GO
ALTER TABLE [dbo].[SelledCar] CHECK CONSTRAINT [FK_SelledCar_Model]
GO
ALTER TABLE [dbo].[SelledCar]  WITH CHECK ADD  CONSTRAINT [FK_SelledCar_Status] FOREIGN KEY([StatusIDs])
REFERENCES [dbo].[Status] ([ID])
GO
ALTER TABLE [dbo].[SelledCar] CHECK CONSTRAINT [FK_SelledCar_Status]
GO
USE [master]
GO
ALTER DATABASE [TurboAz] SET  READ_WRITE 
GO
