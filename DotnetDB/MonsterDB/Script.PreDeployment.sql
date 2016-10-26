/*
 Pre-Deployment Script Template                     
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.   
 Use SQLCMD syntax to include a file in the pre-deployment script.         
 Example:      :r .\myfile.sql                        
 Use SQLCMD syntax to reference a variable in the pre-deployment script.      
 Example:      :setvar TableName MyTable                     
               SELECT * FROM [$(TableName)]               
--------------------------------------------------------------------------------------
*/

USE [master]
GO

CREATE DATABASE [MonsterDB]
GO

USE [MonsterDB]
GO

CREATE SCHEMA [Monster] 
GO


CREATE TABLE [Monster].[Gender](
	[GenderId] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [Monster].[Monster](
	[MonsterId] [int] IDENTITY(1,1) NOT NULL,
	[GenderId] [int] NULL,
	[TitleId] [int] NULL,
	[TypeId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[PicturePath] [nvarchar](256) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [pk_monster_monsterid] PRIMARY KEY CLUSTERED 
(
	[MonsterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [Monster].[MonsterType](
	[MonsterTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_MonsterType] PRIMARY KEY CLUSTERED 
(
	[MonsterTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [Monster].[Title](
	[TitleId] [int] IDENTITY(1,1) NOT NULL,
	[TitleName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Title] PRIMARY KEY CLUSTERED 
(
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [Monster].[Monster]  WITH CHECK ADD  CONSTRAINT [FK_Monster_Gender] FOREIGN KEY([GenderId])
REFERENCES [Monster].[Gender] ([GenderId])
GO
ALTER TABLE [Monster].[Monster] CHECK CONSTRAINT [FK_Monster_Gender]
GO
ALTER TABLE [Monster].[Monster]  WITH CHECK ADD  CONSTRAINT [FK_Monster_MonsterType] FOREIGN KEY([MonsterId])
REFERENCES [Monster].[MonsterType] ([MonsterTypeId])
GO
ALTER TABLE [Monster].[Monster] CHECK CONSTRAINT [FK_Monster_MonsterType]
GO
ALTER TABLE [Monster].[Monster]  WITH CHECK ADD  CONSTRAINT [FK_Monster_Title] FOREIGN KEY([TitleId])
REFERENCES [Monster].[Title] ([TitleId])
GO
ALTER TABLE [Monster].[Monster] CHECK CONSTRAINT [FK_Monster_Title]
GO



