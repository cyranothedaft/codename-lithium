
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/18/2012 11:20:45
-- Generated from EDMX file: C:\files\priv\personal\eat\proj\dev\_github\codename-lithium\src\lithium.cli.net45\netDbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [lithium.netdb];
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

-- Creating table 'Models'
CREATE TABLE [dbo].[Models] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Line] nvarchar(max)  NOT NULL,
    [Trim] nvarchar(max)  NOT NULL,
    [DeviceTypeId] int  NOT NULL,
    [MfgrId] int  NOT NULL
);
GO

-- Creating table 'DeviceTypes'
CREATE TABLE [dbo].[DeviceTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Mfgrs'
CREATE TABLE [dbo].[Mfgrs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FactorySettingses'
CREATE TABLE [dbo].[FactorySettingses] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'OwnerTypes'
CREATE TABLE [dbo].[OwnerTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'OperatingSystems'
CREATE TABLE [dbo].[OperatingSystems] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Networks'
CREATE TABLE [dbo].[Networks] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'NetworkNodes'
CREATE TABLE [dbo].[NetworkNodes] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'IpAddrAssignTypes'
CREATE TABLE [dbo].[IpAddrAssignTypes] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'NetworkServiceTypes'
CREATE TABLE [dbo].[NetworkServiceTypes] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'NetworkServices'
CREATE TABLE [dbo].[NetworkServices] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Interfaces'
CREATE TABLE [dbo].[Interfaces] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [InterfaceTypeId] int  NOT NULL,
    [NetConnectorTypeId] int  NOT NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'Devices'
CREATE TABLE [dbo].[Devices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [InstanceNo] int  NOT NULL,
    [OwnerId] int  NOT NULL,
    [ModelId] int  NOT NULL
);
GO

-- Creating table 'InterfaceTypes'
CREATE TABLE [dbo].[InterfaceTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NetConnectorTypes'
CREATE TABLE [dbo].[NetConnectorTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Owners'
CREATE TABLE [dbo].[Owners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [PK_Models]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeviceTypes'
ALTER TABLE [dbo].[DeviceTypes]
ADD CONSTRAINT [PK_DeviceTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mfgrs'
ALTER TABLE [dbo].[Mfgrs]
ADD CONSTRAINT [PK_Mfgrs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FactorySettingses'
ALTER TABLE [dbo].[FactorySettingses]
ADD CONSTRAINT [PK_FactorySettingses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OwnerTypes'
ALTER TABLE [dbo].[OwnerTypes]
ADD CONSTRAINT [PK_OwnerTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OperatingSystems'
ALTER TABLE [dbo].[OperatingSystems]
ADD CONSTRAINT [PK_OperatingSystems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Networks'
ALTER TABLE [dbo].[Networks]
ADD CONSTRAINT [PK_Networks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NetworkNodes'
ALTER TABLE [dbo].[NetworkNodes]
ADD CONSTRAINT [PK_NetworkNodes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IpAddrAssignTypes'
ALTER TABLE [dbo].[IpAddrAssignTypes]
ADD CONSTRAINT [PK_IpAddrAssignTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NetworkServiceTypes'
ALTER TABLE [dbo].[NetworkServiceTypes]
ADD CONSTRAINT [PK_NetworkServiceTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NetworkServices'
ALTER TABLE [dbo].[NetworkServices]
ADD CONSTRAINT [PK_NetworkServices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Interfaces'
ALTER TABLE [dbo].[Interfaces]
ADD CONSTRAINT [PK_Interfaces]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Devices'
ALTER TABLE [dbo].[Devices]
ADD CONSTRAINT [PK_Devices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InterfaceTypes'
ALTER TABLE [dbo].[InterfaceTypes]
ADD CONSTRAINT [PK_InterfaceTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NetConnectorTypes'
ALTER TABLE [dbo].[NetConnectorTypes]
ADD CONSTRAINT [PK_NetConnectorTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Owners'
ALTER TABLE [dbo].[Owners]
ADD CONSTRAINT [PK_Owners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeviceTypeId] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [FK_ModelDeviceType]
    FOREIGN KEY ([DeviceTypeId])
    REFERENCES [dbo].[DeviceTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelDeviceType'
CREATE INDEX [IX_FK_ModelDeviceType]
ON [dbo].[Models]
    ([DeviceTypeId]);
GO

-- Creating foreign key on [MfgrId] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [FK_ModelMfgr]
    FOREIGN KEY ([MfgrId])
    REFERENCES [dbo].[Mfgrs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelMfgr'
CREATE INDEX [IX_FK_ModelMfgr]
ON [dbo].[Models]
    ([MfgrId]);
GO

-- Creating foreign key on [OwnerId] in table 'Devices'
ALTER TABLE [dbo].[Devices]
ADD CONSTRAINT [FK_DeviceOwner]
    FOREIGN KEY ([OwnerId])
    REFERENCES [dbo].[Owners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceOwner'
CREATE INDEX [IX_FK_DeviceOwner]
ON [dbo].[Devices]
    ([OwnerId]);
GO

-- Creating foreign key on [ModelId] in table 'Devices'
ALTER TABLE [dbo].[Devices]
ADD CONSTRAINT [FK_DeviceModel]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[Models]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceModel'
CREATE INDEX [IX_FK_DeviceModel]
ON [dbo].[Devices]
    ([ModelId]);
GO

-- Creating foreign key on [InterfaceTypeId] in table 'Interfaces'
ALTER TABLE [dbo].[Interfaces]
ADD CONSTRAINT [FK_InterfaceInterfaceType]
    FOREIGN KEY ([InterfaceTypeId])
    REFERENCES [dbo].[InterfaceTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InterfaceInterfaceType'
CREATE INDEX [IX_FK_InterfaceInterfaceType]
ON [dbo].[Interfaces]
    ([InterfaceTypeId]);
GO

-- Creating foreign key on [NetConnectorTypeId] in table 'Interfaces'
ALTER TABLE [dbo].[Interfaces]
ADD CONSTRAINT [FK_InterfaceNetConnectorType]
    FOREIGN KEY ([NetConnectorTypeId])
    REFERENCES [dbo].[NetConnectorTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InterfaceNetConnectorType'
CREATE INDEX [IX_FK_InterfaceNetConnectorType]
ON [dbo].[Interfaces]
    ([NetConnectorTypeId]);
GO

-- Creating foreign key on [DeviceId] in table 'Interfaces'
ALTER TABLE [dbo].[Interfaces]
ADD CONSTRAINT [FK_InterfaceDevice]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InterfaceDevice'
CREATE INDEX [IX_FK_InterfaceDevice]
ON [dbo].[Interfaces]
    ([DeviceId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------