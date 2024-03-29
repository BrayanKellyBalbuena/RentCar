---Base de datos Proyecto Exoneración Propieraria 1
DROP DATABASE IF EXISTS RentCar
GO

CREATE DATABASE RentCar
GO 
USE RentCar
GO

CREATE LOGIN rentcar_user
WITH PASSWORD 'rentcardb'

CREATE USER rentcar_user
FOR LOGIN rentcar_user
GO
ALTER ROLE db_datareader ADD MEMBER rentcar_user; 
ALTER ROLE db_datawriter ADD MEMBER rentcar_user; 
ALTER ROLE db_ddladmin ADD MEMBER rentcar_user; 
GO

DROP TABLE IF EXISTS dbo.DevolutionAndRent;
DROP TABLE IF EXISTS dbo.CarsInspections;
DROP TABLE IF EXISTS dbo.Car;
DROP TABLE IF EXISTS dbo.CarModels;
DROP TABLE IF EXISTS dbo.CarBrands;
DROP TABLE IF EXISTS dbo.FluelCategories;
DROP TABLE IF EXISTS dbo.Clients;
DROP TABLE IF EXISTS dbo.PersonType;
DROP TABLE IF EXISTS dbo.Employees;

DROP TABLE IF EXISTS dbo.Access;
DROP TABLE IF EXISTS dbo.UserRoles;
DROP TABLE IF EXISTS dbo.Roles;
DROP TABLE IF EXISTS dbo.Menues;
DROP TABLE IF EXISTS dbo.Users;

CREATE TABLE CarBrands(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(256) NOT NULL,
    [Description] NVARCHAR (512),
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2 
    CONSTRAINT Pk_Brands_Id PRIMARY KEY(Id),
)

---- Indexes Brands---
CREATE NONCLUSTERED INDEX IX_Brands_Name ON CarBrands([Name])
GO
--------------
CREATE TABLE CarModels(
    Id INT NOT NULL IDENTITY,
    CarBrandId INT NOT NULL,
    [Name] NVARCHAR(256) NOT NULL,
    [Description] NVARCHAR (512),
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_CarModels PRIMARY KEY (Id),
    CONSTRAINT FK_CarModels_CarBrands_Id FOREIGN KEY(CarBrandId) REFERENCES CarBrands(Id)
)

-------Index Models---------

CREATE NONCLUSTERED INDEX IX_CarModels_Name ON CarModels([Name]);
CREATE NONCLUSTERED INDEX IX_CarModels_BrandId ON CarModels(CarBrandId)

GO
CREATE TABLE FluelCategories(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(200) NOT NULL,
    [Description] NVARCHAR (512),
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_FluelCategories_Id PRIMARY KEY (Id)
)

CREATE NONCLUSTERED INDEX IX_FluelCategories_Name ON FluelCategories([Name])
GO
CREATE TABLE CarCategories (
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(200) NOT NULL,
    [Description] NVARCHAR (512),
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT Pk_CarTypes_Id PRIMARY KEY(Id)
)
GO
CREATE TABLE Cars (
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(200) NOT NULL,
    ChassisNumber NCHAR(17) NOT NULL,
    EngineNumber NVARCHAR(15) NOT NULL,
    PlacaNumber NVARCHAR(7) NOT NULL,
    CarCategoryId INT NOT NULL,
    CarBrandId INT NOT NULL,
    CarModelId INT NOT NULL,
    FluelCategoryId INT NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_Cars_Id PRIMARY KEY(Id),
    CONSTRAINT FK_Cars_CarCategories_Id FOREIGN KEY(CarCategoryId) REFERENCES CarCategories(Id),
	CONSTRAINT FK_Cars_Brands_Id FOREIGN KEY(CarBrandId) REFERENCES CarBrands(Id),
	CONSTRAINT FK_Cars_Models_Id FOREIGN KEY(CarModelId) REFERENCES CarModels(Id),
	CONSTRAINT FK_Cars_FluelTypes_Id FOREIGN KEY(FluelCategoryId) REFERENCES FluelCategories(Id),
	CONSTRAINT UQ_Cars_ChasisNumber UNIQUE(ChassisNumber),
	CONSTRAINT UQ_Cars_EngineNumber UNIQUE(EngineNumber),
	CONSTRAINT UQ_Cars_PlacaNumber UNIQUE(PlacaNumber),
)
GO
CREATE TABLE PersonTypes(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(20),
    [Description] NVARCHAR(512),
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_PersonTypes_Id PRIMARY KEY(Id)
)

