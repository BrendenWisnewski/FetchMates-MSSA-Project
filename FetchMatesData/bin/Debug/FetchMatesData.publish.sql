﻿/*
Deployment script for FetchMatesData

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "FetchMatesData"
:setvar DefaultFilePrefix "FetchMatesData"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367)) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
    END


GO
PRINT N'Creating [dbo].[DogParkVisits]...';


GO
CREATE TABLE [dbo].[DogParkVisits] (
    [VisitID]      INT          IDENTITY (1, 1) NOT NULL,
    [DogID]        INT          NOT NULL,
    [Park Name]    VARCHAR (50) NOT NULL,
    [Day And Time] DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([VisitID] ASC)
);


GO
PRINT N'Creating [dbo].[Dogs]...';


GO
CREATE TABLE [dbo].[Dogs] (
    [DogID]      INT          IDENTITY (1, 1) NOT NULL,
    [Dog Breed]  VARCHAR (50) NOT NULL,
    [Dog Name]   VARCHAR (40) NOT NULL,
    [Dog Weight] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([DogID] ASC)
);


GO
PRINT N'Creating [dbo].[FK_dbo.Dog]...';


GO
ALTER TABLE [dbo].[DogParkVisits] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Dog] FOREIGN KEY ([DogID]) REFERENCES [dbo].[Dogs] ([DogID]);


GO
