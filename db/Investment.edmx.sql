
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/22/2021 18:35:45
-- Generated from EDMX file: C:\Users\mrvay\Desktop\правый фланг\вуз\ООП\coursework\db\Investment.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CourseworkBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TMarketTAsset]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TAsset] DROP CONSTRAINT [FK_TMarketTAsset];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountTMarket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TMarket] DROP CONSTRAINT [FK_AccountTMarket];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TMarket]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMarket];
GO
IF OBJECT_ID(N'[dbo].[TAsset]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TAsset];
GO
IF OBJECT_ID(N'[dbo].[Account]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Account];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TMarket'
CREATE TABLE [dbo].[TMarket] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Abbreviation] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [MIC] nvarchar(max)  NOT NULL,
    [Timezone] nvarchar(max)  NOT NULL,
    [Account_Id] int  NOT NULL
);
GO

-- Creating table 'TAsset'
CREATE TABLE [dbo].[TAsset] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [InstrumentName] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [Currency] nvarchar(max)  NOT NULL,
    [Abbreviation] nvarchar(max)  NOT NULL,
    [TMarket_Id] int  NOT NULL
);
GO

-- Creating table 'TAccount'
CREATE TABLE [dbo].[TAccount] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TMarket'
ALTER TABLE [dbo].[TMarket]
ADD CONSTRAINT [PK_TMarket]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TAsset'
ALTER TABLE [dbo].[TAsset]
ADD CONSTRAINT [PK_TAsset]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TAccount'
ALTER TABLE [dbo].[TAccount]
ADD CONSTRAINT [PK_TAccount]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TMarket_Id] in table 'TAsset'
ALTER TABLE [dbo].[TAsset]
ADD CONSTRAINT [FK_TMarketTAsset]
    FOREIGN KEY ([TMarket_Id])
    REFERENCES [dbo].[TMarket]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TMarketTAsset'
CREATE INDEX [IX_FK_TMarketTAsset]
ON [dbo].[TAsset]
    ([TMarket_Id]);
GO

-- Creating foreign key on [Account_Id] in table 'TMarket'
ALTER TABLE [dbo].[TMarket]
ADD CONSTRAINT [FK_AccountTMarket]
    FOREIGN KEY ([Account_Id])
    REFERENCES [dbo].[TAccount]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountTMarket'
CREATE INDEX [IX_FK_AccountTMarket]
ON [dbo].[TMarket]
    ([Account_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------