GO
CREATE TABLE Clients(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(128) NOT NULL,
    IdentificationCard CHAR(11) NOT NULL,
    CreditCardNumber CHAR(16) NOT NULL,
    CreditLimit DECIMAL(12,2),
    PersonTypeId INT NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
	CONSTRAINT Chk_Clients_IdentificationCard CHECK(CreditCardNumber LIKE '%[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]%'),
	CONSTRAINT Chk_Clients_CreditCardNumber CHECK(CreditCardNumber LIKE '%[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]%'),
    CONSTRAINT PK_Clients_Id PRIMARY KEY(Id),
    CONSTRAINT FK_Clients_PersonTypes_Id FOREIGN KEY (PersonTypeId) REFERENCES PersonTypes(Id)
)
GO
CREATE TABLE Employees(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(128) NOT NULL,
    IdentificationCard NCHAR(11)  NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_Employees_Id PRIMARY KEY(Id),
    CONSTRAINT Chk_Employees_IdentificationCard
    CHECK(IdentificationCard LIKE '%[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]%' )
)
GO
---INDEX Employees
CREATE UNIQUE INDEX IXU_Employee_IdentificationCard ON Employees(IdentificationCard)

GO

CREATE TABLE CarsInspections
(
    Id INT NOT NULL IDENTITY,
    CarId INT NOT NULL,
    ClientId INt NOT NULL,
	EmployeeId INT NOT NULL,
    HasScratch BIT NOT NULL,
    HasTires BIT NOT NULL,
    FluelQuantity FLOAT,
    HasHydraulicJack BIT NOT NULL,
    HasReplacementTires BIT NOT NULL,
    HasBrokenCrystal BIT NOT NULL,
    FrontRightTireState BIT NOT NULL,
    FrontLeftTireState BIT NOT NULL,
    BackRightTireState BIT NOT NULL,
    BackLeftTireState BIT NOT NULL,
    InspectionsDate DATETIME2 NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_CarsInspections PRIMARY KEY (Id),
    CONSTRAINT FK_CarsInspections_EmployeeId FOREIGN KEY(EmployeeId) REFERENCES Employees(Id),
    CONSTRAINT FK_CarsInspections_ClienteIdId FOREIGN KEY(ClientId) REFERENCES Clients(Id)
)

DROP TABLE CarsInspections

CREATE TABLE DevolutionAndRent(
    Id INT NOT NULL IDENTITY,
    EmployeeId INT NOT NULL ,
    ClientId INT NOT NULL,
	CarId INT NOT NULL,
    RentDate DATETIME NOT NULL,
    DevolutionDate DATETIME NULL,
    AmountPerDay DECIMAL (12, 2) NOT NULL,
    DayQuantity INT NULL,
    Comentary NVARCHAR(1000),
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_DevolutionAndRent_Id PRIMARY KEY (Id),
    CONSTRAINT FK_DevolutionAndRent_Employees_Id FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    CONSTRAINT FK_DevolutionAndRent_Clients_Id FOREIGN KEY (ClientId) REFERENCES Clients(Id),
	CONSTRAINT FK_DevolutionAndRent_Car_Id FOREIGN KEY (CarId) REFERENCES Cars(Id)
)


----Indexes Clients Table---
CREATE NONCLUSTERED INDEX IX_Clients_Name ON Clients([name])
CREATE UNIQUE INDEX IXU_Clients_IdentificationCard ON Clients(IdentificationCard)
CREATE NONCLUSTERED INDEX IX_Clients_CreditCarNumber ON Clients(CreditCardNumber)
CREATE NONCLUSTERED INDEX IX_Employees_Name ON Clients([name])

CREATE TABLE Users
(
    Id INT NOT NULL IDENTITY,
    EmployeeId INT NOT NULL,
    UserName NVARCHAR(60) NOT NULL UNIQUE,
    UserPassword NVARCHAR(64) NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_Users_Id PRIMARY KEY(Id),
    CONSTRAINT FK_Users_Employees_Id FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
)
GO

CREATE TABLE Roles(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(256) UNIQUE,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy  NVARCHAR(60),
    ModifiedDate DATETIME2
    CONSTRAINT PK_Roles_Id PRIMARY KEY(Id)
)
GO

CREATE TABLE UserRoles(
    Id INT NOT NULL IDENTITY,
    UserId INT NOT NULL,
    RoleId INT NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(2),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_UserRoles_Id PRIMARY KEY(Id),
    CONSTRAINT FK_UserRoles_Roles_RoleId FOREIGN KEY (RoleId) REFERENCES Roles(Id),
    CONSTRAINT FK_UserRoles_User_UserId FOREIGN KEY (UserId) REFERENCES Users(Id)
)

GO
CREATE TABLE Menues(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(256) NOT NULL,
    [State] BIT NOT NULL,
    CONSTRAINT PK_Menues_Id PRIMARY KEY(Id)
)
GO

CREATE TABLE Access (
    Id INT NOT NULL IDENTITY,
    MenuId INT NOT NULL,
    RoleId INT NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_Access_Id PRIMARY KEY(Id),
    CONSTRAINT FK_Access_Menues_MenuId FOREIGN KEY (MenuId) REFERENCES Menues(Id),
    CONSTRAINT FK_Access_Roles_RoleId FOREIGN KEY (RoleId) REFERENCES Roles(Id)
)
GO

/*Reports**/

CREATE PROC RentReports
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

CREATE PROC InspectionReport
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