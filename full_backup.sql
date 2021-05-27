USE [master]
GO
/****** Object:  Database [RentCar]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE DATABASE [RentCar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentCar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.DEVELOP\MSSQL\DATA\RentCar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentCar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.DEVELOP\MSSQL\DATA\RentCar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RentCar] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentCar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentCar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentCar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentCar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentCar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentCar] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentCar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentCar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentCar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentCar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentCar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentCar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentCar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentCar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentCar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentCar] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RentCar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentCar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentCar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentCar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentCar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentCar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentCar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentCar] SET RECOVERY FULL 
GO
ALTER DATABASE [RentCar] SET  MULTI_USER 
GO
ALTER DATABASE [RentCar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentCar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentCar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentCar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentCar] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RentCar', N'ON'
GO
ALTER DATABASE [RentCar] SET QUERY_STORE = OFF
GO
USE [RentCar]
GO
/****** Object:  User [rentcar_user]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE USER [rentcar_user] FOR LOGIN [rentcar_user] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [rentcar_user]
GO
ALTER ROLE [db_datareader] ADD MEMBER [rentcar_user]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [rentcar_user]
GO
/****** Object:  Table [dbo].[Access]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Access](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Access_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarBrands]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarBrands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Description] [nvarchar](512) NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [Pk_Brands_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarCategories]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](512) NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [Pk_CarTypes_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarModels]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarModels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarBrandId] [int] NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Description] [nvarchar](512) NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_CarModels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[ChassisNumber] [nchar](17) NOT NULL,
	[EngineNumber] [nvarchar](15) NOT NULL,
	[PlacaNumber] [nvarchar](7) NOT NULL,
	[CarCategoryId] [int] NOT NULL,
	[CarBrandId] [int] NOT NULL,
	[CarModelId] [int] NOT NULL,
	[FluelCategoryId] [int] NOT NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Cars_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Cars_ChasisNumber] UNIQUE NONCLUSTERED 
(
	[ChassisNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Cars_EngineNumber] UNIQUE NONCLUSTERED 
(
	[EngineNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Cars_PlacaNumber] UNIQUE NONCLUSTERED 
(
	[PlacaNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarsInspections]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarsInspections](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[HasScratch] [bit] NOT NULL,
	[HasTires] [bit] NOT NULL,
	[FluelQuantity] [float] NULL,
	[HasHydraulicJack] [bit] NOT NULL,
	[HasReplacementTires] [bit] NOT NULL,
	[HasBrokenCrystal] [bit] NOT NULL,
	[FrontRightTireState] [bit] NOT NULL,
	[FrontLeftTireState] [bit] NOT NULL,
	[BackRightTireState] [bit] NOT NULL,
	[BackLeftTireState] [bit] NOT NULL,
	[InspectionsDate] [datetime2](7) NOT NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_CarsInspections] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[IdentificationCard] [char](11) NOT NULL,
	[CreditCardNumber] [char](16) NOT NULL,
	[CreditLimit] [decimal](12, 2) NULL,
	[PersonTypeId] [int] NOT NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Clients_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DevolutionAndRent]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DevolutionAndRent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[CarId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[RentDate] [datetime] NOT NULL,
	[DevolutionDate] [datetime] NULL,
	[AmountPerDay] [decimal](12, 2) NOT NULL,
	[DayQuantity] [int] NULL,
	[Comentary] [nvarchar](1000) NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_DevolutionAndRent_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[IdentificationCard] [nchar](11) NOT NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Employees_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FluelCategories]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FluelCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](512) NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_FluelCategories_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menues]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menues](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[State] [bit] NOT NULL,
 CONSTRAINT [PK_Menues_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonTypes]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Description] [nvarchar](512) NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_PersonTypes_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Roles_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](2) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_UserRoles_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[UserName] [nvarchar](60) NOT NULL,
	[UserPassword] [nvarchar](64) NOT NULL,
	[State] [bit] NOT NULL,
	[CreatedBy] [nvarchar](60) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [nvarchar](60) NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Users_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Brands_Name]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Brands_Name] ON [dbo].[CarBrands]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarModels_BrandId]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarModels_BrandId] ON [dbo].[CarModels]
(
	[CarBrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CarModels_Name]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarModels_Name] ON [dbo].[CarModels]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Clients_CreditCarNumber]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Clients_CreditCarNumber] ON [dbo].[Clients]
(
	[CreditCardNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Clients_Name]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Clients_Name] ON [dbo].[Clients]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Employees_Name]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Employees_Name] ON [dbo].[Clients]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IXU_Clients_IdentificationCard]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IXU_Clients_IdentificationCard] ON [dbo].[Clients]
(
	[IdentificationCard] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IXU_Employee_IdentificationCard]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IXU_Employee_IdentificationCard] ON [dbo].[Employees]
(
	[IdentificationCard] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FluelCategories_Name]    Script Date: 10/16/2019 10:58:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_FluelCategories_Name] ON [dbo].[FluelCategories]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Access]  WITH CHECK ADD  CONSTRAINT [FK_Access_Menues_MenuId] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menues] ([Id])
GO
ALTER TABLE [dbo].[Access] CHECK CONSTRAINT [FK_Access_Menues_MenuId]
GO
ALTER TABLE [dbo].[Access]  WITH CHECK ADD  CONSTRAINT [FK_Access_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Access] CHECK CONSTRAINT [FK_Access_Roles_RoleId]
GO
ALTER TABLE [dbo].[CarModels]  WITH CHECK ADD  CONSTRAINT [FK_CarModels_CarBrands_Id] FOREIGN KEY([CarBrandId])
REFERENCES [dbo].[CarBrands] ([Id])
GO
ALTER TABLE [dbo].[CarModels] CHECK CONSTRAINT [FK_CarModels_CarBrands_Id]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Brands_Id] FOREIGN KEY([CarBrandId])
REFERENCES [dbo].[CarBrands] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Brands_Id]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_CarCategories_Id] FOREIGN KEY([CarCategoryId])
REFERENCES [dbo].[CarCategories] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_CarCategories_Id]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_FluelTypes_Id] FOREIGN KEY([FluelCategoryId])
REFERENCES [dbo].[FluelCategories] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_FluelTypes_Id]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Models_Id] FOREIGN KEY([CarModelId])
REFERENCES [dbo].[CarModels] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Models_Id]
GO
ALTER TABLE [dbo].[CarsInspections]  WITH CHECK ADD  CONSTRAINT [FK_CarsInspections_ClienteIdId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[CarsInspections] CHECK CONSTRAINT [FK_CarsInspections_ClienteIdId]
GO
ALTER TABLE [dbo].[CarsInspections]  WITH CHECK ADD  CONSTRAINT [FK_CarsInspections_EmployeeId] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[CarsInspections] CHECK CONSTRAINT [FK_CarsInspections_EmployeeId]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_PersonTypes_Id] FOREIGN KEY([PersonTypeId])
REFERENCES [dbo].[PersonTypes] ([Id])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_PersonTypes_Id]
GO
ALTER TABLE [dbo].[DevolutionAndRent]  WITH CHECK ADD  CONSTRAINT [FK_DevolutionAndRent_Car_Id] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
GO
ALTER TABLE [dbo].[DevolutionAndRent] CHECK CONSTRAINT [FK_DevolutionAndRent_Car_Id]
GO
ALTER TABLE [dbo].[DevolutionAndRent]  WITH CHECK ADD  CONSTRAINT [FK_DevolutionAndRent_Clients_Id] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[DevolutionAndRent] CHECK CONSTRAINT [FK_DevolutionAndRent_Clients_Id]
GO
ALTER TABLE [dbo].[DevolutionAndRent]  WITH CHECK ADD  CONSTRAINT [FK_DevolutionAndRent_Employees_Id] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[DevolutionAndRent] CHECK CONSTRAINT [FK_DevolutionAndRent_Employees_Id]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_User_UserId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees_Id] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees_Id]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [Chk_Clients_CreditCardNumber] CHECK  (([CreditCardNumber] like '%[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]%'))
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [Chk_Clients_CreditCardNumber]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [Chk_Clients_IdentificationCard] CHECK  (([CreditCardNumber] like '%[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]%'))
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [Chk_Clients_IdentificationCard]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [Chk_Employees_IdentificationCard] CHECK  (([IdentificationCard] like '%[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]%'))
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [Chk_Employees_IdentificationCard]
GO
/****** Object:  StoredProcedure [dbo].[InspectionReport]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InspectionReport]
AS
SET NOCOUNT ON;

SELECT C.[Name] AS Cliente, E.[Name] AS Employee,
	CASE [HasScratch] WHEN 1 THEN 'Yes' ELSE 'No' END HasScratch,
	CASE [HasTires] WHEN 1 THEN 'Yes' ELSE 'No' END HasTires,
	CASE [FluelQuantity] WHEN 1 THEN 'Yes' ELSE 'No' END FluelQuantity,
	CASE [HasHydraulicJack] WHEN 1 THEN 'Yes' ELSE 'No' END HasHydraulicJack,
	CASE [HasBrokenCrystal] WHEN 1 THEN 'Yes' ELSE 'No' END HasBrokenCrystal, 
	CASE [FrontRightTireState] WHEN 1 THEN 'Yes' ELSE 'No' END FrontRightTireState,
	CASE [FrontLeftTireState] WHEN 1 THEN 'Yes' ELSE 'No' END FrontLeftTireState,
	CASE [BackRightTireState] WHEN 1 THEN 'Yes' ELSE 'No' END BackRightTireState,
	CASE [BackLeftTireState] WHEN 1 THEN 'Yes' ELSE 'No' END BackLeftTireState,
	[InspectionsDate]
FROM [dbo].[CarsInspections] CI 
	INNER JOIN Cars C ON CI.CarId = C.Id
	INNER JOIN Employees E ON CI.EmployeeId = E.Id
WHERE CI.[State] = 1
GO
/****** Object:  StoredProcedure [dbo].[RentReports]    Script Date: 10/16/2019 10:58:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RentReports]
AS

SET NOCOUNT ON;

SELECT 
	E.[Name] AS Empleado,
	C.[Name] AS Cliente,
	Ca.[Name] AS Carro,
	Ca.PlacaNumber,
	[RentDate],
	[DevolutionDate], 
	[AmountPerDay],
	[AmountPerDay],
	[DayQuantity],
	[Comentary]
FROM [dbo].[DevolutionAndRent] DR
	INNER JOIN Employees E ON DR.EmployeeId = E.Id
	INNER JOIN Clients C ON DR.ClientId = C.Id
	INNER JOIN Cars Ca ON DR.CarId = Ca.Id
WHERE DR.[State] = 1
GO
USE [master]
GO
ALTER DATABASE [RentCar] SET  READ_WRITE 
GO
