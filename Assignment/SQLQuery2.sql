Create DATABASE ProductManagement;

CREATE TABLE [dbo].[Categories] (
    [id] INT  IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [name]        VARCHAR (255) NOT NULL,
    [description] TEXT          NULL,
);

CREATE TABLE [dbo].[Products] (
    [id] uniqueidentifier PRIMARY KEY NOT NULL,
    [name] VARCHAR(255) NOT NULL,
    [description] TEXT NULL,
    [price] DECIMAL(10, 2) NOT NULL,
    [category_id] INT NULL,
    [image_path] VARCHAR(255) NULL,
    [qr_code] VARCHAR(255) NULL,
    [bar_code] VARCHAR(255) NULL,
    FOREIGN KEY ([category_id]) REFERENCES [dbo].[Categories] ([id])
);

