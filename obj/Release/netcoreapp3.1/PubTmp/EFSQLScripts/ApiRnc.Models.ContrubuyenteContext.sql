IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219141650_Add-Migration InitialCrate')
BEGIN
    CREATE TABLE [Contribuyentes] (
        [RncEmpresa] nvarchar(450) NOT NULL,
        [RazonSocial] nvarchar(max) NULL,
        [NombreComercial] nvarchar(max) NULL,
        [ActividadEconomica] nvarchar(max) NULL,
        [Fecha] nvarchar(max) NULL,
        [Estatus] nvarchar(max) NULL,
        [RegimenDePagos] nvarchar(max) NULL,
        CONSTRAINT [PK_Contribuyentes] PRIMARY KEY ([RncEmpresa])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219141650_Add-Migration InitialCrate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210219141650_Add-Migration InitialCrate', N'3.1.11');
END;

GO

