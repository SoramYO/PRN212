create database [MilkTea]

USE [MilkTea]
GO


-- Employees table
CREATE TABLE [dbo].[Employees](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[fullName] [nvarchar](250) NULL,
	[phoneNumber] [varchar](15) NULL,
	[address] [nvarchar](500) NULL,
	[idCard] [varchar](150) NULL,
	[dateWork] [date] NULL,
	[img] [varbinary](max) NULL,
	[status] [bit] NULL,
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-- Login table
CREATE TABLE [dbo].[Login](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[idEmployee] [bigint] NULL,
	[userName] [varchar](250) NULL,
	[password] [varchar](max) NULL,
	[isUse] [bit] NULL,
	FOREIGN KEY (idEmployee) REFERENCES Employees(id)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-- MenuItems table
CREATE TABLE [dbo].[MenuItems](
	[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[idLogin] [bigint] NULL,
	[idMenuItems] [int] NULL,
) ON [PRIMARY]
GO

-- LoginRole table
CREATE TABLE [dbo].[LoginRole](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[idLogin] [bigint] NOT NULL,
	[idMenuItems] [int] NOT NULL,
	FOREIGN KEY (idLogin) REFERENCES Login(id),
	FOREIGN KEY (idMenuItems) REFERENCES MenuItems(id)
) ON [PRIMARY]
GO

-- Customers table
CREATE TABLE [dbo].[tbCustomer](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [nvarchar](500) NULL,
	[address] [nvarchar](500) NULL,
	[phone] [varchar](50) NULL,
	[description] [nvarchar](500) NULL,
	[status] [bit] NULL,
) ON [PRIMARY]
GO

-- GroupProduct table
CREATE TABLE [dbo].[tbGroupProduct](
	[idGr] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[nameGr] [nvarchar](500) NULL,
	[descriptionGr] [nvarchar](500) NULL,
) ON [PRIMARY]
GO

-- Product table
CREATE TABLE [dbo].[tbProduct](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[idGroupProduct] [bigint] NULL,
	[name] [nvarchar](500) NULL,
	[unit] [nvarchar](50) NULL,
	[unitPrice] [float] NULL,
	[description] [nvarchar](500) NULL,
	[img] [varbinary](max) NULL,
	FOREIGN KEY (idGroupProduct) REFERENCES tbGroupProduct(idGr)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-- GroupTb table
CREATE TABLE [dbo].[tbGroupTb](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [nvarchar](50) NULL,
	[description] [nvarchar](500) NULL,
) ON [PRIMARY]
GO

-- Table (tbTable) table
CREATE TABLE [dbo].[tbTable](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[nameTb] [nvarchar](50) NULL,
	[description] [nvarchar](50) NULL,
	[idGroup] [bigint] NULL,
	[status] [bit] NULL,
	FOREIGN KEY (idGroup) REFERENCES tbGroupTb(id)
) ON [PRIMARY]
GO

-- Bill table
CREATE TABLE [dbo].[tbBill](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[idTable] [bigint] NULL,
	[billDate] [datetime] NULL,
	[totalMoney] [float] NULL,
	[status] [bit] NULL,
	[description] [nvarchar](500) NULL,
	[idUser] [bigint] NULL,
	[idCustomer] [bigint] NULL,
	FOREIGN KEY (idTable) REFERENCES tbTable(id),
	FOREIGN KEY (idUser) REFERENCES Login(id),
	FOREIGN KEY (idCustomer) REFERENCES tbCustomer(id)
) ON [PRIMARY]
GO

-- BillDetail table
CREATE TABLE [dbo].[tbBillDetailt](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[unitPrice] [float] NULL,
	[quantity] [int] NULL,
	[idBill] [bigint] NULL,
	[idProduct] [bigint] NULL,
	[intoMoney] [float] NULL,
	[description] [nvarchar](500) NULL,
	FOREIGN KEY (idBill) REFERENCES tbBill(id),
	FOREIGN KEY (idProduct) REFERENCES tbProduct(id)
) ON [PRIMARY]
GO

-- Store table
CREATE TABLE [dbo].[tbStore](
	[id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[nameStore] [nvarchar](500) NULL,
	[addressStore] [nvarchar](500) NULL,
	[phoneStore] [nvarchar](500) NULL,
	[taxCode] [nvarchar](250) NULL,
) ON [PRIMARY]
GO
