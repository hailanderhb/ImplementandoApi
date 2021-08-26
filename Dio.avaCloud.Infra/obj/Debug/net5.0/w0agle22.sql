IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Customers] (
    [CustomerId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Document] bigint NOT NULL,
    [BirthDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId])
);
GO

CREATE TABLE [Products] (
    [Id] int NOT NULL IDENTITY,
    [Description] nvarchar(max) NULL,
    [Price] decimal(18,2) NOT NULL,
    [ProductName] nvarchar(max) NULL,
    [Seller] nvarchar(max) NULL,
    [CreateDate] datetime2 NOT NULL,
    [ProductId] datetime2 NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Addresses] (
    [Id] int NOT NULL IDENTITY,
    [AddressType] int NOT NULL,
    [City] nvarchar(max) NULL,
    [PostCode] nvarchar(max) NULL,
    [StreetName] nvarchar(max) NULL,
    [State] nvarchar(max) NULL,
    [Number] nvarchar(max) NULL,
    [Complement] nvarchar(max) NULL,
    [CustomerId] int NULL,
    [ProductId] datetime2 NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Addresses_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Orders] (
    [Id] int NOT NULL IDENTITY,
    [OrderDate] datetime2 NOT NULL,
    [CustomerId] int NOT NULL,
    [ProductId] datetime2 NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Orders_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId]) ON DELETE CASCADE
);
GO

CREATE TABLE [OrderItems] (
    [Id] int NOT NULL IDENTITY,
    [ProductId1] int NULL,
    [Quantity] int NOT NULL,
    [OrderId] int NULL,
    [ProductId] datetime2 NOT NULL,
    CONSTRAINT [PK_OrderItems] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_OrderItems_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_OrderItems_Products_ProductId1] FOREIGN KEY ([ProductId1]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Addresses_CustomerId] ON [Addresses] ([CustomerId]);
GO

CREATE INDEX [IX_OrderItems_OrderId] ON [OrderItems] ([OrderId]);
GO

CREATE INDEX [IX_OrderItems_ProductId1] ON [OrderItems] ([ProductId1]);
GO

CREATE INDEX [IX_Orders_CustomerId] ON [Orders] ([CustomerId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210825200129_Inicial', N'5.0.9');
GO

COMMIT;
GO

