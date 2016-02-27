
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/27/2016 09:21:19
-- Generated from EDMX file: C:\Users\Иван\Desktop\FamilyCash\FamilyCash\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FamilyDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ExpenceSet'
CREATE TABLE [dbo].[ExpenceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ExpDate] datetime  NOT NULL,
    [ExpDescription] nvarchar(max)  NOT NULL,
    [Summa] decimal(10,2)  NOT NULL,
    [TypeExpenceId] int  NOT NULL
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [SecondName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProfitSet'
CREATE TABLE [dbo].[ProfitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProfDate] datetime  NOT NULL,
    [ProfDescription] nvarchar(max)  NOT NULL,
    [SumEntrance] decimal(10,2)  NOT NULL,
    [SumAdded] decimal(10,2)  NOT NULL,
    [PersonId] int  NOT NULL
);
GO

-- Creating table 'TypeExpenceSet'
CREATE TABLE [dbo].[TypeExpenceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeExpDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TypeRevenueSet'
CREATE TABLE [dbo].[TypeRevenueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeRevDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RevenueSet'
CREATE TABLE [dbo].[RevenueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RevDate] datetime  NOT NULL,
    [RevDescription] nvarchar(max)  NOT NULL,
    [RevSum] decimal(10,2)  NOT NULL,
    [RevProcent] decimal(10,2)  NOT NULL,
    [TypeRevenueId] int  NOT NULL,
    [PersonId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ExpenceSet'
ALTER TABLE [dbo].[ExpenceSet]
ADD CONSTRAINT [PK_ExpenceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProfitSet'
ALTER TABLE [dbo].[ProfitSet]
ADD CONSTRAINT [PK_ProfitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeExpenceSet'
ALTER TABLE [dbo].[TypeExpenceSet]
ADD CONSTRAINT [PK_TypeExpenceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeRevenueSet'
ALTER TABLE [dbo].[TypeRevenueSet]
ADD CONSTRAINT [PK_TypeRevenueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RevenueSet'
ALTER TABLE [dbo].[RevenueSet]
ADD CONSTRAINT [PK_RevenueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TypeExpenceId] in table 'ExpenceSet'
ALTER TABLE [dbo].[ExpenceSet]
ADD CONSTRAINT [FK_TypeExpenceExpence]
    FOREIGN KEY ([TypeExpenceId])
    REFERENCES [dbo].[TypeExpenceSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeExpenceExpence'
CREATE INDEX [IX_FK_TypeExpenceExpence]
ON [dbo].[ExpenceSet]
    ([TypeExpenceId]);
GO

-- Creating foreign key on [TypeRevenueId] in table 'RevenueSet'
ALTER TABLE [dbo].[RevenueSet]
ADD CONSTRAINT [FK_TypeRevenueRevenue]
    FOREIGN KEY ([TypeRevenueId])
    REFERENCES [dbo].[TypeRevenueSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeRevenueRevenue'
CREATE INDEX [IX_FK_TypeRevenueRevenue]
ON [dbo].[RevenueSet]
    ([TypeRevenueId]);
GO

-- Creating foreign key on [PersonId] in table 'RevenueSet'
ALTER TABLE [dbo].[RevenueSet]
ADD CONSTRAINT [FK_PersonRevenue]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[PersonSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonRevenue'
CREATE INDEX [IX_FK_PersonRevenue]
ON [dbo].[RevenueSet]
    ([PersonId]);
GO

-- Creating foreign key on [PersonId] in table 'ProfitSet'
ALTER TABLE [dbo].[ProfitSet]
ADD CONSTRAINT [FK_PersonProfit]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[PersonSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonProfit'
CREATE INDEX [IX_FK_PersonProfit]
ON [dbo].[ProfitSet]
    ([PersonId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------