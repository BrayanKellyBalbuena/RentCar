---Base de datos Proyecto Exoneración Propieraria 1
DROP DATABASE IF EXISTS RentCar
GO

CREATE DATABASE RentCar
GO 
USE RentCar
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
    [Name] NVARCHAR(256),
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

CREATE TABLE Menues(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(256) NOT NULL,
    [State] BIT NOT NULL,
    CONSTRAINT PK_Menues_Id PRIMARY KEY(Id)
)

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
    BrandId INT NOT NULL,
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

CREATE TABLE Car (
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(200) NOT NULL,
    ChasisNumber INT NOT NULL,
    EngineNumber INT NOT NULL,
    PlacaNumber INT NOT NULL,
    CarCategoryId INT NOT NULL,
    BrandId INT NOT NULL,
    ModelId INT NOT NULL,
    FluelTypeId INT NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_Cars_Id PRIMARY KEY(Id),
    CONSTRAINT FK_Cars_CarCategories_Id FOREIGN KEY(CarCategoryId)
        REFERENCES CarCategories(Id)
)

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

CREATE TABLE Clients(
    Id INT NOT NULL IDENTITY,
    [Name] NVARCHAR(128) NOT NULL,
    IdentificationCard TINYINT NOT NULL,
    CreditCardNumber TINYINT NOT NULL,
    CreditLimit DECIMAL(12,2),
    PersonTypeId INT NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_Clients_Id PRIMARY KEY(Id),
    CONSTRAINT FK_Clients_PersonTypes_Id FOREIGN KEY (PersonTypeId) REFERENCES PersonTypes(Id)
)

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


CREATE TABLE CarsInspections
(
    Id INT NOT NULL IDENTITY,
    CarId INT NOT NULL,
    ClienteId INt NOT NULL,
    HasScratch INT NOT NULL,
    HasTires BIT NOT NULL,
    FluelQuantity FLOAT,
    HastHydraulicJack BIT NOT NULL,
    HasReplacementTires BIT NOT NULL,
    HasBrokenCrystal BIT NOT NULL,
    FrontRightTireState BIT NOT NULL,
    FrontLeftTireState BIT NOT NULL,
    BackRightTireState BIT NOT NULL,
    BackLeftTireState BIT NOT NULL,
    InspectionsDate DATETIME2 NOT NULL,
    EmployeeId INT NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_CarsInspections PRIMARY KEY (Id),
    CONSTRAINT FK_CarsInspections_EmployeeId FOREIGN KEY(EmployeeId) REFERENCES Employees(Id),
    CONSTRAINT FK_CarsInspections_ClienteIdId FOREIGN KEY(ClienteId) REFERENCES Clients(Id)
)

CREATE TABLE DevolutionAndRent(
    Id INT NOT NULL IDENTITY,
    EmployeeId INT NOT NULL ,
    ClientId INT NOT NULL,
    RentDate DATETIME NOT NULL,
    DevolutionDate DATETIME NOT NULL,
    AmountPerDay DECIMAL (12, 2) NOT NULL,
    DayQuantity INT NOT NULL,
    Comentary NVARCHAR(1000) NOT NULL,
    [State] BIT NOT NULL,
    CreatedBy NVARCHAR(60),
    CreatedDate DATETIME2 NOT NULL,
    ModifiedBy NVARCHAR(60),
    ModifiedDate DATETIME2,
    CONSTRAINT PK_DevolutionAndRent_Id PRIMARY KEY (Id),
    CONSTRAINT FK_DevolutionAndRent_Employees_Id FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    CONSTRAINT FK_DevolutionAndRent_Clients_Id FOREIGN KEY (ClientId) REFERENCES Clients(Id)
)
----Indexes Clients Table---
CREATE NONCLUSTERED INDEX IX_Clients_Name ON Clients([name])
CREATE UNIQUE INDEX IXU_Clients_IdentificationCard ON Clients(IdentificationCard)
CREATE NONCLUSTERED INDEX IX_Clients_CreditCarNumber ON Clients(CreditCardNumber)
CREATE NONCLUSTERED INDEX IX_Employees_Name ON Clients([name])

GO
/*No. Renta
Empleado
Vehículo
Cliente
Fecha Renta
Fecha Devolución
Monto x Día
Cantidad de días
Comentario
Estado
*/